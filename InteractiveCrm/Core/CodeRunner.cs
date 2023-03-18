using InteractiveCrm.Core;
using InteractiveCrm.Utils;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Documents;

namespace InteractiveCrm
{
    internal class CodeRunner
    {
        private readonly CodeManager _codeManager;
        private readonly EntryPointResolver _entryPointResolver;
        private readonly DiagnosticManager _diagnosticManager;
        private readonly ControlWriter _outWriter;
        private readonly ControlWriter _logWriter;

        public CodeRunner(CodeManager codeManager, EntryPointResolver resolver, DiagnosticManager diagnosticManager, ControlWriter outWriter, ControlWriter logWriter)
        {
            _codeManager = codeManager;
            _entryPointResolver = resolver;
            _diagnosticManager = diagnosticManager;
            _outWriter = outWriter;
            _logWriter = logWriter;
        }

        public void Run(IOrganizationService service)
        {
            var stdWriter = Console.Out;
            var stdError = Console.Error;
            Console.SetOut(_outWriter);
            Console.SetError(_outWriter);

            var compilation = _codeManager.GetCompilation();
            using (var stream = new MemoryStream())
            {
                EmitResult result = compilation.Emit(stream);

                _diagnosticManager.ClearDiagnostics();
                if (!result.Success)
                {
                    _diagnosticManager.SetDiagnostics(result.Diagnostics);
                    Console.Error.WriteLine("Compilations errors occureed");
                    return;
                }

                // Entry points resolving
                var entryPoints = _entryPointResolver.Resolve(compilation);
                if(!entryPoints.Any()) 
                { 
                    Console.Error.WriteLine("No entry point found");
                    return;
                }
                else if(entryPoints.Count() > 1)
                {
                    Console.Error.WriteLine("Multiple possible entry points found");
                    return;
                }

                // Load assembly and retrieve entry point
                var entryInfo = entryPoints.First();
                stream.Seek(0, SeekOrigin.Begin);
                Assembly assembly = Assembly.Load(stream.ToArray());
                Type dynamicClassType = assembly.GetType(entryInfo.Class);
                MethodInfo executeMethod = dynamicClassType.GetMethod(entryInfo.Method);

                // Setup entry method parametrs
                var parameters = executeMethod.GetParameters();
                List<object> entryParams = new List<object>();
                foreach(var param in parameters)
                {
                    if (param.ParameterType == typeof(IOrganizationService)) 
                        entryParams.Add(service);
                    if (param.ParameterType == typeof(IInteractiveCrmLogger)) 
                        entryParams.Add(new InteractiveCrmLogger(_logWriter));
                }

                try 
                { 
                    executeMethod.Invoke(null, entryParams.Count == 0 ? null : entryParams.ToArray());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.SetOut(stdWriter);
                    throw ex;
                }
            }

            Console.SetOut(stdWriter);
            Console.SetError(stdError);
        }

    }
}
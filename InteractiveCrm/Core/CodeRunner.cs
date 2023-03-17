using InteractiveCrm.Core;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.Xrm.Sdk;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Windows.Documents;
using System.Windows.Forms;

namespace InteractiveCrm
{
    internal class CodeRunner
    {
        private readonly CodeManager _codeManager;
        private readonly EntryPointResolver _entryPointResolver;
        private readonly ControlWriter _outWriter;
        private readonly BindingSource _diagnosticsSource;

        public CodeRunner(CodeManager codeManager, EntryPointResolver resolver, ControlWriter outWriter, BindingSource diagnosticsSource)
        {
            _codeManager = codeManager;
            _entryPointResolver = resolver;
            _outWriter = outWriter;
            _diagnosticsSource = diagnosticsSource;
        }

        public void Run(IOrganizationService service)
        {
            var stdWriter = Console.Out;
            Console.SetOut(_outWriter);

            var compilation = _codeManager.GetCompilation();
            using (var stream = new MemoryStream())
            {
                EmitResult result = compilation.Emit(stream);

                _diagnosticsSource.Clear();
                if (!result.Success)
                {
                    foreach (Diagnostic diagnostic in result.Diagnostics)
                    {
                        _diagnosticsSource.Add(diagnostic.ToViewModel());
                    }

                    return;
                }

                stream.Seek(0, SeekOrigin.Begin);
                Assembly assembly = Assembly.Load(stream.ToArray());

                var entryInfo = _entryPointResolver.Resolve(compilation);

                Type dynamicClassType = assembly.GetType(entryInfo.Class);
                MethodInfo executeMethod = dynamicClassType.GetMethod(entryInfo.Method);

                executeMethod.Invoke(null, new object[] { service });
            }

            Console.SetOut(stdWriter);
        }

    }
}
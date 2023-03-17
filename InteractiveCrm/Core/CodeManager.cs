using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Host.Mef;
using Microsoft.CodeAnalysis.Text;
using Microsoft.Crm.Sdk.Messages;
using Microsoft.Web.WebView2.Core;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace InteractiveCrm.Core
{
    internal class CodeManager
    {
        private readonly MefHostServices _host;
        private readonly AdhocWorkspace _workspace;

        public Solution Solution => _workspace.CurrentSolution;
        public Project Project => Solution.Projects.First();
        public Document SourceDocument => Project.Documents.FirstOrDefault();

        private CodeManager(MefHostServices host, AdhocWorkspace workspace)
        {
            _host = host;
            _workspace = workspace;
        }

        public SyntaxTree GetSyntaxTree(CancellationToken cancellationToken = default)
        {
            var task = SourceDocument.GetSyntaxTreeAsync(cancellationToken);
            task.Wait(cancellationToken);

            return task.Result;
        }

        public Compilation GetCompilation(CancellationToken cancellationToken = default)
        {
            var task = Project.GetCompilationAsync(cancellationToken);
            task.Wait(cancellationToken);

            return task.Result;
        }

        public void UpdateSourceFile(string source)
        {
            var sourceText = SourceText.From(source);
            Document sourceDocument = null;
            if (!Project.Documents.Any())
            {
                sourceDocument = _workspace.AddDocument(Project.Id, "SourceDocument.cs", sourceText);
            }
            else
            {
                sourceDocument = SourceDocument.WithText(sourceText);
            }

            _workspace.TryApplyChanges(sourceDocument.Project.Solution);
        }

        public static CodeManager Create()
        {
            var host = MefHostServices.Create(MefHostServices.DefaultAssemblies);
            var workspace = new AdhocWorkspace();

            var compilationOptions = new CSharpCompilationOptions(
                    OutputKind.DynamicallyLinkedLibrary
                );

            var metadataReferences = new PortableExecutableReference[] {
                MetadataReference.CreateFromFile(typeof(IOrganizationService).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(object).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(Console).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(IOrganizationService).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(OrganizationServiceProxy).Assembly.Location),
                MetadataReference.CreateFromFile(typeof(WhoAmIRequest).Assembly.Location),
            };

            var projectInfo = ProjectInfo.Create(
                ProjectId.CreateNewId(),
                VersionStamp.Create(),
                "TestProject",
                "TestProject",
                LanguageNames.CSharp,
                compilationOptions: compilationOptions)
                .WithMetadataReferences(metadataReferences);

            var project = workspace.AddProject(projectInfo);

            return new CodeManager(host, workspace);
        }

    }
}

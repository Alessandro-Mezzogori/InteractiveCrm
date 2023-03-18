using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;

namespace InteractiveCrm
{
    public class EntryPointResolver
    {
        public const string EntryMethodName = "Main";

        public EntryPointResolver() { }

        public IEnumerable<EntryPointInfo> Resolve(Compilation compilation)
        {
            List<EntryPointInfo> entryPoints = new List<EntryPointInfo>();
            foreach(var syntaxTree in compilation.SyntaxTrees)
            {
                var classes = syntaxTree.GetRoot()
                    .DescendantNodes()
                    .OfType<ClassDeclarationSyntax>();

                foreach(var classDeclaration in classes)
                {
                    var candidateEntryMethods = classDeclaration.Members
                        .OfType<MethodDeclarationSyntax>()
                        .Where(x => x.Identifier.ValueText == EntryMethodName);

                    foreach(var candidateEntryMethod in candidateEntryMethods)
                    {
                        var modifiersKind = candidateEntryMethod.Modifiers.Select(x => x.Kind());
                        if(modifiersKind.Contains(SyntaxKind.PublicKeyword) && modifiersKind.Contains(SyntaxKind.StaticKeyword))
                        {
                            entryPoints.Add(new EntryPointInfo
                            {
                                Class = classDeclaration.Identifier.ValueText,
                                Method = candidateEntryMethod.Identifier.ValueText,
                            });
                        }
                    }
                }
            }

            return entryPoints;
        }
    }
}
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.IO;
using System.Linq;
using System.Text;

namespace UMsGenerator;

[Generator]
public class UMTypesGenerator : ISourceGenerator
{
    void ISourceGenerator.Execute(GeneratorExecutionContext context)
    {
        System.Diagnostics.Debugger.Break();
        //var sr = (ServiceSyntaxReceiver)context.SyntaxReceiver; // obtain the instance
        var text = File.ReadAllText(context.AdditionalFiles[0].Path);
        var ums = text.Split(new string[] { "\r\n" }, System.StringSplitOptions.RemoveEmptyEntries).ToArray();

        foreach (var um in ums)
        {
            var code = GenerateMethodModule("UMsss", um);
            var text1 = SourceText.From(code.NormalizeWhitespace().ToFullString(), Encoding.UTF8);
            context.AddSource(um, text1);
        }
    }

    void ISourceGenerator.Initialize(GeneratorInitializationContext context)
    {
        //var syntaxReceiver = new ServiceSyntaxReceiver(); // local function, not member
        //context.RegisterForSyntaxNotifications(() => syntaxReceiver);
    }

    NamespaceDeclarationSyntax GenerateMethodModule(string nsName, string typeName)
    {
        var ns = SyntaxFactory
            .NamespaceDeclaration(SyntaxFactory.IdentifierName(nsName))
            //.AddUsings(
            //    SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("Contract")),
            //    SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.Threading.Tasks"))
            //)
            .AddMembers(
                // request
                SyntaxFactory.ClassDeclaration($"{typeName}")
                .WithModifiers(SyntaxFactory.TokenList()
                    .Add(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                )
                .AddMembers(
                    SyntaxFactory
                        .FieldDeclaration(
                            SyntaxFactory
                                .VariableDeclaration(SyntaxFactory.ParseTypeName("double"))
                                .AddVariables(SyntaxFactory.VariableDeclarator("value"))
                        )
                        .WithModifiers(SyntaxFactory.TokenList().Add(SyntaxFactory.Token(SyntaxKind.InternalKeyword)))
                        ,
                    SyntaxFactory
                        .MethodDeclaration(
                            SyntaxFactory.IdentifierName($"{typeName}"),
                            $"operator{typeName}1"
                        )
                        .AddParameterListParameters(
                            SyntaxFactory.Parameter(SyntaxFactory.Identifier("value")).WithType(SyntaxFactory.IdentifierName("double"))
                        )
                        .AddBodyStatements(
                            SyntaxFactory.ReturnStatement(
                                SyntaxFactory.ObjectCreationExpression(SyntaxFactory.IdentifierName(typeName))
                                    .WithInitializer(
                                        SyntaxFactory.InitializerExpression(SyntaxKind.ObjectInitializerExpression)
                                        .AddExpressions(
                                            SyntaxFactory.ParseExpression("value = value")
                                        )
                                    )
                            )
                        )
                        .WithModifiers(SyntaxFactory.TokenList()
                            .Add(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                            .Add(SyntaxFactory.Token(SyntaxKind.StaticKeyword))
                            //.Add(SyntaxFactory.Token(SyntaxKind.ImplicitKeyword))
                        )
                )
            );

        return ns;
    }
}

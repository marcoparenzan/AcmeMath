using Microsoft.Azure.DigitalTwins.Parser;
using Microsoft.Azure.DigitalTwins.Parser.Models;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

var path = @"..\..\..\..\..\AcmeMath\TestDTDLGenerator\Models";

foreach (var filename in Directory.GetFiles(path, "*.json"))
{
    var sourceText = File.ReadAllText(filename);

    var parser = new ModelParser();

    var models = await parser.ParseAsync(new[] { sourceText });

    var groups = models.Where(xx => xx.Value is DTTelemetryInfo).Select(xx => xx.Value).Cast<DTTelemetryInfo>().GroupBy(xx => xx.DefinedIn);

    var nsName = $"{groups.First().Key.Labels.First()}";

    var cd = new List<ClassDeclarationSyntax>();

    foreach (var xx in groups)
    {
        cd.Add(SyntaxFactory.ClassDeclaration($"{xx.Key.Labels.Last()}")
                .WithModifiers(SyntaxFactory.TokenList()
                    .Add(SyntaxFactory.Token(SyntaxKind.PublicKeyword))
                )
                .AddMembers(
                    Generate(xx)
                )
        );
    }

    var ns = SyntaxFactory
        .CompilationUnit()
        .AddUsings(SyntaxFactory.UsingDirective(SyntaxFactory.IdentifierName("System.ComponentModel")))
        .AddMembers(
            SyntaxFactory.NamespaceDeclaration(SyntaxFactory.IdentifierName(nsName))
            .AddMembers(cd.ToArray())
        );

    var sourceText1 = ns.NormalizeWhitespace().ToFullString();

    File.WriteAllText(Path.GetFullPath(filename).Replace(".json", $".g.cs"), sourceText1);
}

PropertyDeclarationSyntax[] Generate(IEnumerable<DTTelemetryInfo> temetryInfos)
{
    var p =
            temetryInfos.Select(xx =>
                SyntaxFactory.PropertyDeclaration(DTDLPropertyType(xx), xx.Name)
                .AddAttributeLists(
                    SyntaxFactory.AttributeList()
                    .AddAttributes(
                        SyntaxFactory.Attribute(
                            SyntaxFactory.IdentifierName("DescriptionAttribute")
                        )
                        .AddArgumentListArguments(
                            SyntaxFactory.AttributeArgument(
                                SyntaxFactory.LiteralExpression(
                                    SyntaxKind.StringLiteralExpression,
                                    SyntaxFactory.Literal(xx.Id.ToString())
                                )
                            )
                        )
                    )
                )
                .AddModifiers(
                    SyntaxFactory.Token(SyntaxKind.PublicKeyword)
                )
                .AddAccessorListAccessors(
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.GetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken)),
                    SyntaxFactory.AccessorDeclaration(SyntaxKind.SetAccessorDeclaration).WithSemicolonToken(SyntaxFactory.Token(SyntaxKind.SemicolonToken))
                )
            ).ToArray();
    return p;
}

TypeSyntax DTDLPropertyType(DTTelemetryInfo xx)
{
    var typeName = xx.Schema.EntityKind.ToString();
    var xxx = SyntaxFactory.ParseTypeName(typeName);
    return xxx;
}
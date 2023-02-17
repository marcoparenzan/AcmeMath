using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Linq.Expressions;

namespace AcmeMathLanguage
{
    public partial class AcmeMathVisitor
    {
        public ExpressionSyntax VisitAlpha([NotNull] AcmeMathParser.AlphaContext context)
        {
            var name = context.GetChild(0).GetText();
            var arg1 = Visit(context.GetChild(2));
            var arg2 = Visit(context.GetChild(4));
            return SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, contextExpression, SyntaxFactory.IdentifierName(name))
            )
            .AddArgumentListArguments(
                SyntaxFactory.Argument(arg1),
                SyntaxFactory.Argument(arg2)
            );
        }

        public ExpressionSyntax VisitBeta([NotNull] AcmeMathParser.BetaContext context)
        {
            var name = context.GetChild(0).GetText();
            var arg1 = Visit(context.GetChild(2));
            return SyntaxFactory.InvocationExpression(
                //SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, contextExpression, SyntaxFactory.IdentifierName(name))
                SyntaxFactory.IdentifierName(name)
            )
            .AddArgumentListArguments(
                SyntaxFactory.Argument(arg1)
            );
        }

        public ExpressionSyntax VisitGamma([NotNull] AcmeMathParser.GammaContext context)
        {
            var name = context.GetChild(0).GetText();
            return SyntaxFactory.InvocationExpression(
                SyntaxFactory.MemberAccessExpression(SyntaxKind.SimpleMemberAccessExpression, contextExpression, SyntaxFactory.IdentifierName(name))
            );
        }
    }
}

using AcmeMathLanguage.Model;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static AcmeMathParser;

namespace AcmeMathLanguage
{
    public partial class AcmeMathVisitor : IAcmeMathVisitor<ExpressionSyntax>
    {
        IdentifierNameSyntax contextExpression;

        public AcmeMathVisitor()
        {
            this.contextExpression = SyntaxFactory.IdentifierName("context");
        }

        public ExpressionSyntax Visit(IParseTree tree)
        {
            if (tree.Payload is AcmeMathParser.LiteralContext literal)
            {
                return VisitLiteral(literal);
            }
            else if (tree.Payload is AcmeMathParser.FunctionCallContext functionCall)
            {
                // alpha, beta, gamma
                throw new NotImplementedException();
            }
            else if (tree.Payload is AcmeMathParser.AlphaContext alpha)
            {
                return VisitAlpha(alpha);
            }
            else if (tree.Payload is AcmeMathParser.BetaContext beta)
            {
                return VisitBeta(beta);
            }
            else if (tree.Payload is AcmeMathParser.GammaContext gamma)
            {
                return VisitGamma(gamma);
            }

            else if (tree.Payload is AcmeMathParser.ArgListContext argList)
            {
                return VisitArgList(argList);
            }
            else if (tree.Payload is AcmeMathParser.AttributeContext attribute)
            {
                return VisitAttribute(attribute);
            }
            else if (tree.Payload is AcmeMathParser.BitXorContext bitXor)
            {
                return VisitBitXor(bitXor);
            }
            else if (tree.Payload is AcmeMathParser.BooleanContext boolean)
            {
                return VisitBoolean(boolean);
            }
            else if (tree.Payload is AcmeMathParser.CallContext call)
            {
                return VisitCall(call);
            }
            else if (tree.Payload is AcmeMathParser.ComparisonContext comparison)
            {
                return VisitComparison(comparison);
            }
            else if (tree.Payload is AcmeMathParser.FactorContext factor)
            {
                return VisitFactor(factor);
            }
            else if (tree.Payload is AcmeMathParser.GetNodeContext getNode)
            {
                return VisitGetNode(getNode);
            }
            else if (tree.Payload is AcmeMathParser.JumpLiteralContext jumpLiteral)
            {
                return VisitJumpLiteral(jumpLiteral);
            }
            else if (tree.Payload is AcmeMathParser.UmLiteralContext umLiteral)
            {
                return VisitUmLiteral(umLiteral);
            }
            else if (tree.Payload is AcmeMathParser.LogicAndContext logicAnd)
            {
                return VisitLogicAnd(logicAnd);
            }
            else if (tree.Payload is AcmeMathParser.LogicNotContext logicNot)
            {
                return VisitLogicNot(logicNot);
            }
            else if (tree.Payload is AcmeMathParser.LogicOrContext logicOr)
            {
                return VisitLogicOr(logicOr);
            }
            else if (tree.Payload is AcmeMathParser.MinusContext minus)
            {
                return VisitMinus(minus);
            }
            else if (tree.Payload is AcmeMathParser.ParentesesContext parenteses)
            {
                return VisitParenteses(parenteses);
            }
            else if (tree.Payload is AcmeMathParser.PlusContext plus)
            {
                return VisitPlus(plus);
            }
            else if (tree.Payload is AcmeMathParser.SignContext sign)
            {
                return VisitSign(sign);
            }
            else if (tree.Payload is AcmeMathParser.SubscriptionContext subscription)
            {
                return VisitSubscription(subscription);
            }
            else if (tree.Payload is AcmeMathParser.JsonContext json)
            {
                return VisitJson(json);
            }
            else if (tree.Payload is AcmeMathParser.JmespathContext jmespath)
            {
                return VisitJmespath(jmespath);
            }
            else if (tree.Payload is CommonToken token)
            {
                return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(token.Text.Trim('"')));  // MEGAFAKE! STRINGCONTENT
            }
            else
            {
                throw new NotImplementedException("");
            }
        }

        public ExpressionSyntax VisitArgList([NotNull] AcmeMathParser.ArgListContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitAttribute([NotNull] AcmeMathParser.AttributeContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitBitXor([NotNull] AcmeMathParser.BitXorContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitBoolean([NotNull] AcmeMathParser.BooleanContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitCall([NotNull] AcmeMathParser.CallContext context)
        {
            var target = context.GetChild(0);
            if (target.Payload is AcmeMathParser.AlphaContext alpha)
            {
                return VisitAlpha(alpha);
            }
            else if (target.Payload is AcmeMathParser.BetaContext beta)
            {
                return VisitBeta(beta);
            }
            else if (target.Payload is AcmeMathParser.GammaContext gamma)
            {
                return VisitGamma(gamma);
            }
            else
                throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitChildren(IRuleNode node)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitComparison([NotNull] AcmeMathParser.ComparisonContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitFactor([NotNull] AcmeMathParser.FactorContext context)
        {
            var a = Visit(context.GetChild(0));
            var b = Visit(context.GetChild(2));
            var kind = SyntaxKind.MultiplyExpression;
            return SyntaxFactory.BinaryExpression(kind, a, b); // map with the context
        }

        public ExpressionSyntax VisitGetNode([NotNull] AcmeMathParser.GetNodeContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitJumpLiteral([NotNull] AcmeMathParser.JumpLiteralContext context)
        {
            var target = context.GetChild(0) as LiteralContext;
            if (target != null)
                return VisitLiteral(target);
            else
                throw new NotImplementedException();
        }

        public ExpressionSyntax VisitUmLiteral([NotNull] AcmeMathParser.UmLiteralContext context)
        {
            var umName = context.GetChild(1);
            var literal = context.GetChild(3) as LiteralContext;
            var literalExpression = VisitLiteral(literal);
            return SyntaxFactory.ParseExpression($"{umName}.Parse(\"{literalExpression}\", null)");
        }

        public ExpressionSyntax VisitLiteral([NotNull] AcmeMathParser.LiteralContext context)
        {
            if (context.STRING() != null)
            {
                return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(context.STRING().GetText().Trim('"')));  // MEGAFAKE! STRINGCONTENT
            }
            else if (context.INTEGER() != null)
            {
                //return SyntaxFactory.ParseExpression($"Speed.Parse(\"{context.INTEGER().GetText()}\", null)");
                return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(int.Parse(context.INTEGER().GetText())));
            }
            else if (context.FLOAT() != null)
            {
                return SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(float.Parse(context.FLOAT().GetText())));
            }
            else if (context.IDENTIFIER() != null)
            {
                return SyntaxFactory.IdentifierName(context.GetText().Trim('"'));  // MEGAFAKE! STRINGCONTENT
            }
            else
                throw new NotImplementedException();

        }

        public ExpressionSyntax VisitLogicAnd([NotNull] AcmeMathParser.LogicAndContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitLogicNot([NotNull] AcmeMathParser.LogicNotContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitLogicOr([NotNull] AcmeMathParser.LogicOrContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitMinus([NotNull] AcmeMathParser.MinusContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitParenteses([NotNull] AcmeMathParser.ParentesesContext context)
        {
            return null;
        }

        public ExpressionSyntax VisitPlus([NotNull] AcmeMathParser.PlusContext context)
        {
            var a = Visit(context.GetChild(0));
            var b = Visit(context.GetChild(2));
            return SyntaxFactory.BinaryExpression(SyntaxKind.AddExpression, a, b);
        }

        public ExpressionSyntax VisitSign([NotNull] AcmeMathParser.SignContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitSubscription([NotNull] AcmeMathParser.SubscriptionContext context)
        {
            throw new NotImplementedException("");
        }

        public ExpressionSyntax VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException("");
        }

        /// JSON

        public ExpressionSyntax VisitArr([NotNull] ArrContext context)
        {
            var ctor = typeof(JList).GetConstructors()[1];

            var initializers = new List<ExpressionSyntax>();
            for (var i = 0; i < context.ChildCount; i++)
            {
                var child = context.GetChild(i);
                if (child is AcmeMathParser.ExpressionContext value)
                {
                    var v = Visit(value);
                    initializers.Add(v);
                }
            }

            return SyntaxFactory.ArrayCreationExpression(
                SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName("JList"))
            ).WithInitializer(
                SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression).AddExpressions(initializers.ToArray())
            );
        }

        public ExpressionSyntax VisitJson([NotNull] JsonContext context)
        {
            if (context.obj() != null)
            {
                return VisitObj(context.obj());
            }
            else if (context.arr() != null)
            {
                return VisitArr(context.arr());
            }
            else
                throw new NotImplementedException();
        }

        public ExpressionSyntax VisitObj([NotNull] ObjContext context)
        {
            var initializers = new List<ExpressionSyntax>();
            for (var i = 0; i < context.ChildCount; i++)
            {
                var child = context.GetChild(i);
                if (child is AcmeMathParser.PairContext pair)
                {
                    var name = SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralExpression, SyntaxFactory.Literal(pair.GetChild(0).GetText().Trim('"')));
                    var value = Visit(pair.GetChild(2).Payload as AcmeMathParser.ExpressionContext);

                    var vvalue = SyntaxFactory.ObjectCreationExpression(
                        SyntaxFactory.ParseTypeName(nameof(JNodeKV)) //  ExpressionSyntax.New(typeof(JValue).GetConstructor(new Type[] { value.Type }), value);
                    ).AddArgumentListArguments(SyntaxFactory.Argument(value))
                    ;

                    initializers.Add(vvalue);
                }
            }
            return SyntaxFactory.ArrayCreationExpression(
                SyntaxFactory.ArrayType(SyntaxFactory.ParseTypeName(nameof(JNode)))
            ).WithInitializer(
                SyntaxFactory.InitializerExpression(SyntaxKind.ArrayInitializerExpression).AddExpressions(initializers.ToArray())
            );
        }

        public ExpressionSyntax VisitPair([NotNull] PairContext context)
        {
            throw new NotImplementedException();
        }

        public ExpressionSyntax VisitJmespath([NotNull] JmespathContext context)
        {
            var text = context.STRING().GetText().Trim('\"');

            return SyntaxFactory.ObjectCreationExpression(
                SyntaxFactory.ParseTypeName(nameof(JMSPathQuery)) // typeof(string)
            )
            .AddArgumentListArguments(
                SyntaxFactory.Argument(SyntaxFactory.LiteralExpression(SyntaxKind.StringLiteralToken, SyntaxFactory.Literal(text)))
            );
        }
    }
}
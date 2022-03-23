using AcmeMathLanguage.Model;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System.Linq.Expressions;
using static AcmeMathParser;

namespace AcmeMathLanguage
{
    public partial class AcmeMathVisitor<TTarget> : IAcmeMathVisitor<Expression>
    {
        TTarget contextInstance;
        ParameterExpression contextExpression;

        public AcmeMathVisitor(TTarget instance)
        {
            this.contextInstance = instance;
            this.contextExpression = Expression.Variable(typeof(TTarget), "context");
        }

        public Expression Visit(IParseTree tree)
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
                return Expression.Constant(token.Text.Trim('"'));
            }
            else
            {
                throw new NotImplementedException("");
            }
        }

        public Expression VisitArgList([NotNull] AcmeMathParser.ArgListContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitAttribute([NotNull] AcmeMathParser.AttributeContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitBitXor([NotNull] AcmeMathParser.BitXorContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitBoolean([NotNull] AcmeMathParser.BooleanContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitCall([NotNull] AcmeMathParser.CallContext context)
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

        public Expression VisitChildren(IRuleNode node)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitComparison([NotNull] AcmeMathParser.ComparisonContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitErrorNode(IErrorNode node)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitFactor([NotNull] AcmeMathParser.FactorContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitGetNode([NotNull] AcmeMathParser.GetNodeContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitJumpLiteral([NotNull] AcmeMathParser.JumpLiteralContext context)
        {
            var target = context.GetChild(0) as LiteralContext;
            if (target != null)
                return VisitLiteral(target);
            else
                throw new NotImplementedException();
        }

        public Expression VisitLiteral([NotNull] AcmeMathParser.LiteralContext context)
        {
            if (context.STRING() != null)
            {
                return Expression.Constant(context.STRING().GetText());
            }
            else if (context.INTEGER() != null)
            {
                return Expression.Constant(int.Parse(context.INTEGER().GetText()));
            }
            else if (context.FLOAT() != null)
            {
                return Expression.Constant(float.Parse(context.FLOAT().GetText()));
            }
            else if (context.IDENTIFIER() != null)
            {
                throw new NotImplementedException();
            }
            else
                throw new NotImplementedException();

        }

        public Expression VisitLogicAnd([NotNull] AcmeMathParser.LogicAndContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitLogicNot([NotNull] AcmeMathParser.LogicNotContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitLogicOr([NotNull] AcmeMathParser.LogicOrContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitMinus([NotNull] AcmeMathParser.MinusContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitParenteses([NotNull] AcmeMathParser.ParentesesContext context)
        {
            return null;
        }

        public Expression VisitPlus([NotNull] AcmeMathParser.PlusContext context)
        {
            var a = Visit(context.GetChild(0));
            var b = Visit(context.GetChild(2));
            return Expression.Add(a, b);
        }

        public Expression VisitSign([NotNull] AcmeMathParser.SignContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitSubscription([NotNull] AcmeMathParser.SubscriptionContext context)
        {
            throw new NotImplementedException("");
        }

        public Expression VisitTerminal(ITerminalNode node)
        {
            throw new NotImplementedException("");
        }

        /// JSON

        public Expression VisitArr([NotNull] ArrContext context)
        {
            var ctor = typeof(JList).GetConstructors()[1];

            var initializers = new List<Expression>();
            for (var i = 0; i < context.ChildCount; i++)
            {
                var child = context.GetChild(i);
                if (child is AcmeMathParser.ExpressionContext value)
                {
                    var v = Visit(value);
                    initializers.Add(v);
                }
            }

            return Expression.New(ctor, Expression.NewArrayInit(typeof(JItem), initializers.ToArray()));
        }

        public Expression VisitJson([NotNull] JsonContext context)
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

        public Expression VisitObj([NotNull] ObjContext context)
        {
            var ctor = typeof(JNode).GetConstructors()[0];
            var ctorTuple = typeof(JNodeKV).GetConstructors()[0];

            var initializers = new List<Expression>();
            for (var i = 0; i < context.ChildCount; i++)
            {
                var child = context.GetChild(i);
                if (child is AcmeMathParser.PairContext pair)
                {
                    var name = Expression.Constant(pair.GetChild(0).GetText().Trim('"'));
                    var value = Visit(pair.GetChild(2).Payload as AcmeMathParser.ExpressionContext);

                    var vvalue = Expression.New(typeof(JValue).GetConstructor(new Type[] { value.Type }), value);

                    initializers.Add(Expression.New(ctorTuple, name, vvalue));
                }
            }
            return Expression.New(ctor, Expression.NewArrayInit(typeof(JNodeKV), initializers.ToArray()));
        }

        public Expression VisitPair([NotNull] PairContext context)
        {
            throw new NotImplementedException();
        }

        public Expression VisitJmespath([NotNull] JmespathContext context)
        {
            var text = context.STRING().GetText().Trim('\"');

            return Expression.New(
                typeof(JMSPathQuery).GetConstructor(new Type[] { typeof(string) })
                , Expression.Constant(text));
        }
    }
}
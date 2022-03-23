using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMathLanguage
{
    public static class AcmeMathHelpers
    {
        public static Expression ExpressionOf(string code)
        {
            var inputStream = new AntlrInputStream(code);
            var lexer = new AcmeMathLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new AcmeMathParser(commonTokenStream);

            var context = parser.expression();

            var ctx = new AcmeMathContext();

            var visitor = new AcmeMathVisitor<AcmeMathContext>(ctx);
            var exp = visitor.Visit(context);

            return exp;
        }
    }
}

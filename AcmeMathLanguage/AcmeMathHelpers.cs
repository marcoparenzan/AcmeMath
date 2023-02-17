using Antlr4.Runtime;
using Microsoft.CodeAnalysis.CSharp.Syntax;
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
        public static ExpressionSyntax ExpressionOf(string code)
        {
            var inputStream = new AntlrInputStream(code);
            var lexer = new AcmeMathLexer(inputStream);
            var commonTokenStream = new CommonTokenStream(lexer);
            var parser = new AcmeMathParser(commonTokenStream);

            var context = parser.expression();

            var visitor = new AcmeMathVisitor();
            var exp = visitor.Visit(context);

            return exp;
        }
    }
}

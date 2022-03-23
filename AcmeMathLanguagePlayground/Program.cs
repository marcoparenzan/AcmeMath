using Antlr4.Runtime;
using AcmeMathLanguage;

var text = File.ReadAllText("example1.acm");

var exp = AcmeMathHelpers.ExpressionOf(text);

Console.WriteLine(exp.ToString());

Console.ReadLine();

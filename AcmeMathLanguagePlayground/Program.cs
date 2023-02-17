using AcmeMathLanguage;
using AcmeMathLanguagePlayground;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using System.Text;

var text = "[Current]3 * [Voltage]5";
var ctx = new AcmeMathContext();

var exp = AcmeMathHelpers.ExpressionOf(text);

var source = exp.ToString();

var options = ScriptOptions.Default
             .AddReferences("Microsoft.CSharp")
             .AddReferences("GenericMathLib")
         ;

var sbCode = new StringBuilder();

sbCode.AppendLine($@"
                using System;
                using System.Threading.Tasks;
                using GenericMathLib;
            ");
sbCode.AppendLine(source);

var loader = new InteractiveAssemblyLoader();

var state = CSharpScript.Create<object>(sbCode.ToString(), options, typeof(AcmeMathContext), loader);

var result = await state.RunAsync(ctx, (ex) =>
    true
);

Console.WriteLine($"{source}={result.ReturnValue}");
Console.ReadLine();

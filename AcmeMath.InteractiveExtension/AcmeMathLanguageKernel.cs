using AcmeMathLanguage;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using System;
using System.Text;
using System.Threading.Tasks;

namespace AcmeMath.InteractiveExtension;

internal class AcmeMathLanguageKernel : Kernel, IKernelCommandHandler<SubmitCode>
{
    public AcmeMathLanguageKernel() : base("acmemath")
    {
    }

    public async Task HandleAsync(SubmitCode command, KernelInvocationContext context)
    {
        try
        {
            var exp = AcmeMathHelpers.ExpressionOf(command.Code);

            var source = exp.ToString();

            var options = ScriptOptions.Default
                         .AddReferences("Microsoft.CSharp")
                     ;

            var sbCode = new StringBuilder();

            sbCode.AppendLine($@"
                using System;
                using System.Threading.Tasks;
            ");
            sbCode.AppendLine(source);

            var loader = new InteractiveAssemblyLoader();

            var state = CSharpScript.Create<object>(sbCode.ToString(), options, typeof(AcmeMathContext), loader);

            var ctx = new AcmeMathContext();

            var result = await state.RunAsync(ctx, (ex) =>
                true
            );

            context.Display((object)$"{source}={result.ReturnValue}");
            //context.Display((object)$"Ciao {command.Code}");
        }
        catch (Exception ex)
        {
            context.Display((object)$"Error: {ex.Message}");
        }
    }
}
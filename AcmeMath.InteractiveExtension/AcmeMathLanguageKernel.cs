using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AcmeMathLanguage;
using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using Microsoft.DotNet.Interactive.Http;

namespace AcmeMath.InteractiveExtension;

internal class AcmeMathLanguageKernel : Kernel, IKernelCommandHandler<SubmitCode>
{
    public AcmeMathLanguageKernel() : base("acmemath")
    {
    }

    public async Task HandleAsync(SubmitCode command, KernelInvocationContext context)
    {
        var expr = AcmeMathHelpers.ExpressionOf(command.Code);

        context.Display((object)expr.ToString());
    }
}
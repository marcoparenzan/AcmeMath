using System;
using System.CommandLine;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;

namespace AcmeMath.InteractiveExtension;

public static class AcmeMathKernelExtension
{
    public static void Load(Kernel kernel)
    {
        var acmeMathCommand = new Command("#!acmemathelp", "Evaluate math.")
        {
        };

        acmeMathCommand.SetHandler(
            () => KernelInvocationContext.Current.Display((object) $"<div>{DateTimeOffset.Now}</div>"));

        kernel.AddDirective(acmeMathCommand);

        try
        {
            KernelInvocationContext.Current?.Display(new HtmlString(kernel.GetType().FullName), "text/html");
            if (kernel is CompositeKernel cs)
            {
                cs.Add(new AcmeMathLanguageKernel());
                KernelInvocationContext.Current?.Display(new HtmlString(@"<details><summary>Hello Acme Math language kernel.</summary></details>"), "text/html");
            }
        }
        catch (Exception ex)
        {
            KernelInvocationContext.Current?.Display(new HtmlString($@"<details><summary>ERROR: {ex.Message} ********** {ex.StackTrace}</summary></details>"), "text/html");
        }
    }
}
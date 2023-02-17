using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;
using System.CommandLine;

namespace AcmeMath;

public static class Extension
{
    public static void Load(Kernel kernel)
    {
        var current = KernelInvocationContext.Current;
        try
        {
            // Next, define a magic command that will render a clock.
            var commandNameOption = new Option<string>(new[] { "-c", "--command" }, "The command name");

            var command = new Command("#!acmemath", "AcmeMath extension")
            {
                commandNameOption
            };

            command.SetHandler(Commanding.ExecuteAsync, commandNameOption);

            kernel.AddDirective(command);
        }
        catch (Exception ex)
        {
            Commanding.Display($@"<details><summary>ERROR: {ex.Message} ********** {ex.StackTrace}</summary></details>");
        }

        try
        {
            if (kernel is CompositeKernel cs)
            {
                cs.Add(new AcmeMathKernel());
                Commanding.Display(@"<details><summary>Hello Acme Math language kernel #!acmemathk.</summary></details>");
            }
            else
            {
                Commanding.Display($@"<details><summary>ERROR: no compositeKernel {kernel.GetType().Name} **********</summary></details>");
            }
        }
        catch (Exception ex)
        {
            Commanding.Display($@"<details><summary>ERROR: {ex.Message} ********** {ex.StackTrace}</summary></details>");
        }
    }
}
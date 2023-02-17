using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;

namespace AcmeMath;

internal class AcmeMathKernel : Kernel, IKernelCommandHandler<SubmitCode>
{
    public AcmeMathKernel() : base("acmemathk")
    {
    }

    public async Task HandleAsync(SubmitCode command, KernelInvocationContext context)
    {
        try
        {
            context.Display((object)$"Command={command}");
            context.Display((object)$"Context={context}");
        }
        catch (Exception ex)
        {
            context.Display((object)$"Error: {ex.Message}");
        }
    }
}
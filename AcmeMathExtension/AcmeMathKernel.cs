using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using System;
using System.Threading.Tasks;

namespace AcmeMathExtension
{
    public class AcmeMathKernel : Kernel, IKernelCommandHandler<SubmitCode>
    {
        internal const string DefaultKernelName = "acmemath";

        public AcmeMathKernel() : this(DefaultKernelName)
        {

        }
        public AcmeMathKernel(string name) : base(name)
        {
        }

        public async Task HandleAsync(SubmitCode command, KernelInvocationContext context)
        {
            context.Display((object) $"{command.Code}", "text/html");
        }
    }
}
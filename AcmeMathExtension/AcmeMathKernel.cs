using Microsoft.DotNet.Interactive;
using Microsoft.DotNet.Interactive.Commands;
using Microsoft.DotNet.Interactive.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
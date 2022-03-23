using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.DotNet.Interactive;

namespace AcmeMath.InteractiveExtension;

public class KernelExtension : IKernelExtension
{
    public async Task OnLoadAsync(Kernel kernel)
    {
        if (kernel is CompositeKernel cs)
        {
            cs.Add(new AcmeMathLanguageKernel());
            KernelInvocationContext.Current?.Display(new HtmlString(@"<details><summary>Acme Math language.</summary></details>"), "text/html");
        }
    }
}
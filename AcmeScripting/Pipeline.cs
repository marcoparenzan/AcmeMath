using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using System.Text;
using System.Threading.Tasks;

namespace AcmeScripting
{
    public static class Pipeline
    {
        public static async Task<int> RunAsync<TGlobals>(TGlobals globals, PipelineConfig config)
        {
            var options = ScriptOptions.Default
                .AddReferences("Microsoft.CSharp")
            ;

            var sbCode = new StringBuilder();

            sbCode.AppendLine($@"
                using System;
                using System.Threading.Tasks;
            ");

            foreach (var xx in config.Stages)
            {
                sbCode.AppendLine($@"
                    // {xx.Key}Filter()
                    {xx.Value.Filter?.Script}
                    // {xx.Key}Aggregate()
                    {xx.Value.Aggregate?.Script}
                    // {xx.Key}Transform()
                    {xx.Value.Transform?.Script}
                    // {xx.Key}Enrich()
                    {xx.Value.Enrich?.Script}
                ");
            }

            var loader = new InteractiveAssemblyLoader();

            var state = CSharpScript.Create<int>(sbCode.ToString(), options, typeof(TGlobals), loader);

            var result = await state.RunAsync(globals, (ex) =>
                true
            );

            return result.ReturnValue;
        }
    }
}

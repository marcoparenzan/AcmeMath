using System.Collections.Generic;

namespace AcmeScripting
{
    public class PipelineConfig
    {
        public PipelineStages Stages { get; set; }
    }

    public class PipelineStages : Dictionary<string, PipelineStage>
    {
    }

    public class PipelineStage
    {
        public PipelineScript Filter { get; set; }
        public PipelineScript Aggregate { get; set; }
        public PipelineScript Transform { get; set; }
        public PipelineScript Enrich { get; set; }
    }

    public class PipelineScript
    {
        public static implicit operator PipelineScript(string script) => new PipelineScript
        {
            Script = script,
            Language = "CSharp"
        };

        public string Script { get; init; }
        public string Language { get; init; }
    }
}

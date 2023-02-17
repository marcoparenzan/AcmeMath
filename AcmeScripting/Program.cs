using AcmeScripting;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var payloadJson = File.ReadAllText("perfEnergyProbe.json");
dynamic payload = DynamicJsonDocument.Parse(payloadJson);

var pipelineConfigYaml = File.ReadAllText("PipelineConfig.yaml");
var deserializer = new DeserializerBuilder()
    .WithNamingConvention(PascalCaseNamingConvention.Instance)
    .Build();
var pipelineConfig = deserializer.Deserialize<PipelineConfig>(pipelineConfigYaml);

var pipelineGlobals = new PipelineGlobals
{
    payload = payload
};

await Pipeline.RunAsync(pipelineGlobals, pipelineConfig);

pipelineGlobals.Log($"*************************************");
pipelineGlobals.Log(pipelineGlobals.payload);

Console.ReadLine();

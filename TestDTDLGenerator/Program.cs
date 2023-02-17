using GenericMathLib;
using solarPanelMonitoring;
using System.Numerics;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using TestDTDLGenerator;

var sample = new Solar_Panel_v1_1_7k6
{
    EnergyAmountkWh = 100,
    NominalVoltage = 220,
    PowerAmountKW = 15
};

FormulaValue xxx = (sample, "=EnergyAmountkWh * NominalVoltage");

Console.WriteLine(xxx);


JsonSerializerOptions genericMathSerializationOptions2 = new()
{
    WriteIndented = true,
    Converters = { 
        new GenericMathJsonConverter<Voltage>(),
        new GenericMathJsonConverter<Power>(),
        new GenericMathJsonConverter<Energy>()
    }
};


JsonSerializerOptions genericMathSerializationOptions1 = new()
{
    WriteIndented = true,
    Converters = {
        new GenericMathJsonConverter<Voltage>(),
        new GenericMathJsonConverter<Power>(),
        new GenericMathJsonConverter<Energy>()
    },
    TypeInfoResolver = new DefaultJsonTypeInfoResolver
    {
        Modifiers = { GenericMathSerializationModifier }
    }
};

//var sampleJson = JsonSerializer.Serialize(sample, genericMathSerializationOptions2);
//File.WriteAllText("sample.json", sampleJson);
//Console.WriteLine(sampleJson);

//var sampleJson = File.ReadAllText("sample.json");
//var sample1 = JsonSerializer.Deserialize<Solar_Panel_v1_1_7k6>(sampleJson, genericMathSerializationOptions2);

var sample2Json = File.ReadAllText("sample2.json");
var sample2 = JsonSerializer.Deserialize<Solar_Panel_v1_1_7k6>(sample2Json, genericMathSerializationOptions1);

Console.ReadLine();


static void GenericMathSerializationModifier(JsonTypeInfo jsonTypeInfo)
{
    if ((jsonTypeInfo.Type == typeof(Voltage)) || (jsonTypeInfo.Type == typeof(Power)) || (jsonTypeInfo.Type == typeof(Energy)))
    {
        var valueFieldInfo = jsonTypeInfo.Type.GetField("value", BindingFlags.NonPublic | BindingFlags.Instance);
        JsonPropertyInfo propertyInfo = jsonTypeInfo.CreateJsonPropertyInfo(valueFieldInfo.FieldType, valueFieldInfo.Name);
        propertyInfo.Get = obj => valueFieldInfo.GetValue(obj);
        propertyInfo.Set = (obj, value) => valueFieldInfo.SetValue(obj, value);

        jsonTypeInfo.Properties.Add(propertyInfo);
    }
}
public class GenericMathJsonConverter<T> : JsonConverter<T>
    where T : INumber<T>
{
    public override T Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options) =>
            T.Parse(reader.GetString()!, null);

    public override void Write(
        Utf8JsonWriter writer,
        T value,
        JsonSerializerOptions options) =>
            writer.WriteStringValue(value.ToString());
}

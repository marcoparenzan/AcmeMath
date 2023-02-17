var targetNamespaceName = $"GenericMathLib";
var targetPath = @$"..\..\..\..\{targetNamespaceName}";

GenericFloat("Voltage");
GenericFloat("Current");
GenericFloat("Power");
GenericFloat("Energy");

GenericNumber("ModBusInt32");
GenericDecimal("Money");
GenericFloat("Formula");
GenericFloat("FormulaValue");

//
//  API
//

void GenericFloat(string targetName) => Write(nameof(GenericFloat), targetName);
void GenericDecimal(string targetName) => Write(nameof(GenericDecimal), targetName);
void GenericNumber(string targetName) => Write(nameof(GenericNumber), targetName);

void Write(string sourceName, string targetName, string sourceType = null, string targetType = null)
{
    WriteImpl(sourceName, targetName, sourceType, targetType);
    WriteImpl("Partial", targetName, targetFileName: $"{targetName}.Relations");
}

void WriteImpl(string sourceName, string targetName, string sourceType = null, string targetType = null, string targetFileName = null)
{
    targetFileName = @$"{targetPath}\{targetFileName ?? targetName}.cs";
    if (!File.Exists(targetFileName))
    {
        var text = File.ReadAllText($"{sourceName}.cs");
        text = text.Replace("NamespaceName", targetNamespaceName);
        text = text.Replace($"{sourceName}", targetName);
        if (!string.IsNullOrWhiteSpace(sourceType))
        {
            text = text.Replace(sourceType, targetType);
        }
        File.WriteAllText(targetFileName, text);
    }
}
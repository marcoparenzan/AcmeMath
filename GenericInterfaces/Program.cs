
using System.Diagnostics.CodeAnalysis;

Do<MyObject>();

Console.WriteLine();



void Do<T>()
    where T: IParsable<T>
{
    var pObj = T.Parse("do", null);

    Console.Write(pObj);
}


public class MyObject : IParsable<MyObject>
{
    private string value;

    public override string ToString() => value;

    public static MyObject Parse(string s, IFormatProvider? provider = null)
    {
        return new MyObject
        {
            value = s
        };
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out MyObject result)
    {
        throw new NotImplementedException();
    }
}
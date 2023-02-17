
using System.Diagnostics.CodeAnalysis;
using System.Numerics;

T Pitagora<T>(T c1, T c2)
    where T: IFloatingPoint<T>, IRootFunctions<T>
{
    return T.Sqrt(c1*c1+ c2*c2);
}


void Do<T>(string s)
    where T : IParsable<T>
{
    var t = T.Parse(s, null);
}

public class MyClass : IParsable<MyClass>
{
    public static MyClass Parse(string s, IFormatProvider? provider)
    {
        throw new NotImplementedException();
    }

    public static bool TryParse([NotNullWhen(true)] string? s, IFormatProvider? provider, [MaybeNullWhen(false)] out MyClass result)
    {
        throw new NotImplementedException();
    }
}
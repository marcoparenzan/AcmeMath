using AcmeMathLanguage;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting.Hosting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Text;

namespace TestDTDLGenerator
{
    public partial struct FormulaValue : IFloatingPoint<FormulaValue>
    {
        public static implicit operator FormulaValue(float value) => new FormulaValue { value = value };
        public static implicit operator FormulaValue((object context, string text) value) => new FormulaValue { context = value.context, text = value.text };

        string text;
        object context;
        float? backingValue;

        internal float value
        {
            get
            {
                if (backingValue.HasValue) return backingValue.Value;
                if (text.StartsWith("="))
                { 
                    var exp = AcmeMathHelpers.ExpressionOf(text.Substring(1));

                    var source = exp.ToString();

                    var options = ScriptOptions.Default
                                 .AddReferences("Microsoft.CSharp")
                                 .AddReferences("GenericMathLib")
                             ;

                    var sbCode = new StringBuilder();

                    sbCode.AppendLine($@"
                        using System;
                        using System.Threading.Tasks;
                        using GenericMathLib;
                    ");
                    sbCode.AppendLine(source);

                    var loader = new InteractiveAssemblyLoader();

                    var state = CSharpScript.Create<float>(sbCode.ToString(), options, context.GetType(), loader);

                    var result = state.RunAsync(context, (ex) =>
                        true
                    ).Result;

                    return result.ReturnValue;
                }
                backingValue = int.Parse(text);
                return backingValue.Value;
            }

            set
            {
                backingValue = value;
            }
        }

        static FormulaValue zero = new FormulaValue { value = 0 };
        static FormulaValue one = new FormulaValue { value = 1 };
        static FormulaValue radix = new FormulaValue { value = 10 };
        static FormulaValue e = new FormulaValue { value = float.E };
        static FormulaValue pi = new FormulaValue { value = float.Pi };
        static FormulaValue tau = new FormulaValue { value = float.Tau };
        static FormulaValue negativeOne = new FormulaValue { value = -1 };

        public static FormulaValue One => one;

        public static int Radix => 10;

        public static FormulaValue Zero => zero;

        public static FormulaValue AdditiveIdentity => zero;

        public static FormulaValue MultiplicativeIdentity => one;

        public static FormulaValue E => e;

        public static FormulaValue Pi => pi;

        public static FormulaValue Tau => tau;

        public static FormulaValue NegativeOne => negativeOne;

        public static FormulaValue Abs(FormulaValue value) => new FormulaValue { value = float.Abs(value.value) };

        public static bool IsCanonical(FormulaValue value) => false;

        public static bool IsComplexNumber(FormulaValue value) => false;

        public static bool IsEvenInteger(FormulaValue value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(FormulaValue value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(FormulaValue value) => false;

        public static bool IsInfinity(FormulaValue value) => float.IsInfinity(value.value);

        public static bool IsInteger(FormulaValue value) => float.IsInteger(value.value);

        public static bool IsNaN(FormulaValue value) => float.IsNaN(value.value);

        public static bool IsNegative(FormulaValue value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(FormulaValue value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(FormulaValue value) => float.IsNormal(value.value);

        public static bool IsOddInteger(FormulaValue value) => float.IsOddInteger(value.value);

        public static bool IsPositive(FormulaValue value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(FormulaValue value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(FormulaValue value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(FormulaValue value) => float.IsSubnormal(value.value);

        public static bool IsZero(FormulaValue value) => value.value == 0;

        public static FormulaValue MaxMagnitude(FormulaValue x, FormulaValue y) => new FormulaValue { value = float.MaxMagnitude(x.value, y.value) };

        public static FormulaValue MaxMagnitudeNumber(FormulaValue x, FormulaValue y) => new FormulaValue { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static FormulaValue MinMagnitude(FormulaValue x, FormulaValue y) => new FormulaValue { value = float.MinMagnitude(x.value, y.value) };

        public static FormulaValue MinMagnitudeNumber(FormulaValue x, FormulaValue y) => new FormulaValue { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static FormulaValue Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new FormulaValue { value = value };
        }

        public static FormulaValue Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new FormulaValue { value = value };
        }

        public static FormulaValue Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new FormulaValue { value = value };
        }

        public static FormulaValue Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new FormulaValue { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out FormulaValue result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new FormulaValue { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out FormulaValue result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new FormulaValue { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out FormulaValue result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new FormulaValue { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out FormulaValue result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new FormulaValue { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(FormulaValue other) => value.CompareTo(other.value);

        public bool Equals(FormulaValue other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out FormulaValue result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out FormulaValue result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out FormulaValue result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(FormulaValue value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(FormulaValue value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(FormulaValue value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public int GetExponentByteCount()
        {
            throw new NotImplementedException();
        }

        public int GetExponentShortestBitLength()
        {
            throw new NotImplementedException();
        }

        public int GetSignificandBitLength()
        {
            throw new NotImplementedException();
        }

        public int GetSignificandByteCount()
        {
            throw new NotImplementedException();
        }

        public static FormulaValue Round(FormulaValue x, int digits, MidpointRounding mode)
        {
            throw new NotImplementedException();
        }

        public bool TryWriteExponentBigEndian(Span<byte> destination, out int bytesWritten)
        {
            throw new NotImplementedException();
        }

        public bool TryWriteExponentLittleEndian(Span<byte> destination, out int bytesWritten)
        {
            throw new NotImplementedException();
        }

        public bool TryWriteSignificandBigEndian(Span<byte> destination, out int bytesWritten)
        {
            throw new NotImplementedException();
        }

        public bool TryWriteSignificandLittleEndian(Span<byte> destination, out int bytesWritten)
        {
            throw new NotImplementedException();
        }

        public static FormulaValue operator +(FormulaValue value) => new FormulaValue { value = +value.value };

        public static FormulaValue operator +(FormulaValue left, FormulaValue right) => new FormulaValue { value = left.value + right.value };

        public static FormulaValue operator -(FormulaValue value) => new FormulaValue { value = -value.value };

        public static FormulaValue operator -(FormulaValue left, FormulaValue right) => new FormulaValue { value = left.value - right.value };

        public static FormulaValue operator ++(FormulaValue value) => new FormulaValue { value = value.value++ };

        public static FormulaValue operator --(FormulaValue value) => new FormulaValue { value = value.value-- };

        public static FormulaValue operator *(FormulaValue left, FormulaValue right) => new FormulaValue { value = left.value * right.value };

        public static FormulaValue operator /(FormulaValue left, FormulaValue right) => new FormulaValue { value = left.value / right.value };

        public static FormulaValue operator %(FormulaValue left, FormulaValue right) => new FormulaValue { value = left.value % right.value };

        public static bool operator ==(FormulaValue left, FormulaValue right) => left.value == right.value;

        public static bool operator !=(FormulaValue left, FormulaValue right) => left.value != right.value;

        public static bool operator <(FormulaValue left, FormulaValue right) => left.value < right.value;

        public static bool operator >(FormulaValue left, FormulaValue right) => left.value > right.value;

        public static bool operator <=(FormulaValue left, FormulaValue right) => left.value <= right.value;

        public static bool operator >=(FormulaValue left, FormulaValue right) => left.value >= right.value;
    }
}

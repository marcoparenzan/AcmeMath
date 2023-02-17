using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct Energy : IFloatingPoint<Energy>
    {
        public static implicit operator Energy(float value) => new Energy { value = value };

        internal float value;

        static Energy zero = new Energy { value = 0 };
        static Energy one = new Energy { value = 1 };
        static Energy radix = new Energy { value = 10 };
        static Energy e = new Energy { value = float.E };
        static Energy pi = new Energy { value = float.Pi };
        static Energy tau = new Energy { value = float.Tau };
        static Energy negativeOne = new Energy { value = -1 };

        public static Energy One => one;

        public static int Radix => 10;

        public static Energy Zero => zero;

        public static Energy AdditiveIdentity => zero;

        public static Energy MultiplicativeIdentity => one;

        public static Energy E => e;

        public static Energy Pi => pi;

        public static Energy Tau => tau;

        public static Energy NegativeOne => negativeOne;

        public static Energy Abs(Energy value) => new Energy { value = float.Abs(value.value) };

        public static bool IsCanonical(Energy value) => false;

        public static bool IsComplexNumber(Energy value) => false;

        public static bool IsEvenInteger(Energy value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Energy value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Energy value) => false;

        public static bool IsInfinity(Energy value) => float.IsInfinity(value.value);

        public static bool IsInteger(Energy value) => float.IsInteger(value.value);

        public static bool IsNaN(Energy value) => float.IsNaN(value.value);

        public static bool IsNegative(Energy value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Energy value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Energy value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Energy value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Energy value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Energy value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Energy value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Energy value) => float.IsSubnormal(value.value);

        public static bool IsZero(Energy value) => value.value == 0;

        public static Energy MaxMagnitude(Energy x, Energy y) => new Energy { value = float.MaxMagnitude(x.value, y.value) };

        public static Energy MaxMagnitudeNumber(Energy x, Energy y) => new Energy { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Energy MinMagnitude(Energy x, Energy y) => new Energy { value = float.MinMagnitude(x.value, y.value) };

        public static Energy MinMagnitudeNumber(Energy x, Energy y) => new Energy { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Energy Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Energy { value = value };
        }

        public static Energy Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Energy { value = value };
        }

        public static Energy Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Energy { value = value };
        }

        public static Energy Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Energy { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Energy result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Energy { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Energy result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Energy { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Energy result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Energy { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Energy result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Energy { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Energy other) => value.CompareTo(other.value);

        public bool Equals(Energy other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Energy result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Energy result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Energy result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Energy value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Energy value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Energy value, out TOther result)
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

        public static Energy Round(Energy x, int digits, MidpointRounding mode)
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

        public static Energy operator +(Energy value) => new Energy { value = +value.value };

        public static Energy operator +(Energy left, Energy right) => new Energy { value = left.value + right.value };

        public static Energy operator -(Energy value) => new Energy { value = -value.value };

        public static Energy operator -(Energy left, Energy right) => new Energy { value = left.value - right.value };

        public static Energy operator ++(Energy value) => new Energy { value = value.value++ };

        public static Energy operator --(Energy value) => new Energy { value = value.value-- };

        public static Energy operator *(Energy left, Energy right) => new Energy { value = left.value * right.value };

        public static Energy operator /(Energy left, Energy right) => new Energy { value = left.value / right.value };

        public static Energy operator %(Energy left, Energy right) => new Energy { value = left.value % right.value };

        public static bool operator ==(Energy left, Energy right) => left.value == right.value;

        public static bool operator !=(Energy left, Energy right) => left.value != right.value;

        public static bool operator <(Energy left, Energy right) => left.value < right.value;

        public static bool operator >(Energy left, Energy right) => left.value > right.value;

        public static bool operator <=(Energy left, Energy right) => left.value <= right.value;

        public static bool operator >=(Energy left, Energy right) => left.value >= right.value;
    }
}

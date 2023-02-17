using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace NamespaceName
{
    public partial struct GenericDecimal : INumber<GenericDecimal>
    {
        public static implicit operator GenericDecimal(decimal value) => new GenericDecimal { value = value };

        internal decimal value;

        static GenericDecimal zero = new GenericDecimal { value = 0 };
        static GenericDecimal one = new GenericDecimal { value = 1 };
        static GenericDecimal negativeOne = new GenericDecimal { value = -1 };

        public static GenericDecimal One => one;

        public static int Radix => 10;

        public static GenericDecimal Zero => zero;

        public static GenericDecimal AdditiveIdentity => zero;

        public static GenericDecimal MultiplicativeIdentity => one;

        public static GenericDecimal NegativeOne => negativeOne;

        public static GenericDecimal Abs(GenericDecimal value) => new GenericDecimal { value = decimal.Abs(value.value) };

        public static bool IsCanonical(GenericDecimal value) => false;

        public static bool IsComplexNumber(GenericDecimal value) => false;

        public static bool IsEvenInteger(GenericDecimal value) => decimal.IsEvenInteger(value.value);

        public static bool IsFinite(GenericDecimal value) => true;

        public static bool IsImaginaryNumber(GenericDecimal value) => false;

        public static bool IsInfinity(GenericDecimal value) => false;

        public static bool IsInteger(GenericDecimal value) => decimal.IsInteger(value.value);

        public static bool IsNaN(GenericDecimal value) => false;

        public static bool IsNegative(GenericDecimal value) => decimal.IsNegative(value.value);

        public static bool IsNegativeInfinity(GenericDecimal value) => false;

        public static bool IsNormal(GenericDecimal value) => false;

        public static bool IsOddInteger(GenericDecimal value) => decimal.IsOddInteger(value.value);

        public static bool IsPositive(GenericDecimal value) => decimal.IsPositive(value.value);

        public static bool IsPositiveInfinity(GenericDecimal value) => false;

        public static bool IsRealNumber(GenericDecimal value) => false;

        public static bool IsSubnormal(GenericDecimal value) => false;

        public static bool IsZero(GenericDecimal value) => value.value == 0;

        public static GenericDecimal MaxMagnitude(GenericDecimal x, GenericDecimal y) => new GenericDecimal { value = decimal.MaxMagnitude(x.value, y.value) };

        public static GenericDecimal MaxMagnitudeNumber(GenericDecimal x, GenericDecimal y) => new GenericDecimal { value = (decimal) Math.MaxMagnitude((double) x.value, (double) y.value) };

        public static GenericDecimal MinMagnitude(GenericDecimal x, GenericDecimal y) => new GenericDecimal { value = decimal.MinMagnitude(x.value, y.value) };

        public static GenericDecimal MinMagnitudeNumber(GenericDecimal x, GenericDecimal y) => new GenericDecimal { value = (decimal)Math.MinMagnitude((double)x.value, (double)y.value) };

        public static GenericDecimal Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = decimal.Parse(s, style, provider);
            return new GenericDecimal { value = value };
        }

        public static GenericDecimal Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = decimal.Parse(s, style, provider);
            return new GenericDecimal { value = value };
        }

        public static GenericDecimal Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = decimal.Parse(s, provider);
            return new GenericDecimal { value = value };
        }

        public static GenericDecimal Parse(string s, IFormatProvider provider)
        {
            var value = decimal.Parse(s, provider);
            return new GenericDecimal { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericDecimal result)
        {
            if (decimal.TryParse(s, style, provider, out var value))
            {
                result = new GenericDecimal { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericDecimal result)
        {
            if (decimal.TryParse(s, style, provider, out var value))
            {
                result = new GenericDecimal { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericDecimal result)
        {
            if (decimal.TryParse(s, provider, out var value))
            {
                result = new GenericDecimal { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericDecimal result)
        {
            if (decimal.TryParse(s, provider, out var value))
            {
                result = new GenericDecimal { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(GenericDecimal other) => value.CompareTo(other.value);

        public bool Equals(GenericDecimal other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var result = value.TryFormat(destination, out int cw, format, provider);
            charsWritten = cw;
            return result;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out GenericDecimal result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out GenericDecimal result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out GenericDecimal result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(GenericDecimal value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(GenericDecimal value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(GenericDecimal value, out TOther result)
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

        public static GenericDecimal Round(GenericDecimal x, int digits, MidpointRounding mode)
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

        public static GenericDecimal operator +(GenericDecimal value) => new GenericDecimal { value = +value.value };

        public static GenericDecimal operator +(GenericDecimal left, GenericDecimal right) => new GenericDecimal { value = left.value + right.value };

        public static GenericDecimal operator -(GenericDecimal value) => new GenericDecimal { value = -value.value };

        public static GenericDecimal operator -(GenericDecimal left, GenericDecimal right) => new GenericDecimal { value = left.value - right.value };

        public static GenericDecimal operator ++(GenericDecimal value) => new GenericDecimal { value = value.value++ };

        public static GenericDecimal operator --(GenericDecimal value) => new GenericDecimal { value = value.value-- };

        public static GenericDecimal operator *(GenericDecimal left, GenericDecimal right) => new GenericDecimal { value = left.value * right.value };

        public static GenericDecimal operator /(GenericDecimal left, GenericDecimal right) => new GenericDecimal { value = left.value / right.value };

        public static GenericDecimal operator %(GenericDecimal left, GenericDecimal right) => new GenericDecimal { value = left.value % right.value };

        public static bool operator ==(GenericDecimal left, GenericDecimal right) => left.value == right.value;

        public static bool operator !=(GenericDecimal left, GenericDecimal right) => left.value != right.value;

        public static bool operator <(GenericDecimal left, GenericDecimal right) => left.value < right.value;

        public static bool operator >(GenericDecimal left, GenericDecimal right) => left.value > right.value;

        public static bool operator <=(GenericDecimal left, GenericDecimal right) => left.value <= right.value;

        public static bool operator >=(GenericDecimal left, GenericDecimal right) => left.value >= right.value;
    }
}

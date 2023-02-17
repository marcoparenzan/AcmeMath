using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace NamespaceName
{
    public partial struct GenericFloat : IFloatingPoint<GenericFloat>
    {
        public static implicit operator GenericFloat(float value) => new GenericFloat { value = value };

        internal float value;

        static GenericFloat zero = new GenericFloat { value = 0 };
        static GenericFloat one = new GenericFloat { value = 1 };
        static GenericFloat radix = new GenericFloat { value = 10 };
        static GenericFloat e = new GenericFloat { value = float.E };
        static GenericFloat pi = new GenericFloat { value = float.Pi };
        static GenericFloat tau = new GenericFloat { value = float.Tau };
        static GenericFloat negativeOne = new GenericFloat { value = -1 };

        public static GenericFloat One => one;

        public static int Radix => 10;

        public static GenericFloat Zero => zero;

        public static GenericFloat AdditiveIdentity => zero;

        public static GenericFloat MultiplicativeIdentity => one;

        public static GenericFloat E => e;

        public static GenericFloat Pi => pi;

        public static GenericFloat Tau => tau;

        public static GenericFloat NegativeOne => negativeOne;

        public static GenericFloat Abs(GenericFloat value) => new GenericFloat { value = float.Abs(value.value) };

        public static bool IsCanonical(GenericFloat value) => false;

        public static bool IsComplexNumber(GenericFloat value) => false;

        public static bool IsEvenInteger(GenericFloat value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(GenericFloat value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(GenericFloat value) => false;

        public static bool IsInfinity(GenericFloat value) => float.IsInfinity(value.value);

        public static bool IsInteger(GenericFloat value) => float.IsInteger(value.value);

        public static bool IsNaN(GenericFloat value) => float.IsNaN(value.value);

        public static bool IsNegative(GenericFloat value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(GenericFloat value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(GenericFloat value) => float.IsNormal(value.value);

        public static bool IsOddInteger(GenericFloat value) => float.IsOddInteger(value.value);

        public static bool IsPositive(GenericFloat value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(GenericFloat value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(GenericFloat value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(GenericFloat value) => float.IsSubnormal(value.value);

        public static bool IsZero(GenericFloat value) => value.value == 0;

        public static GenericFloat MaxMagnitude(GenericFloat x, GenericFloat y) => new GenericFloat { value = float.MaxMagnitude(x.value, y.value) };

        public static GenericFloat MaxMagnitudeNumber(GenericFloat x, GenericFloat y) => new GenericFloat { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static GenericFloat MinMagnitude(GenericFloat x, GenericFloat y) => new GenericFloat { value = float.MinMagnitude(x.value, y.value) };

        public static GenericFloat MinMagnitudeNumber(GenericFloat x, GenericFloat y) => new GenericFloat { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static GenericFloat Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new GenericFloat { value = value };
        }

        public static GenericFloat Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new GenericFloat { value = value };
        }

        public static GenericFloat Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new GenericFloat { value = value };
        }

        public static GenericFloat Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new GenericFloat { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericFloat result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new GenericFloat { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericFloat result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new GenericFloat { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericFloat result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new GenericFloat { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericFloat result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new GenericFloat { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(GenericFloat other) => value.CompareTo(other.value);

        public bool Equals(GenericFloat other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out GenericFloat result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out GenericFloat result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out GenericFloat result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(GenericFloat value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(GenericFloat value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(GenericFloat value, out TOther result)
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

        public static GenericFloat Round(GenericFloat x, int digits, MidpointRounding mode)
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

        public static GenericFloat operator +(GenericFloat value) => new GenericFloat { value = +value.value };

        public static GenericFloat operator +(GenericFloat left, GenericFloat right) => new GenericFloat { value = left.value + right.value };

        public static GenericFloat operator -(GenericFloat value) => new GenericFloat { value = -value.value };

        public static GenericFloat operator -(GenericFloat left, GenericFloat right) => new GenericFloat { value = left.value - right.value };

        public static GenericFloat operator ++(GenericFloat value) => new GenericFloat { value = value.value++ };

        public static GenericFloat operator --(GenericFloat value) => new GenericFloat { value = value.value-- };

        public static GenericFloat operator *(GenericFloat left, GenericFloat right) => new GenericFloat { value = left.value * right.value };

        public static GenericFloat operator /(GenericFloat left, GenericFloat right) => new GenericFloat { value = left.value / right.value };

        public static GenericFloat operator %(GenericFloat left, GenericFloat right) => new GenericFloat { value = left.value % right.value };

        public static bool operator ==(GenericFloat left, GenericFloat right) => left.value == right.value;

        public static bool operator !=(GenericFloat left, GenericFloat right) => left.value != right.value;

        public static bool operator <(GenericFloat left, GenericFloat right) => left.value < right.value;

        public static bool operator >(GenericFloat left, GenericFloat right) => left.value > right.value;

        public static bool operator <=(GenericFloat left, GenericFloat right) => left.value <= right.value;

        public static bool operator >=(GenericFloat left, GenericFloat right) => left.value >= right.value;
    }
}

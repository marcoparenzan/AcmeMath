using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct Speed : IFloatingPoint<Speed>
    {
        public static implicit operator Speed(float value) => new Speed { value = value };

        internal float value;

        static Speed zero = new Speed { value = 0 };
        static Speed one = new Speed { value = 1 };
        static Speed radix = new Speed { value = 10 };
        static Speed e = new Speed { value = float.E };
        static Speed pi = new Speed { value = float.Pi };
        static Speed tau = new Speed { value = float.Tau };
        static Speed negativeOne = new Speed { value = -1 };

        public static Speed One => one;

        public static int Radix => 10;

        public static Speed Zero => zero;

        public static Speed AdditiveIdentity => zero;

        public static Speed MultiplicativeIdentity => one;

        public static Speed E => e;

        public static Speed Pi => pi;

        public static Speed Tau => tau;

        public static Speed NegativeOne => negativeOne;

        public static Speed Abs(Speed value) => new Speed { value = float.Abs(value.value) };

        public static bool IsCanonical(Speed value) => false;

        public static bool IsComplexNumber(Speed value) => false;

        public static bool IsEvenInteger(Speed value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Speed value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Speed value) => false;

        public static bool IsInfinity(Speed value) => float.IsInfinity(value.value);

        public static bool IsInteger(Speed value) => float.IsInteger(value.value);

        public static bool IsNaN(Speed value) => float.IsNaN(value.value);

        public static bool IsNegative(Speed value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Speed value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Speed value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Speed value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Speed value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Speed value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Speed value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Speed value) => float.IsSubnormal(value.value);

        public static bool IsZero(Speed value) => value.value == 0;

        public static Speed MaxMagnitude(Speed x, Speed y) => new Speed { value = float.MaxMagnitude(x.value, y.value) };

        public static Speed MaxMagnitudeNumber(Speed x, Speed y) => new Speed { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Speed MinMagnitude(Speed x, Speed y) => new Speed { value = float.MinMagnitude(x.value, y.value) };

        public static Speed MinMagnitudeNumber(Speed x, Speed y) => new Speed { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Speed Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Speed { value = value };
        }

        public static Speed Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Speed { value = value };
        }

        public static Speed Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Speed { value = value };
        }

        public static Speed Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Speed { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Speed result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Speed { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Speed result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Speed { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Speed result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Speed { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Speed result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Speed { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Speed other) => value.CompareTo(other.value);

        public bool Equals(Speed other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Speed result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Speed result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Speed result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Speed value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Speed value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Speed value, out TOther result)
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

        public static Speed Round(Speed x, int digits, MidpointRounding mode)
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

        public static Speed operator +(Speed value) => new Speed { value = +value.value };

        public static Speed operator +(Speed left, Speed right) => new Speed { value = left.value + right.value };

        public static Speed operator -(Speed value) => new Speed { value = -value.value };

        public static Speed operator -(Speed left, Speed right) => new Speed { value = left.value - right.value };

        public static Speed operator ++(Speed value) => new Speed { value = value.value++ };

        public static Speed operator --(Speed value) => new Speed { value = value.value-- };

        public static Speed operator *(Speed left, Speed right) => new Speed { value = left.value * right.value };

        public static Speed operator /(Speed left, Speed right) => new Speed { value = left.value / right.value };

        public static Speed operator %(Speed left, Speed right) => new Speed { value = left.value % right.value };

        public static bool operator ==(Speed left, Speed right) => left.value == right.value;

        public static bool operator !=(Speed left, Speed right) => left.value != right.value;

        public static bool operator <(Speed left, Speed right) => left.value < right.value;

        public static bool operator >(Speed left, Speed right) => left.value > right.value;

        public static bool operator <=(Speed left, Speed right) => left.value <= right.value;

        public static bool operator >=(Speed left, Speed right) => left.value >= right.value;
    }
}

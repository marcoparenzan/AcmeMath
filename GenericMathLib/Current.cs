using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct Current : IFloatingPoint<Current>
    {
        public static implicit operator Current(float value) => new Current { value = value };

        internal float value;

        static Current zero = new Current { value = 0 };
        static Current one = new Current { value = 1 };
        static Current radix = new Current { value = 10 };
        static Current e = new Current { value = float.E };
        static Current pi = new Current { value = float.Pi };
        static Current tau = new Current { value = float.Tau };
        static Current negativeOne = new Current { value = -1 };

        public static Current One => one;

        public static int Radix => 10;

        public static Current Zero => zero;

        public static Current AdditiveIdentity => zero;

        public static Current MultiplicativeIdentity => one;

        public static Current E => e;

        public static Current Pi => pi;

        public static Current Tau => tau;

        public static Current NegativeOne => negativeOne;

        public static Current Abs(Current value) => new Current { value = float.Abs(value.value) };

        public static bool IsCanonical(Current value) => false;

        public static bool IsComplexNumber(Current value) => false;

        public static bool IsEvenInteger(Current value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Current value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Current value) => false;

        public static bool IsInfinity(Current value) => float.IsInfinity(value.value);

        public static bool IsInteger(Current value) => float.IsInteger(value.value);

        public static bool IsNaN(Current value) => float.IsNaN(value.value);

        public static bool IsNegative(Current value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Current value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Current value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Current value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Current value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Current value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Current value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Current value) => float.IsSubnormal(value.value);

        public static bool IsZero(Current value) => value.value == 0;

        public static Current MaxMagnitude(Current x, Current y) => new Current { value = float.MaxMagnitude(x.value, y.value) };

        public static Current MaxMagnitudeNumber(Current x, Current y) => new Current { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Current MinMagnitude(Current x, Current y) => new Current { value = float.MinMagnitude(x.value, y.value) };

        public static Current MinMagnitudeNumber(Current x, Current y) => new Current { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Current Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Current { value = value };
        }

        public static Current Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Current { value = value };
        }

        public static Current Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Current { value = value };
        }

        public static Current Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Current { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Current result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Current { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Current result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Current { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Current result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Current { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Current result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Current { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Current other) => value.CompareTo(other.value);

        public bool Equals(Current other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Current result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Current result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Current result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Current value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Current value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Current value, out TOther result)
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

        public static Current Round(Current x, int digits, MidpointRounding mode)
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

        public static Current operator +(Current value) => new Current { value = +value.value };

        public static Current operator +(Current left, Current right) => new Current { value = left.value + right.value };

        public static Current operator -(Current value) => new Current { value = -value.value };

        public static Current operator -(Current left, Current right) => new Current { value = left.value - right.value };

        public static Current operator ++(Current value) => new Current { value = value.value++ };

        public static Current operator --(Current value) => new Current { value = value.value-- };

        public static Current operator *(Current left, Current right) => new Current { value = left.value * right.value };

        public static Current operator /(Current left, Current right) => new Current { value = left.value / right.value };

        public static Current operator %(Current left, Current right) => new Current { value = left.value % right.value };

        public static bool operator ==(Current left, Current right) => left.value == right.value;

        public static bool operator !=(Current left, Current right) => left.value != right.value;

        public static bool operator <(Current left, Current right) => left.value < right.value;

        public static bool operator >(Current left, Current right) => left.value > right.value;

        public static bool operator <=(Current left, Current right) => left.value <= right.value;

        public static bool operator >=(Current left, Current right) => left.value >= right.value;
    }
}

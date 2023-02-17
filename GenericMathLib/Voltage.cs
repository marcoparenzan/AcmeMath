using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct Voltage : IFloatingPoint<Voltage>
    {
        public static implicit operator Voltage(float value) => new Voltage { value = value };

        internal float value;

        static Voltage zero = new Voltage { value = 0 };
        static Voltage one = new Voltage { value = 1 };
        static Voltage radix = new Voltage { value = 10 };
        static Voltage e = new Voltage { value = float.E };
        static Voltage pi = new Voltage { value = float.Pi };
        static Voltage tau = new Voltage { value = float.Tau };
        static Voltage negativeOne = new Voltage { value = -1 };

        public static Voltage One => one;

        public static int Radix => 10;

        public static Voltage Zero => zero;

        public static Voltage AdditiveIdentity => zero;

        public static Voltage MultiplicativeIdentity => one;

        public static Voltage E => e;

        public static Voltage Pi => pi;

        public static Voltage Tau => tau;

        public static Voltage NegativeOne => negativeOne;

        public static Voltage Abs(Voltage value) => new Voltage { value = float.Abs(value.value) };

        public static bool IsCanonical(Voltage value) => false;

        public static bool IsComplexNumber(Voltage value) => false;

        public static bool IsEvenInteger(Voltage value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Voltage value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Voltage value) => false;

        public static bool IsInfinity(Voltage value) => float.IsInfinity(value.value);

        public static bool IsInteger(Voltage value) => float.IsInteger(value.value);

        public static bool IsNaN(Voltage value) => float.IsNaN(value.value);

        public static bool IsNegative(Voltage value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Voltage value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Voltage value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Voltage value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Voltage value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Voltage value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Voltage value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Voltage value) => float.IsSubnormal(value.value);

        public static bool IsZero(Voltage value) => value.value == 0;

        public static Voltage MaxMagnitude(Voltage x, Voltage y) => new Voltage { value = float.MaxMagnitude(x.value, y.value) };

        public static Voltage MaxMagnitudeNumber(Voltage x, Voltage y) => new Voltage { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Voltage MinMagnitude(Voltage x, Voltage y) => new Voltage { value = float.MinMagnitude(x.value, y.value) };

        public static Voltage MinMagnitudeNumber(Voltage x, Voltage y) => new Voltage { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Voltage Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Voltage { value = value };
        }

        public static Voltage Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Voltage { value = value };
        }

        public static Voltage Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Voltage { value = value };
        }

        public static Voltage Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Voltage { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Voltage result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Voltage { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Voltage result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Voltage { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Voltage result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Voltage { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Voltage result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Voltage { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Voltage other) => value.CompareTo(other.value);

        public bool Equals(Voltage other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Voltage result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Voltage result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Voltage result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Voltage value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Voltage value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Voltage value, out TOther result)
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

        public static Voltage Round(Voltage x, int digits, MidpointRounding mode)
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

        public static Voltage operator +(Voltage value) => new Voltage { value = +value.value };

        public static Voltage operator +(Voltage left, Voltage right) => new Voltage { value = left.value + right.value };

        public static Voltage operator -(Voltage value) => new Voltage { value = -value.value };

        public static Voltage operator -(Voltage left, Voltage right) => new Voltage { value = left.value - right.value };

        public static Voltage operator ++(Voltage value) => new Voltage { value = value.value++ };

        public static Voltage operator --(Voltage value) => new Voltage { value = value.value-- };

        public static Voltage operator *(Voltage left, Voltage right) => new Voltage { value = left.value * right.value };

        public static Voltage operator /(Voltage left, Voltage right) => new Voltage { value = left.value / right.value };

        public static Voltage operator %(Voltage left, Voltage right) => new Voltage { value = left.value % right.value };

        public static bool operator ==(Voltage left, Voltage right) => left.value == right.value;

        public static bool operator !=(Voltage left, Voltage right) => left.value != right.value;

        public static bool operator <(Voltage left, Voltage right) => left.value < right.value;

        public static bool operator >(Voltage left, Voltage right) => left.value > right.value;

        public static bool operator <=(Voltage left, Voltage right) => left.value <= right.value;

        public static bool operator >=(Voltage left, Voltage right) => left.value >= right.value;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct Power : IFloatingPoint<Power>
    {
        public static implicit operator Power(float value) => new Power { value = value };

        internal float value;

        static Power zero = new Power { value = 0 };
        static Power one = new Power { value = 1 };
        static Power radix = new Power { value = 10 };
        static Power e = new Power { value = float.E };
        static Power pi = new Power { value = float.Pi };
        static Power tau = new Power { value = float.Tau };
        static Power negativeOne = new Power { value = -1 };

        public static Power One => one;

        public static int Radix => 10;

        public static Power Zero => zero;

        public static Power AdditiveIdentity => zero;

        public static Power MultiplicativeIdentity => one;

        public static Power E => e;

        public static Power Pi => pi;

        public static Power Tau => tau;

        public static Power NegativeOne => negativeOne;

        public static Power Abs(Power value) => new Power { value = float.Abs(value.value) };

        public static bool IsCanonical(Power value) => false;

        public static bool IsComplexNumber(Power value) => false;

        public static bool IsEvenInteger(Power value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Power value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Power value) => false;

        public static bool IsInfinity(Power value) => float.IsInfinity(value.value);

        public static bool IsInteger(Power value) => float.IsInteger(value.value);

        public static bool IsNaN(Power value) => float.IsNaN(value.value);

        public static bool IsNegative(Power value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Power value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Power value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Power value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Power value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Power value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Power value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Power value) => float.IsSubnormal(value.value);

        public static bool IsZero(Power value) => value.value == 0;

        public static Power MaxMagnitude(Power x, Power y) => new Power { value = float.MaxMagnitude(x.value, y.value) };

        public static Power MaxMagnitudeNumber(Power x, Power y) => new Power { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Power MinMagnitude(Power x, Power y) => new Power { value = float.MinMagnitude(x.value, y.value) };

        public static Power MinMagnitudeNumber(Power x, Power y) => new Power { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Power Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Power { value = value };
        }

        public static Power Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Power { value = value };
        }

        public static Power Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Power { value = value };
        }

        public static Power Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Power { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Power result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Power { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Power result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Power { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Power result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Power { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Power result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Power { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Power other) => value.CompareTo(other.value);

        public bool Equals(Power other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Power result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Power result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Power result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Power value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Power value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Power value, out TOther result)
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

        public static Power Round(Power x, int digits, MidpointRounding mode)
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

        public static Power operator +(Power value) => new Power { value = +value.value };

        public static Power operator +(Power left, Power right) => new Power { value = left.value + right.value };

        public static Power operator -(Power value) => new Power { value = -value.value };

        public static Power operator -(Power left, Power right) => new Power { value = left.value - right.value };

        public static Power operator ++(Power value) => new Power { value = value.value++ };

        public static Power operator --(Power value) => new Power { value = value.value-- };

        public static Power operator *(Power left, Power right) => new Power { value = left.value * right.value };

        public static Power operator /(Power left, Power right) => new Power { value = left.value / right.value };

        public static Power operator %(Power left, Power right) => new Power { value = left.value % right.value };

        public static bool operator ==(Power left, Power right) => left.value == right.value;

        public static bool operator !=(Power left, Power right) => left.value != right.value;

        public static bool operator <(Power left, Power right) => left.value < right.value;

        public static bool operator >(Power left, Power right) => left.value > right.value;

        public static bool operator <=(Power left, Power right) => left.value <= right.value;

        public static bool operator >=(Power left, Power right) => left.value >= right.value;
    }
}

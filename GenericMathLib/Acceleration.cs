using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GenericMathLib
{
    public partial struct Acceleration : IFloatingPoint<Acceleration>
    {
        public static implicit operator Acceleration(float value) => new Acceleration { value = value };

        internal float value;

        static Acceleration zero = new Acceleration { value = 0 };
        static Acceleration one = new Acceleration { value = 1 };
        static Acceleration radix = new Acceleration { value = 10 };
        static Acceleration e = new Acceleration { value = float.E };
        static Acceleration pi = new Acceleration { value = float.Pi };
        static Acceleration tau = new Acceleration { value = float.Tau };
        static Acceleration negativeOne = new Acceleration { value = -1 };

        public static Acceleration One => one;

        public static int Radix => 10;

        public static Acceleration Zero => zero;

        public static Acceleration AdditiveIdentity => zero;

        public static Acceleration MultiplicativeIdentity => one;

        public static Acceleration E => e;

        public static Acceleration Pi => pi;

        public static Acceleration Tau => tau;

        public static Acceleration NegativeOne => negativeOne;

        public static Acceleration Abs(Acceleration value) => new Acceleration { value = float.Abs(value.value) };

        public static bool IsCanonical(Acceleration value) => false;

        public static bool IsComplexNumber(Acceleration value) => false;

        public static bool IsEvenInteger(Acceleration value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Acceleration value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Acceleration value) => false;

        public static bool IsInfinity(Acceleration value) => float.IsInfinity(value.value);

        public static bool IsInteger(Acceleration value) => float.IsInteger(value.value);

        public static bool IsNaN(Acceleration value) => float.IsNaN(value.value);

        public static bool IsNegative(Acceleration value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Acceleration value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Acceleration value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Acceleration value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Acceleration value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Acceleration value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Acceleration value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Acceleration value) => float.IsSubnormal(value.value);

        public static bool IsZero(Acceleration value) => value.value == 0;

        public static Acceleration MaxMagnitude(Acceleration x, Acceleration y) => new Acceleration { value = float.MaxMagnitude(x.value, y.value) };

        public static Acceleration MaxMagnitudeNumber(Acceleration x, Acceleration y) => new Acceleration { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Acceleration MinMagnitude(Acceleration x, Acceleration y) => new Acceleration { value = float.MinMagnitude(x.value, y.value) };

        public static Acceleration MinMagnitudeNumber(Acceleration x, Acceleration y) => new Acceleration { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Acceleration Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Acceleration { value = value };
        }

        public static Acceleration Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Acceleration { value = value };
        }

        public static Acceleration Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Acceleration { value = value };
        }

        public static Acceleration Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Acceleration { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Acceleration result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Acceleration { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Acceleration result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Acceleration { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Acceleration result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Acceleration { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Acceleration result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Acceleration { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Acceleration other) => value.CompareTo(other.value);

        public bool Equals(Acceleration other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Acceleration result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Acceleration result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Acceleration result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Acceleration value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Acceleration value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Acceleration value, out TOther result)
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

        public static Acceleration Round(Acceleration x, int digits, MidpointRounding mode)
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

        public static Acceleration operator +(Acceleration value) => new Acceleration { value = +value.value };

        public static Acceleration operator +(Acceleration left, Acceleration right) => new Acceleration { value = left.value + right.value };

        public static Acceleration operator -(Acceleration value) => new Acceleration { value = -value.value };

        public static Acceleration operator -(Acceleration left, Acceleration right) => new Acceleration { value = left.value - right.value };

        public static Acceleration operator ++(Acceleration value) => new Acceleration { value = value.value++ };

        public static Acceleration operator --(Acceleration value) => new Acceleration { value = value.value-- };

        public static Acceleration operator *(Acceleration left, Acceleration right) => new Acceleration { value = left.value * right.value };

        public static Acceleration operator /(Acceleration left, Acceleration right) => new Acceleration { value = left.value / right.value };

        public static Acceleration operator %(Acceleration left, Acceleration right) => new Acceleration { value = left.value % right.value };

        public static bool operator ==(Acceleration left, Acceleration right) => left.value == right.value;

        public static bool operator !=(Acceleration left, Acceleration right) => left.value != right.value;

        public static bool operator <(Acceleration left, Acceleration right) => left.value < right.value;

        public static bool operator >(Acceleration left, Acceleration right) => left.value > right.value;

        public static bool operator <=(Acceleration left, Acceleration right) => left.value <= right.value;

        public static bool operator >=(Acceleration left, Acceleration right) => left.value >= right.value;
    }
}

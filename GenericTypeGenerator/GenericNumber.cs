using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace NamespaceName
{
    public partial struct GenericNumber : INumber<GenericNumber>
    {
        public static implicit operator GenericNumber(int value) => new GenericNumber { value = value };

        internal int value;

        static GenericNumber zero = new GenericNumber { value = 0 };
        static GenericNumber one = new GenericNumber { value = 1 };
        static GenericNumber negativeOne = new GenericNumber { value = -1 };

        public static GenericNumber One => one;

        public static int Radix => 10;

        public static GenericNumber Zero => zero;

        public static GenericNumber AdditiveIdentity => zero;

        public static GenericNumber MultiplicativeIdentity => one;

        public static GenericNumber NegativeOne => negativeOne;

        public static GenericNumber Abs(GenericNumber value) => new GenericNumber { value = int.Abs(value.value) };

        public static bool IsCanonical(GenericNumber value) => false;

        public static bool IsComplexNumber(GenericNumber value) => false;

        public static bool IsEvenInteger(GenericNumber value) => int.IsEvenInteger(value.value);

        public static bool IsFinite(GenericNumber value) => true;

        public static bool IsImaginaryNumber(GenericNumber value) => false;

        public static bool IsInfinity(GenericNumber value) => false;

        public static bool IsInteger(GenericNumber value) => true;

        public static bool IsNaN(GenericNumber value) => false;

        public static bool IsNegative(GenericNumber value) => int.IsNegative(value.value);

        public static bool IsNegativeInfinity(GenericNumber value) => false;

        public static bool IsNormal(GenericNumber value) => false;

        public static bool IsOddInteger(GenericNumber value) => int.IsOddInteger(value.value);

        public static bool IsPositive(GenericNumber value) => int.IsPositive(value.value);

        public static bool IsPositiveInfinity(GenericNumber value) => false;

        public static bool IsRealNumber(GenericNumber value) => false;

        public static bool IsSubnormal(GenericNumber value) => false;

        public static bool IsZero(GenericNumber value) => value.value == 0;

        public static GenericNumber MaxMagnitude(GenericNumber x, GenericNumber y) => new GenericNumber { value = int.MaxMagnitude(x.value, y.value) };

        public static GenericNumber MaxMagnitudeNumber(GenericNumber x, GenericNumber y) => new GenericNumber { value = (int) Math.MaxMagnitude((double) x.value, (double) y.value) };

        public static GenericNumber MinMagnitude(GenericNumber x, GenericNumber y) => new GenericNumber { value = int.MinMagnitude(x.value, y.value) };

        public static GenericNumber MinMagnitudeNumber(GenericNumber x, GenericNumber y) => new GenericNumber { value = (int)Math.MinMagnitude((double)x.value, (double)y.value) };

        public static GenericNumber Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = int.Parse(s, style, provider);
            return new GenericNumber { value = value };
        }

        public static GenericNumber Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = int.Parse(s, style, provider);
            return new GenericNumber { value = value };
        }

        public static GenericNumber Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = int.Parse(s, provider);
            return new GenericNumber { value = value };
        }

        public static GenericNumber Parse(string s, IFormatProvider provider)
        {
            var value = int.Parse(s, provider);
            return new GenericNumber { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericNumber result)
        {
            if (int.TryParse(s, style, provider, out var value))
            {
                result = new GenericNumber { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out GenericNumber result)
        {
            if (int.TryParse(s, style, provider, out var value))
            {
                result = new GenericNumber { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericNumber result)
        {
            if (int.TryParse(s, provider, out var value))
            {
                result = new GenericNumber { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out GenericNumber result)
        {
            if (int.TryParse(s, provider, out var value))
            {
                result = new GenericNumber { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(GenericNumber other) => value.CompareTo(other.value);

        public bool Equals(GenericNumber other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var result = value.TryFormat(destination, out int cw, format, provider);
            charsWritten = cw;
            return result;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out GenericNumber result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out GenericNumber result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out GenericNumber result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(GenericNumber value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(GenericNumber value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(GenericNumber value, out TOther result)
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

        public static GenericNumber Round(GenericNumber x, int digits, MidpointRounding mode)
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

        public static GenericNumber operator +(GenericNumber value) => new GenericNumber { value = +value.value };

        public static GenericNumber operator +(GenericNumber left, GenericNumber right) => new GenericNumber { value = left.value + right.value };

        public static GenericNumber operator -(GenericNumber value) => new GenericNumber { value = -value.value };

        public static GenericNumber operator -(GenericNumber left, GenericNumber right) => new GenericNumber { value = left.value - right.value };

        public static GenericNumber operator ++(GenericNumber value) => new GenericNumber { value = value.value++ };

        public static GenericNumber operator --(GenericNumber value) => new GenericNumber { value = value.value-- };

        public static GenericNumber operator *(GenericNumber left, GenericNumber right) => new GenericNumber { value = left.value * right.value };

        public static GenericNumber operator /(GenericNumber left, GenericNumber right) => new GenericNumber { value = left.value / right.value };

        public static GenericNumber operator %(GenericNumber left, GenericNumber right) => new GenericNumber { value = left.value % right.value };

        public static bool operator ==(GenericNumber left, GenericNumber right) => left.value == right.value;

        public static bool operator !=(GenericNumber left, GenericNumber right) => left.value != right.value;

        public static bool operator <(GenericNumber left, GenericNumber right) => left.value < right.value;

        public static bool operator >(GenericNumber left, GenericNumber right) => left.value > right.value;

        public static bool operator <=(GenericNumber left, GenericNumber right) => left.value <= right.value;

        public static bool operator >=(GenericNumber left, GenericNumber right) => left.value >= right.value;
    }
}

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
    public partial struct Space : IFloatingPoint<Space>
    {
        public static implicit operator Space(float value) => new Space { value = value };

        internal float value;

        static Space zero = new Space { value = 0 };
        static Space one = new Space { value = 1 };
        static Space radix = new Space { value = 10 };
        static Space e = new Space { value = float.E };
        static Space pi = new Space { value = float.Pi };
        static Space tau = new Space { value = float.Tau };
        static Space negativeOne = new Space { value = -1 };

        public static Space One => one;

        public static int Radix => 10;

        public static Space Zero => zero;

        public static Space AdditiveIdentity => zero;

        public static Space MultiplicativeIdentity => one;

        public static Space E => e;

        public static Space Pi => pi;

        public static Space Tau => tau;

        public static Space NegativeOne => negativeOne;

        public static Space Abs(Space value) => new Space { value = float.Abs(value.value) };

        public static bool IsCanonical(Space value) => false;

        public static bool IsComplexNumber(Space value) => false;

        public static bool IsEvenInteger(Space value) => float.IsEvenInteger(value.value);

        public static bool IsFinite(Space value) => float.IsFinite(value.value);

        public static bool IsImaginaryNumber(Space value) => false;

        public static bool IsInfinity(Space value) => float.IsInfinity(value.value);

        public static bool IsInteger(Space value) => float.IsInteger(value.value);

        public static bool IsNaN(Space value) => float.IsNaN(value.value);

        public static bool IsNegative(Space value) => float.IsNegative(value.value);

        public static bool IsNegativeInfinity(Space value) => float.IsNegativeInfinity(value.value);

        public static bool IsNormal(Space value) => float.IsNormal(value.value);

        public static bool IsOddInteger(Space value) => float.IsOddInteger(value.value);

        public static bool IsPositive(Space value) => float.IsPositive(value.value);

        public static bool IsPositiveInfinity(Space value) => float.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Space value) => float.IsRealNumber(value.value);

        public static bool IsSubnormal(Space value) => float.IsSubnormal(value.value);

        public static bool IsZero(Space value) => value.value == 0;

        public static Space MaxMagnitude(Space x, Space y) => new Space { value = float.MaxMagnitude(x.value, y.value) };

        public static Space MaxMagnitudeNumber(Space x, Space y) => new Space { value = float.MaxMagnitudeNumber(x.value, y.value) };

        public static Space MinMagnitude(Space x, Space y) => new Space { value = float.MinMagnitude(x.value, y.value) };

        public static Space MinMagnitudeNumber(Space x, Space y) => new Space { value = float.MinMagnitudeNumber(x.value, y.value) };

        public static Space Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Space { value = value };
        }

        public static Space Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = float.Parse(s, style, provider);
            return new Space { value = value };
        }

        public static Space Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Space { value = value };
        }

        public static Space Parse(string s, IFormatProvider provider)
        {
            var value = float.Parse(s, provider);
            return new Space { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Space result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Space { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Space result)
        {
            if (Single.TryParse(s, style, provider, out var value))
            {
                result = new Space { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Space result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Space { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Space result)
        {
            if (Single.TryParse(s, provider, out var value))
            {
                result = new Space { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Space other) => value.CompareTo(other.value);

        public bool Equals(Space other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Space result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Space result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Space result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Space value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Space value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Space value, out TOther result)
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

        public static Space Round(Space x, int digits, MidpointRounding mode)
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

        public static Space operator +(Space value) => new Space { value = +value.value };

        public static Space operator +(Space left, Space right) => new Space { value = left.value + right.value };

        public static Space operator -(Space value) => new Space { value = -value.value };

        public static Space operator -(Space left, Space right) => new Space { value = left.value - right.value };

        public static Space operator ++(Space value) => new Space { value = value.value++ };

        public static Space operator --(Space value) => new Space { value = value.value-- };

        public static Space operator *(Space left, Space right) => new Space { value = left.value * right.value };

        public static Space operator /(Space left, Space right) => new Space { value = left.value / right.value };

        public static Space operator %(Space left, Space right) => new Space { value = left.value % right.value };

        public static bool operator ==(Space left, Space right) => left.value == right.value;

        public static bool operator !=(Space left, Space right) => left.value != right.value;

        public static bool operator <(Space left, Space right) => left.value < right.value;

        public static bool operator >(Space left, Space right) => left.value > right.value;

        public static bool operator <=(Space left, Space right) => left.value <= right.value;

        public static bool operator >=(Space left, Space right) => left.value >= right.value;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public enum Currency
    {
        EUR,
        USD
    }

    public partial struct Money : INumber<Money>
    {
        public static implicit operator Money(decimal value) => new Money { value = Math.Round(value, 2) };
        public static implicit operator Money((decimal value, Currency currency) value) => new Money { value = Math.Round(value.value, 2), currency = value.currency };

        Currency currency;
        internal decimal value;

        public Currency Currency => currency;

        static Money zero = new Money { value = 0 };
        static Money one = new Money { value = 1 };
        static Money negativeOne = new Money { value = -1 };

        public static Money One => one;

        public static int Radix => 10;

        public static Money Zero => zero;

        public static Money AdditiveIdentity => zero;

        public static Money MultiplicativeIdentity => one;

        public static Money NegativeOne => negativeOne;

        public static Money Abs(Money value) => new Money { value = decimal.Abs(value.value) };

        public static bool IsCanonical(Money value) => false;

        public static bool IsComplexNumber(Money value) => false;

        public static bool IsEvenInteger(Money value) => decimal.IsEvenInteger(value.value);

        public static bool IsFinite(Money value) => true;

        public static bool IsImaginaryNumber(Money value) => false;

        public static bool IsInfinity(Money value) => false;

        public static bool IsInteger(Money value) => decimal.IsInteger(value.value);

        public static bool IsNaN(Money value) => false;

        public static bool IsNegative(Money value) => decimal.IsNegative(value.value);

        public static bool IsNegativeInfinity(Money value) => false;

        public static bool IsNormal(Money value) => false;

        public static bool IsOddInteger(Money value) => decimal.IsOddInteger(value.value);

        public static bool IsPositive(Money value) => decimal.IsPositive(value.value);

        public static bool IsPositiveInfinity(Money value) => false;

        public static bool IsRealNumber(Money value) => false;

        public static bool IsSubnormal(Money value) => false;

        public static bool IsZero(Money value) => value.value == 0;

        public static Money MaxMagnitude(Money x, Money y) => new Money { value = decimal.MaxMagnitude(x.value, y.value) };

        public static Money MaxMagnitudeNumber(Money x, Money y) => new Money { value = (decimal) Math.MaxMagnitude((double) x.value, (double) y.value) };

        public static Money MinMagnitude(Money x, Money y) => new Money { value = decimal.MinMagnitude(x.value, y.value) };

        public static Money MinMagnitudeNumber(Money x, Money y) => new Money { value = (decimal)Math.MinMagnitude((double)x.value, (double)y.value) };

        public static Money Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = decimal.Parse(s, style, provider);
            return new Money { value = value };
        }

        public static Money Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = decimal.Parse(s, style, provider);
            return new Money { value = value };
        }

        public static Money Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = decimal.Parse(s, provider);
            return new Money { value = value };
        }

        public static Money Parse(string s, IFormatProvider provider)
        {
            var value = decimal.Parse(s, provider);
            return new Money { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Money result)
        {
            if (decimal.TryParse(s, style, provider, out var value))
            {
                result = new Money { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Money result)
        {
            if (decimal.TryParse(s, style, provider, out var value))
            {
                result = new Money { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Money result)
        {
            if (decimal.TryParse(s, provider, out var value))
            {
                result = new Money { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Money result)
        {
            if (decimal.TryParse(s, provider, out var value))
            {
                result = new Money { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Money other) => value.CompareTo(other.value);

        public bool Equals(Money other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var result = value.TryFormat(destination, out int cw, format, provider);
            charsWritten = cw;
            return result;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Money result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Money result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Money result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Money value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Money value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Money value, out TOther result)
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

        public static Money Round(Money x, int digits, MidpointRounding mode)
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

        public static Money operator +(Money value) => new Money { value = +value.value };

        public static Money operator +(Money left, Money right) => new Money { value = left.value + right.value };

        public static Money operator -(Money value) => new Money { value = -value.value };

        public static Money operator -(Money left, Money right) => new Money { value = left.value - right.value };

        public static Money operator ++(Money value) => new Money { value = value.value++ };

        public static Money operator --(Money value) => new Money { value = value.value-- };

        public static Money operator *(Money left, Money right) => new Money { value = Math.Round(left.value * right.value, 2) };

        public static Money operator /(Money left, Money right) => new Money { value = Math.Round(left.value / right.value, 2) };

        public static Money operator %(Money left, Money right) => new Money { value = Math.Round(left.value % right.value, 2) };

        public static bool operator ==(Money left, Money right) => left.value == right.value;

        public static bool operator !=(Money left, Money right) => left.value != right.value;

        public static bool operator <(Money left, Money right) => left.value < right.value;

        public static bool operator >(Money left, Money right) => left.value > right.value;

        public static bool operator <=(Money left, Money right) => left.value <= right.value;

        public static bool operator >=(Money left, Money right) => left.value >= right.value;
    }
}

using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Reflection;

namespace GenericMathLib
{
    public partial struct Formula<T> : IFloatingPoint<Formula<T>>
        where T: IFloatingPoint<T>
    {
        public static implicit operator Formula<T>(T value) => new Formula<T> { value = value };

        public static implicit operator Formula<T>(Func<T> formula) => new Formula<T> { formula = formula };

        bool backingValueSet;
        T backingValue;
        Func<T> formula;

        internal T value
        {
            get
            {
                if (backingValueSet) return backingValue;
                return formula();
            }

            set
            {
                backingValue = value;
                backingValueSet = true;
            }
        }

        static Formula<T> zero = new Formula<T> { backingValue = T.Zero };
        static Formula<T> one = new Formula<T> { backingValue = T.One };
        static Formula<T> e = new Formula<T> { backingValue = T.E };
        static Formula<T> pi = new Formula<T> { backingValue = T.Pi };
        static Formula<T> tau = new Formula<T> { backingValue = T.Tau };
        static Formula<T> negativeOne = new Formula<T> { backingValue = T.NegativeOne };

        public static Formula<T> One => one;

        public static int Radix => 10;

        public static Formula<T> Zero => zero;

        public static Formula<T> AdditiveIdentity => zero;

        public static Formula<T> MultiplicativeIdentity => one;

        public static Formula<T> E => e;

        public static Formula<T> Pi => pi;

        public static Formula<T> Tau => tau;

        public static Formula<T> NegativeOne => negativeOne;

        public static Formula<T> Abs(Formula<T> value) => new Formula<T> { value = T.Abs(value.value) };

        public static bool IsCanonical(Formula<T> value) => false;

        public static bool IsComplexNumber(Formula<T> value) => false;

        public static bool IsEvenInteger(Formula<T> value) => T.IsEvenInteger(value.value);

        public static bool IsFinite(Formula<T> value) => T.IsFinite(value.value);

        public static bool IsImaginaryNumber(Formula<T> value) => false;

        public static bool IsInfinity(Formula<T> value) => T.IsInfinity(value.value);

        public static bool IsInteger(Formula<T> value) => T.IsInteger(value.value);

        public static bool IsNaN(Formula<T> value) => T.IsNaN(value.value);

        public static bool IsNegative(Formula<T> value) => T.IsNegative(value.value);

        public static bool IsNegativeInfinity(Formula<T> value) => T.IsNegativeInfinity(value.value);

        public static bool IsNormal(Formula<T> value) => T.IsNormal(value.value);

        public static bool IsOddInteger(Formula<T> value) => T.IsOddInteger(value.value);

        public static bool IsPositive(Formula<T> value) => T.IsPositive(value.value);

        public static bool IsPositiveInfinity(Formula<T> value) => T.IsPositiveInfinity(value.value);

        public static bool IsRealNumber(Formula<T> value) => T.IsRealNumber(value.value);

        public static bool IsSubnormal(Formula<T> value) => T.IsSubnormal(value.value);

        public static bool IsZero(Formula<T> value) => value.value == T.Zero;

        public static Formula<T> MaxMagnitude(Formula<T> x, Formula<T> y) => new Formula<T> { value = T.MaxMagnitude(x.value, y.value) };

        public static Formula<T> MaxMagnitudeNumber(Formula<T> x, Formula<T> y) => new Formula<T> { value = T.MaxMagnitudeNumber(x.value, y.value) };

        public static Formula<T> MinMagnitude(Formula<T> x, Formula<T> y) => new Formula<T> { value = T.MinMagnitude(x.value, y.value) };

        public static Formula<T> MinMagnitudeNumber(Formula<T> x, Formula<T> y) => new Formula<T> { value = T.MinMagnitudeNumber(x.value, y.value) };

        public static Formula<T> Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = T.Parse(s, style, provider);
            return new Formula<T> { value = value };
        }

        public static Formula<T> Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = T.Parse(s, style, provider);
            return new Formula<T> { value = value };
        }

        public static Formula<T> Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = T.Parse(s, provider);
            return new Formula<T> { value = value };
        }

        public static Formula<T> Parse(string s, IFormatProvider provider)
        {
            var value = T.Parse(s, provider);
            return new Formula<T> { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Formula<T> result)
        {
            if (Formula<T>.TryParse(s, style, provider, out var value))
            {
                result = new Formula<T> { value = value.value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out Formula<T> result)
        {
            if (Formula<T>.TryParse(s, style, provider, out var value))
            {
                result = new Formula<T> { value = value.value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out Formula<T> result)
        {
            if (Formula<T>.TryParse(s, provider, out var value))
            {
                result = new Formula<T> { value = value.value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out Formula<T> result)
        {
            if (Formula<T>.TryParse(s, provider, out var value))
            {
                result = new Formula<T> { value = value.value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(Formula<T> other) => value.CompareTo(other.value);

        public bool Equals(Formula<T> other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public override string ToString() => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var formatted = value.TryFormat(destination, out int charsWritten1, format, provider);
            charsWritten = charsWritten1;
            return formatted;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out Formula<T> result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out Formula<T> result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out Formula<T> result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(Formula<T> value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(Formula<T> value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(Formula<T> value, out TOther result)
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

        public static Formula<T> Round(Formula<T> x, int digits, MidpointRounding mode)
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

        public static Formula<T> operator +(Formula<T> value) => new Formula<T> { value = +value.value };

        public static Formula<T> operator +(Formula<T> left, Formula<T> right) => new Formula<T> { value = left.value + right.value };

        public static Formula<T> operator -(Formula<T> value) => new Formula<T> { value = -value.value };

        public static Formula<T> operator -(Formula<T> left, Formula<T> right) => new Formula<T> { value = left.value - right.value };

        public static Formula<T> operator ++(Formula<T> value) => new Formula<T> { value = value.value++ };

        public static Formula<T> operator --(Formula<T> value) => new Formula<T> { value = value.value-- };

        public static Formula<T> operator *(Formula<T> left, Formula<T> right) => new Formula<T> { value = left.value * right.value };

        public static Formula<T> operator /(Formula<T> left, Formula<T> right) => new Formula<T> { value = left.value / right.value };

        public static Formula<T> operator %(Formula<T> left, Formula<T> right) => new Formula<T> { value = left.value % right.value };

        public static bool operator ==(Formula<T> left, Formula<T> right) => left.value == right.value;

        public static bool operator !=(Formula<T> left, Formula<T> right) => left.value != right.value;

        public static bool operator <(Formula<T> left, Formula<T> right) => left.value < right.value;

        public static bool operator >(Formula<T> left, Formula<T> right) => left.value > right.value;

        public static bool operator <=(Formula<T> left, Formula<T> right) => left.value <= right.value;

        public static bool operator >=(Formula<T> left, Formula<T> right) => left.value >= right.value;
    }
}

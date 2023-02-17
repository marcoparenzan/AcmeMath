using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;

namespace GenericMathLib
{
    public partial struct ModBusInt32 : INumber<ModBusInt32>
    {
        public static implicit operator ModBusInt32(int value) => new ModBusInt32 { value = value };
        public static implicit operator ModBusInt32((ushort[] buffer, int index) value) => new ModBusInt32 { buffer = value.buffer, index = value.index };

        int index;
        ushort[] buffer;
        int? backingValue;

        internal int value 
        { 
            get
            { 
                if (backingValue.HasValue) return backingValue.Value;
                return buffer[index] + (buffer[index + 1] << 16);
                //return backingValue.Value;
            } 
            
            set 
            { 
                backingValue = value;
            } 
        }

        static ModBusInt32 zero = new ModBusInt32 { value = 0 };
        static ModBusInt32 one = new ModBusInt32 { value = 1 };
        static ModBusInt32 negativeOne = new ModBusInt32 { value = -1 };

        public static ModBusInt32 One => one;

        public static int Radix => 10;

        public static ModBusInt32 Zero => zero;

        public static ModBusInt32 AdditiveIdentity => zero;

        public static ModBusInt32 MultiplicativeIdentity => one;

        public static ModBusInt32 NegativeOne => negativeOne;

        public static ModBusInt32 Abs(ModBusInt32 value) => new ModBusInt32 { value = int.Abs(value.value) };

        public static bool IsCanonical(ModBusInt32 value) => false;

        public static bool IsComplexNumber(ModBusInt32 value) => false;

        public static bool IsEvenInteger(ModBusInt32 value) => int.IsEvenInteger(value.value);

        public static bool IsFinite(ModBusInt32 value) => true;

        public static bool IsImaginaryNumber(ModBusInt32 value) => false;

        public static bool IsInfinity(ModBusInt32 value) => false;

        public static bool IsInteger(ModBusInt32 value) => true;

        public static bool IsNaN(ModBusInt32 value) => false;

        public static bool IsNegative(ModBusInt32 value) => int.IsNegative(value.value);

        public static bool IsNegativeInfinity(ModBusInt32 value) => false;

        public static bool IsNormal(ModBusInt32 value) => false;

        public static bool IsOddInteger(ModBusInt32 value) => int.IsOddInteger(value.value);

        public static bool IsPositive(ModBusInt32 value) => int.IsPositive(value.value);

        public static bool IsPositiveInfinity(ModBusInt32 value) => false;

        public static bool IsRealNumber(ModBusInt32 value) => false;

        public static bool IsSubnormal(ModBusInt32 value) => false;

        public static bool IsZero(ModBusInt32 value) => value.value == 0;

        public static ModBusInt32 MaxMagnitude(ModBusInt32 x, ModBusInt32 y) => new ModBusInt32 { value = int.MaxMagnitude(x.value, y.value) };

        public static ModBusInt32 MaxMagnitudeNumber(ModBusInt32 x, ModBusInt32 y) => new ModBusInt32 { value = (int) Math.MaxMagnitude((double) x.value, (double) y.value) };

        public static ModBusInt32 MinMagnitude(ModBusInt32 x, ModBusInt32 y) => new ModBusInt32 { value = int.MinMagnitude(x.value, y.value) };

        public static ModBusInt32 MinMagnitudeNumber(ModBusInt32 x, ModBusInt32 y) => new ModBusInt32 { value = (int)Math.MinMagnitude((double)x.value, (double)y.value) };

        public static ModBusInt32 Parse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider)
        {
            var value = int.Parse(s, style, provider);
            return new ModBusInt32 { value = value };
        }

        public static ModBusInt32 Parse(string s, NumberStyles style, IFormatProvider provider)
        {
            var value = int.Parse(s, style, provider);
            return new ModBusInt32 { value = value };
        }

        public static ModBusInt32 Parse(ReadOnlySpan<char> s, IFormatProvider provider)
        {
            var value = int.Parse(s, provider);
            return new ModBusInt32 { value = value };
        }

        public static ModBusInt32 Parse(string s, IFormatProvider provider)
        {
            var value = int.Parse(s, provider);
            return new ModBusInt32 { value = value };
        }

        public static bool TryParse(ReadOnlySpan<char> s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out ModBusInt32 result)
        {
            if (int.TryParse(s, style, provider, out var value))
            {
                result = new ModBusInt32 { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, NumberStyles style, IFormatProvider provider, [MaybeNullWhen(false)] out ModBusInt32 result)
        {
            if (int.TryParse(s, style, provider, out var value))
            {
                result = new ModBusInt32 { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse(ReadOnlySpan<char> s, IFormatProvider provider, [MaybeNullWhen(false)] out ModBusInt32 result)
        {
            if (int.TryParse(s, provider, out var value))
            {
                result = new ModBusInt32 { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public static bool TryParse([NotNullWhen(true)] string s, IFormatProvider provider, [MaybeNullWhen(false)] out ModBusInt32 result)
        {
            if (int.TryParse(s, provider, out var value))
            {
                result = new ModBusInt32 { value = value };
                return true;
            }
            result = default;
            return false;
        }

        public int CompareTo(object obj) => value.CompareTo(obj);

        public int CompareTo(ModBusInt32 other) => value.CompareTo(other.value);

        public bool Equals(ModBusInt32 other) => value.Equals(other.value);

        public string ToString(string format, IFormatProvider formatProvider) => value.ToString();

        public bool TryFormat(Span<char> destination, out int charsWritten, ReadOnlySpan<char> format, IFormatProvider provider)
        {
            var result = value.TryFormat(destination, out int cw, format, provider);
            charsWritten = cw;
            return result;
        }

        public static bool TryConvertFromChecked<TOther>(TOther value, out ModBusInt32 result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromSaturating<TOther>(TOther value, out ModBusInt32 result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertFromTruncating<TOther>(TOther value, out ModBusInt32 result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToChecked<TOther>(ModBusInt32 value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToSaturating<TOther>(ModBusInt32 value, out TOther result)
            where TOther : INumberBase<TOther>
        {
            throw new NotImplementedException();
        }

        public static bool TryConvertToTruncating<TOther>(ModBusInt32 value, out TOther result)
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

        public static ModBusInt32 Round(ModBusInt32 x, int digits, MidpointRounding mode)
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

        public static ModBusInt32 operator +(ModBusInt32 value) => new ModBusInt32 { value = +value.value };

        public static ModBusInt32 operator +(ModBusInt32 left, ModBusInt32 right) => new ModBusInt32 { value = left.value + right.value };

        public static ModBusInt32 operator -(ModBusInt32 value) => new ModBusInt32 { value = -value.value };

        public static ModBusInt32 operator -(ModBusInt32 left, ModBusInt32 right) => new ModBusInt32 { value = left.value - right.value };

        public static ModBusInt32 operator ++(ModBusInt32 value) => new ModBusInt32 { value = value.value++ };

        public static ModBusInt32 operator --(ModBusInt32 value) => new ModBusInt32 { value = value.value-- };

        public static ModBusInt32 operator *(ModBusInt32 left, ModBusInt32 right) => new ModBusInt32 { value = left.value * right.value };

        public static ModBusInt32 operator /(ModBusInt32 left, ModBusInt32 right) => new ModBusInt32 { value = left.value / right.value };

        public static ModBusInt32 operator %(ModBusInt32 left, ModBusInt32 right) => new ModBusInt32 { value = left.value % right.value };

        public static bool operator ==(ModBusInt32 left, ModBusInt32 right) => left.value == right.value;

        public static bool operator !=(ModBusInt32 left, ModBusInt32 right) => left.value != right.value;

        public static bool operator <(ModBusInt32 left, ModBusInt32 right) => left.value < right.value;

        public static bool operator >(ModBusInt32 left, ModBusInt32 right) => left.value > right.value;

        public static bool operator <=(ModBusInt32 left, ModBusInt32 right) => left.value <= right.value;

        public static bool operator >=(ModBusInt32 left, ModBusInt32 right) => left.value >= right.value;

        public override string ToString() => value.ToString();
    }
}

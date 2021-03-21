# API Reference

* *struct* **System.Half** - represents 16-bit floating point number.
* *static readonly field* **Half.Epsilon -> Half** - Represents the smallest positive System.Half value greater than zero.
* *static readonly field* **Half.MaxValue -> Half** - Represents the largest possible value of System.Half.
* *static readonly field* **Half.MinValue -> Half** - Represents the smallest possible value of System.Half.
* *static readonly field* **Half.NaN -> Half** - Represents not a number (NaN).
* *static readonly field* **Half.NegativeInfinity -> Half** - Represents negative infinity.
* *static readonly field* **Half.PositiveInfinity -> Half** - Represents positive infinity.
* *constructor* **Half(float value) -> new Half** - Initializes a new instance of System.Half to the value of the specified single-precision floating-point number.
* *constructor* **Half(int value) -> new Half** - Initializes a new instance of System.Half to the value of the specified 32-bit signed integer.
* *constructor* **Half(long value) -> new Half** - Initializes a new instance of System.Half to the value of the specified 64-bit signed integer.
* *constructor* **Half(double value) -> new Half** - Initializes a new instance of System.Half to the value of the specified double-precision floating-point number.
* *constructor* **Half(decimal value) -> new Half** - Initializes a new instance of System.Half to the value of the specified decimal number.
* *constructor* **Half(uint value) -> new Half** - Initializes a new instance of System.Half to the value of the specified 32-bit unsigned integer.
* *constructor* **Half(ulong value) -> new Half** - Initializes a new instance of System.Half to the value of the specified 64-bit unsigned integer.
* *static method* **Half.Negate(Half half) -> Half** - Returns the result of multiplying the specified System.Half value by negative one.
* *static method* **Half.Add(Half half1, Half half2)** -> Half - Adds two specified System.Half values.
* *static method* **Half.Substract(Half half1, Half half2)** -> Half - Subtracts one specified System.Half value from another.
* *static method* **Half.Multiply(Half half1, Half half2)** -> Half - Multiplies two specified System.Half values.
* *static method* **Half.Divide(Half half1, Half half2)** -> Half - Divides two specified System.Half values.
* *operator* **Half.+(Half half) -> Half** - Returns the value of the System.Half operand (the sign of the operand is unchanged).
* *operator* **Half.-(Half half) -> Half** - Negates the value of the specified System.Half operand.
* *operator* **Half.++(Half half) -> Half** - Increments the System.Half operand by 1.
* *operator* **Half.--(Half half) -> Half** - Decrements the System.Half operand by one.
* *operator* **Half.+(Half half1, Half half2) -> Half** - Adds two specified System.Half values.
* *operator* **Half.-(Half half1, Half half2) -> Half** - Subtracts two specified System.Half values.
* *operator* **Half.\*(Half half1, Half half2) -> Half** - Multiplies two specified System.Half values.
* *operator* **Half./(Half half1, Half half2) -> Half** - Divides two specified System.Half values.
* *operator* **Half.==(Half half1, Half half2) -> bool** - Returns a value indicating whether two instances of System.Half are equal.
* *operator* **Half.!=(Half half1, Half half2) -> bool** - Returns a value indicating whether two instances of System.Half are not equal.
* *operator* **Half.<(Half half1, Half half2) -> bool** - Returns a value indicating whether a specified System.Half is less than another specified System.Half.
* *operator* **Half.>(Half half1, Half half2) -> bool** - Returns a value indicating whether a specified System.Half is greater than another specified System.Half.
* *operator* **Half.<=(Half half1, Half half2) -> bool** - Returns a value indicating whether a specified System.Half is less than or equal to another specified System.Half.
* *operator* **Half.>=(Half half1, Half half2) -> bool** - Returns a value indicating whether a specified System.Half is greater than or equal to another specified System.Half.
* *operator* **Half.implicit(byte value) -> Half** - Converts an 8-bit unsigned integer to a System.Half.
* *operator* **Half.implicit(short value) -> Half** - Converts a 16-bit signed integer to a System.Half.
* *operator* **Half.implicit(char value) -> Half** - Converts a Unicode character to a System.Half.
* *operator* **Half.implicit(int value) -> Half** - Converts a 32-bit signed integer to a System.Half.
* *operator* **Half.implicit(long value) -> Half** - Converts a 64-bit signed integer to a System.Half.
* *operator* **Half.explicit(float value) -> Half** - Converts a single-precision floating-point number to a System.Half.
* *operator* **Half.explicit(double value) -> Half** - Converts a double-precision floating-point number to a System.Half.
* *operator* **Half.explicit(decimal value) -> Half** - Converts a decimal number to a System.Half.
* *operator* **Half.explicit(Half value) -> byte** - Converts a System.Half to an 8-bit unsigned integer.
* *operator* **Half.explicit(Half value) -> char** - Converts a System.Half to a Unicode character.
* *operator* **Half.explicit(Half value) -> short** - Converts a System.Half to a 16-bit signed integer.
* *operator* **Half.explicit(Half value) -> int** - Converts a System.Half to a 32-bit signed integer.
* *operator* **Half.explicit(Half value) -> long** - Converts a System.Half to a 64-bit signed integer.
* *operator* **Half.implicit(Half value) -> float** - Converts a System.Half to a single-precision floating-point number.
* *operator* **Half.implicit(Half value) -> double** - Converts a System.Half to a double-precision floating-point number.
* *operator* **Half.explicit(Half value) -> decimal** - Converts a System.Half to a decimal number.
* *operator* **Half.implicit(sbyte value) -> Half** - Converts an 8-bit signed integer to a System.Half.
* *operator* **Half.implicit(ushort value) -> Half** - Converts a 16-bit unsigned integer to a System.Half.
* *operator* **Half.implicit(uint value) -> Half** - Converts a 32-bit unsigned integer to a System.Half.
* *operator* **Half.implicit(ulong value) -> Half** - Converts a 64-bit unsigned integer to a System.Half.
* *operator* **Half.explicit(Half value) -> sbyte** - Converts a System.Half to an 8-bit signed integer.
* *operator* **Half.explicit(Half value) -> ushort** - Converts a System.Half to a 16-bit unsigned integer.
* *operator* **Half.explicit(Half value) -> uint** - Converts a System.Half to a 32-bit unsigned integer.
* *operator* **Half.explicit(Half value) -> ulong** - Converts a System.Half to a 64-bit unsigned integer.
* *method* **Half.CompareTo(Half other) -> int** - Compares this instance to a specified System.Half object.
* *method* **Half.CompareTo(object obj) -> int** - Compares this instance to a specified System.Object.
* *method* **Half.Equals(Half other) -> bool** - Returns a value indicating whether this instance and a specified System.Half object represent the same value.
* *override method* **Half.Equals(object obj) -> bool** - Returns a value indicating whether this instance and a specified System.Object represent the same type and value.
* *override method* **Half.GetHashCode() -> int** - Returns the hash code for this instance.
* *method* **Half.GetTypeCode() -> TypeCode** - Returns the System.TypeCode for value type System.Half.
* *static method* **Half.GetBytes(Half value) -> byte[]** - Returns the specified half-precision floating point value as an array of bytes.
* *static method* **Half.GetBits(Half value) -> ushort** - Converts the value of a specified instance of System.Half to its equivalent binary representation.
* *static method* **Half.ToHalf(byte[] value, int startIndex) -> Half** - Returns a half-precision floating point number converted from two bytes at a specified position in a byte array.
* *static method* **Half.ToHalf(ushort bits) -> Half** - Returns a half-precision floating point number converted from its binary representation.
* *static method* **Half.Sign(Half value) -> int** - Returns a value indicating the sign of a half-precision floating-point number.
* *static method* **Half.Abs(Half value) -> Half** - Returns the absolute value of a half-precision floating-point number.
* *static method* **Half.Max(Half value1, Half value2) -> Half** - Returns the larger of two half-precision floating-point numbers.
* *static method* **Half.Min(Half value1, Half value2) -> Half** - Returns the smaller of two half-precision floating-point numbers.
* *static method* **Half.IsNaN(Half half) -> bool** - Returns a value indicating whether the specified number evaluates to not a number (System.Half.NaN).
* *static method* **Half.IsInfinity(Half half) -> bool** - Returns a value indicating whether the specified number evaluates to negative or positive infinity.
* *static method* **Half.IsNegativeInfinity(Half half) -> bool** - Returns a value indicating whether the specified number evaluates to negative infinity.
* *static method* **Half.IsPositiveInfinity(Half half) -> bool** - Returns a value indicating whether the specified number evaluates to positive infinity.
* *static method* **Half.Parse(string value) -> Half** - Converts the string representation of a number to its System.Half equivalent.
* *static method* **Half.Parse(string value, IFormatProvider provider) -> Half** - Converts the string representation of a number to its System.Half equivalent using the specified culture-specific format information.
* *static method* **Half.Parse(string value, NumberStyles style) -> Half** - Converts the string representation of a number in a specified style to its System.Half equivalent.
* *static method* **Half.Parse(string value, NumberStyles style, IFormatProvider provider) -> Half** - Converts the string representation of a number to its System.Half equivalent using the specified style and culture-specific format.
* *static method* **Half.TryParse(string value, out Half result) -> bool** - Converts the string representation of a number to its System.Half equivalent. A return value indicates whether the conversion succeeded or failed.
* *static method* **Half.TryParse(string value, NumberStyles style, IFormatProvider provider, out Half result) -> bool** - Converts the string representation of a number to its System.Half equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed.
* *override method* **Half.ToString() -> string** - Converts the numeric value of this instance to its equivalent string representation.
* *method* **Half.ToString(IFormatProvider formatProvider) -> string** - Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information.
* *method* **Half.ToString(string format) -> string** - Converts the numeric value of this instance to its equivalent string representation, using the specified format.
* *method* **Half.ToString(string format, IFormatProvider formatProvider) -> string** - Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information.
* *IConvertible method* **Half.ToSingle(IFormatProvider provider) -> float**
* *IConvertible method* **Half.GetTypeCode() -> TypeCode**
* *IConvertible method* **Half.ToBoolean(IFormatProvider provider) -> bool**
* *IConvertible method* **Half.ToByte(IFormatProvider provider) -> byte**
* *IConvertible method* **Half.ToChar(IFormatProvider provider) -> char**
* *IConvertible method* **Half.ToDateTime(IFormatProvider provider) -> DateTime**
* *IConvertible method* **Half.ToDecimal(IFormatProvider provider) -> decimal**
* *IConvertible method* **Half.ToDouble(IFormatProvider provider) -> double**
* *IConvertible method* **Half.ToInt16(IFormatProvider provider) -> short**
* *IConvertible method* **Half.ToInt32(IFormatProvider provider) -> int**
* *IConvertible method* **Half.ToInt64(IFormatProvider provider) -> long**
* *IConvertible method* **Half.ToSByte(IFormatProvider provider) -> sbyte**
* *IConvertible method* **Half.ToString(IFormatProvider provider) -> string**
* *IConvertible method* **Half.ToType(Type conversionType, IFormatProvider provider) -> Type**
* *IConvertible method* **Half.ToUInt16(IFormatProvider provider) -> ushort**
* *IConvertible method* **Half.ToUInt32(IFormatProvider provider) -> uint**
* *IConvertible method* **Half.ToUInt64(IFormatProvider provider) -> ulong**

# Sample programs

Adding two Half numbers.

```C#
using System;

namespace HalfExample
{

    public static class Program
    {

        public static void Main()
        {
            Console.Write("a = ");
            var a = Half.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = Half.Parse(Console.ReadLine());
            Console.WriteLine("a + b = " + (a + b).ToString());
            Console.ReadKey(true);
        }

    }

}
```

# Third-party codes as part of System.Half

System.Half is a fully third-party code. Original source: https://sourceforge.net/projects/csharp-half/
In accordance with the license of the original System.Half code, the source code was refactored and included in the System.AI stack as an integral part.

# System.FloatingPoint

## API reference

![namespace](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/namespace.png) `System`

* ![struct](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/struct.png) `Half`

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Epsilon -> Half` **static readonly** _Represents the smallest positive `System.Half` value greater than zero._
  
* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MaxValue -> Half` **static readonly** _Represents the largest possible value of `System.Half`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MinValue -> Half` **static readonly** _Represents the smallest possible value of `System.Half`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NaN -> Half` **static readonly** _Represents not a number (NaN)._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NegativeInfinity -> Half` **static readonly** _Represents negative infinity._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `PositiveInfinity -> Half` **static readonly** _Represents positive infinity._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(float value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified single-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(int value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified 32-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(long value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified 64-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(double value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified double-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(decimal value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified decimal number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(uint value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified 32-bit unsigned integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Half(ulong value) -> new Half` _Initializes a new instance of `System.Half` to the value of the specified 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Negate(Half half) -> Half` **static** _Returns the result of multiplying the specified `System.Half` value by negative one._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Add(Half half1, Half half2) -> Half` **static** _Adds two specified `System.Half` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Substract(Half half1, Half half2) -> Half` **static** _Subtracts one specified `System.Half` value from another._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Multiply(Half half1, Half half2) -> Half` **static** _Multiplies two specified `System.Half` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Divide(Half half1, Half half2) -> Half` **static** _Divides two specified `System.Half` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(Half half) -> Half` _Returns the value of the `System.Half` operand (the sign of the operand is unchanged)._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(Half half) -> Half` _Negates the value of the specified `System.Half` operand._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `++(Half half) -> Half` _Increments the `System.Half` operand by 1._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `--(Half half) -> Half` _Decrements the `System.Half` operand by one._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(Half half1, Half half2) -> Half` _Adds two specified `System.Half` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(Half half1, Half half2) -> Half` _Subtracts two specified `System.Half` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `*(Half half1, Half half2) -> Half` _Multiplies two specified `System.Half` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `/(Half half1, Half half2) -> Half` _Divides two specified `System.Half` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `==(Half half1, Half half2) -> bool` _Returns a value indicating whether two instances of `System.Half` are equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `!=(Half half1, Half half2) -> bool` _Returns a value indicating whether two instances of `System.Half` are not equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<(Half half1, Half half2) -> bool` _Returns a value indicating whether a specified `System.Half` is less than another specified `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>(Half half1, Half half2) -> bool` _Returns a value indicating whether a specified `System.Half` is greater than another specified `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<=(Half half1, Half half2) -> bool` _Returns a value indicating whether a specified `System.Half` is less than or equal to another specified `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>=(Half half1, Half half2) -> bool` _Returns a value indicating whether a specified `System.Half` is greater than or equal to another specified `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(byte value) -> Half` _Converts an 8-bit unsigned integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(short value) -> Half` _Converts a 16-bit signed integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(char value) -> Half` _Converts a Unicode character to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(int value) -> Half` _Converts a 32-bit signed integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(long value) -> Half` _Converts a 64-bit signed integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Quarter value) -> Half` _Converts a quarter-precision floating-point number to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> Half` _Converts a 16-bit google brain floating-point number to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(float value) -> Half` _Converts a single-precision floating-point number to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(double value) -> Half` _Converts a double-precision floating-point number to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(decimal value) -> Half` _Converts a decimal number to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> byte` _Converts a `System.Half` to an 8-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> char` _Converts a `System.Half` to a Unicode character._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> short` _Converts a `System.Half` to a 16-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> int` _Converts a `System.Half` to a 32-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> long` _Converts a `System.Half` to a 64-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Half value) -> float` _Converts a `System.Half` to a single-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Half value) -> double` _Converts a `System.Half` to a double-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> decimal` _Converts a `System.Half` to a decimal number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(sbyte value) -> Half` _Converts an 8-bit signed integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ushort value) -> Half` _Converts a 16-bit unsigned integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(uint value) -> Half` _Converts a 32-bit unsigned integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ulong value) -> Half` _Converts a 64-bit unsigned integer to a `System.Half`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> sbyte` _Converts a `System.Half` to an 8-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> ushort` _Converts a `System.Half` to a 16-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> uint` _Converts a `System.Half` to a 32-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> ulong` _Converts a `System.Half` to a 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(Half other) -> int` _Compares this instance to a specified `System.Half` object._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(object obj) -> int` _Compares this instance to a specified `System.Object`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(Half other) -> bool` _Returns a value indicating whether this instance and a specified `System.Half` object represent the same value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(object obj) -> bool` **override** _Returns a value indicating whether this instance and a specified `System.Object` represent the same type and value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetHashCode() -> int` **override** _Returns the hash code for this instance._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetTypeCode() -> TypeCode` _Returns the `System.TypeCode` for value type `System.Half`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBytes(Half value) -> byte[]` **static** _Returns the specified half-precision floating point value as an array of bytes._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBits(Half value) -> ushort` **static** _Converts the value of a specified instance of System.Half to its equivalent binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToHalf(byte[] value, int startIndex) -> Half` **static** _Returns a half-precision floating point number converted from two bytes at a specified position in a byte array._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToHalf(ushort bits) -> Half` **static** _Returns a half-precision floating point number converted from its binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Sign(Half value) -> int` **static** _Returns a value indicating the sign of a half-precision floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Abs(Half value) -> Half` **static** _Returns the absolute value of a half-precision floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Max(Half value1, Half value2) -> Half` **static** _Returns the larger of two half-precision floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Min(Half value1, Half value2) -> Half` **static** _Returns the smaller of two half-precision floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNaN(Half half) -> bool` **static** _Returns a value indicating whether the specified number evaluates to not a number (System.Half.NaN)._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsInfinity(Half half) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative or positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNegativeInfinity(Half half) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsPositiveInfinity(Half half) -> boo` **static** _Returns a value indicating whether the specified number evaluates to positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value) -> Half` **static** _Converts the string representation of a number to its `System.Half` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, IFormatProvider provider) -> Half` **static** _Converts the string representation of a number to its `System.Half` equivalent using the specified culture-specific format information._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style) -> Half` **static** _Converts the string representation of a number in a specified style to its `System.Half` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style, IFormatProvider provider) -> Half` **static** _Converts the string representation of a number to its `System.Half` equivalent using the specified style and culture-specific format._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, out Half result) -> bool` **static** _Converts the string representation of a number to its `System.Half` equivalent. A return value indicates whether the conversion succeeded or failed._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, NumberStyles style, IFormatProvider provider, out Half result) -> bool` **static** _Converts the string representation of a number to its `System.Half` equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString() -> string` **override** _Converts the numeric value of this instance to its equivalent string representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString(IFormatProvider formatProvider) -> string` **override** _Converts the numeric value of this instance to its equivalent string representation using the specified culture-specific format information._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString(string format) -> string` **override** _Converts the numeric value of this instance to its equivalent string representation, using the specified format._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString(string format, IFormatProvider formatProvider) -> string` **override** _Converts the numeric value of this instance to its equivalent string representation using the specified format and culture-specific format information._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToSingle(IFormatProvider provider) -> float`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.GetTypeCode() -> TypeCode`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToBoolean(IFormatProvider provider) -> bool`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToByte(IFormatProvider provider) -> byte`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToChar(IFormatProvider provider) -> char`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToDateTime(IFormatProvider provider) -> DateTime`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToDecimal(IFormatProvider provider) -> decimal`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToDouble(IFormatProvider provider) -> double`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToInt16(IFormatProvider provider) -> short`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToInt32(IFormatProvider provider) -> int`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToInt64(IFormatProvider provider) -> long`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToSByte(IFormatProvider provider) -> sbyte`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToString(IFormatProvider provider) -> string`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToType(Type conversionType, IFormatProvider provider) -> Type`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToUInt16(IFormatProvider provider) -> ushort`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToUInt32(IFormatProvider provider) -> uint`

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `IConvertible.ToUInt64(IFormatProvider provider) -> ulong`

## Code samples

* Input and output of floating-point numbers. The simplest operations on them.

```C#
//reference System.FloatingPoint.dll or System.AI.dll
using System;

namespace FloatsExample
{

    public static class Program
    {

        public static void Main()
        {
            Console.Write("a = ");
            var a = Half.Parse(Console.ReadLine());
            Console.Write("b = ");
            var b = Quarter.Parse(Console.ReadLine());
            Console.Write("c = ");
            var c = BFloat16.Parse(Console.ReadLine());
            Console.WriteLine(string.Format("({0} + {1}) * {2} = {3}", a, b, c, (a + b) * c));
            Console.ReadKey(true);
        }

    }

}
```

* BFloat16 matrix multiplication

```C#
//reference System.FloatingPoint.dll or System.AI.dll
using System;

namespace FloatMatrixExample
{

    public static class Program
    {

        public static BFloat16[,] MatMul(BFloat16[,] a, BFloat16[,] b)
        {
            var m = a.GetLength(0);
            var n = b.GetLength(1);
            var k = b.GetLength(0);
            var c = new BFloat16[m, n];
            for(int i = 0; i < m; ++i)
            {
                for(int z = 0; z < k; ++z)
                {
                    var av = a[i, z];
                    for(int j = 0; j < n; ++j)
                    {
                        c[i, j] += av * b[z, j];
                    }
                }
            }
            return c;
        }

        public static BFloat16[,] RandomMatrix(int m, int n)
        {
            var matrix = new BFloat16[m, n];
            var rand = new Random();
            for(int i = 0; i < m; ++i)
            {
                for(int j = 0; j < n; ++j)
                {
                    matrix[i, j] = (BFloat16)rand.NextDouble();
                }
            }
            return matrix;
        }

        public static void PrintMatrix(BFloat16[,] m)
        {
            var h = m.GetLength(0);
            var w = m.GetLength(1);
            for(int i = 0; i < h; ++i)
            {
                for(int j = 0; j < w; ++j)
                {
                    if((j + 1) < w)
                    {
                        Console.Write(string.Format("{0:f4}, ", m[i, j]));
                    }
                    else
                    {
                        Console.WriteLine(string.Format("{0:f4}", m[i, j]));
                    }
                }
            }
        }

        public static void Main()
        {
            const int m = 4;
            const int n = 7;
            const int k = 3;
            var a = RandomMatrix(m, n);
            Console.WriteLine("a=");
            PrintMatrix(a);
            var b = RandomMatrix(n, k);
            Console.WriteLine("\nb=");
            PrintMatrix(b);
            var c = MatMul(a, b);
            Console.WriteLine("\nc=");
            PrintMatrix(c);
            Console.ReadKey(true);
        }

    }

}
```

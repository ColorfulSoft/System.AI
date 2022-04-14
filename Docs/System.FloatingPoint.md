# System.FloatingPoint

The library provides the floating-point numeric types `Quarter`, `Half` and `BFloat16`.

***All types provided by this library are not hardware-accelerated and are implemented programmatically, so their performance is significantly lower than that of the native float and double types.***

## API reference

![namespace](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/namespace.png) `System`

* ![struct](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/struct.png) `Quarter`

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Epsilon -> Quarter` **static readonly** _Represents the smallest positive `System.Quarter` value greater than zero._
  
* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MaxValue -> Quarter` **static readonly** _Represents the largest possible value of `System.Quarter`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MinValue -> Quarter` **static readonly** _Represents the smallest possible value of `System.Quarter`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NaN -> Quarter` **static readonly** _Represents not a number (NaN)._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NegativeInfinity -> Quarter` **static readonly** _Represents negative infinity._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `PositiveInfinity -> Quarter` **static readonly** _Represents positive infinity._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(float value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified single-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(int value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified 32-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(long value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified 64-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(double value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified double-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(decimal value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified decimal number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(uint value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified 32-bit unsigned integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Quarter(ulong value) -> new Quarter` _Initializes a new instance of `System.Quarter` to the value of the specified 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Negate(Quarter quarter) -> Quarter` **static** _Returns the result of multiplying the specified `System.Quarter` value by negative one._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Add(Quarter quarter1, Quarter quarter2) -> Quarter` **static** _Adds two specified `System.Quarter` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Substract(Quarter quarter1, Quarter quarter2) -> Quarter` **static** _Subtracts one specified `System.Quarter` value from another._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Multiply(Quarter quarter1, Quarter quarter2) -> Quarter` **static** _Multiplies two specified `System.Quarter` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Divide(Quarter quarter1, Quarter quarter2) -> Quarter` **static** _Divides two specified `System.Quarter` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(Quarter quarter) -> Quarter` _Returns the value of the `System.Quarter` operand (the sign of the operand is unchanged)._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(Quarter quarter) -> Quarter` _Negates the value of the specified `System.Quarter` operand._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `++(Quarter quarter) -> Quarter` _Increments the `System.Quarter` operand by 1._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `--(Quarter quarter) -> Quarter` _Decrements the `System.Quarter` operand by one._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(Quarter quarter1, Quarter quarter2) -> Quarter` _Adds two specified `System.Quarter` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(Quarter quarter1, Quarter quarter2) -> Quarter` _Subtracts two specified `System.Quarter` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `*(Quarter quarter1, Quarter quarter2) -> Quarter` _Multiplies two specified `System.Quarter` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `/(Quarter quarter1, Quarter quarter2) -> Quarter` _Divides two specified `System.Quarter` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `==(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether two instances of `System.Quarter` are equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `!=(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether two instances of `System.Quarter` are not equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether a specified `System.Quarter` is less than another specified `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether a specified `System.Quarter` is greater than another specified `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<=(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether a specified `System.Quarter` is less than or equal to another specified `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>=(Quarter quarter1, Quarter quarter2) -> bool` _Returns a value indicating whether a specified `System.Quarter` is greater than or equal to another specified `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(byte value) -> Quarter` _Converts an 8-bit unsigned integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(short value) -> Quarter` _Converts a 16-bit signed integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(char value) -> Quarter` _Converts a Unicode character to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(int value) -> Quarter` _Converts a 32-bit signed integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(long value) -> Quarter` _Converts a 64-bit signed integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Half value) -> Quarter` _Converts a half-precision floating-point number to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> Quarter` _Converts a 16-bit google brain floating-point number to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(float value) -> Quarter` _Converts a single-precision floating-point number to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(double value) -> Quarter` _Converts a double-precision floating-point number to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(decimal value) -> Quarter` _Converts a decimal number to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> byte` _Converts a `System.Quarter` to an 8-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> char` _Converts a `System.Quarter` to a Unicode character._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> short` _Converts a `System.Quarter` to a 16-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> int` _Converts a `System.Quarter` to a 32-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> long` _Converts a `System.Quarter` to a 64-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Quarter value) -> float` _Converts a `System.Quarter` to a single-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Quarter value) -> double` _Converts a `System.Quarter` to a double-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> decimal` _Converts a `System.Quarter` to a decimal number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(sbyte value) -> Quarter` _Converts an 8-bit signed integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ushort value) -> Quarter` _Converts a 16-bit unsigned integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(uint value) -> Quarter` _Converts a 32-bit unsigned integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ulong value) -> Quarter` _Converts a 64-bit unsigned integer to a `System.Quarter`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> sbyte` _Converts a `System.Quarter` to an 8-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> ushort` _Converts a `System.Quarter` to a 16-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> uint` _Converts a `System.Quarter` to a 32-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(Quarter value) -> ulong` _Converts a `System.Quarter` to a 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(Quarter other) -> int` _Compares this instance to a specified `System.Quarter` object._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(object obj) -> int` _Compares this instance to a specified `System.Object`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(Quarter other) -> bool` _Returns a value indicating whether this instance and a specified `System.Quarter` object represent the same value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(object obj) -> bool` **override** _Returns a value indicating whether this instance and a specified `System.Object` represent the same type and value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetHashCode() -> int` **override** _Returns the hash code for this instance._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetTypeCode() -> TypeCode` _Returns the `System.TypeCode` for value type `System.Quarter`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBytes(Quarter value) -> byte[]` **static** _Returns the specified quarter-precision floating point value as an array of bytes._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBits(Quarter value) -> byte` **static** _Converts the value of a specified instance of System.Quarter to its equivalent binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToQuarter(byte[] value, int startIndex) -> Quarter` **static** _Returns a quarter-precision floating point number converted from one byte at a specified position in a byte array._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToQuarter(byte bits) -> Quarter` **static** _Returns a quarter-precision floating point number converted from its binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Sign(Quarter value) -> int` **static** _Returns a value indicating the sign of a quarter-precision floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Abs(Quarter value) -> Quarter` **static** _Returns the absolute value of a quarter-precision floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Max(Quarter value1, Quarter value2) -> Quarter` **static** _Returns the larger of two quarter-precision floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Min(Quarter value1, Quarter value2) -> Quarter` **static** _Returns the smaller of two quarter-precision floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNaN(Quarter quarter) -> bool` **static** _Returns a value indicating whether the specified number evaluates to not a number (System.Quarter.NaN)._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsInfinity(Quarter quarter) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative or positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNegativeInfinity(Quarter quarter) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsPositiveInfinity(Quarter quarter) -> boo` **static** _Returns a value indicating whether the specified number evaluates to positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value) -> Quarter` **static** _Converts the string representation of a number to its `System.Quarter` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, IFormatProvider provider) -> Quarter` **static** _Converts the string representation of a number to its `System.Quarter` equivalent using the specified culture-specific format information._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style) -> Quarter` **static** _Converts the string representation of a number in a specified style to its `System.Quarter` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style, IFormatProvider provider) -> Quarter` **static** _Converts the string representation of a number to its `System.Quarter` equivalent using the specified style and culture-specific format._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, out Quarter result) -> bool` **static** _Converts the string representation of a number to its `System.Quarter` equivalent. A return value indicates whether the conversion succeeded or failed._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, NumberStyles style, IFormatProvider provider, out Quarter result) -> bool` **static** _Converts the string representation of a number to its `System.Quarter` equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed._

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

* ![struct](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/struct.png) `BFloat16`

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Epsilon -> BFloat16` **static readonly** _Represents the smallest positive `System.BFloat16` value greater than zero._
  
* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MaxValue -> BFloat16` **static readonly** _Represents the largest possible value of `System.BFloat16`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `MinValue -> BFloat16` **static readonly** _Represents the smallest possible value of `System.BFloat16`._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NaN -> BFloat16` **static readonly** _Represents not a number (NaN)._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `NegativeInfinity -> BFloat16` **static readonly** _Represents negative infinity._

* *  ![field](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/fieldreadonly.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `PositiveInfinity -> BFloat16` **static readonly** _Represents positive infinity._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(float value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified single-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(int value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified 32-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(long value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified 64-bit signed integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(double value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified double-precision floating-point number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(decimal value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified decimal number._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(uint value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified 32-bit unsigned integer._

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BFloat16(ulong value) -> new BFloat16` _Initializes a new instance of `System.BFloat16` to the value of the specified 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Negate(BFloat16 bfloat16) -> BFloat16` **static** _Returns the result of multiplying the specified `System.BFloat16` value by negative one._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Add(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` **static** _Adds two specified `System.BFloat16` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Substract(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` **static** _Subtracts one specified `System.BFloat16` value from another._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Multiply(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` **static** _Multiplies two specified `System.BFloat16` values._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Divide(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` **static** _Divides two specified `System.BFloat16` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(BFloat16 bfloat16) -> BFloat16` _Returns the value of the `System.BFloat16` operand (the sign of the operand is unchanged)._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(BFloat16 bfloat16) -> BFloat16` _Negates the value of the specified `System.BFloat16` operand._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `++(BFloat16 bfloat16) -> BFloat16` _Increments the `System.BFloat16` operand by 1._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `--(BFloat16 bfloat16) -> BFloat16` _Decrements the `System.BFloat16` operand by one._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `+(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` _Adds two specified `System.BFloat16` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `-(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` _Subtracts two specified `System.BFloat16` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `*(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` _Multiplies two specified `System.BFloat16` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `/(BFloat16 bfloat161, BFloat16 bfloat162) -> BFloat16` _Divides two specified `System.BFloat16` values._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `==(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether two instances of `System.BFloat16` are equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `!=(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether two instances of `System.BFloat16` are not equal._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether a specified `System.BFloat16` is less than another specified `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether a specified `System.BFloat16` is greater than another specified `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `<=(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether a specified `System.BFloat16` is less than or equal to another specified `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `>=(BFloat16 bfloat161, BFloat16 bfloat162) -> bool` _Returns a value indicating whether a specified `System.BFloat16` is greater than or equal to another specified `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(byte value) -> BFloat16` _Converts an 8-bit unsigned integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(short value) -> BFloat16` _Converts a 16-bit signed integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(char value) -> BFloat16` _Converts a Unicode character to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(int value) -> BFloat16` _Converts a 32-bit signed integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(long value) -> BFloat16` _Converts a 64-bit signed integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Quarter value) -> BFloat16` _Converts a quarter-precision floating-point number to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(Half value) -> BFloat16` _Converts a half-precision floating-point number to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(float value) -> BFloat16` _Converts a single-precision floating-point number to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(double value) -> BFloat16` _Converts a double-precision floating-point number to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(decimal value) -> BFloat16` _Converts a decimal number to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> byte` _Converts a `System.BFloat16` to an 8-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> char` _Converts a `System.BFloat16` to a Unicode character._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> short` _Converts a `System.BFloat16` to a 16-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> int` _Converts a `System.BFloat16` to a 32-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> long` _Converts a `System.BFloat16` to a 64-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(BFloat16 value) -> float` _Converts a `System.BFloat16` to a single-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(BFloat16 value) -> double` _Converts a `System.BFloat16` to a double-precision floating-point number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> decimal` _Converts a `System.BFloat16` to a decimal number._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(sbyte value) -> BFloat16` _Converts an 8-bit signed integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ushort value) -> BFloat16` _Converts a 16-bit unsigned integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(uint value) -> BFloat16` _Converts a 32-bit unsigned integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `implicit(ulong value) -> BFloat16` _Converts a 64-bit unsigned integer to a `System.BFloat16`._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> sbyte` _Converts a `System.BFloat16` to an 8-bit signed integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> ushort` _Converts a `System.BFloat16` to a 16-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> uint` _Converts a `System.BFloat16` to a 32-bit unsigned integer._

* *  ![operator](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/operator.png) `explicit(BFloat16 value) -> ulong` _Converts a `System.BFloat16` to a 64-bit unsigned integer._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(BFloat16 other) -> int` _Compares this instance to a specified `System.BFloat16` object._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `CompareTo(object obj) -> int` _Compares this instance to a specified `System.Object`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(BFloat16 other) -> bool` _Returns a value indicating whether this instance and a specified `System.BFloat16` object represent the same value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `Equals(object obj) -> bool` **override** _Returns a value indicating whether this instance and a specified `System.Object` represent the same type and value._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetHashCode() -> int` **override** _Returns the hash code for this instance._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetTypeCode() -> TypeCode` _Returns the `System.TypeCode` for value type `System.BFloat16`._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBytes(BFloat16 value) -> byte[]` **static** _Returns the specified 16-bit google brain floating point value as an array of bytes._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `GetBits(BFloat16 value) -> byte` **static** _Converts the value of a specified instance of System.BFloat16 to its equivalent binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToBFloat16(byte[] value, int startIndex) -> BFloat16` **static** _Returns a 16-bit google brain floating point number converted from one byte at a specified position in a byte array._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `ToBFloat16(byte bits) -> BFloat16` **static** _Returns a 16-bit google brain floating point number converted from its binary representation._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Sign(BFloat16 value) -> int` **static** _Returns a value indicating the sign of a 16-bit google brain floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Abs(BFloat16 value) -> BFloat16` **static** _Returns the absolute value of a 16-bit google brain floating-point number._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Max(BFloat16 value1, BFloat16 value2) -> BFloat16` **static** _Returns the larger of two 16-bit google brain floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Min(BFloat16 value1, BFloat16 value2) -> BFloat16` **static** _Returns the smaller of two 16-bit google brain floating-point numbers._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNaN(BFloat16 bfloat16) -> bool` **static** _Returns a value indicating whether the specified number evaluates to not a number (System.BFloat16.NaN)._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsInfinity(BFloat16 bfloat16) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative or positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsNegativeInfinity(BFloat16 bfloat16) -> bool` **static** _Returns a value indicating whether the specified number evaluates to negative infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `IsPositiveInfinity(BFloat16 bfloat16) -> boo` **static** _Returns a value indicating whether the specified number evaluates to positive infinity._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value) -> BFloat16` **static** _Converts the string representation of a number to its `System.BFloat16` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, IFormatProvider provider) -> BFloat16` **static** _Converts the string representation of a number to its `System.BFloat16` equivalent using the specified culture-specific format information._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style) -> BFloat16` **static** _Converts the string representation of a number in a specified style to its `System.BFloat16` equivalent._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `Parse(string value, NumberStyles style, IFormatProvider provider) -> BFloat16` **static** _Converts the string representation of a number to its `System.BFloat16` equivalent using the specified style and culture-specific format._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, out BFloat16 result) -> bool` **static** _Converts the string representation of a number to its `System.BFloat16` equivalent. A return value indicates whether the conversion succeeded or failed._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `TryParse(string value, NumberStyles style, IFormatProvider provider, out BFloat16 result) -> bool` **static** _Converts the string representation of a number to its `System.BFloat16` equivalent using the specified style and culture-specific format. A return value indicates whether the conversion succeeded or failed._

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

## Technical details

**Quarter(float8)** is a 8-bit IEEE 754 floating point type. See https://en.wikipedia.org/wiki/Minifloat
![float8](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/float8.png)

**Half(float16)** is a 16-bit IEEE 754 floating point type. See https://en.wikipedia.org/wiki/Half-precision_floating-point_format
![float16](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/float16.png)

**BFloat16** is a 16-bit Google Brain's floating point type for AI. Is a truncated version of Single(float32) type. See https://en.wikipedia.org/wiki/Bfloat16_floating-point_format
![bfloat16](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/bfloat16.png)

## Third-party codes as part of System.FloatingPoint

`System.Half` data type is a fully third-party code. Original source: https://sourceforge.net/projects/csharp-half/

In accordance with the license of the original `System.Half` code, the source code was refactored and included in the System.AI stack as an integral part.

# API Reference

* *struct* System.Half - represents 16-bit floating point number.
* *static readonly field* Half.Epsilon -> Half - Represents the smallest positive System.Half value greater than zero.
* *static readonly field* Half.MaxValue -> Half - Represents the largest possible value of System.Half.
* *static readonly field* Half.MinValue -> Half - Represents the smallest possible value of System.Half.
* *static readonly field* Half.NaN -> Half - Represents not a number (NaN).
* *static readonly field* Half.NegativeInfinity -> Half - Represents negative infinity.
* *static readonly field* Half.PositiveInfinity -> Half - Represents positive infinity.
* *constructor* Half(float value) -> new Half - Initializes a new instance of System.Half to the value of the specified single-precision floating-point number.
* *constructor* Half(int value) -> new Half - Initializes a new instance of System.Half to the value of the specified 32-bit signed integer.
* *constructor* Half(long value) -> new Half - Initializes a new instance of System.Half to the value of the specified 64-bit signed integer.
* *constructor* Half(double value) -> new Half - Initializes a new instance of System.Half to the value of the specified double-precision floating-point number.
* *constructor* Half(decimal value) -> new Half - Initializes a new instance of System.Half to the value of the specified decimal number.
* *constructor* Half(uint value) -> new Half - Initializes a new instance of System.Half to the value of the specified 32-bit unsigned integer.
* *constructor* Half(ulong value) -> new Half - Initializes a new instance of System.Half to the value of the specified 64-bit unsigned integer.
* *static method* Half.Negate(Half half) -> Half - Returns the result of multiplying the specified System.Half value by negative one.
* *static method* Half.Add(Half half1, Half half2) -> Half - Adds two specified System.Half values.
* *static method* Half.Substract(Half half1, Half half2) -> Half - Subtracts one specified System.Half value from another.
* *static method* Half.Multiply(Half half1, Half half2) -> Half - Multiplies two specified System.Half values.
* *static method* Half.Divide(Half half1, Half half2) -> Half - Divides two specified System.Half values.
* *operator* +(Half half) -> Half - Returns the value of the System.Half operand (the sign of the operand is unchanged).
* *operator* -(Half half) -> Half - Negates the value of the specified System.Half operand.
* *operator* ++(Half half) -> Half - Increments the System.Half operand by 1.
* *operator* --(Half half) -> Half - Decrements the System.Half operand by one.
* *operator* +(Half half1, Half half2) -> Half - Adds two specified System.Half values.
* *operator* -(Half half1, Half half2) -> Half - Subtracts two specified System.Half values.
* *operator* \*(Half half1, Half half2) -> Half - Multiplies two specified System.Half values.
* *operator* /(Half half1, Half half2) -> Half - Divides two specified System.Half values.
* *operator* ==(Half half1, Half half2) -> bool - Returns a value indicating whether two instances of System.Half are equal.
* *operator* !=(Half half1, Half half2) -> bool - Returns a value indicating whether two instances of System.Half are not equal.
* *operator* <(Half half1, Half half2) -> bool - Returns a value indicating whether a specified System.Half is less than another specified System.Half.
* *operator* >(Half half1, Half half2) -> bool - Returns a value indicating whether a specified System.Half is greater than another specified System.Half.
* *operator* <=(Half half1, Half half2) -> bool - Returns a value indicating whether a specified System.Half is less than or equal to another specified System.Half.
* *operator* >=(Half half1, Half half2) -> bool - Returns a value indicating whether a specified System.Half is greater than or equal to another specified System.Half.
* *operator* implicit(byte value) -> Half - Converts an 8-bit unsigned integer to a System.Half.
* *operator* implicit(short value) -> Half - Converts a 16-bit signed integer to a System.Half.
* *operator* implicit(char value) -> Half - Converts a Unicode character to a System.Half.

//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2021. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System
{

    /// <summary>
    /// Represents a quarter-precision floating point number. 
    /// </summary>
    /// <remarks>
    /// Note:
    ///     Quarter is not fast enought and precision is also very bad, 
    ///     so is should not be used for matemathical computation (use Single instead).
    ///     The main advantage of Quarter type is lower memory cost: one byte per number. 
    ///     Quarter is typically used in graphical and AI applications.
    ///
    /// References:
    ///     - https://en.wikipedia.org/wiki/Minifloat
    ///     - IEEE 754 revision, link: http://grouper.ieee.org/groups/754/
    /// </remarks>
    [Serializable]
    public struct Quarter : IComparable, IFormattable, IConvertible, IComparable<Quarter>, IEquatable<Quarter>
    {

        /// <summary>
        /// Internal representation of the quarter-precision floating-point number.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal byte value;

        #region Constants

        /// <summary>
        /// Represents the smallest positive System.Quarter value greater than zero. This field is constant.
        /// </summary>
        public static readonly Quarter Epsilon = Quarter.ToQuarter(0x0001);

        /// <summary>
        /// Represents the largest possible value of System.Quarter. This field is constant.
        /// </summary>
        public static readonly Quarter MaxValue = Quarter.ToQuarter(0x77);

        /// <summary>
        /// Represents the smallest possible value of System.Quarter. This field is constant.
        /// </summary>
        public static readonly Quarter MinValue = Quarter.ToQuarter(0xf7);

        /// <summary>
        /// Represents not a number (NaN). This field is constant.
        /// </summary>
        public static readonly Quarter NaN = Quarter.ToQuarter(0xfc);

        /// <summary>
        /// Represents negative infinity. This field is constant.
        /// </summary>
        public static readonly Quarter NegativeInfinity = Quarter.ToQuarter(0xf8);

        /// <summary>
        /// Represents positive infinity. This field is constant.
        /// </summary>
        public static readonly Quarter PositiveInfinity = Quarter.ToQuarter(0x78);

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified single-precision floating-point number.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(float value)
        {
            this = QuarterHelper.SingleToQuarter(value);
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified 32-bit signed integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(int value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified 64-bit signed integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(long value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified double-precision floating-point number.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(double value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified decimal number.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(decimal value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified 32-bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(uint value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.Quarter to the value of the specified 64-bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.Quarter.</param>
        public Quarter(ulong value) : this((float)value)
        {
        }

        #endregion
        
        #region Numeric operators

        /// <summary>
        /// Returns the result of multiplying the specified System.Quarter value by negative one.
        /// </summary>
        /// <param name="quarter">A System.Quarter.</param>
        /// <returns>A System.Quarter with the value of quarter, but the opposite sign. -or- Zero, if quarter is zero.</returns>
        public static Quarter Negate(Quarter quarter)
        {
            return -quarter;
        }

        /// <summary>
        /// Adds two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>A System.Quarter value that is the sum of quarter1 and quarter2.</returns>
        public static Quarter Add(Quarter quarter1, Quarter quarter2)
        {
            return quarter1 + quarter2;
        }

        /// <summary>
        /// Subtracts one specified System.Quarter value from another.
        /// </summary>
        /// <param name="quarter1">A System.Quarter (the minuend).</param>
        /// <param name="quarter2">A System.Quarter (the subtrahend).</param>
        /// <returns>The System.Quarter result of subtracting quarter2 from quarter1.</returns>
        public static Quarter Subtract(Quarter quarter1, Quarter quarter2)
        {
            return quarter1 - quarter2;
        }

        /// <summary>
        /// Multiplies two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter (the multiplicand).</param>
        /// <param name="quarter2">A System.Quarter (the multiplier).</param>
        /// <returns>A System.Quarter that is the result of multiplying quarter1 and quarter2.</returns>
        public static Quarter Multiply(Quarter quarter1, Quarter quarter2)
        {
            return quarter1 * quarter2;
        }

        /// <summary>
        /// Divides two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter (the dividend).</param>
        /// <param name="quarter2">A System.Quarter (the divisor).</param>
        /// <returns>The System.Quarter that is the result of dividing quarter1 by quarter2.</returns>
        /// <exception cref="System.DivideByZeroException">quarter2 is zero.</exception>
        public static Quarter Divide(Quarter quarter1, Quarter quarter2)
        {
            return quarter1 / quarter2;
        }

        /// <summary>
        /// Returns the value of the System.Quarter operand (the sign of the operand is unchanged).
        /// </summary>
        /// <param name="quarter">The System.Quarter operand.</param>
        /// <returns>The value of the operand, quarter.</returns>
        public static Quarter operator +(Quarter quarter)
        {
            return quarter;
        }

        /// <summary>
        /// Negates the value of the specified System.Quarter operand.
        /// </summary>
        /// <param name="quarter">The System.Quarter operand.</param>
        /// <returns>The result of quarter multiplied by negative one (-1).</returns>
        public static Quarter operator -(Quarter quarter)
        {
            return QuarterHelper.Negate(quarter);
        }

        /// <summary>
        /// Increments the System.Quarter operand by 1.
        /// </summary>
        /// <param name="quarter">The System.Quarter operand.</param>
        /// <returns>The value of quarter incremented by 1.</returns>
        public static Quarter operator ++(Quarter quarter)
        {
            return (Quarter)(quarter + 1f);
        }

        /// <summary>
        /// Decrements the System.Quarter operand by one.
        /// </summary>
        /// <param name="quarter">The System.Quarter operand.</param>
        /// <returns>The value of quarter decremented by 1.</returns>
        public static Quarter operator --(Quarter quarter)
        {
            return (Quarter)(quarter - 1f);
        }

        /// <summary>
        /// Adds two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>The System.Quarter result of adding quarter1 and quarter2.</returns>
        public static Quarter operator +(Quarter quarter1, Quarter quarter2)
        {
            return (Quarter)((float)quarter1 + (float)quarter2);
        }

        /// <summary>
        /// Subtracts two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>The System.Quarter result of subtracting quarter1 and quarter2.</returns>        
        public static Quarter operator -(Quarter quarter1, Quarter quarter2)
        {
            return (Quarter)((float)quarter1 - (float)quarter2);
        }

        /// <summary>
        /// Multiplies two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>The System.Quarter result of multiplying quarter1 by quarter2.</returns>
        public static Quarter operator *(Quarter quarter1, Quarter quarter2)
        {
            return (Quarter)((float)quarter1 * (float)quarter2);
        }

        /// <summary>
        /// Divides two specified System.Quarter values.
        /// </summary>
        /// <param name="quarter1">A System.Quarter (the dividend).</param>
        /// <param name="quarter2">A System.Quarter (the divisor).</param>
        /// <returns>The System.Quarter result of quarter1 by quarter2.</returns>
        public static Quarter operator /(Quarter quarter1, Quarter quarter2)
        {
            return (Quarter)((float)quarter1 / (float)quarter2);
        }

        /// <summary>
        /// Returns a value indicating whether two instances of System.Quarter are equal.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 and quarter2 are equal; otherwise, false.</returns>
        public static bool operator ==(Quarter quarter1, Quarter quarter2)
        {
            return (!IsNaN(quarter1) && (quarter1.value == quarter2.value));
        }

        /// <summary>
        /// Returns a value indicating whether two instances of System.Quarter are not equal.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 and quarter2 are not equal; otherwise, false.</returns>
        public static bool operator !=(Quarter quarter1, Quarter quarter2)
        {
            return !(quarter1.value == quarter2.value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.Quarter is less than another specified System.Quarter.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 is less than quarter1; otherwise, false.</returns>
        public static bool operator <(Quarter quarter1, Quarter quarter2)
        {
            return (float)quarter1 < (float)quarter2;
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.Quarter is greater than another specified System.Quarter.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 is greater than quarter2; otherwise, false.</returns>
        public static bool operator >(Quarter quarter1, Quarter quarter2)
        {
            return (float)quarter1 > (float)quarter2;
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.Quarter is less than or equal to another specified System.Quarter.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 is less than or equal to quarter2; otherwise, false.</returns>
        public static bool operator <=(Quarter quarter1, Quarter quarter2)
        {
            return (quarter1 == quarter2) || (quarter1 < quarter2);
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.Quarter is greater than or equal to another specified System.Quarter.
        /// </summary>
        /// <param name="quarter1">A System.Quarter.</param>
        /// <param name="quarter2">A System.Quarter.</param>
        /// <returns>true if quarter1 is greater than or equal to quarter2; otherwise, false.</returns>
        public static bool operator >=(Quarter quarter1, Quarter quarter2)
        {
            return (quarter1 == quarter2) || (quarter1 > quarter2);
        }

        #endregion

        #region Type casting operators

        /// <summary>
        /// Converts an 8-bit unsigned integer to a System.Quarter.
        /// </summary>
        /// <param name="value">An 8-bit unsigned integer.</param>
        /// <returns>A System.Quarter that represents the converted 8-bit unsigned integer.</returns>
        public static implicit operator Quarter(byte value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 16-bit signed integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 16-bit signed integer.</param>
        /// <returns>A System.Quarter that represents the converted 16-bit signed integer.</returns>
        public static implicit operator Quarter(short value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a Unicode character to a System.Quarter.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns>A System.Quarter that represents the converted Unicode character.</returns>
        public static implicit operator Quarter(char value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 32-bit signed integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 32-bit signed integer.</param>
        /// <returns>A System.Quarter that represents the converted 32-bit signed integer.</returns>
        public static implicit operator Quarter(int value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 64-bit signed integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 64-bit signed integer.</param>
        /// <returns>A System.Quarter that represents the converted 64-bit signed integer.</returns>
        public static implicit operator Quarter(long value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a half-precision floating-point number to a System.Quarter.
        /// </summary>
        /// <param name="value">A half-precision floating-point number.</param>
        /// <returns>A System.Quarter that represents the converted half-precision floating point number.</returns>
        public static explicit operator Quarter(Half value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a google brain 16-bit floating-point number to a System.Quarter.
        /// </summary>
        /// <param name="value">A google brain 16-bit floating-point number.</param>
        /// <returns>A System.Quarter that represents the converted google brain 16-bit floating point number.</returns>
        public static explicit operator Quarter(BFloat16 value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a single-precision floating-point number to a System.Quarter.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns>A System.Quarter that represents the converted single-precision floating point number.</returns>
        public static explicit operator Quarter(float value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a double-precision floating-point number to a System.Quarter.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns>A System.Quarter that represents the converted double-precision floating point number.</returns>
        public static explicit operator Quarter(double value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a decimal number to a System.Quarter.
        /// </summary>
        /// <param name="value">decimal number</param>
        /// <returns>A System.Quarter that represents the converted decimal number.</returns>
        public static explicit operator Quarter(decimal value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a System.Quarter to an 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>An 8-bit unsigned integer that represents the converted System.Quarter.</returns>
        public static explicit operator byte(Quarter value)
        {
            return (byte)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a Unicode character.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A Unicode character that represents the converted System.Quarter.</returns>
        public static explicit operator char(Quarter value)
        {
            return (char)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 16-bit signed integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 16-bit signed integer that represents the converted System.Quarter.</returns>
        public static explicit operator short(Quarter value)
        {
            return (short)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 32-bit signed integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 32-bit signed integer that represents the converted System.Quarter.</returns>
        public static explicit operator int(Quarter value)
        {
            return (int)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 64-bit signed integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 64-bit signed integer that represents the converted System.Quarter.</returns>
        public static explicit operator long(Quarter value)
        {
            return (long)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a single-precision floating-point number.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A single-precision floating-point number that represents the converted System.Quarter.</returns>
        public static implicit operator float(Quarter value)
        {
            return (float)QuarterHelper.QuarterToSingle(value);
        }

        /// <summary>
        /// Converts a System.Quarter to a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A double-precision floating-point number that represents the converted System.Quarter.</returns>
        public static implicit operator double(Quarter value)
        {
            return (double)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a decimal number.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A decimal number that represents the converted System.Quarter.</returns>
        public static explicit operator decimal(Quarter value)
        {
            return (decimal)(float)value;
        }

        /// <summary>
        /// Converts an 8-bit signed integer to a System.Quarter.
        /// </summary>
        /// <param name="value">An 8-bit signed integer.</param>
        /// <returns>A System.Quarter that represents the converted 8-bit signed integer.</returns>
        public static implicit operator Quarter(sbyte value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 16-bit unsigned integer.</param>
        /// <returns>A System.Quarter that represents the converted 16-bit unsigned integer.</returns>
        public static implicit operator Quarter(ushort value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 32-bit unsigned integer.</param>
        /// <returns>A System.Quarter that represents the converted 32-bit unsigned integer.</returns>
        public static implicit operator Quarter(uint value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a 64-bit unsigned integer to a System.Quarter.
        /// </summary>
        /// <param name="value">A 64-bit unsigned integer.</param>
        /// <returns>A System.Quarter that represents the converted 64-bit unsigned integer.</returns>
        public static implicit operator Quarter(ulong value)
        {
            return new Quarter((float)value);
        }

        /// <summary>
        /// Converts a System.Quarter to an 8-bit signed integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>An 8-bit signed integer that represents the converted System.Quarter.</returns>
        public static explicit operator sbyte(Quarter value)
        {
            return (sbyte)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 16-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 16-bit unsigned integer that represents the converted System.Quarter.</returns>
        public static explicit operator ushort(Quarter value)
        {
            return (ushort)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 32-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 32-bit unsigned integer that represents the converted System.Quarter.</returns>
        public static explicit operator uint(Quarter value)
        {
            return (uint)(float)value;
        }

        /// <summary>
        /// Converts a System.Quarter to a 64-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.Quarter to convert.</param>
        /// <returns>A 64-bit unsigned integer that represents the converted System.Quarter.</returns>
        public static explicit operator ulong(Quarter value)
        {
            return (ulong)(float)value;
        }

        #endregion

        /// <summary>
        /// Compares this instance to a specified System.Quarter object.
        /// </summary>
        /// <param name="other">A System.Quarter object.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value.
        /// Return Value Meaning Less than zero This instance is less than value. Zero
        /// This instance is equal to value. Greater than zero This instance is greater than value.
        /// </returns>
        public int CompareTo(Quarter other)
        {            
            int result = 0;
            if(this < other)
            {
                result = -1;
            }
            else
            {
                if(this > other)
                {
                    result = 1;
                }
                else
                {
                    if(this != other)
                    {
                        if(!IsNaN(this))
                        {
                            result = 1;
                        }
                        else
                        {
                            if(!IsNaN(other))
                            {
                                result = -1;
                            }
                        }
                    }
                }
            }
            return result;
        }

        /// <summary>
        /// Compares this instance to a specified System.Object.
        /// </summary>
        /// <param name="obj">An System.Object or null.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value.
        /// Return Value Meaning Less than zero This instance is less than value. Zero
        /// This instance is equal to value. Greater than zero This instance is greater
        /// than value. -or- value is null.
        /// </returns>
        /// <exception cref="System.ArgumentException">value is not a System.Quarter</exception>
        public int CompareTo(object obj)
        {
            int result = 0;
            if(obj == null)
            {
                result = 1;
            }
            else
            {
                if(obj is Quarter)
                {
                    result = CompareTo((Quarter)obj);
                }
                else
                {
                    throw new ArgumentException("Object must be of type Quarter.");
                }
            }
            return result;
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified System.Quarter object represent the same value.
        /// </summary>
        /// <param name="other">A System.Quarter object to compare to this instance.</param>
        /// <returns>true if value is equal to this instance; otherwise, false.</returns>
        public bool Equals(Quarter other)
        {
            return ((other == this) || (IsNaN(other) && IsNaN(this)));
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified System.Object
        /// represent the same type and value.
        /// </summary>
        /// <param name="obj">An System.Object.</param>
        /// <returns>true if value is a System.Quarter and equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            bool result = false;
            if(obj is Quarter)
            {
                Quarter quarter = (Quarter)obj;
                if((quarter == this) || (IsNaN(quarter) && IsNaN(this)))
                {
                    result = true;
                }
            }
            return result;
        }

        /// <summary>
        /// Returns the hash code for this instance.
        /// </summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }

        /// <summary>
        /// Returns the System.TypeCode for value type System.Quarter.
        /// </summary>
        /// <returns>The enumerated constant (TypeCode)255.</returns>
        public TypeCode GetTypeCode()
        { 
            return (TypeCode)255;
        }

        #region BitConverter & Math methods for Quarter

        /// <summary>
        /// Returns the specified quarter-precision floating point value as an array of bytes.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>An array of bytes with length 1.</returns>
        public static byte[] GetBytes(Quarter value)
        {
            return BitConverter.GetBytes(value.value);
        }

        /// <summary>
        /// Converts the value of a specified instance of System.Quarter to its equivalent binary representation.
        /// </summary>
        /// <param name="value">A System.Quarter value.</param>
        /// <returns>A 8-bit unsigned integer that contain the binary representation of value.</returns>        
        public static byte GetBits(Quarter value)
        {
            return value.value;
        }

        /// <summary>
        /// Returns a quarter-precision floating point number converted from one byte
        /// at a specified position in a byte array.
        /// </summary>
        /// <param name="value">An array of bytes.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A quarter-precision floating point number formed by one byte beginning at startIndex.</returns>
        /// <exception cref="System.ArgumentException">
        /// startIndex is greater than or equal to the length of value minus 1, and is
        /// less than or equal to the length of value minus 1.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">startIndex is less than zero or greater than the length of value minus 1.</exception>
        public static Quarter ToQuarter(byte[] value, int startIndex)
        {
            return Quarter.ToQuarter(value[startIndex]);
        }

        /// <summary>
        /// Returns a quarter-precision floating point number converted from its binary representation.
        /// </summary>
        /// <param name="bits">Binary representation of System.Quarter value</param>
        /// <returns>A quarter-precision floating point number formed by its binary representation.</returns>
        public static Quarter ToQuarter(byte bits)
        {
            return new Quarter
            {
                value = bits
            };
        }

        /// <summary>
        /// Returns a value indicating the sign of a quarter-precision floating-point number.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number indicating the sign of value. Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.
        /// </returns>
        /// <exception cref="System.ArithmeticException">value is equal to System.Quarter.NaN.</exception>
        public static int Sign(Quarter value)
        {
            if(value < 0)
            {
                return -1;
            }
            if(value > 0)
            {
                return 1;
            }
            if(value != 0)
            {
                throw new ArithmeticException("Function does not accept floating point Not-a-Number values.");
            }
            return 0;
        }

        /// <summary>
        /// Returns the absolute value of a quarter-precision floating-point number.
        /// </summary>
        /// <param name="value">A number in the range System.Quarter.MinValue ≤ value ≤ System.Quarter.MaxValue.</param>
        /// <returns>A quarter-precision floating-point number, x, such that 0 ≤ x ≤System.Quarter.MaxValue.</returns>
        public static Quarter Abs(Quarter value)
        {
            return QuarterHelper.Abs(value);
        }

        /// <summary>
        /// Returns the larger of two quarter-precision floating-point numbers.
        /// </summary>
        /// <param name="value1">The first of two quarter-precision floating-point numbers to compare.</param>
        /// <param name="value2">The second of two quarter-precision floating-point numbers to compare.</param>
        /// <returns>
        /// Parameter value1 or value2, whichever is larger. If value1, or value2, or both val1
        /// and value2 are equal to System.Quarter.NaN, System.Quarter.NaN is returned.
        /// </returns>
        public static Quarter Max(Quarter value1, Quarter value2)
        {
            return (value1 < value2) ? value2 : value1;
        }

        /// <summary>
        /// Returns the smaller of two quarter-precision floating-point numbers.
        /// </summary>
        /// <param name="value1">The first of two quarter-precision floating-point numbers to compare.</param>
        /// <param name="value2">The second of two quarter-precision floating-point numbers to compare.</param>
        /// <returns>
        /// Parameter value1 or value2, whichever is smaller. If value1, or value2, or both val1
        /// and value2 are equal to System.Quarter.NaN, System.Quarter.NaN is returned.
        /// </returns>
        public static Quarter Min(Quarter value1, Quarter value2)
        {
            return (value1 < value2) ? value1 : value2;
        }

        #endregion

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to not a number (System.Quarter.NaN).
        /// </summary>
        /// <param name="quarter">A quarter-precision floating-point number.</param>
        /// <returns>true if value evaluates to not a number (System.Quarter.NaN); otherwise, false.</returns>
        public static bool IsNaN(Quarter quarter)
        {
            return QuarterHelper.IsNaN(quarter);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="quarter">A quarter-precision floating-point number.</param>
        /// <returns>true if quarter evaluates to System.Quarter.PositiveInfinity or System.Quarter.NegativeInfinity; otherwise, false.</returns>
        public static bool IsInfinity(Quarter quarter)
        {
            return QuarterHelper.IsInfinity(quarter);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="quarter">A quarter-precision floating-point number.</param>
        /// <returns>true if quarter evaluates to System.Quarter.NegativeInfinity; otherwise, false.</returns>
        public static bool IsNegativeInfinity(Quarter quarter)
        {
            return QuarterHelper.IsNegativeInfinity(quarter);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="quarter">A quarter-precision floating-point number.</param>
        /// <returns>true if quarter evaluates to System.Quarter.PositiveInfinity; otherwise, false.</returns>
        public static bool IsPositiveInfinity(Quarter quarter)
        {
            return QuarterHelper.IsPositiveInfinity(quarter);
        }

        #region String operations (Parse and ToString)

        /// <summary>
        /// Converts the string representation of a number to its System.Quarter equivalent.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <returns>The System.Quarter number equivalent to the number contained in value.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.Quarter.MinValue or greater than System.Quarter.MaxValue.</exception>
        public static Quarter Parse(string value)
        {
            return (Quarter)float.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Quarter equivalent 
        /// using the specified culture-specific format information.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="provider">An System.IFormatProvider that supplies culture-specific parsing information about value.</param>
        /// <returns>The System.Quarter number equivalent to the number contained in s as specified by provider.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.Quarter.MinValue or greater than System.Quarter.MaxValue.</exception>
        public static Quarter Parse(string value, IFormatProvider provider)
        {
            return (Quarter)float.Parse(value, provider);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified style to its System.Quarter equivalent.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="style">
        /// A bitwise combination of System.Globalization.NumberStyles values that indicates
        /// the style elements that can be present in value. A typical value to specify is
        /// System.Globalization.NumberStyles.Number.
        /// </param>
        /// <returns>The System.Quarter number equivalent to the number contained in s as specified by style.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style is the
        /// System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.Quarter.MinValue or greater than System.Quarter.MaxValue.</exception>
        public static Quarter Parse(string value, NumberStyles style)
        {
            return (Quarter)float.Parse(value, style, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Quarter equivalent 
        /// using the specified style and culture-specific format.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="style">
        /// A bitwise combination of System.Globalization.NumberStyles values that indicates
        /// the style elements that can be present in value. A typical value to specify is 
        /// System.Globalization.NumberStyles.Number.
        /// </param>
        /// <param name="provider">An System.IFormatProvider object that supplies culture-specific information about the format of value.</param>
        /// <returns>The System.Quarter number equivalent to the number contained in s as specified by style and provider.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style is the
        /// System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.Quarter.MinValue or greater than System.Quarter.MaxValue.</exception>
        public static Quarter Parse(string value, NumberStyles style, IFormatProvider provider)
        {
            return (Quarter)float.Parse(value, style, provider);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Quarter equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="result">
        /// When this method returns, contains the System.Quarter number that is equivalent
        /// to the numeric value contained in value, if the conversion succeeded, or is zero
        /// if the conversion failed. The conversion fails if the s parameter is null,
        /// is not a number in a valid format, or represents a number less than System.Quarter.MinValue
        /// or greater than System.Quarter.MaxValue. This parameter is passed uninitialized.
        /// </param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParse(string value, out Quarter result)
        {
            float f;
            if(float.TryParse(value, out f))
            {
                result = (Quarter)f;
                return true;
            }
            result = new Quarter();
            return false;
        }

        /// <summary>
        /// Converts the string representation of a number to its System.Quarter equivalent
        /// using the specified style and culture-specific format. A return value indicates
        /// whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="style">
        /// A bitwise combination of System.Globalization.NumberStyles values that indicates
        /// the permitted format of value. A typical value to specify is System.Globalization.NumberStyles.Number.
        /// </param>
        /// <param name="provider">An System.IFormatProvider object that supplies culture-specific parsing information about value.</param>
        /// <param name="result">
        /// When this method returns, contains the System.Quarter number that is equivalent
        /// to the numeric value contained in value, if the conversion succeeded, or is zero
        /// if the conversion failed. The conversion fails if the s parameter is null,
        /// is not in a format compliant with style, or represents a number less than
        /// System.Quarter.MinValue or greater than System.Quarter.MaxValue. This parameter is passed uninitialized.
        /// </param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style 
        /// is the System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out Quarter result)
        {
            bool parseResult = false;
            float f;
            if(float.TryParse(value, style, provider, out f))
            {
                result = (Quarter)f;
                parseResult = true;
            }
            else
            {
                result = new Quarter();
            }
            return parseResult;
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation.
        /// </summary>
        /// <returns>A string that represents the value of this instance.</returns>
        public override string ToString()
        {
            return ((float)this).ToString(CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation
        /// using the specified culture-specific format information.
        /// </summary>
        /// <param name="formatProvider">An System.IFormatProvider that supplies culture-specific formatting information.</param>
        /// <returns>The string representation of the value of this instance as specified by provider.</returns>
        public string ToString(IFormatProvider formatProvider)
        {
            return ((float)this).ToString(formatProvider);
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation, using the specified format.
        /// </summary>
        /// <param name="format">A numeric format string.</param>
        /// <returns>The string representation of the value of this instance as specified by format.</returns>
        public string ToString(string format)
        {
            return ((float)this).ToString(format, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the numeric value of this instance to its equivalent string representation 
        /// using the specified format and culture-specific format information.
        /// </summary>
        /// <param name="format">A numeric format string.</param>
        /// <param name="formatProvider">An System.IFormatProvider that supplies culture-specific formatting information.</param>
        /// <returns>The string representation of the value of this instance as specified by format and provider.</returns>
        /// <exception cref="System.FormatException">format is invalid.</exception>
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return ((float)this).ToString(format, formatProvider);
        }

        #endregion

        #region IConvertible Members

        float IConvertible.ToSingle(IFormatProvider provider)
        {
            return (float)this;
        }

        TypeCode IConvertible.GetTypeCode()
        {
            return GetTypeCode();
        }

        bool IConvertible.ToBoolean(IFormatProvider provider)
        {
            return Convert.ToBoolean((float)this);
        }

        byte IConvertible.ToByte(IFormatProvider provider)
        {
            return Convert.ToByte((float)this);
        }

        char IConvertible.ToChar(IFormatProvider provider)
        {
            throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, "Invalid cast from '{0}' to '{1}'.", "Quarter", "Char"));
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, "Invalid cast from '{0}' to '{1}'.", "Quarter", "DateTime"));
        }

        decimal IConvertible.ToDecimal(IFormatProvider provider)
        {
            return Convert.ToDecimal((float)this);
        }

        double IConvertible.ToDouble(IFormatProvider provider)
        {
            return Convert.ToDouble((float)this);
        }

        short IConvertible.ToInt16(IFormatProvider provider)
        {
            return Convert.ToInt16((float)this);
        }

        int IConvertible.ToInt32(IFormatProvider provider)
        {
            return Convert.ToInt32((float)this);
        }

        long IConvertible.ToInt64(IFormatProvider provider)
        {
            return Convert.ToInt64((float)this);
        }

        sbyte IConvertible.ToSByte(IFormatProvider provider)
        {
            return Convert.ToSByte((float)this);
        }

        string IConvertible.ToString(IFormatProvider provider)
        {
            return Convert.ToString((float)this, CultureInfo.InvariantCulture);
        }

        object IConvertible.ToType(Type conversionType, IFormatProvider provider)
        {
            return (((float)this) as IConvertible).ToType(conversionType, provider);
        }

        ushort IConvertible.ToUInt16(IFormatProvider provider)
        {
            return Convert.ToUInt16((float)this);
        }

        uint IConvertible.ToUInt32(IFormatProvider provider)
        {
            return Convert.ToUInt32((float)this);
        }

        ulong IConvertible.ToUInt64(IFormatProvider provider)
        {
            return Convert.ToUInt64((float)this);
        }

        #endregion

    }

}
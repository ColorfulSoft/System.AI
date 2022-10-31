using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace System
{

    /// <summary>
    /// Represents a brain floating point number. 
    /// </summary>
    /// <remarks>
    /// Note:
    ///     BFloat16 is not fast enought and precision is also very bad, 
    ///     so is should not be used for matemathical computation (use Single instead).
    ///     The main advantage of BFloat16 type is lower memory cost: two bytes per number. 
    ///     BFloat16 is typically used in AI applications.
    ///
    /// References:
    ///     - https://en.wikipedia.org/wiki/Bfloat16_floating-point_format
    /// </remarks>
    [Serializable]
    public struct BFloat16 : IComparable, IFormattable, IConvertible, IComparable<BFloat16>, IEquatable<BFloat16>
    {

        /// <summary>
        /// Internal representation of the bfloat16 number.
        /// </summary>
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        internal ushort value;

        #region Constants

        /// <summary>
        /// Represents the smallest positive System.BFloat16 value greater than zero. This field is constant.
        /// </summary>
        public static readonly BFloat16 Epsilon = BFloat16.ToBFloat16(0x0001);

        /// <summary>
        /// Represents the largest possible value of System.BFloat16. This field is constant.
        /// </summary>
        public static readonly BFloat16 MaxValue = (BFloat16)float.MaxValue;

        /// <summary>
        /// Represents the smallest possible value of System.BFloat16. This field is constant.
        /// </summary>
        public static readonly BFloat16 MinValue = (BFloat16)float.MinValue;

        /// <summary>
        /// Represents not a number (NaN). This field is constant.
        /// </summary>
        public static readonly BFloat16 NaN = (BFloat16)float.NaN;

        /// <summary>
        /// Represents negative infinity. This field is constant.
        /// </summary>
        public static readonly BFloat16 NegativeInfinity = (BFloat16)float.NegativeInfinity;

        /// <summary>
        /// Represents positive infinity. This field is constant.
        /// </summary>
        public static readonly BFloat16 PositiveInfinity = (BFloat16)float.PositiveInfinity;

        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified single-precision floating-point number.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(float value)
        {
            this = BFloat16Helper.SingleToBFloat16(value);
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified 32-bit signed integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(int value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified 64-bit signed integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(long value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified double-precision floating-point number.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(double value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified decimal number.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(decimal value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified 32-bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(uint value) : this((float)value)
        {
        }

        /// <summary>
        /// Initializes a new instance of System.BFloat16 to the value of the specified 64-bit unsigned integer.
        /// </summary>
        /// <param name="value">The value to represent as a System.BFloat16.</param>
        public BFloat16(ulong value) : this((float)value)
        {
        }

        #endregion

        #region Numeric operators

        /// <summary>
        /// Returns the result of multiplying the specified System.BFloat16 value by negative one.
        /// </summary>
        /// <param name="bfloat16">A System.BFloat16.</param>
        /// <returns>A System.BFloat16 with the value of bfloat16, but the opposite sign. -or- Zero, if bfloat16 is zero.</returns>
        public static BFloat16 Negate(BFloat16 bfloat16)
        {
            return -bfloat16;
        }

        /// <summary>
        /// Adds two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>A System.BFloat16 value that is the sum of bfloat161 and bfloat162.</returns>
        public static BFloat16 Add(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return bfloat161 + bfloat162;
        }

        /// <summary>
        /// Subtracts one specified System.BFloat16 value from another.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16 (the minuend).</param>
        /// <param name="bfloat162">A System.BFloat16 (the subtrahend).</param>
        /// <returns>The System.BFloat16 result of subtracting bfloat162 from bfloat161.</returns>
        public static BFloat16 Subtract(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return bfloat161 - bfloat162;
        }

        /// <summary>
        /// Multiplies two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16 (the multiplicand).</param>
        /// <param name="bfloat162">A System.BFloat16 (the multiplier).</param>
        /// <returns>A System.BFloat16 that is the result of multiplying bfloat161 and bfloat162.</returns>
        public static BFloat16 Multiply(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return bfloat161 * bfloat162;
        }

        /// <summary>
        /// Divides two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16 (the dividend).</param>
        /// <param name="bfloat162">A System.BFloat16 (the divisor).</param>
        /// <returns>The System.BFloat16 that is the result of dividing bfloat161 by bfloat162.</returns>
        /// <exception cref="System.DivideByZeroException">bfloat162 is zero.</exception>
        public static BFloat16 Divide(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return bfloat161 / bfloat162;
        }

        /// <summary>
        /// Returns the value of the System.BFloat16 operand (the sign of the operand is unchanged).
        /// </summary>
        /// <param name="bfloat16">The System.BFloat16 operand.</param>
        /// <returns>The value of the operand, bfloat16.</returns>
        public static BFloat16 operator +(BFloat16 bfloat16)
        {
            return bfloat16;
        }

        /// <summary>
        /// Negates the value of the specified System.BFloat16 operand.
        /// </summary>
        /// <param name="bfloat16">The System.BFloat16 operand.</param>
        /// <returns>The result of bfloat16 multiplied by negative one (-1).</returns>
        public static BFloat16 operator -(BFloat16 bfloat16)
        {
            return BFloat16Helper.Negate(bfloat16);
        }

        /// <summary>
        /// Increments the System.BFloat16 operand by 1.
        /// </summary>
        /// <param name="bfloat16">The System.BFloat16 operand.</param>
        /// <returns>The value of bfloat16 incremented by 1.</returns>
        public static BFloat16 operator ++(BFloat16 bfloat16)
        {
            return (BFloat16)(bfloat16 + 1f);
        }

        /// <summary>
        /// Decrements the System.BFloat16 operand by one.
        /// </summary>
        /// <param name="bfloat16">The System.BFloat16 operand.</param>
        /// <returns>The value of bfloat16 decremented by 1.</returns>
        public static BFloat16 operator --(BFloat16 bfloat16)
        {
            return (BFloat16)(bfloat16 - 1f);
        }

        /// <summary>
        /// Adds two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>The System.BFloat16 result of adding bfloat161 and bfloat162.</returns>
        public static BFloat16 operator +(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (BFloat16)((float)bfloat161 + (float)bfloat162);
        }

        /// <summary>
        /// Subtracts two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>The System.BFloat16 result of subtracting bfloat161 and bfloat162.</returns>        
        public static BFloat16 operator -(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (BFloat16)((float)bfloat161 - (float)bfloat162);
        }

        /// <summary>
        /// Multiplies two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>The System.BFloat16 result of multiplying bfloat161 by bfloat162.</returns>
        public static BFloat16 operator *(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (BFloat16)((float)bfloat161 * (float)bfloat162);
        }

        /// <summary>
        /// Divides two specified System.BFloat16 values.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16 (the dividend).</param>
        /// <param name="bfloat162">A System.BFloat16 (the divisor).</param>
        /// <returns>The System.BFloat16 result of bfloat161 by bfloat162.</returns>
        public static BFloat16 operator /(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (BFloat16)((float)bfloat161 / (float)bfloat162);
        }

        /// <summary>
        /// Returns a value indicating whether two instances of System.BFloat16 are equal.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 and bfloat162 are equal; otherwise, false.</returns>
        public static bool operator ==(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (!IsNaN(bfloat161) && (bfloat161.value == bfloat162.value));
        }

        /// <summary>
        /// Returns a value indicating whether two instances of System.BFloat16 are not equal.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 and bfloat162 are not equal; otherwise, false.</returns>
        public static bool operator !=(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return !(bfloat161.value == bfloat162.value);
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.BFloat16 is less than another specified System.BFloat16.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 is less than bfloat161; otherwise, false.</returns>
        public static bool operator <(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (float)bfloat161 < (float)bfloat162;
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.BFloat16 is greater than another specified System.BFloat16.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 is greater than bfloat162; otherwise, false.</returns>
        public static bool operator >(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (float)bfloat161 > (float)bfloat162;
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.BFloat16 is less than or equal to another specified System.BFloat16.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 is less than or equal to bfloat162; otherwise, false.</returns>
        public static bool operator <=(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (bfloat161 == bfloat162) || (bfloat161 < bfloat162);
        }

        /// <summary>
        /// Returns a value indicating whether a specified System.BFloat16 is greater than or equal to another specified System.BFloat16.
        /// </summary>
        /// <param name="bfloat161">A System.BFloat16.</param>
        /// <param name="bfloat162">A System.BFloat16.</param>
        /// <returns>true if bfloat161 is greater than or equal to bfloat162; otherwise, false.</returns>
        public static bool operator >=(BFloat16 bfloat161, BFloat16 bfloat162)
        {
            return (bfloat161 == bfloat162) || (bfloat161 > bfloat162);
        }

        #endregion

        #region Type casting operators

        /// <summary>
        /// Converts an 8-bit unsigned integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">An 8-bit unsigned integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 8-bit unsigned integer.</returns>
        public static implicit operator BFloat16(byte value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 16-bit signed integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 16-bit signed integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 16-bit signed integer.</returns>
        public static implicit operator BFloat16(short value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a Unicode character to a System.BFloat16.
        /// </summary>
        /// <param name="value">A Unicode character.</param>
        /// <returns>A System.BFloat16 that represents the converted Unicode character.</returns>
        public static implicit operator BFloat16(char value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 32-bit signed integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 32-bit signed integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 32-bit signed integer.</returns>
        public static implicit operator BFloat16(int value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 64-bit signed integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 64-bit signed integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 64-bit signed integer.</returns>
        public static implicit operator BFloat16(long value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a quarter-precision floating-point number to a System.BFloat16.
        /// </summary>
        /// <param name="value">A quarter-precision floating-point number.</param>
        /// <returns>A System.BFloat16 that represents the converted quarter-precision floating point number.</returns>
        public static implicit operator BFloat16(Quarter value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a half-precision floating-point number to a System.BFloat16.
        /// </summary>
        /// <param name="value">A half-precision floating-point number.</param>
        /// <returns>A System.BFloat16 that represents the converted half-precision floating point number.</returns>
        public static implicit operator BFloat16(Half value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a single-precision floating-point number to a System.BFloat16.
        /// </summary>
        /// <param name="value">A single-precision floating-point number.</param>
        /// <returns>A System.BFloat16 that represents the converted single-precision floating point number.</returns>
        public static explicit operator BFloat16(float value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a double-precision floating-point number to a System.BFloat16.
        /// </summary>
        /// <param name="value">A double-precision floating-point number.</param>
        /// <returns>A System.BFloat16 that represents the converted double-precision floating point number.</returns>
        public static explicit operator BFloat16(double value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a decimal number to a System.BFloat16.
        /// </summary>
        /// <param name="value">decimal number</param>
        /// <returns>A System.BFloat16 that represents the converted decimal number.</returns>
        public static explicit operator BFloat16(decimal value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a System.BFloat16 to an 8-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>An 8-bit unsigned integer that represents the converted System.BFloat16.</returns>
        public static explicit operator byte(BFloat16 value)
        {
            return (byte)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a Unicode character.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A Unicode character that represents the converted System.BFloat16.</returns>
        public static explicit operator char(BFloat16 value)
        {
            return (char)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 16-bit signed integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 16-bit signed integer that represents the converted System.BFloat16.</returns>
        public static explicit operator short(BFloat16 value)
        {
            return (short)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 32-bit signed integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 32-bit signed integer that represents the converted System.BFloat16.</returns>
        public static explicit operator int(BFloat16 value)
        {
            return (int)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 64-bit signed integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 64-bit signed integer that represents the converted System.BFloat16.</returns>
        public static explicit operator long(BFloat16 value)
        {
            return (long)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a single-precision floating-point number.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A single-precision floating-point number that represents the converted System.BFloat16.</returns>
        public static implicit operator float(BFloat16 value)
        {
            return (float)BFloat16Helper.BFloat16ToSingle(value);
        }

        /// <summary>
        /// Converts a System.BFloat16 to a double-precision floating-point number.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A double-precision floating-point number that represents the converted System.BFloat16.</returns>
        public static implicit operator double(BFloat16 value)
        {
            return (double)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a decimal number.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A decimal number that represents the converted System.BFloat16.</returns>
        public static explicit operator decimal(BFloat16 value)
        {
            return (decimal)(float)value;
        }

        /// <summary>
        /// Converts an 8-bit signed integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">An 8-bit signed integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 8-bit signed integer.</returns>
        public static implicit operator BFloat16(sbyte value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 16-bit unsigned integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 16-bit unsigned integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 16-bit unsigned integer.</returns>
        public static implicit operator BFloat16(ushort value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 32-bit unsigned integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 32-bit unsigned integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 32-bit unsigned integer.</returns>
        public static implicit operator BFloat16(uint value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a 64-bit unsigned integer to a System.BFloat16.
        /// </summary>
        /// <param name="value">A 64-bit unsigned integer.</param>
        /// <returns>A System.BFloat16 that represents the converted 64-bit unsigned integer.</returns>
        public static implicit operator BFloat16(ulong value)
        {
            return new BFloat16((float)value);
        }

        /// <summary>
        /// Converts a System.BFloat16 to an 8-bit signed integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>An 8-bit signed integer that represents the converted System.BFloat16.</returns>
        public static explicit operator sbyte(BFloat16 value)
        {
            return (sbyte)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 16-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 16-bit unsigned integer that represents the converted System.BFloat16.</returns>
        public static explicit operator ushort(BFloat16 value)
        {
            return (ushort)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 32-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 32-bit unsigned integer that represents the converted System.BFloat16.</returns>
        public static explicit operator uint(BFloat16 value)
        {
            return (uint)(float)value;
        }

        /// <summary>
        /// Converts a System.BFloat16 to a 64-bit unsigned integer.
        /// </summary>
        /// <param name="value">A System.BFloat16 to convert.</param>
        /// <returns>A 64-bit unsigned integer that represents the converted System.BFloat16.</returns>
        public static explicit operator ulong(BFloat16 value)
        {
            return (ulong)(float)value;
        }

        #endregion

        /// <summary>
        /// Compares this instance to a specified System.BFloat16 object.
        /// </summary>
        /// <param name="other">A System.BFloat16 object.</param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and value.
        /// Return Value Meaning Less than zero This instance is less than value. Zero
        /// This instance is equal to value. Greater than zero This instance is greater than value.
        /// </returns>
        public int CompareTo(BFloat16 other)
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
        /// <exception cref="System.ArgumentException">value is not a System.BFloat16</exception>
        public int CompareTo(object obj)
        {
            int result = 0;
            if(obj == null)
            {
                result = 1;
            }
            else
            {
                if(obj is BFloat16)
                {
                    result = CompareTo((BFloat16)obj);
                }
                else
                {
                    throw new ArgumentException("Object must be of type BFloat16.");
                }
            }
            return result;
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified System.BFloat16 object represent the same value.
        /// </summary>
        /// <param name="other">A System.BFloat16 object to compare to this instance.</param>
        /// <returns>true if value is equal to this instance; otherwise, false.</returns>
        public bool Equals(BFloat16 other)
        {
            return ((other == this) || (IsNaN(other) && IsNaN(this)));
        }

        /// <summary>
        /// Returns a value indicating whether this instance and a specified System.Object
        /// represent the same type and value.
        /// </summary>
        /// <param name="obj">An System.Object.</param>
        /// <returns>true if value is a System.BFloat16 and equal to this instance; otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            bool result = false;
            if(obj is BFloat16)
            {
                BFloat16 bfloat16 = (BFloat16)obj;
                if((bfloat16 == this) || (IsNaN(bfloat16) && IsNaN(this)))
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
        /// Returns the System.TypeCode for value type System.BFloat16.
        /// </summary>
        /// <returns>The enumerated constant (TypeCode)255.</returns>
        public TypeCode GetTypeCode()
        { 
            return (TypeCode)255;
        }

        #region BitConverter & Math methods for BFloat16

        /// <summary>
        /// Returns the specified bfloat16 floating point value as an array of bytes.
        /// </summary>
        /// <param name="value">The number to convert.</param>
        /// <returns>An array of bytes with length 2.</returns>
        public static byte[] GetBytes(BFloat16 value)
        {
            return BitConverter.GetBytes(value.value);
        }

        /// <summary>
        /// Converts the value of a specified instance of System.BFloat16 to its equivalent binary representation.
        /// </summary>
        /// <param name="value">A System.BFloat16 value.</param>
        /// <returns>A 16-bit unsigned integer that contain the binary representation of value.</returns>        
        public static ushort GetBits(BFloat16 value)
        {
            return value.value;
        }

        /// <summary>
        /// Returns a bfloat16 floating point number converted from two bytes
        /// at a specified position in a byte array.
        /// </summary>
        /// <param name="value">An array of bytes.</param>
        /// <param name="startIndex">The starting position within value.</param>
        /// <returns>A bfloat16 floating point number formed by two bytes beginning at startIndex.</returns>
        /// <exception cref="System.ArgumentException">
        /// startIndex is greater than or equal to the length of value minus 1, and is
        /// less than or equal to the length of value minus 1.
        /// </exception>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">startIndex is less than zero or greater than the length of value minus 1.</exception>
        public static BFloat16 ToBFloat16(byte[] value, int startIndex)
        {
            return BFloat16.ToBFloat16((ushort)BitConverter.ToInt16(value, startIndex));
        }

        /// <summary>
        /// Returns a bfloat16 floating point number converted from its binary representation.
        /// </summary>
        /// <param name="bits">Binary representation of System.BFloat16 value</param>
        /// <returns>A bfloat16 floating point number formed by its binary representation.</returns>
        public static BFloat16 ToBFloat16(ushort bits)
        {
            return new BFloat16
            {
                value = bits
            };
        }

        /// <summary>
        /// Returns a value indicating the sign of a bfloat16 floating-point number.
        /// </summary>
        /// <param name="value">A signed number.</param>
        /// <returns>
        /// A number indicating the sign of value. Number Description -1 value is less
        /// than zero. 0 value is equal to zero. 1 value is greater than zero.
        /// </returns>
        /// <exception cref="System.ArithmeticException">value is equal to System.BFloat16.NaN.</exception>
        public static int Sign(BFloat16 value)
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
        /// Returns the absolute value of a bfloat16 floating-point number.
        /// </summary>
        /// <param name="value">A number in the range System.BFloat16.MinValue ≤ value ≤ System.BFloat16.MaxValue.</param>
        /// <returns>A bfloat16 floating-point number, x, such that 0 ≤ x ≤System.BFloat16.MaxValue.</returns>
        public static BFloat16 Abs(BFloat16 value)
        {
            return BFloat16Helper.Abs(value);
        }

        /// <summary>
        /// Returns the larger of two bfloat16 floating-point numbers.
        /// </summary>
        /// <param name="value1">The first of two bfloat16 floating-point numbers to compare.</param>
        /// <param name="value2">The second of two bfloat16 floating-point numbers to compare.</param>
        /// <returns>
        /// Parameter value1 or value2, whichever is larger. If value1, or value2, or both val1
        /// and value2 are equal to System.BFloat16.NaN, System.BFloat16.NaN is returned.
        /// </returns>
        public static BFloat16 Max(BFloat16 value1, BFloat16 value2)
        {
            return (value1 < value2) ? value2 : value1;
        }

        /// <summary>
        /// Returns the smaller of two bfloat16 floating-point numbers.
        /// </summary>
        /// <param name="value1">The first of two bfloat16 floating-point numbers to compare.</param>
        /// <param name="value2">The second of two bfloat16 floating-point numbers to compare.</param>
        /// <returns>
        /// Parameter value1 or value2, whichever is smaller. If value1, or value2, or both val1
        /// and value2 are equal to System.BFloat16.NaN, System.BFloat16.NaN is returned.
        /// </returns>
        public static BFloat16 Min(BFloat16 value1, BFloat16 value2)
        {
            return (value1 < value2) ? value1 : value2;
        }

        #endregion

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to not a number (System.BFloat16.NaN).
        /// </summary>
        /// <param name="bfloat16">A bfloat16 floating-point number.</param>
        /// <returns>true if value evaluates to not a number (System.BFloat16.NaN); otherwise, false.</returns>
        public static bool IsNaN(BFloat16 bfloat16)
        {
            return BFloat16Helper.IsNaN(bfloat16);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative or positive infinity.
        /// </summary>
        /// <param name="bfloat16">A bfloat16 floating-point number.</param>
        /// <returns>true if bfloat16 evaluates to System.BFloat16.PositiveInfinity or System.BFloat16.NegativeInfinity; otherwise, false.</returns>
        public static bool IsInfinity(BFloat16 bfloat16)
        {
            return BFloat16Helper.IsInfinity(bfloat16);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to negative infinity.
        /// </summary>
        /// <param name="bfloat16">A bfloat16 floating-point number.</param>
        /// <returns>true if bfloat16 evaluates to System.BFloat16.NegativeInfinity; otherwise, false.</returns>
        public static bool IsNegativeInfinity(BFloat16 bfloat16)
        {
            return BFloat16Helper.IsNegativeInfinity(bfloat16);
        }

        /// <summary>
        /// Returns a value indicating whether the specified number evaluates to positive infinity.
        /// </summary>
        /// <param name="bfloat16">A bfloat16 number.</param>
        /// <returns>true if bfloat16 evaluates to System.BFloat16.PositiveInfinity; otherwise, false.</returns>
        public static bool IsPositiveInfinity(BFloat16 bfloat16)
        {
            return BFloat16Helper.IsPositiveInfinity(bfloat16);
        }

        #region String operations (Parse and ToString)

        /// <summary>
        /// Converts the string representation of a number to its System.BFloat16 equivalent.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <returns>The System.BFloat16 number equivalent to the number contained in value.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.BFloat16.MinValue or greater than System.BFloat16.MaxValue.</exception>
        public static BFloat16 Parse(string value)
        {
            return (BFloat16)float.Parse(value, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.BFloat16 equivalent 
        /// using the specified culture-specific format information.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="provider">An System.IFormatProvider that supplies culture-specific parsing information about value.</param>
        /// <returns>The System.BFloat16 number equivalent to the number contained in s as specified by provider.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.BFloat16.MinValue or greater than System.BFloat16.MaxValue.</exception>
        public static BFloat16 Parse(string value, IFormatProvider provider)
        {
            return (BFloat16)float.Parse(value, provider);
        }

        /// <summary>
        /// Converts the string representation of a number in a specified style to its System.BFloat16 equivalent.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="style">
        /// A bitwise combination of System.Globalization.NumberStyles values that indicates
        /// the style elements that can be present in value. A typical value to specify is
        /// System.Globalization.NumberStyles.Number.
        /// </param>
        /// <returns>The System.BFloat16 number equivalent to the number contained in s as specified by style.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style is the
        /// System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.BFloat16.MinValue or greater than System.BFloat16.MaxValue.</exception>
        public static BFloat16 Parse(string value, NumberStyles style)
        {
            return (BFloat16)float.Parse(value, style, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.BFloat16 equivalent 
        /// using the specified style and culture-specific format.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="style">
        /// A bitwise combination of System.Globalization.NumberStyles values that indicates
        /// the style elements that can be present in value. A typical value to specify is 
        /// System.Globalization.NumberStyles.Number.
        /// </param>
        /// <param name="provider">An System.IFormatProvider object that supplies culture-specific information about the format of value.</param>
        /// <returns>The System.BFloat16 number equivalent to the number contained in s as specified by style and provider.</returns>
        /// <exception cref="System.ArgumentNullException">value is null.</exception>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style is the
        /// System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        /// <exception cref="System.FormatException">value is not in the correct format.</exception>
        /// <exception cref="System.OverflowException">value represents a number less than System.BFloat16.MinValue or greater than System.BFloat16.MaxValue.</exception>
        public static BFloat16 Parse(string value, NumberStyles style, IFormatProvider provider)
        {
            return (BFloat16)float.Parse(value, style, provider);
        }

        /// <summary>
        /// Converts the string representation of a number to its System.BFloat16 equivalent.
        /// A return value indicates whether the conversion succeeded or failed.
        /// </summary>
        /// <param name="value">The string representation of the number to convert.</param>
        /// <param name="result">
        /// When this method returns, contains the System.BFloat16 number that is equivalent
        /// to the numeric value contained in value, if the conversion succeeded, or is zero
        /// if the conversion failed. The conversion fails if the s parameter is null,
        /// is not a number in a valid format, or represents a number less than System.BFloat16.MinValue
        /// or greater than System.BFloat16.MaxValue. This parameter is passed uninitialized.
        /// </param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        public static bool TryParse(string value, out BFloat16 result)
        {
            float f;
            if(float.TryParse(value, out f))
            {
                result = (BFloat16)f;
                return true;
            }
            result = new BFloat16();
            return false;
        }

        /// <summary>
        /// Converts the string representation of a number to its System.BFloat16 equivalent
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
        /// When this method returns, contains the System.BFloat16 number that is equivalent
        /// to the numeric value contained in value, if the conversion succeeded, or is zero
        /// if the conversion failed. The conversion fails if the s parameter is null,
        /// is not in a format compliant with style, or represents a number less than
        /// System.BFloat16.MinValue or greater than System.BFloat16.MaxValue. This parameter is passed uninitialized.
        /// </param>
        /// <returns>true if s was converted successfully; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException">
        /// style is not a System.Globalization.NumberStyles value. -or- style 
        /// is the System.Globalization.NumberStyles.AllowHexSpecifier value.
        /// </exception>
        public static bool TryParse(string value, NumberStyles style, IFormatProvider provider, out BFloat16 result)
        {
            bool parseResult = false;
            float f;
            if(float.TryParse(value, style, provider, out f))
            {
                result = (BFloat16)f;
                parseResult = true;
            }
            else
            {
                result = new BFloat16();
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
            throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, "Invalid cast from '{0}' to '{1}'.", "BFloat16", "Char"));
        }

        DateTime IConvertible.ToDateTime(IFormatProvider provider)
        {
            throw new InvalidCastException(string.Format(CultureInfo.CurrentCulture, "Invalid cast from '{0}' to '{1}'.", "BFloat16", "DateTime"));
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
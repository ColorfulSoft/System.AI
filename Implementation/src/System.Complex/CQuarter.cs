//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

// This code is based on Microsoft's implementation of System.Numerics.Complex.
// See https://referencesource.microsoft.com/#System.Numerics/System/Numerics/Complex.cs
// Decompiled from System.Numerics.cs

using System;
using System.Globalization;

namespace System
{

    /// <summary>Represents a 8-bit complex floating point number.</summary>
    [Serializable]
    public struct CQuarter : IEquatable<CQuarter>, IFormattable
    {

        internal Quarter m_real;

        internal Quarter m_imaginary;

        /// <summary>Returns a new <see cref="T:System.CQuarter" /> instance with a real number equal to zero and an imaginary number equal to zero.</summary>
        public static readonly CQuarter Zero = new CQuarter(0, 0);

        /// <summary>Returns a new <see cref="T:System.CQuarter" /> instance with a real number equal to one and an imaginary number equal to zero.</summary>
        public static readonly CQuarter One = new CQuarter(1, 0);

        /// <summary>Returns a new <see cref="T:System.CQuarter" /> instance with a real number equal to zero and an imaginary number equal to one.</summary>
        public static readonly CQuarter ImaginaryOne = new CQuarter(0, 1);

        /// <summary>Gets the real component of the current <see cref="T:System.CQuarter" /> object.</summary>
        /// <returns>The real component of a complex number.</returns>
        public Quarter Real
        {

            get
            {
                return m_real;
            }

        }

        /// <summary>Gets the imaginary component of the current <see cref="T:System.CQuarter" /> object.</summary>
        /// <returns>The imaginary component of a complex number.</returns>
        public Quarter Imaginary
        {

            get
            {
                return m_imaginary;
            }

        }

        /// <summary>Gets the magnitude (or absolute value) of a complex number.</summary>
        /// <returns>The magnitude of the current instance.</returns>
        public Quarter Magnitude
        {

            get
            {
                return Abs(this);
            }

        }

        /// <summary>Gets the phase of a complex number.</summary>
        /// <returns>The phase of a complex number, in radians.</returns>
        public Quarter Phase
        {

            get
            {
                return (Quarter)Math.Atan2(m_imaginary, m_real);
            }

        }

        /// <summary>Initializes a new instance of the <see cref="T:System.CQuarter" /> structure using the specified real and imaginary values.</summary>
        /// <param name="real">The real part of the complex number.</param>
        /// <param name="imaginary">The imaginary part of the complex number.</param>
        public CQuarter(Quarter real, Quarter imaginary)
        {
            m_real = real;
            m_imaginary = imaginary;
        }

        /// <summary>Creates a complex number from a point's polar coordinates.</summary>
        /// <returns>A complex number.</returns>
        /// <param name="magnitude">The magnitude, which is the distance from the origin (the intersection of the x-axis and the y-axis) to the number.</param>
        /// <param name="phase">The phase, which is the angle from the line to the horizontal axis, measured in radians.</param>
        public static CQuarter FromPolarCoordinates(Quarter magnitude, Quarter phase)
        {
            return new CQuarter(magnitude * (Quarter)Math.Cos(phase), magnitude * (Quarter)Math.Sin(phase));
        }

        /// <summary>Returns the additive inverse of a specified complex number.</summary>
        /// <returns>The result of the <see cref="P:System.CQuarter.Real" /> and <see cref="P:System.CQuarter.Imaginary" /> components of the <paramref name="value" /> parameter multiplied by -1.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Negate(CQuarter value)
        {
            return -value;
        }

        /// <summary>Adds two complex numbers and returns the result.</summary>
        /// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first complex number to add.</param>
        /// <param name="right">The second complex number to add.</param>
        public static CQuarter Add(CQuarter left, CQuarter right)
        {
            return left + right;
        }

        /// <summary>Subtracts one complex number from another and returns the result.</summary>
        /// <returns>The result of subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
        /// <param name="left">The value to subtract from (the minuend).</param>
        /// <param name="right">The value to subtract (the subtrahend).</param>
        public static CQuarter Subtract(CQuarter left, CQuarter right)
        {
            return left - right;
        }

        /// <summary>Returns the product of two complex numbers.</summary>
        /// <returns>The product of the <paramref name="left" /> and <paramref name="right" /> parameters.</returns>
        /// <param name="left">The first complex number to multiply.</param>
        /// <param name="right">The second complex number to multiply.</param>
        public static CQuarter Multiply(CQuarter left, CQuarter right)
        {
            return left * right;
        }

        /// <summary>Divides one complex number by another and returns the result.</summary>
        /// <returns>The quotient of the division.</returns>
        /// <param name="dividend">The complex number to be divided.</param>
        /// <param name="divisor">The complex number to divide by.</param>
        public static CQuarter Divide(CQuarter dividend, CQuarter divisor)
        {
            return dividend / divisor;
        }

        /// <summary>Returns the additive inverse of a specified complex number.</summary>
        /// <returns>The result of the <see cref="P:System.CQuarter.Real" /> and <see cref="P:System.CQuarter.Imaginary" /> components of the <paramref name="value" /> parameter multiplied by -1.</returns>
        /// <param name="value">The value to negate.</param>
        public static CQuarter operator -(CQuarter value)
        {
            return new CQuarter(0 - value.m_real, 0 - value.m_imaginary);
        }

        /// <summary>Adds two complex numbers.</summary>
        /// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first value to add.</param>
        /// <param name="right">The second value to add.</param>
        public static CQuarter operator +(CQuarter left, CQuarter right)
        {
            return new CQuarter(left.m_real + right.m_real, left.m_imaginary + right.m_imaginary);
        }

        /// <summary>Subtracts a complex number from another complex number.</summary>
        /// <returns>The result of subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
        /// <param name="left">The value to subtract from (the minuend).</param>
        /// <param name="right">The value to subtract (the subtrahend).</param>
        public static CQuarter operator -(CQuarter left, CQuarter right)
        {
            return new CQuarter(left.m_real - right.m_real, left.m_imaginary - right.m_imaginary);
        }

        /// <summary>Multiplies two specified complex numbers.</summary>
        /// <returns>The product of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first value to multiply.</param>
        /// <param name="right">The second value to multiply.</param>
        public static CQuarter operator *(CQuarter left, CQuarter right)
        {
            Quarter real = left.m_real * right.m_real - left.m_imaginary * right.m_imaginary;
            Quarter imaginary = left.m_imaginary * right.m_real + left.m_real * right.m_imaginary;
            return new CQuarter(real, imaginary);
        }

        /// <summary>Divides a specified complex number by another specified complex number.</summary>
        /// <returns>The result of dividing <paramref name="left" /> by <paramref name="right" />.</returns>
        /// <param name="left">The value to be divided.</param>
        /// <param name="right">The value to divide by.</param>
        public static CQuarter operator /(CQuarter left, CQuarter right)
        {
            Quarter real = left.m_real;
            Quarter imaginary = left.m_imaginary;
            Quarter real2 = right.m_real;
            Quarter imaginary2 = right.m_imaginary;
            if(Math.Abs(imaginary2) < Math.Abs(real2))
            {
                Quarter num = imaginary2 / real2;
                return new CQuarter((real + imaginary * num) / (real2 + imaginary2 * num), (imaginary - real * num) / (real2 + imaginary2 * num));
            }
            Quarter num2 = real2 / imaginary2;
            return new CQuarter((imaginary + real * num2) / (imaginary2 + real2 * num2), (0 - real + imaginary * num2) / (imaginary2 + real2 * num2));
        }

        /// <summary>Gets the absolute value (or magnitude) of a complex number.</summary>
        /// <returns>The absolute value of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static Quarter Abs(CQuarter value)
        {
            if(Quarter.IsInfinity(value.m_real) || Quarter.IsInfinity(value.m_imaginary))
            {
                return Quarter.PositiveInfinity;
            }
            Quarter num = (Quarter)Math.Abs(value.m_real);
            Quarter num2 = (Quarter)Math.Abs(value.m_imaginary);
            if(num > num2)
            {
                Quarter num3 = num2 / num;
                return num * (Quarter)Math.Sqrt(1 + num3 * num3);
            }
            if(num2 == 0)
            {
                return num;
            }
            Quarter num4 = num / num2;
            return num2 * (Quarter)Math.Sqrt(1 + num4 * num4);
        }

        /// <summary>Computes the conjugate of a complex number and returns the result.</summary>
        /// <returns>The conjugate of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Conjugate(CQuarter value)
        {
            return new CQuarter(value.m_real, 0 - value.m_imaginary);
        }

        /// <summary>Returns the multiplicative inverse of a complex number.</summary>
        /// <returns>The reciprocal of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Reciprocal(CQuarter value)
        {
            if((value.m_real == 0) && (value.m_imaginary == 0))
            {
                return Zero;
            }
            return One / value;
        }

        /// <summary>Returns a value that indicates whether two complex numbers are equal.</summary>
        /// <returns>true if the <paramref name="left" /> and <paramref name="right" /> parameters have the same value; otherwise, false.</returns>
        /// <param name="left">The first complex number to compare.</param>
        /// <param name="right">The second complex number to compare.</param>
        public static bool operator ==(CQuarter left, CQuarter right)
        {
            if(left.m_real == right.m_real)
            {
                return left.m_imaginary == right.m_imaginary;
            }
            return false;
        }

        /// <summary>Returns a value that indicates whether two complex numbers are not equal.</summary>
        /// <returns>true if <paramref name="left" /> and <paramref name="right" /> are not equal; otherwise, false.</returns>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        public static bool operator !=(CQuarter left, CQuarter right)
        {
            if(left.m_real == right.m_real)
            {
                return left.m_imaginary != right.m_imaginary;
            }
            return true;
        }

        /// <summary>Returns a value that indicates whether the current instance and a specified object have the same value. </summary>
        /// <returns>true if the <paramref name="obj" /> parameter is a <see cref="T:System.CQuarter" /> object or a type capable of implicit conversion to a <see cref="T:System.CQuarter" /> object, and its value is equal to the current <see cref="T:System.CQuarter" /> object; otherwise, false.</returns>
        /// <param name="obj">The object to compare.</param>
        public override bool Equals(object obj)
        {
            if(!(obj is CQuarter))
            {
                return false;
            }
            return this == (CQuarter)obj;
        }

        /// <summary>Returns a value that indicates whether the current instance and a specified complex number have the same value.</summary>
        /// <returns>true if this complex number and <paramref name="value" /> have the same value; otherwise, false.</returns>
        /// <param name="value">The complex number to compare.</param>
        public bool Equals(CQuarter value)
        {
            if(m_real.Equals(value.m_real))
            {
                return m_imaginary.Equals(value.m_imaginary);
            }
            return false;
        }

        /// <summary>Defines an implicit conversion of a 16-bit signed integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(short value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 32-bit signed integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(int value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 64-bit signed integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(long value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 16-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CQuarter(ushort value)
        {
            return new CQuarter((int)value, 0);
        }

        /// <summary>Defines an implicit conversion of a 32-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CQuarter(uint value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 64-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CQuarter(ulong value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a signed byte to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CQuarter(sbyte value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of an unsigned byte to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(byte value)
        {
            return new CQuarter((int)value, 0);
        }

        /// <summary>Defines an implicit conversion of a quarter-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(Quarter value)
        {
            return new CQuarter(value, 0);
        }

        /// <summary>Defines an implicit conversion of a half-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(Half value)
        {
            return new CQuarter((Quarter)value, 0);
        }

        /// <summary>Defines an implicit conversion of a google brain 16-bit floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(BFloat16 value)
        {
            return new CQuarter((Quarter)value, 0);
        }

        /// <summary>Defines an implicit conversion of a single-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(float value)
        {
            return new CQuarter((Quarter)value, 0);
        }

        /// <summary>Defines an implicit conversion of a double-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CQuarter(double value)
        {
            return new CQuarter((Quarter)value, 0);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CQuarter(decimal value)
        {
            return new CQuarter((Quarter)value, 0);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CHalf" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CQuarter(CHalf value)
        {
            return new CQuarter((Quarter)value.m_real, (Quarter)value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CBFloat16" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CQuarter(CBFloat16 value)
        {
            return new CQuarter((Quarter)value.m_real, (Quarter)value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CFloat" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CQuarter(CFloat value)
        {
            return new CQuarter((Quarter)value.m_real, (Quarter)value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CDouble" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CQuarter(CDouble value)
        {
            return new CQuarter((Quarter)value.m_real, (Quarter)value.m_imaginary);
        }

        /// <summary>Converts the value of the current complex number to its equivalent string representation in Cartesian form.</summary>
        /// <returns>The string representation of the current instance in Cartesian form.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture, "({0}, {1})", this.m_real, this.m_imaginary);
        }

        /// <summary>Converts the value of the current complex number to its equivalent string representation in Cartesian form by using the specified format for its real and imaginary parts.</summary>
        /// <returns>The string representation of the current instance in Cartesian form.</returns>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="format" /> is not a valid format string.</exception>
        public string ToString(string format)
        {
            return string.Format(CultureInfo.CurrentCulture,
                                 "({0}, {1})",
                                 m_real.ToString(format, CultureInfo.CurrentCulture),
                                 m_imaginary.ToString(format, CultureInfo.CurrentCulture));
        }

        /// <summary>Converts the value of the current complex number to its equivalent string representation in Cartesian form by using the specified culture-specific formatting information.</summary>
        /// <returns>The string representation of the current instance in Cartesian form, as specified by <paramref name="provider" />.</returns>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        public string ToString(IFormatProvider provider)
        {
            return string.Format(provider, "({0}, {1})", m_real, m_imaginary);
        }

        /// <summary>Converts the value of the current complex number to its equivalent string representation in Cartesian form by using the specified format and culture-specific format information for its real and imaginary parts.</summary>
        /// <returns>The string representation of the current instance in Cartesian form, as specified by <paramref name="format" /> and <paramref name="provider" />.</returns>
        /// <param name="format">A standard or custom numeric format string.</param>
        /// <param name="provider">An object that supplies culture-specific formatting information.</param>
        /// <exception cref="T:System.FormatException">
        ///   <paramref name="format" /> is not a valid format string.</exception>
        public string ToString(string format, IFormatProvider provider)
        {
            return string.Format(provider,
                                 "({0}, {1})",
                                 m_real.ToString(format, provider),
                                 m_imaginary.ToString(format, provider));
        }

        /// <summary>Returns the hash code for the current <see cref="T:System.CQuarter" /> object.</summary>
        /// <returns>A 32-bit signed integer hash code.</returns>
        public override int GetHashCode()
        {
            int num = 99999997;
            int num2 = m_real.GetHashCode() % num;
            int hashCode = m_imaginary.GetHashCode();
            return num2 ^ hashCode;
        }

        /// <summary>Returns the sine of the specified complex number.</summary>
        /// <returns>The sine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Sin(CQuarter value)
        {
            Quarter real = value.m_real;
            Quarter imaginary = value.m_imaginary;
            return new CQuarter((Quarter)(Math.Sin(real) * Math.Cosh(imaginary)), (Quarter)(Math.Cos(real) * Math.Sinh(imaginary)));
        }

        /// <summary>Returns the hyperbolic sine of the specified complex number.</summary>
        /// <returns>The hyperbolic sine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Sinh(CQuarter value)
        {
            Quarter real = value.m_real;
            Quarter imaginary = value.m_imaginary;
            return new CQuarter((Quarter)(Math.Sinh(real) * Math.Cos(imaginary)), (Quarter)(Math.Cosh(real) * Math.Sin(imaginary)));
        }

        /// <summary>Returns the angle that is the arc sine of the specified complex number.</summary>
        /// <returns>The angle which is the arc sine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Asin(CQuarter value)
        {
            return -ImaginaryOne * Log(ImaginaryOne * value + Sqrt(One - value * value));
        }

        /// <summary>Returns the cosine of the specified complex number.</summary>
        /// <returns>The cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Cos(CQuarter value)
        {
            Quarter real = value.m_real;
            Quarter imaginary = value.m_imaginary;
            return new CQuarter((Quarter)(Math.Cos(real) * Math.Cosh(imaginary)), (Quarter)(0 - Math.Sin(real) * Math.Sinh(imaginary)));
        }

        /// <summary>Returns the hyperbolic cosine of the specified complex number.</summary>
        /// <returns>The hyperbolic cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Cosh(CQuarter value)
        {
            Quarter real = value.m_real;
            Quarter imaginary = value.m_imaginary;
            return new CQuarter((Quarter)(Math.Cosh(real) * Math.Cos(imaginary)), (Quarter)(Math.Sinh(real) * Math.Sin(imaginary)));
        }

        /// <summary>Returns the angle that is the arc cosine of the specified complex number.</summary>
        /// <returns>The angle, measured in radians, which is the arc cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number that represents a cosine.</param>
        public static CQuarter Acos(CQuarter value)
        {
            return -ImaginaryOne * Log(value + ImaginaryOne * Sqrt(One - value * value));
        }

        /// <summary>Returns the tangent of the specified complex number.</summary>
        /// <returns>The tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Tan(CQuarter value)
        {
            return Sin(value) / Cos(value);
        }

        /// <summary>Returns the hyperbolic tangent of the specified complex number.</summary>
        /// <returns>The hyperbolic tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Tanh(CQuarter value)
        {
            return Sinh(value) / Cosh(value);
        }

        /// <summary>Returns the angle that is the arc tangent of the specified complex number.</summary>
        /// <returns>The angle that is the arc tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Atan(CQuarter value)
        {
            CQuarter complex = new CQuarter(2, 0);
            return ImaginaryOne / complex * (Log(One - ImaginaryOne * value) - Log(One + ImaginaryOne * value));
        }

        /// <summary>Returns the natural (base e) logarithm of a specified complex number.</summary>
        /// <returns>The natural (base e) logarithm of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Log(CQuarter value)
        {
            return new CQuarter((Quarter)Math.Log(Abs(value)), (Quarter)Math.Atan2(value.m_imaginary, value.m_real));
        }

        /// <summary>Returns the logarithm of a specified complex number in a specified base.</summary>
        /// <returns>The logarithm of <paramref name="value" /> in base <paramref name="baseValue" />.</returns>
        /// <param name="value">A complex number.</param>
        /// <param name="baseValue">The base of the logarithm.</param>
        public static CQuarter Log(CQuarter value, Quarter baseValue)
        {
            return Log(value) / Log(baseValue);
        }

        /// <summary>Returns the base-10 logarithm of a specified complex number.</summary>
        /// <returns>The base-10 logarithm of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Log10(CQuarter value)
        {
            CQuarter value2 = Log(value);
            return Scale(value2, (Quarter)0.43429448190325);
        }

        /// <summary>Returns e raised to the power specified by a complex number.</summary>
        /// <returns>The number e raised to the power <paramref name="value" />.</returns>
        /// <param name="value">A complex number that specifies a power.</param>
        public static CQuarter Exp(CQuarter value)
        {
            Quarter num = (Quarter)Math.Exp(value.m_real);
            Quarter real = num * (Quarter)Math.Cos(value.m_imaginary);
            Quarter imaginary = num * (Quarter)Math.Sin(value.m_imaginary);
            return new CQuarter(real, imaginary);
        }

        /// <summary>Returns the square root of a specified complex number.</summary>
        /// <returns>The square root of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CQuarter Sqrt(CQuarter value)
        {
            return FromPolarCoordinates((Quarter)Math.Sqrt(value.Magnitude), value.Phase / 2);
        }

        /// <summary>Returns a specified complex number raised to a power specified by a complex number.</summary>
        /// <returns>The complex number <paramref name="value" /> raised to the power <paramref name="power" />.</returns>
        /// <param name="value">A complex number to be raised to a power.</param>
        /// <param name="power">A complex number that specifies a power.</param>
        public static CQuarter Pow(CQuarter value, CQuarter power)
        {
            if(power == Zero)
            {
                return One;
            }
            if(value == Zero)
            {
                return Zero;
            }
            Quarter real = value.m_real;
            Quarter imaginary = value.m_imaginary;
            Quarter real2 = power.m_real;
            Quarter imaginary2 = power.m_imaginary;
            Quarter num = Abs(value);
            Quarter num2 = (Quarter)Math.Atan2(imaginary, real);
            Quarter num3 = real2 * num2 + imaginary2 * (Quarter)Math.Log(num);
            Quarter num4 = (Quarter)(Math.Pow(num, real2) * Math.Pow(Math.E, (0 - imaginary2) * num2));
            return new CQuarter((Quarter)(num4 * Math.Cos(num3)), (Quarter)(num4 * Math.Sin(num3)));
        }

        /// <summary>Returns a specified complex number raised to a power specified by a quarter-precision floating-point number.</summary>
        /// <returns>The complex number <paramref name="value" /> raised to the power <paramref name="power" />.</returns>
        /// <param name="value">A complex number to be raised to a power.</param>
        /// <param name="power">A quarter-precision floating-point number that specifies a power.</param>
        public static CQuarter Pow(CQuarter value, Quarter power)
        {
            return Pow(value, new CQuarter(power, 0));
        }

        private static CQuarter Scale(CQuarter value, Quarter factor)
        {
            Quarter real = factor * value.m_real;
            Quarter imaginary = factor * value.m_imaginary;
            return new CQuarter(real, imaginary);
        }

    }

}
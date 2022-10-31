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

    /// <summary>Represents a 16-bit complex floating point number.</summary>
    [Serializable]
    public struct CHalf : IEquatable<CHalf>, IFormattable
    {

        internal Half m_real;

        internal Half m_imaginary;

        /// <summary>Returns a new <see cref="T:System.CHalf" /> instance with a real number equal to zero and an imaginary number equal to zero.</summary>
        public static readonly CHalf Zero = new CHalf(0, 0);

        /// <summary>Returns a new <see cref="T:System.CHalf" /> instance with a real number equal to one and an imaginary number equal to zero.</summary>
        public static readonly CHalf One = new CHalf(1, 0);

        /// <summary>Returns a new <see cref="T:System.CHalf" /> instance with a real number equal to zero and an imaginary number equal to one.</summary>
        public static readonly CHalf ImaginaryOne = new CHalf(0, 1);

        /// <summary>Gets the real component of the current <see cref="T:System.CHalf" /> object.</summary>
        /// <returns>The real component of a complex number.</returns>
        public Half Real
        {

            get
            {
                return m_real;
            }

        }

        /// <summary>Gets the imaginary component of the current <see cref="T:System.CHalf" /> object.</summary>
        /// <returns>The imaginary component of a complex number.</returns>
        public Half Imaginary
        {

            get
            {
                return m_imaginary;
            }

        }

        /// <summary>Gets the magnitude (or absolute value) of a complex number.</summary>
        /// <returns>The magnitude of the current instance.</returns>
        public Half Magnitude
        {

            get
            {
                return Abs(this);
            }

        }

        /// <summary>Gets the phase of a complex number.</summary>
        /// <returns>The phase of a complex number, in radians.</returns>
        public Half Phase
        {

            get
            {
                return (Half)Math.Atan2(m_imaginary, m_real);
            }

        }

        /// <summary>Initializes a new instance of the <see cref="T:System.CHalf" /> structure using the specified real and imaginary values.</summary>
        /// <param name="real">The real part of the complex number.</param>
        /// <param name="imaginary">The imaginary part of the complex number.</param>
        public CHalf(Half real, Half imaginary)
        {
            m_real = real;
            m_imaginary = imaginary;
        }

        /// <summary>Creates a complex number from a point's polar coordinates.</summary>
        /// <returns>A complex number.</returns>
        /// <param name="magnitude">The magnitude, which is the distance from the origin (the intersection of the x-axis and the y-axis) to the number.</param>
        /// <param name="phase">The phase, which is the angle from the line to the horizontal axis, measured in radians.</param>
        public static CHalf FromPolarCoordinates(Half magnitude, Half phase)
        {
            return new CHalf(magnitude * (Half)Math.Cos(phase), magnitude * (Half)Math.Sin(phase));
        }

        /// <summary>Returns the additive inverse of a specified complex number.</summary>
        /// <returns>The result of the <see cref="P:System.CHalf.Real" /> and <see cref="P:System.CHalf.Imaginary" /> components of the <paramref name="value" /> parameter multiplied by -1.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Negate(CHalf value)
        {
            return -value;
        }

        /// <summary>Adds two complex numbers and returns the result.</summary>
        /// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first complex number to add.</param>
        /// <param name="right">The second complex number to add.</param>
        public static CHalf Add(CHalf left, CHalf right)
        {
            return left + right;
        }

        /// <summary>Subtracts one complex number from another and returns the result.</summary>
        /// <returns>The result of subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
        /// <param name="left">The value to subtract from (the minuend).</param>
        /// <param name="right">The value to subtract (the subtrahend).</param>
        public static CHalf Subtract(CHalf left, CHalf right)
        {
            return left - right;
        }

        /// <summary>Returns the product of two complex numbers.</summary>
        /// <returns>The product of the <paramref name="left" /> and <paramref name="right" /> parameters.</returns>
        /// <param name="left">The first complex number to multiply.</param>
        /// <param name="right">The second complex number to multiply.</param>
        public static CHalf Multiply(CHalf left, CHalf right)
        {
            return left * right;
        }

        /// <summary>Divides one complex number by another and returns the result.</summary>
        /// <returns>The quotient of the division.</returns>
        /// <param name="dividend">The complex number to be divided.</param>
        /// <param name="divisor">The complex number to divide by.</param>
        public static CHalf Divide(CHalf dividend, CHalf divisor)
        {
            return dividend / divisor;
        }

        /// <summary>Returns the additive inverse of a specified complex number.</summary>
        /// <returns>The result of the <see cref="P:System.CHalf.Real" /> and <see cref="P:System.CHalf.Imaginary" /> components of the <paramref name="value" /> parameter multiplied by -1.</returns>
        /// <param name="value">The value to negate.</param>
        public static CHalf operator -(CHalf value)
        {
            return new CHalf(0 - value.m_real, 0 - value.m_imaginary);
        }

        /// <summary>Adds two complex numbers.</summary>
        /// <returns>The sum of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first value to add.</param>
        /// <param name="right">The second value to add.</param>
        public static CHalf operator +(CHalf left, CHalf right)
        {
            return new CHalf(left.m_real + right.m_real, left.m_imaginary + right.m_imaginary);
        }

        /// <summary>Subtracts a complex number from another complex number.</summary>
        /// <returns>The result of subtracting <paramref name="right" /> from <paramref name="left" />.</returns>
        /// <param name="left">The value to subtract from (the minuend).</param>
        /// <param name="right">The value to subtract (the subtrahend).</param>
        public static CHalf operator -(CHalf left, CHalf right)
        {
            return new CHalf(left.m_real - right.m_real, left.m_imaginary - right.m_imaginary);
        }

        /// <summary>Multiplies two specified complex numbers.</summary>
        /// <returns>The product of <paramref name="left" /> and <paramref name="right" />.</returns>
        /// <param name="left">The first value to multiply.</param>
        /// <param name="right">The second value to multiply.</param>
        public static CHalf operator *(CHalf left, CHalf right)
        {
            Half real = left.m_real * right.m_real - left.m_imaginary * right.m_imaginary;
            Half imaginary = left.m_imaginary * right.m_real + left.m_real * right.m_imaginary;
            return new CHalf(real, imaginary);
        }

        /// <summary>Divides a specified complex number by another specified complex number.</summary>
        /// <returns>The result of dividing <paramref name="left" /> by <paramref name="right" />.</returns>
        /// <param name="left">The value to be divided.</param>
        /// <param name="right">The value to divide by.</param>
        public static CHalf operator /(CHalf left, CHalf right)
        {
            Half real = left.m_real;
            Half imaginary = left.m_imaginary;
            Half real2 = right.m_real;
            Half imaginary2 = right.m_imaginary;
            if(Math.Abs(imaginary2) < Math.Abs(real2))
            {
                Half num = imaginary2 / real2;
                return new CHalf((real + imaginary * num) / (real2 + imaginary2 * num), (imaginary - real * num) / (real2 + imaginary2 * num));
            }
            Half num2 = real2 / imaginary2;
            return new CHalf((imaginary + real * num2) / (imaginary2 + real2 * num2), (0 - real + imaginary * num2) / (imaginary2 + real2 * num2));
        }

        /// <summary>Gets the absolute value (or magnitude) of a complex number.</summary>
        /// <returns>The absolute value of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static Half Abs(CHalf value)
        {
            if(Half.IsInfinity(value.m_real) || Half.IsInfinity(value.m_imaginary))
            {
                return Half.PositiveInfinity;
            }
            Half num = (Half)Math.Abs(value.m_real);
            Half num2 = (Half)Math.Abs(value.m_imaginary);
            if(num > num2)
            {
                Half num3 = num2 / num;
                return num * (Half)Math.Sqrt(1 + num3 * num3);
            }
            if(num2 == 0)
            {
                return num;
            }
            Half num4 = num / num2;
            return num2 * (Half)Math.Sqrt(1 + num4 * num4);
        }

        /// <summary>Computes the conjugate of a complex number and returns the result.</summary>
        /// <returns>The conjugate of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Conjugate(CHalf value)
        {
            return new CHalf(value.m_real, 0 - value.m_imaginary);
        }

        /// <summary>Returns the multiplicative inverse of a complex number.</summary>
        /// <returns>The reciprocal of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Reciprocal(CHalf value)
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
        public static bool operator ==(CHalf left, CHalf right)
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
        public static bool operator !=(CHalf left, CHalf right)
        {
            if(left.m_real == right.m_real)
            {
                return left.m_imaginary != right.m_imaginary;
            }
            return true;
        }

        /// <summary>Returns a value that indicates whether the current instance and a specified object have the same value. </summary>
        /// <returns>true if the <paramref name="obj" /> parameter is a <see cref="T:System.CHalf" /> object or a type capable of implicit conversion to a <see cref="T:System.CHalf" /> object, and its value is equal to the current <see cref="T:System.CHalf" /> object; otherwise, false.</returns>
        /// <param name="obj">The object to compare.</param>
        public override bool Equals(object obj)
        {
            if(!(obj is CHalf))
            {
                return false;
            }
            return this == (CHalf)obj;
        }

        /// <summary>Returns a value that indicates whether the current instance and a specified complex number have the same value.</summary>
        /// <returns>true if this complex number and <paramref name="value" /> have the same value; otherwise, false.</returns>
        /// <param name="value">The complex number to compare.</param>
        public bool Equals(CHalf value)
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
        public static implicit operator CHalf(short value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 32-bit signed integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(int value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 64-bit signed integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(long value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 16-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CHalf(ushort value)
        {
            return new CHalf((int)value, 0);
        }

        /// <summary>Defines an implicit conversion of a 32-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CHalf(uint value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a 64-bit unsigned integer to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CHalf(ulong value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a signed byte to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        [CLSCompliant(false)]
        public static implicit operator CHalf(sbyte value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of an unsigned byte to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(byte value)
        {
            return new CHalf((int)value, 0);
        }

        /// <summary>Defines an implicit conversion of a quarter-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(Quarter value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a half-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(Half value)
        {
            return new CHalf(value, 0);
        }

        /// <summary>Defines an implicit conversion of a google brain 16-bit floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(BFloat16 value)
        {
            return new CHalf((Half)value, 0);
        }

        /// <summary>Defines an implicit conversion of a single-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(float value)
        {
            return new CHalf((Half)value, 0);
        }

        /// <summary>Defines an implicit conversion of a double-precision floating-point number to a complex number.</summary>
        /// <returns>An object that contains the value of the <paramref name="value" /> parameter as its real part and zero as its imaginary part.</returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(double value)
        {
            return new CHalf((Half)value, 0);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.Decimal" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CHalf(decimal value)
        {
            return new CHalf((Half)value, 0);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CQuarter" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static implicit operator CHalf(CQuarter value)
        {
            return new CHalf(value.m_real, value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CBFloat16" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CHalf(CBFloat16 value)
        {
            return new CHalf((Half)value.m_real, (Half)value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CFloat" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CHalf(CFloat value)
        {
            return new CHalf((Half)value.m_real, (Half)value.m_imaginary);
        }

        /// <summary>Defines an explicit conversion of a <see cref="T:System.CDouble" /> value to a complex number.</summary>
        /// <returns>A complex number that has a real component equal to <paramref name="value" /> and an imaginary component equal to zero. </returns>
        /// <param name="value">The value to convert to a complex number.</param>
        public static explicit operator CHalf(CDouble value)
        {
            return new CHalf((Half)value.m_real, (Half)value.m_imaginary);
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

        /// <summary>Returns the hash code for the current <see cref="T:System.CHalf" /> object.</summary>
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
        public static CHalf Sin(CHalf value)
        {
            Half real = value.m_real;
            Half imaginary = value.m_imaginary;
            return new CHalf((Half)(Math.Sin(real) * Math.Cosh(imaginary)), (Half)(Math.Cos(real) * Math.Sinh(imaginary)));
        }

        /// <summary>Returns the hyperbolic sine of the specified complex number.</summary>
        /// <returns>The hyperbolic sine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Sinh(CHalf value)
        {
            Half real = value.m_real;
            Half imaginary = value.m_imaginary;
            return new CHalf((Half)(Math.Sinh(real) * Math.Cos(imaginary)), (Half)(Math.Cosh(real) * Math.Sin(imaginary)));
        }

        /// <summary>Returns the angle that is the arc sine of the specified complex number.</summary>
        /// <returns>The angle which is the arc sine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Asin(CHalf value)
        {
            return -ImaginaryOne * Log(ImaginaryOne * value + Sqrt(One - value * value));
        }

        /// <summary>Returns the cosine of the specified complex number.</summary>
        /// <returns>The cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Cos(CHalf value)
        {
            Half real = value.m_real;
            Half imaginary = value.m_imaginary;
            return new CHalf((Half)(Math.Cos(real) * Math.Cosh(imaginary)), (Half)(0 - Math.Sin(real) * Math.Sinh(imaginary)));
        }

        /// <summary>Returns the hyperbolic cosine of the specified complex number.</summary>
        /// <returns>The hyperbolic cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Cosh(CHalf value)
        {
            Half real = value.m_real;
            Half imaginary = value.m_imaginary;
            return new CHalf((Half)(Math.Cosh(real) * Math.Cos(imaginary)), (Half)(Math.Sinh(real) * Math.Sin(imaginary)));
        }

        /// <summary>Returns the angle that is the arc cosine of the specified complex number.</summary>
        /// <returns>The angle, measured in radians, which is the arc cosine of <paramref name="value" />.</returns>
        /// <param name="value">A complex number that represents a cosine.</param>
        public static CHalf Acos(CHalf value)
        {
            return -ImaginaryOne * Log(value + ImaginaryOne * Sqrt(One - value * value));
        }

        /// <summary>Returns the tangent of the specified complex number.</summary>
        /// <returns>The tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Tan(CHalf value)
        {
            return Sin(value) / Cos(value);
        }

        /// <summary>Returns the hyperbolic tangent of the specified complex number.</summary>
        /// <returns>The hyperbolic tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Tanh(CHalf value)
        {
            return Sinh(value) / Cosh(value);
        }

        /// <summary>Returns the angle that is the arc tangent of the specified complex number.</summary>
        /// <returns>The angle that is the arc tangent of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Atan(CHalf value)
        {
            CHalf complex = new CHalf(2, 0);
            return ImaginaryOne / complex * (Log(One - ImaginaryOne * value) - Log(One + ImaginaryOne * value));
        }

        /// <summary>Returns the natural (base e) logarithm of a specified complex number.</summary>
        /// <returns>The natural (base e) logarithm of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Log(CHalf value)
        {
            return new CHalf((Half)Math.Log(Abs(value)), (Half)Math.Atan2(value.m_imaginary, value.m_real));
        }

        /// <summary>Returns the logarithm of a specified complex number in a specified base.</summary>
        /// <returns>The logarithm of <paramref name="value" /> in base <paramref name="baseValue" />.</returns>
        /// <param name="value">A complex number.</param>
        /// <param name="baseValue">The base of the logarithm.</param>
        public static CHalf Log(CHalf value, Half baseValue)
        {
            return Log(value) / Log(baseValue);
        }

        /// <summary>Returns the base-10 logarithm of a specified complex number.</summary>
        /// <returns>The base-10 logarithm of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Log10(CHalf value)
        {
            CHalf value2 = Log(value);
            return Scale(value2, (Half)0.43429448190325);
        }

        /// <summary>Returns e raised to the power specified by a complex number.</summary>
        /// <returns>The number e raised to the power <paramref name="value" />.</returns>
        /// <param name="value">A complex number that specifies a power.</param>
        public static CHalf Exp(CHalf value)
        {
            Half num = (Half)Math.Exp(value.m_real);
            Half real = num * (Half)Math.Cos(value.m_imaginary);
            Half imaginary = num * (Half)Math.Sin(value.m_imaginary);
            return new CHalf(real, imaginary);
        }

        /// <summary>Returns the square root of a specified complex number.</summary>
        /// <returns>The square root of <paramref name="value" />.</returns>
        /// <param name="value">A complex number.</param>
        public static CHalf Sqrt(CHalf value)
        {
            return FromPolarCoordinates((Half)Math.Sqrt(value.Magnitude), value.Phase / 2);
        }

        /// <summary>Returns a specified complex number raised to a power specified by a complex number.</summary>
        /// <returns>The complex number <paramref name="value" /> raised to the power <paramref name="power" />.</returns>
        /// <param name="value">A complex number to be raised to a power.</param>
        /// <param name="power">A complex number that specifies a power.</param>
        public static CHalf Pow(CHalf value, CHalf power)
        {
            if(power == Zero)
            {
                return One;
            }
            if(value == Zero)
            {
                return Zero;
            }
            Half real = value.m_real;
            Half imaginary = value.m_imaginary;
            Half real2 = power.m_real;
            Half imaginary2 = power.m_imaginary;
            Half num = Abs(value);
            Half num2 = (Half)Math.Atan2(imaginary, real);
            Half num3 = real2 * num2 + imaginary2 * (Half)Math.Log(num);
            Half num4 = (Half)(Math.Pow(num, real2) * Math.Pow(Math.E, (0 - imaginary2) * num2));
            return new CHalf((Half)(num4 * Math.Cos(num3)), (Half)(num4 * Math.Sin(num3)));
        }

        /// <summary>Returns a specified 16-bit complex number raised to a power specified by a half-precision floating-point number.</summary>
        /// <returns>The complex number <paramref name="value" /> raised to the power <paramref name="power" />.</returns>
        /// <param name="value">A 16-bit complex number to be raised to a power.</param>
        /// <param name="power">A half-precision floating-point number that specifies a power.</param>
        public static CHalf Pow(CHalf value, Half power)
        {
            return Pow(value, new CHalf(power, 0));
        }

        private static CHalf Scale(CHalf value, Half factor)
        {
            Half real = factor * value.m_real;
            Half imaginary = factor * value.m_imaginary;
            return new CHalf(real, imaginary);
        }

    }

}
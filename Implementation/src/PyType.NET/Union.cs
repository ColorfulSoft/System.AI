using System;

namespace System
{

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Implicitly converts a value of type X to an object of the Union&lt;X, Y&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y&gt; object.</returns>
        public static implicit operator Union<X, Y>(X val)
        {
            Union<X, Y> v = new Union<X, Y>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y&gt; object.</returns>
        public static implicit operator Union<X, Y>(Y val)
        {
            Union<X, Y> v = new Union<X, Y>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y> val)
        {
            return val.__Y;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z&gt; object.</returns>
        public static implicit operator Union<X, Y, Z>(X val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z&gt; object.</returns>
        public static implicit operator Union<X, Y, Z>(Y val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z&gt; object.</returns>
        public static implicit operator Union<X, Y, Z>(Z val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z> val)
        {
            return val.__Z;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z, T>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Field for value of type "T".
        /// </summary>
        private T __T;

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z, T&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T>(X val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z, T&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T>(Y val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z, T&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z, T&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T>(Z val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type T to an object of the Union&lt;X, Y, Z, T&gt; class.
        /// </summary>
        /// <param name="val">Value of type T.</param>
        /// <returns>Union&lt;X, Y, Z, T&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T>(T val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__T = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z, T> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z, T> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z, T> val)
        {
            return val.__Z;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T&gt; class to a value of type T.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T&gt; object.</param>
        /// <returns>Value of type T.</returns>
        public static implicit operator T(Union<X, Y, Z, T> val)
        {
            return val.__T;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z, T, U>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Field for value of type "T".
        /// </summary>
        private T __T;

        /// <summary>
        /// Field for value of type "U".
        /// </summary>
        private U __U;

        /// <summary>
        /// Implicitly converts a value of type X to an object of the Union&lt;X, Y, Z, T, U&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z, T, U&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U>(X val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T, U&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z, T, U&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U>(Y val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z, T, U&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z, T, U&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U>(Z val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type T to an object of the Union&lt;X, Y, Z, T, U&gt; class.
        /// </summary>
        /// <param name="val">Value of type T.</param>
        /// <returns>Union&lt;X, Y, Z, T, U&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U>(T val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__T = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type U to an object of the Union&lt;X, Y, Z, T, U&gt; class.
        /// </summary>
        /// <param name="val">Value of type U.</param>
        /// <returns>Union&lt;X, Y, Z, T, U&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U>(U val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__U = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z, T, U> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z, T, U> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z, T, U> val)
        {
            return val.__Z;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U&gt; class to a value of type T.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U&gt; object.</param>
        /// <returns>Value of type T.</returns>
        public static implicit operator T(Union<X, Y, Z, T, U> val)
        {
            return val.__T;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U&gt; class to a value of type U.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U&gt; object.</param>
        /// <returns>Value of type U.</returns>
        public static implicit operator U(Union<X, Y, Z, T, U> val)
        {
            return val.__U;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z, T, U, V>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Field for value of type "T".
        /// </summary>
        private T __T;

        /// <summary>
        /// Field for value of type "U".
        /// </summary>
        private U __U;

        /// <summary>
        /// Field for value of type "V".
        /// </summary>
        private V __V;

        /// <summary>
        /// Implicitly converts a value of type X to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(X val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(Y val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(Z val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type T to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type T.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(T val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__T = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type U to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type U.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(U val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__U = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type V to an object of the Union&lt;X, Y, Z, T, U, V&gt; class.
        /// </summary>
        /// <param name="val">Value of type V.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V>(V val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__V = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z, T, U, V> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z, T, U, V> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z, T, U, V> val)
        {
            return val.__Z;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type T.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type T.</returns>
        public static implicit operator T(Union<X, Y, Z, T, U, V> val)
        {
            return val.__T;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type U.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type U.</returns>
        public static implicit operator U(Union<X, Y, Z, T, U, V> val)
        {
            return val.__U;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V&gt; class to a value of type V.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V&gt; object.</param>
        /// <returns>Value of type V.</returns>
        public static implicit operator V(Union<X, Y, Z, T, U, V> val)
        {
            return val.__V;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z, T, U, V, W>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Field for value of type "T".
        /// </summary>
        private T __T;

        /// <summary>
        /// Field for value of type "U".
        /// </summary>
        private U __U;

        /// <summary>
        /// Field for value of type "V".
        /// </summary>
        private V __V;

        /// <summary>
        /// Field for value of type "W".
        /// </summary>
        private W __W;

        /// <summary>
        /// Implicitly converts a value of type X to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(X val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(Y val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(Z val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type T to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type T.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(T val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__T = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type U to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type U.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(U val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__U = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type V to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type V.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(V val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__V = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type W to an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class.
        /// </summary>
        /// <param name="val">Value of type W.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W>(W val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__W = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__Z;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type T.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type T.</returns>
        public static implicit operator T(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__T;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type U.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type U.</returns>
        public static implicit operator U(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__U;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type V.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type V.</returns>
        public static implicit operator V(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__V;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W&gt; class to a value of type W.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W&gt; object.</param>
        /// <returns>Value of type W.</returns>
        public static implicit operator W(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__W;
        }

    }

    /// <summary>
    /// Represents an arbitrary type from a set specified by template parameters.
    /// For example, Union&lt;int, float&gt; can store an int or float value.
    /// The maximum number of type parameters is 8.
    /// </summary>
    public class Union<X, Y, Z, T, U, V, W, Q>
    {

        /// <summary>
        /// Field for value of type "X".
        /// </summary>
        private X __X;

        /// <summary>
        /// Field for value of type "Y".
        /// </summary>
        private Y __Y;

        /// <summary>
        /// Field for value of type "Z".
        /// </summary>
        private Z __Z;

        /// <summary>
        /// Field for value of type "T".
        /// </summary>
        private T __T;

        /// <summary>
        /// Field for value of type "U".
        /// </summary>
        private U __U;

        /// <summary>
        /// Field for value of type "V".
        /// </summary>
        private V __V;

        /// <summary>
        /// Field for value of type "W".
        /// </summary>
        private W __W;

        /// <summary>
        /// Field for value of type "Q".
        /// </summary>
        private Q __Q;

        /// <summary>
        /// Implicitly converts a value of type X to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type X.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(X val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__X = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Y to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type Y.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Y val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Y = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Z to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type Z.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Z val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Z = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type T to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type T.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(T val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__T = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type U to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type U.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(U val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__U = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type V to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type V.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(V val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__V = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type W to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type W.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(W val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__W = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts a value of type Q to an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class.
        /// </summary>
        /// <param name="val">Value of type Q.</param>
        /// <returns>Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</returns>
        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Q val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Q = val;
            return v;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type X.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type X.</returns>
        public static implicit operator X(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__X;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type Y.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type Y.</returns>
        public static implicit operator Y(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Y;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type Z.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type Z.</returns>
        public static implicit operator Z(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Z;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type T.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type T.</returns>
        public static implicit operator T(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__T;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type U.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type U.</returns>
        public static implicit operator U(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__U;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type V.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type V.</returns>
        public static implicit operator V(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__V;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type W.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type W.</returns>
        public static implicit operator W(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__W;
        }

        /// <summary>
        /// Implicitly converts an object of the Union&lt;X, Y, Z, T, U, V, W, Q&gt; class to a value of type Q.
        /// </summary>
        /// <param name="val">Union&lt;X, Y, Z, T, U, V, W, Q&gt; object.</param>
        /// <returns>Value of type Q.</returns>
        public static implicit operator Q(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Q;
        }

    }

}
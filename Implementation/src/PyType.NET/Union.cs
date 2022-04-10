using System;

namespace System
{

    public class Union<X, Y>
    {

        private X __X;

        private Y __Y;

        public static implicit operator Union<X, Y>(X val)
        {
            Union<X, Y> v = new Union<X, Y>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y>(Y val)
        {
            Union<X, Y> v = new Union<X, Y>();
            v.__Y = val;
            return v;
        }

        public static implicit operator X(Union<X, Y> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y> val)
        {
            return val.__Y;
        }

    }

    public class Union<X, Y, Z>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        public static implicit operator Union<X, Y, Z>(X val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z>(Y val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z>(Z val)
        {
            Union<X, Y, Z> v = new Union<X, Y, Z>();
            v.__Z = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z> val)
        {
            return val.__Z;
        }

    }

    public class Union<X, Y, Z, T>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        private T __T;

        public static implicit operator Union<X, Y, Z, T>(X val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T>(Y val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T>(Z val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__Z = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T>(T val)
        {
            Union<X, Y, Z, T> v = new Union<X, Y, Z, T>();
            v.__T = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z, T> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z, T> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z, T> val)
        {
            return val.__Z;
        }

        public static implicit operator T(Union<X, Y, Z, T> val)
        {
            return val.__T;
        }

    }

    public class Union<X, Y, Z, T, U>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        private T __T;

        private U __U;

        public static implicit operator Union<X, Y, Z, T, U>(X val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U>(Y val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U>(Z val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__Z = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U>(T val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__T = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U>(U val)
        {
            Union<X, Y, Z, T, U> v = new Union<X, Y, Z, T, U>();
            v.__U = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z, T, U> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z, T, U> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z, T, U> val)
        {
            return val.__Z;
        }

        public static implicit operator T(Union<X, Y, Z, T, U> val)
        {
            return val.__T;
        }

        public static implicit operator U(Union<X, Y, Z, T, U> val)
        {
            return val.__U;
        }

    }

    public class Union<X, Y, Z, T, U, V>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        private T __T;

        private U __U;

        private V __V;

        public static implicit operator Union<X, Y, Z, T, U, V>(X val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V>(Y val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V>(Z val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__Z = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V>(T val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__T = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V>(U val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__U = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V>(V val)
        {
            Union<X, Y, Z, T, U, V> v = new Union<X, Y, Z, T, U, V>();
            v.__V = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z, T, U, V> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z, T, U, V> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z, T, U, V> val)
        {
            return val.__Z;
        }

        public static implicit operator T(Union<X, Y, Z, T, U, V> val)
        {
            return val.__T;
        }

        public static implicit operator U(Union<X, Y, Z, T, U, V> val)
        {
            return val.__U;
        }

        public static implicit operator V(Union<X, Y, Z, T, U, V> val)
        {
            return val.__V;
        }

    }

    public class Union<X, Y, Z, T, U, V, W>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        private T __T;

        private U __U;

        private V __V;

        private W __W;

        public static implicit operator Union<X, Y, Z, T, U, V, W>(X val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(Y val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(Z val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__Z = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(T val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__T = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(U val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__U = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(V val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__V = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W>(W val)
        {
            Union<X, Y, Z, T, U, V, W> v = new Union<X, Y, Z, T, U, V, W>();
            v.__W = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__Z;
        }

        public static implicit operator T(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__T;
        }

        public static implicit operator U(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__U;
        }

        public static implicit operator V(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__V;
        }

        public static implicit operator W(Union<X, Y, Z, T, U, V, W> val)
        {
            return val.__W;
        }

    }

    public class Union<X, Y, Z, T, U, V, W, Q>
    {

        private X __X;

        private Y __Y;

        private Z __Z;

        private T __T;

        private U __U;

        private V __V;

        private W __W;

        private Q __Q;

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(X val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__X = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Y val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Y = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Z val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Z = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(T val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__T = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(U val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__U = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(V val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__V = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(W val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__W = val;
            return v;
        }

        public static implicit operator Union<X, Y, Z, T, U, V, W, Q>(Q val)
        {
            Union<X, Y, Z, T, U, V, W, Q> v = new Union<X, Y, Z, T, U, V, W, Q>();
            v.__Q = val;
            return v;
        }

        public static implicit operator X(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__X;
        }

        public static implicit operator Y(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Y;
        }

        public static implicit operator Z(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Z;
        }

        public static implicit operator T(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__T;
        }

        public static implicit operator U(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__U;
        }

        public static implicit operator V(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__V;
        }

        public static implicit operator W(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__W;
        }

        public static implicit operator Q(Union<X, Y, Z, T, U, V, W, Q> val)
        {
            return val.__Q;
        }

    }

}
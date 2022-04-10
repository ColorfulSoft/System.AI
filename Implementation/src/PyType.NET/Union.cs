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

}
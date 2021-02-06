//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region zeros

            public static Tensor zeros_like(Tensor x, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(x.__shape, (dtype == DType.@default) ? x.dtype : dtype, requires_grad);
            }

            public static Tensor zeros(int[] shape, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(shape, dtype, requires_grad);
            }

            public static Tensor zeros(long a, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A,
                                       long B, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A,
                                       long B,
                                       long C, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A,
                                       long B,
                                       long C,
                                       long D, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A,
                                       long B,
                                       long C,
                                       long D,
                                       long E, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, dtype, requires_grad);
            }

            public static Tensor zeros(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k,
                                       long l,
                                       long m,
                                       long n,
                                       long o,
                                       long p,
                                       long q,
                                       long r,
                                       long s,
                                       long t,
                                       long u,
                                       long v,
                                       long w,
                                       long x,
                                       long y,
                                       long z,
                                       long A,
                                       long B,
                                       long C,
                                       long D,
                                       long E,
                                       long F, DType dtype = DType.@default, bool requires_grad = false)
            {
                return new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, dtype, requires_grad);
            }

            #endregion

        }

    }

}
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

            #region randn

            private static Tensor __randn(Tensor t)
            {
                switch(t.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Randn(t.__half);
                        return t;
                    }
                    case torch.float32:
                    {
                        MKL.Randn(t.__float);
                        return t;
                    }
                    case torch.float64:
                    {
                        MKL.Randn(t.__double);
                        return t;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.randn is not implemented for integer tensors.");
                    }
                    case torch.@bool:
                    {
                        throw new TorchException("TorchException: torch.randn is not implemented for bool tensors.");
                    }
                }
                return t;
            }

            public static Tensor randn_like(Tensor x, DType dtype = DType.@default, bool requires_grad = false)
            {
                var result = new Tensor(x.__shape, (dtype == DType.@default) ? x.dtype : dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(int[] shape, DType dtype = DType.@default, bool requires_grad = false)
            {
                var result = new Tensor(shape, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
                                       long b,
                                       long c,
                                       long d,
                                       long e,
                                       long f,
                                       long g,
                                       long h,
                                       long i,
                                       long j,
                                       long k, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long l, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long m, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long n, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long o, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long p, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long q, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long r, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long s, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long t, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long u, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long v, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long w, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long x, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long y, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long z, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long A, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long B, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long C, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long D, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long E, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, dtype, requires_grad);
                return __randn(result);
            }

            public static Tensor randn(long a,
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
                                       long F, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, dtype, requires_grad);
                return __randn(result);
            }

            #endregion

        }

    }

}
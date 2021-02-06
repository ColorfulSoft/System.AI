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

            #region uniform

            private static Tensor __uniform(Tensor t, double from, double to)
            {
                switch(t.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Uniform(t.__half, from, to);
                        return t;
                    }
                    case torch.float32:
                    {
                        MKL.Uniform(t.__float, from, to);
                        return t;
                    }
                    case torch.float64:
                    {
                        MKL.Uniform(t.__double, from, to);
                        return t;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.uniform is not implemented for integer tensors.");
                    }
                    case torch.@bool:
                    {
                        throw new TorchException("TorchException: torch.uniform is not implemented for bool tensors.");
                    }
                }
                return t;
            }

            public static Tensor uniform(long a, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f,
                                         long g, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f,
                                         long g,
                                         long h, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f,
                                         long g,
                                         long h,
                                         long i, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f,
                                         long g,
                                         long h,
                                         long i,
                                         long j, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
                                         long b,
                                         long c,
                                         long d,
                                         long e,
                                         long f,
                                         long g,
                                         long h,
                                         long i,
                                         long j,
                                         long k, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long l, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long m, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long n, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long o, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long p, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long q, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long r, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long s, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long t, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long u, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long v, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long w, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long x, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long y, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long z, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long A, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long B, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long C, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long D, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long E, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            public static Tensor uniform(long a,
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
                                         long F, double from = 0, double to = 1, DType dtype = DType.float32, bool requires_grad = false)
            {
                var result = new Tensor(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, dtype, requires_grad);
                return __uniform(result, from, to);
            }

            #endregion

        }

    }

}
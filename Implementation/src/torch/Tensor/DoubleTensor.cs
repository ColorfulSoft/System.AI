//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public sealed class DoubleTensor : Tensor
            {

                public DoubleTensor(Size shape,
                                    bool requires_grad = false) : base((int[])shape, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(bool requires_grad = false) : base(torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    bool requires_grad = false) : base(a, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    bool requires_grad = false) : base(a, b, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    bool requires_grad = false) : base(a, b, c, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d, bool requires_grad = false) : base(a, b, c, d, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e, bool requires_grad = false) : base(a, b, c, d, e, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f, bool requires_grad = false) : base(a, b, c, d, e, f, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f,
                                    long g, bool requires_grad = false) : base(a, b, c, d, e, f, g, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f,
                                    long g,
                                    long h, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f,
                                    long g,
                                    long h,
                                    long i, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f,
                                    long g,
                                    long h,
                                    long i,
                                    long j, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
                                    long b,
                                    long c,
                                    long d,
                                    long e,
                                    long f,
                                    long g,
                                    long h,
                                    long i,
                                    long j,
                                    long k, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long l, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long m, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long n, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long o, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long p, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long q, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long r, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long s, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long t, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long u, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long v, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long w, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long x, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long y, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long z, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long A, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long B, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long C, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long D, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long E, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.float64, requires_grad)
                {
                }

                public DoubleTensor(long a,
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
                                    long F, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.float64, requires_grad)
                {
                }

                public unsafe DoubleTensor(Half[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

                public unsafe DoubleTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float64, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat64(p, src.Length, this.__double);
                    }
                }

            }

        }

    }

}
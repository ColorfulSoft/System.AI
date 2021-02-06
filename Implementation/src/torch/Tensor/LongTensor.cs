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

            public sealed class LongTensor : Tensor
            {

                public LongTensor(Size shape) : base((int[])shape, torch.int64)
                {
                }

                public LongTensor() : base(torch.int64)
                {
                }

                public LongTensor(long a) : base(a, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b) : base(a, b, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c) : base(a, b, c, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d) : base(a, b, c, d, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e) : base(a, b, c, d, e, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f) : base(a, b, c, d, e, f, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g) : base(a, b, c, d, e, f, g, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h) : base(a, b, c, d, e, f, g, h, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i) : base(a, b, c, d, e, f, g, h, i, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j) : base(a, b, c, d, e, f, g, h, i, j, torch.int64)
                {
                }

                public LongTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j,
                                  long k) : base(a, b, c, d, e, f, g, h, i, j, k, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long l) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long m) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long n) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long o) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long p) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long q) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long r) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long s) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long t) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long u) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long v) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long w) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long x) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long y) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long z) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long A) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long B) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long C) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long D) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long E) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.int64)
                {
                }

                public LongTensor(long a,
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
                                  long F) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.int64)
                {
                }

                public unsafe LongTensor(Half[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

                public unsafe LongTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int64, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt64(p, src.Length, this.__int64);
                    }
                }

            }

        }

    }

}
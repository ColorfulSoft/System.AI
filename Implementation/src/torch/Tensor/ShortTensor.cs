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

            public sealed class ShortTensor : Tensor
            {

                public ShortTensor(Size shape) : base((int[])shape, torch.int16)
                {
                }

                public ShortTensor() : base(torch.int16)
                {
                }

                public ShortTensor(long a) : base(a, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b) : base(a, b, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c) : base(a, b, c, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d) : base(a, b, c, d, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e) : base(a, b, c, d, e, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f) : base(a, b, c, d, e, f, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f,
                                   long g) : base(a, b, c, d, e, f, g, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f,
                                   long g,
                                   long h) : base(a, b, c, d, e, f, g, h, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f,
                                   long g,
                                   long h,
                                   long i) : base(a, b, c, d, e, f, g, h, i, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f,
                                   long g,
                                   long h,
                                   long i,
                                   long j) : base(a, b, c, d, e, f, g, h, i, j, torch.int16)
                {
                }

                public ShortTensor(long a,
                                   long b,
                                   long c,
                                   long d,
                                   long e,
                                   long f,
                                   long g,
                                   long h,
                                   long i,
                                   long j,
                                   long k) : base(a, b, c, d, e, f, g, h, i, j, k, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long l) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long m) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long n) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long o) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long p) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long q) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long r) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long s) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long t) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long u) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long v) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long w) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long x) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long y) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long z) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long A) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long B) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long C) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long D) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long E) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.int16)
                {
                }

                public ShortTensor(long a,
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
                                   long F) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.int16)
                {
                }

                public unsafe ShortTensor(Half[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

                public unsafe ShortTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int16, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt16(p, src.Length, this.__int16);
                    }
                }

            }

        }

    }

}
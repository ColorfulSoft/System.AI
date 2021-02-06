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

            public sealed class IntTensor : Tensor
            {

                public IntTensor(Size shape) : base((int[])shape, torch.int32)
                {
                }

                public IntTensor() : base(torch.int32)
                {
                }

                public IntTensor(long a) : base(a, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b) : base(a, b, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c) : base(a, b, c, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d) : base(a, b, c, d, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e) : base(a, b, c, d, e, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f) : base(a, b, c, d, e, f, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f,
                                 long g) : base(a, b, c, d, e, f, g, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f,
                                 long g,
                                 long h) : base(a, b, c, d, e, f, g, h, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f,
                                 long g,
                                 long h,
                                 long i) : base(a, b, c, d, e, f, g, h, i, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f,
                                 long g,
                                 long h,
                                 long i,
                                 long j) : base(a, b, c, d, e, f, g, h, i, j, torch.int32)
                {
                }

                public IntTensor(long a,
                                 long b,
                                 long c,
                                 long d,
                                 long e,
                                 long f,
                                 long g,
                                 long h,
                                 long i,
                                 long j,
                                 long k) : base(a, b, c, d, e, f, g, h, i, j, k, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long l) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long m) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long n) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long o) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long p) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long q) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long r) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long s) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long t) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long u) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long v) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long w) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long x) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long y) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long z) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long A) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long B) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long C) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long D) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long E) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.int32)
                {
                }

                public IntTensor(long a,
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
                                 long F) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.int32)
                {
                }

                public unsafe IntTensor(Half[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(float* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(double* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(short* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(int* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(long* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

                public unsafe IntTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.int32, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToInt32(p, src.Length, this.__int32);
                    }
                }

            }

        }

    }

}
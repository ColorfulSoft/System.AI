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

            public sealed class ByteTensor : Tensor
            {

                public ByteTensor(Size shape) : base((int[])shape, torch.uint8)
                {
                }

                public ByteTensor() : base(torch.uint8)
                {
                }

                public ByteTensor(long a) : base(a, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b) : base(a, b, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c) : base(a, b, c, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d) : base(a, b, c, d, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e) : base(a, b, c, d, e, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f) : base(a, b, c, d, e, f, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g) : base(a, b, c, d, e, f, g, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h) : base(a, b, c, d, e, f, g, h, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i) : base(a, b, c, d, e, f, g, h, i, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j) : base(a, b, c, d, e, f, g, h, i, j, torch.uint8)
                {
                }

                public ByteTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j,
                                  long k) : base(a, b, c, d, e, f, g, h, i, j, k, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long l) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long m) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long n) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long o) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long p) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long q) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long r) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long s) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long t) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long u) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long v) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long w) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long x) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long y) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long z) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long A) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long B) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long C) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long D) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long E) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.uint8)
                {
                }

                public ByteTensor(long a,
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
                                  long F) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.uint8)
                {
                }

                public unsafe ByteTensor(Half[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(float* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(double* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(short* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(int* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(long* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

                public unsafe ByteTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.uint8, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToUint8(p, src.Length, this.__uint8);
                    }
                }

            }

        }

    }

}
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

            public sealed class BoolTensor : Tensor
            {

                public BoolTensor(Size shape) : base((int[])shape, torch.@bool)
                {
                }

                public BoolTensor() : base(torch.@bool)
                {
                }

                public BoolTensor(long a) : base(a, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b) : base(a, b, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c) : base(a, b, c, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d) : base(a, b, c, d, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e) : base(a, b, c, d, e, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f) : base(a, b, c, d, e, f, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g) : base(a, b, c, d, e, f, g, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h) : base(a, b, c, d, e, f, g, h, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i) : base(a, b, c, d, e, f, g, h, i, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j) : base(a, b, c, d, e, f, g, h, i, j, torch.@bool)
                {
                }

                public BoolTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j,
                                  long k) : base(a, b, c, d, e, f, g, h, i, j, k, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long l) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long m) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long n) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long o) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long p) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long q) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long r) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long s) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long t) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long u) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long v) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long w) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long x) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long y) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long z) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long A) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long B) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long C) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long D) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long E) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.@bool)
                {
                }

                public BoolTensor(long a,
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
                                  long F) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.@bool)
                {
                }

                public unsafe BoolTensor(Half[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(Half* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(float* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(double* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(byte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(short* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(int* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(long* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,] src)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

                public unsafe BoolTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.@bool, false);
                    fixed(bool* p = src)
                    {
                        MKL.ToBool(p, src.Length, this.__bool);
                    }
                }

            }

        }

    }

}
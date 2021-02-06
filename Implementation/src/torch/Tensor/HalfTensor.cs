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

            public sealed class HalfTensor : Tensor
            {

                public HalfTensor(Size shape,
                                  bool requires_grad = false) : base((int[])shape, torch.float16, requires_grad)
                {
                }

                public HalfTensor(bool requires_grad = false) : base(torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  bool requires_grad = false) : base(a, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  bool requires_grad = false) : base(a, b, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  bool requires_grad = false) : base(a, b, c, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d, bool requires_grad = false) : base(a, b, c, d, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e, bool requires_grad = false) : base(a, b, c, d, e, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f, bool requires_grad = false) : base(a, b, c, d, e, f, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g, bool requires_grad = false) : base(a, b, c, d, e, f, g, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
                                  long b,
                                  long c,
                                  long d,
                                  long e,
                                  long f,
                                  long g,
                                  long h,
                                  long i,
                                  long j,
                                  long k, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long l, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long m, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long n, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long o, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long p, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long q, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long r, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long s, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long t, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long u, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long v, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long w, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long x, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long y, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long z, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long A, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long B, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long C, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long D, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long E, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, torch.float16, requires_grad)
                {
                }

                public HalfTensor(long a,
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
                                  long F, bool requires_grad = false) : base(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z, A, B, C, D, E, F, torch.float16, requires_grad)
                {
                }

                public unsafe HalfTensor(Half[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(Half* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(float* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(double* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(byte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(sbyte* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(short* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(int* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(long* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)src.Length}, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

                public unsafe HalfTensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, bool requires_grad = false)
                {
                    var shape = new int[src.Rank];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        shape[i] = src.GetLength(i);
                    }
                    this.__InitializeTensor(shape, torch.float16, requires_grad);
                    fixed(bool* p = src)
                    {
                        MKL.ToFloat16(p, src.Length, this.__half);
                    }
                }

            }

        }

    }

}
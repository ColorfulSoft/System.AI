//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 17.01.2021

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace System
{

    namespace AI
    {

        internal static partial class MKL
        {

            #region Conv2d

            /*
            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             float[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                dstC = dstC / group;
                srcC = srcC / group;
                for(int b = 0; b < batch; ++b)
                {
                    for(int g = 0; g < group; ++g)
                    {
                        for(int dc = 0; dc < dstC; ++dc)
                        {
                            for(int dy = 0; dy < dstH; ++dy)
                            {
                                for(int dx = 0; dx < dstW; ++dx)
                                {
                                    float sum = 0;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ++ky)
                                        {
                                            for(int kx = 0; kx < kernelX; ++kx)
                                            {
                                                int sy = dy * strideY + ky * dilationY - padY;
                                                int sx = dx * strideX + kx * dilationX - padX;
                                                if(sy >= 0 && sy < srcH && sx >= 0 && sx < srcW)
                                                {
                                                    sum += x[(((b * group + g) * srcC + sc) * srcH + sy) * srcW + sx] * kernel[(((g * dstC + dc) * srcC + sc) * kernelY + ky) * kernelX + kx];
                                                    //sum += x[(((sy * srcW + sx) * srcC + sc) * group + g) * batch + b] * kernel[(((ky * kernelX + kx) * srcC + sc) * dstC + dc) * group + g];
                                                }
                                            }
                                        }
                                    }
                                    y[(((b * group + g) * dstC + dc) * dstH + dy) * dstW + dx] = sum;
                                    //y[(((dy * dstW + dx) * dstC + dc) * group + g) * batch + b] = sum;
                                }
                            }
                        }
                    }
                }
            }
            */

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             Half[] kernel, Half[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new Half[srcC * dstH * dstW * kernelY * kernelX];
                fixed(Half* py = y)
                {
                    var dst = py;
                    fixed(Half* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(Half* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new Half[N * K];
                                        fixed(Half* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    Half c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             float[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(float* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             double[] kernel, double[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new double[srcC * dstH * dstW * kernelY * kernelX];
                fixed(double* py = y)
                {
                    var dst = py;
                    fixed(double* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(double* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new double[N * K];
                                        fixed(double* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    double c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             byte[] kernel, Half[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new Half[srcC * dstH * dstW * kernelY * kernelX];
                fixed(Half* py = y)
                {
                    var dst = py;
                    fixed(byte* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(Half* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new Half[N * K];
                                        fixed(Half* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    Half c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             sbyte[] kernel, Half[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new Half[srcC * dstH * dstW * kernelY * kernelX];
                fixed(Half* py = y)
                {
                    var dst = py;
                    fixed(sbyte* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(Half* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new Half[N * K];
                                        fixed(Half* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    Half c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             short[] kernel, Half[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new Half[srcC * dstH * dstW * kernelY * kernelX];
                fixed(Half* py = y)
                {
                    var dst = py;
                    fixed(short* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(Half* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new Half[N * K];
                                        fixed(Half* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    Half c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             int[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(int* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(Half[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             long[] kernel, double[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new double[srcC * dstH * dstW * kernelY * kernelX];
                fixed(double* py = y)
                {
                    var dst = py;
                    fixed(long* weight = kernel)
                    {
                        fixed(Half* px = x)
                        {
                            var src = px;
                            fixed(double* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new double[N * K];
                                        fixed(double* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    double c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             Half[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(Half* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             float[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(float* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             double[] kernel, double[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new double[srcC * dstH * dstW * kernelY * kernelX];
                fixed(double* py = y)
                {
                    var dst = py;
                    fixed(double* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(double* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new double[N * K];
                                        fixed(double* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    double c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             byte[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(byte* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             sbyte[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(sbyte* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             short[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(short* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             int[] kernel, float[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new float[srcC * dstH * dstW * kernelY * kernelX];
                fixed(float* py = y)
                {
                    var dst = py;
                    fixed(int* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(float* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new float[N * K];
                                        fixed(float* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    float c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(float[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             long[] kernel, double[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new double[srcC * dstH * dstW * kernelY * kernelX];
                fixed(double* py = y)
                {
                    var dst = py;
                    fixed(long* weight = kernel)
                    {
                        fixed(float* px = x)
                        {
                            var src = px;
                            fixed(double* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new double[N * K];
                                        fixed(double* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    double c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(double[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             double[] kernel, double[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new double[srcC * dstH * dstW * kernelY * kernelX];
                fixed(double* py = y)
                {
                    var dst = py;
                    fixed(double* weight = kernel)
                    {
                        fixed(double* px = x)
                        {
                            var src = px;
                            fixed(double* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new double[N * K];
                                        fixed(double* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    double c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += a_i[k] * b_i[k];
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            public static unsafe void Conv2d(byte[] x, int batch, int srcC, int srcH, int srcW,
                                             int kernelY, int kernelX, int dilationY, int dilationX,
                                             int strideY, int strideX, int padY, int padX, int padH, int padW, int group,
                                             byte[] kernel, byte[] y, int dstC, int dstH, int dstW)
            {
                var buffer = new byte[srcC * dstH * dstW * kernelY * kernelX];
                fixed(byte* py = y)
                {
                    var dst = py;
                    fixed(byte* weight = kernel)
                    {
                        fixed(byte* px = x)
                        {
                            var src = px;
                            fixed(byte* buf = buffer)
                            {
                                int M = dstC / group;
                                int N = dstH * dstW;
                                int K = srcC * kernelY * kernelX / group;
                                for(int b = 0; b < batch; ++b)
                                {
                                    var buf_i = buf;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        for(int ky = 0; ky < kernelY; ky++)
                                        {
                                            for(int kx = 0; kx < kernelX; kx++)
                                            {
                                                for(int dy = 0; dy < dstH; ++dy)
                                                {
                                                    int sy = dy * strideY + ky * dilationY - padY;
                                                    if((sy < 0) || (sy >= srcH))
                                                    {
                                                        buf_i += dstW;
                                                        continue;
                                                    }
                                                    var src_i = src + (sc * srcH + sy) * srcW;
                                                    for(int dx = 0; dx < dstW; ++dx)
                                                    {
                                                        int sx = dx * strideX + kx * dilationX - padX;
                                                        if((sx >= 0) && (sx < srcW))
                                                        {
                                                            *buf_i++ = src_i[sx];
                                                        }
                                                        else
                                                        {
                                                            *buf_i++ = 0;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    for(int g = 0; g < group; ++g)
                                    {
                                        var A_ = weight + M * K * g;
                                        var B_ = buf + N * K * g;
                                        var C_ = dst + M * N * g;
                                        var b_ = new byte[N * K];
                                        fixed(byte* _b = b_)
                                        {
                                            var pb = _b;
                                            Parallel.For(0, N, (int j) =>
                                            {
                                                var b_i = pb + j * K;
                                                for(int k = 0; k < K; k++)
                                                {
                                                    b_i[k] = B_[k * N + j];
                                                }
                                            });
                                            Parallel.For(0, M, (int i) =>
                                            {
                                                var _C = C_ + i * N;
                                                var a_i = A_ + i * K;
                                                for(int j = 0; j < N; ++j)
                                                {
                                                    var b_i = pb + j * K;
                                                    byte c = 0;
                                                    for(int k = 0; k < K; ++k)
                                                    {
                                                        c += (byte)(a_i[k] * b_i[k]);
                                                    }
                                                    *_C++ = c;
                                                }
                                            });
                                        }
                                    }
                                    src += srcC * srcH * srcW;
                                    dst += dstC * dstH * dstW;
                                }
                            }
                        }
                    }
                }
            }

            #endregion

        }

    }

}
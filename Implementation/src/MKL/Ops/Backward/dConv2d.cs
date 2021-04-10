//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 10.04.2021

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

            #region conv2d

            public static unsafe void dConv2d(float[] x,
                                              float[] dx,
                                              int batch,
                                              int srcC,
                                              int srcH,
                                              int srcW,
                                              int kernelY,
                                              int kernelX,
                                              int dilationY,
                                              int dilationX,
                                              int strideY,
                                              int strideX,
                                              int padY,
                                              int padX,
                                              int padH,
                                              int padW,
                                              int group,
                                              float[] kernel,
                                              float[] dkernel,
                                              float[] dy,
                                              int dstC,
                                              int dstH,
                                              int dstW)
            {
                dstC = dstC / group;
                srcC = srcC / group;
                if((dkernel == null) && (dx != null))
                {
                    for(int b = 0; b < batch; ++b)
                    {
                        for(int g = 0; g < group; ++g)
                        {
                            var ybase1 = (b * group + g) * dstC;
                            var xbase1 = (b * group + g) * srcC;
                            Parallel.For(0, dstC, (int dc) =>
                            {
                                var ybase2 = (ybase1 + dc) * dstH;
                                var wbase1 = (g * dstC + dc) * srcC;
                                for(int dy_ = 0; dy_ < dstH; ++dy_)
                                {
                                    var ybase3 = (ybase2 + dy_) * dstW;
                                    var oy = dy_ * strideY - padY;
                                    for(int dx_ = 0; dx_ < dstW; ++dx_)
                                    {
                                        var grad = dy[ybase3 + dx_];
                                        var ox = dx_ * strideX - padX;
                                        for(int sc = 0; sc < srcC; ++sc)
                                        {
                                            var xbase2 = (xbase1 + sc) * srcH;
                                            var wbase2 = (wbase1 + sc) * kernelY;
                                            for(int ky = 0; ky < kernelY; ++ky)
                                            {
                                                int sy = oy + ky * dilationY;
                                                if((sy < 0) || (sy >= srcH))
                                                {
                                                    continue;
                                                }
                                                var xbase3 = (xbase2 + sy) * srcW;
                                                var wbase3 = (wbase2 + ky) * kernelX;
                                                for(int kx = 0; kx < kernelX; ++kx)
                                                {
                                                    int sx = ox + kx * dilationX;
                                                    if((sx >= 0) && (sx < srcW))
                                                    {
                                                        dx[xbase3 + sx] += grad * kernel[wbase3 + kx];
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            });
                        }
                    }
                    return;
                }
                if((dkernel != null) && (dx != null))
                {
                    for(int b = 0; b < batch; ++b)
                    {
                        for(int g = 0; g < group; ++g)
                        {
                            var ybase1 = (b * group + g) * dstC;
                            var xbase1 = (b * group + g) * srcC;
                            Parallel.For(0, dstC, (int dc) =>
                            {
                                var ybase2 = (ybase1 + dc) * dstH;
                                var wbase1 = (g * dstC + dc) * srcC;
                                for(int dy_ = 0; dy_ < dstH; ++dy_)
                                {
                                    var ybase3 = (ybase2 + dy_) * dstW;
                                    var oy = dy_ * strideY - padY;
                                    for(int dx_ = 0; dx_ < dstW; ++dx_)
                                    {
                                        var grad = dy[ybase3 + dx_];
                                        var ox = dx_ * strideX - padX;
                                        for(int sc = 0; sc < srcC; ++sc)
                                        {
                                            var xbase2 = (xbase1 + sc) * srcH;
                                            var wbase2 = (wbase1 + sc) * kernelY;
                                            for(int ky = 0; ky < kernelY; ++ky)
                                            {
                                                int sy = oy + ky * dilationY;
                                                if((sy < 0) || (sy >= srcH))
                                                {
                                                    continue;
                                                }
                                                var xbase3 = (xbase2 + sy) * srcW;
                                                var wbase3 = (wbase2 + ky) * kernelX;
                                                for(int kx = 0; kx < kernelX; ++kx)
                                                {
                                                    int sx = ox + kx * dilationX;
                                                    if((sx >= 0) && (sx < srcW))
                                                    {
                                                        dx[xbase3 + sx] += kernel[wbase3 + kx] * grad;
                                                        dkernel[wbase3 + kx] += x[xbase3 + sx] * grad;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            });
                        }
                    }
                    return;
                }
                for(int b = 0; b < batch; ++b)
                {
                    for(int g = 0; g < group; ++g)
                    {
                        var ybase1 = (b * group + g) * dstC;
                        var xbase1 = (b * group + g) * srcC;
                        Parallel.For(0, dstC, (int dc) =>
                        {
                            var ybase2 = (ybase1 + dc) * dstH;
                            var wbase1 = (g * dstC + dc) * srcC;
                            for(int dy_ = 0; dy_ < dstH; ++dy_)
                            {
                                var ybase3 = (ybase2 + dy_) * dstW;
                                var oy = dy_ * strideY - padY;
                                for(int dx_ = 0; dx_ < dstW; ++dx_)
                                {
                                    var grad = dy[ybase3 + dx_];
                                    var ox = dx_ * strideX - padX;
                                    for(int sc = 0; sc < srcC; ++sc)
                                    {
                                        var xbase2 = (xbase1 + sc) * srcH;
                                        var wbase2 = (wbase1 + sc) * kernelY;
                                        for(int ky = 0; ky < kernelY; ++ky)
                                        {
                                            int sy = oy + ky * dilationY;
                                            if((sy < 0) || (sy >= srcH))
                                            {
                                                continue;
                                            }
                                            var xbase3 = (xbase2 + sy) * srcW;
                                            var wbase3 = (wbase2 + ky) * kernelX;
                                            for(int kx = 0; kx < kernelX; ++kx)
                                            {
                                                int sx = ox + kx * dilationX;
                                                if((sx >= 0) && (sx < srcW))
                                                {
                                                   dkernel[wbase3 + kx] += x[xbase3 + sx] * grad;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        });
                    }
                }
            }

            #endregion

        }

    }

}
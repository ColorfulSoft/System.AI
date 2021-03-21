//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 21.03.2021

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

            #region avg_pool2d

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAvgPool2d(Half[] dx, int[] x_shape, System.Tuple<int, int> kernel_size, System.Tuple<int, int> stride, System.Tuple<int, int> padding, System.Tuple<int, int> dilation, Half[] dy, int[] y_shape)
            {
                int x_width = x_shape[3];
                int x_height = x_shape[2];
                int x_channel = x_shape[1];
                int x_batch = x_shape[0];
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                int stride_x = stride.Item2;
                int stride_y = stride.Item1;
                int padding_x = padding.Item2;
                int padding_y = padding.Item1;
                int dilation_x = dilation.Item2;
                int dilation_y = dilation.Item1;
                int kernel_width = kernel_size.Item2;
                int kernel_height = kernel_size.Item1;
                int norm = kernel_width * kernel_height;
                for(int b = 0; b < x_batch; b++)
                {
                    Parallel.For(0, x_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            var ix_ = ox * stride_x - padding_x;
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var iy_ = oy * stride_y - padding_y;
                                Half grad = dy[((oy * y_width + ox) * y_channel + c) * y_batch + b] / norm;
                                for(int fx = 0; fx < kernel_width; fx++)
                                {
                                    var ix = ix_ + fx * dilation_x;
                                    if((ix >= x_width) || (ix < 0))
                                    {
                                        continue;
                                    }
                                    for(int fy = 0; fy < kernel_height; fy++)
                                    {
                                        var iy = iy_ + fy * dilation_y;
                                        if((iy >= x_height) || (iy < 0))
                                        {
                                            continue;
                                        }
                                        dx[((iy * x_width + ix) * x_channel + c) * x_batch + b] += grad;
                                    }
                                }
                            }
                        }
                    });
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAvgPool2d(float[] dx, int[] x_shape, System.Tuple<int, int> kernel_size, System.Tuple<int, int> stride, System.Tuple<int, int> padding, System.Tuple<int, int> dilation, float[] dy, int[] y_shape)
            {
                int x_width = x_shape[3];
                int x_height = x_shape[2];
                int x_channel = x_shape[1];
                int x_batch = x_shape[0];
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                int stride_x = stride.Item2;
                int stride_y = stride.Item1;
                int padding_x = padding.Item2;
                int padding_y = padding.Item1;
                int dilation_x = dilation.Item2;
                int dilation_y = dilation.Item1;
                int kernel_width = kernel_size.Item2;
                int kernel_height = kernel_size.Item1;
                int norm = kernel_width * kernel_height;
                for(int b = 0; b < x_batch; b++)
                {
                    Parallel.For(0, x_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            var ix_ = ox * stride_x - padding_x;
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var iy_ = oy * stride_y - padding_y;
                                float grad = dy[((oy * y_width + ox) * y_channel + c) * y_batch + b] / norm;
                                for(int fx = 0; fx < kernel_width; fx++)
                                {
                                    var ix = ix_ + fx * dilation_x;
                                    if((ix >= x_width) || (ix < 0))
                                    {
                                        continue;
                                    }
                                    for(int fy = 0; fy < kernel_height; fy++)
                                    {
                                        var iy = iy_ + fy * dilation_y;
                                        if((iy >= x_height) || (iy < 0))
                                        {
                                            continue;
                                        }
                                        dx[((iy * x_width + ix) * x_channel + c) * x_batch + b] += grad;
                                    }
                                }
                            }
                        }
                    });
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAvgPool2d(double[] dx, int[] x_shape, System.Tuple<int, int> kernel_size, System.Tuple<int, int> stride, System.Tuple<int, int> padding, System.Tuple<int, int> dilation, double[] dy, int[] y_shape)
            {
                int x_width = x_shape[3];
                int x_height = x_shape[2];
                int x_channel = x_shape[1];
                int x_batch = x_shape[0];
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                int stride_x = stride.Item2;
                int stride_y = stride.Item1;
                int padding_x = padding.Item2;
                int padding_y = padding.Item1;
                int dilation_x = dilation.Item2;
                int dilation_y = dilation.Item1;
                int kernel_width = kernel_size.Item2;
                int kernel_height = kernel_size.Item1;
                int norm = kernel_width * kernel_height;
                for(int b = 0; b < x_batch; b++)
                {
                    Parallel.For(0, x_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            var ix_ = ox * stride_x - padding_x;
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var iy_ = oy * stride_y - padding_y;
                                double grad = dy[((oy * y_width + ox) * y_channel + c) * y_batch + b] / norm;
                                for(int fx = 0; fx < kernel_width; fx++)
                                {
                                    var ix = ix_ + fx * dilation_x;
                                    if((ix >= x_width) || (ix < 0))
                                    {
                                        continue;
                                    }
                                    for(int fy = 0; fy < kernel_height; fy++)
                                    {
                                        var iy = iy_ + fy * dilation_y;
                                        if((iy >= x_height) || (iy < 0))
                                        {
                                            continue;
                                        }
                                        dx[((iy * x_width + ix) * x_channel + c) * x_batch + b] += grad;
                                    }
                                }
                            }
                        }
                    });
                }
            }

            #endregion

        }

    }

}
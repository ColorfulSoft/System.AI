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

            #region permute

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dPermute(Half[] dx, int[] x_shape, int[] x_strides, int[] dims, Half[] dy, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; ++j)
                    {
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; ++k)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xc = index_to_loc(j, x_shape, x_strides);
                    var yc = new int[xc.Length];
                    for(int k = 0; k < yc.Length; k++)
                    {
                        yc[k] = xc[dims[k]];
                    }
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dPermute(float[] dx, int[] x_shape, int[] x_strides, int[] dims, float[] dy, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xc = index_to_loc(j, x_shape, x_strides);
                    var yc = new int[xc.Length];
                    for(int k = 0; k < yc.Length; k++)
                    {
                        yc[k] = xc[dims[k]];
                    }
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dPermute(double[] dx, int[] x_shape, int[] x_strides, int[] dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xc = index_to_loc(j, x_shape, x_strides);
                    var yc = new int[xc.Length];
                    for(int k = 0; k < yc.Length; k++)
                    {
                        yc[k] = xc[dims[k]];
                    }
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            #endregion

        }

    }

}
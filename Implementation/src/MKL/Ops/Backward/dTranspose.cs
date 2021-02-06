//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 18.01.2021

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

            #region dTranspose

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dTranspose(Half[] dx, int[] x_shape, int[] x_strides, int dim1, int dim2, Half[] dy, int[] y_shape, int[] y_strides)
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
                        var yc = index_to_loc(j, x_shape, x_strides);
                        var t = yc[dim1];
                        yc[dim1] = yc[dim2];
                        yc[dim2] = t;
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var yc = index_to_loc(j, x_shape, x_strides);
                    var t = yc[dim1];
                    yc[dim1] = yc[dim2];
                    yc[dim2] = t;
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dTranspose(float[] dx, int[] x_shape, int[] x_strides, int dim1, int dim2, float[] dy, int[] y_shape, int[] y_strides)
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
                        var yc = index_to_loc(j, x_shape, x_strides);
                        var t = yc[dim1];
                        yc[dim1] = yc[dim2];
                        yc[dim2] = t;
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var yc = index_to_loc(j, x_shape, x_strides);
                    var t = yc[dim1];
                    yc[dim1] = yc[dim2];
                    yc[dim2] = t;
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dTranspose(double[] dx, int[] x_shape, int[] x_strides, int dim1, int dim2, double[] dy, int[] y_shape, int[] y_strides)
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
                        var yc = index_to_loc(j, x_shape, x_strides);
                        var t = yc[dim1];
                        yc[dim1] = yc[dim2];
                        yc[dim2] = t;
                        dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var yc = index_to_loc(j, x_shape, x_strides);
                    var t = yc[dim1];
                    yc[dim1] = yc[dim2];
                    yc[dim2] = t;
                    dx[j] += dy[loc_to_index(yc, y_shape, y_strides)];
                }
            }

            #endregion

        }

    }

}
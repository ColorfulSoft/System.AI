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

            #region transpose

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(Half[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, Half[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(float[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, float[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(double[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, double[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(byte[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, byte[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(sbyte[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, sbyte[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(short[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, short[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(int[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, int[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(long[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, long[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Transpose(bool[] x, int[] x_shape, int[] x_strides, int dim1, int dim2, bool[] y, int[] y_shape, int[] y_strides)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
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
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            #endregion

        }

    }

}
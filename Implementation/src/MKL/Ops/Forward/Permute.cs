//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 28.03.2021

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
            public static void Permute(Half[] x, int[] x_shape, int[] x_strides, int[] dims, Half[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(float[] x, int[] x_shape, int[] x_strides, int[] dims, float[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(double[] x, int[] x_shape, int[] x_strides, int[] dims, double[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(byte[] x, int[] x_shape, int[] x_strides, int[] dims, byte[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(sbyte[] x, int[] x_shape, int[] x_strides, int[] dims, sbyte[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(short[] x, int[] x_shape, int[] x_strides, int[] dims, short[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(int[] x, int[] x_shape, int[] x_strides, int[] dims, int[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(long[] x, int[] x_shape, int[] x_strides, int[] dims, long[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Permute(bool[] x, int[] x_shape, int[] x_strides, int[] dims, bool[] y, int[] y_shape, int[] y_strides)
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
                        var xc = index_to_loc(j, x_shape, x_strides);
                        var yc = new int[xc.Length];
                        for(int k = 0; k < yc.Length; k++)
                        {
                            yc[k] = xc[dims[k]];
                        }
                        y[loc_to_index(yc, y_shape, y_strides)] = x[j];
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
                    y[loc_to_index(yc, y_shape, y_strides)] = x[j];
                }
            }

            #endregion

        }

    }

}
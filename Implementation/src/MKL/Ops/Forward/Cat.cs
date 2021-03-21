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

            #region Cat

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, byte[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, sbyte[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = (sbyte)x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, short[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, int[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(int[]))
                    {
                        var x_ = x[i] as int[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, long[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(int[]))
                    {
                        var x_ = x[i] as int[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(long[]))
                    {
                        var x_ = x[i] as long[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, Half[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(Half[]))
                    {
                        var x_ = x[i] as Half[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, float[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(int[]))
                    {
                        var x_ = x[i] as int[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(Half[]))
                    {
                        var x_ = x[i] as Half[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(float[]))
                    {
                        var x_ = x[i] as float[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, double[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    if(x[i].GetType() == typeof(byte[]))
                    {
                        var x_ = x[i] as byte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(sbyte[]))
                    {
                        var x_ = x[i] as sbyte[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(short[]))
                    {
                        var x_ = x[i] as short[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(int[]))
                    {
                        var x_ = x[i] as int[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(long[]))
                    {
                        var x_ = x[i] as long[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(Half[]))
                    {
                        var x_ = x[i] as Half[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(float[]))
                    {
                        var x_ = x[i] as float[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                    if(x[i].GetType() == typeof(double[]))
                    {
                        var x_ = x[i] as double[];
                        var x_shape_ = x_shapes[i];
                        var x_stride_ = x_strides[i];
                        for(int j = 0; j < x_.Length; j++)
                        {
                            var loc = index_to_loc(j, x_shape_, x_stride_);
                            loc[dim] += dim_;
                            y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                        }
                        dim_ += x_shape_[dim];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Cat(object[] x, int[][] x_shapes, int[][] x_strides, int dim, bool[] y, int[] y_shape, int[] y_strides)
            {
                var yLoc = new int[y_shape.Length];
                int dim_ = 0;
                for(int i = 0; i < x.Length; i++)
                {
                    var x_ = x[i] as bool[];
                    var x_shape_ = x_shapes[i];
                    var x_stride_ = x_strides[i];
                    for(int j = 0; j < x_.Length; j++)
                    {
                        var loc = index_to_loc(j, x_shape_, x_stride_);
                        loc[dim] += dim_;
                        y[loc_to_index(loc, y_shape, y_strides)] = x_[j];
                    }
                    dim_ += x_shape_[dim];
                }
            }

            #endregion

        }

    }

}
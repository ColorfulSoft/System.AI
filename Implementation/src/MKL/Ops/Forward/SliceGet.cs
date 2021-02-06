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

            #region SliceGet

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal static int loc_to_index(int[] indexes, int[] shape, int[] strides)
            {
                if(shape.Length == 0)
                {
                    return 0;
                }
                else
                {
                    if(shape.Length == 1)
                    {
                        return indexes[0];
                    }
                }
                var index = indexes[indexes.Length - 1];
                for(int i = 0; i < indexes.Length - 1; ++i)
                {
                    index += strides[i] * indexes[i];
                }
                return index;
            }

            internal static int[] index_to_loc(int index, int[] shape, int[] strides)
            {
                if(shape.Length == 0)
                {
                    return new int[0];
                }
                else
                {
                    if(shape.Length == 1)
                    {
                        return new int[]{index};
                    }
                }
                var loc = new int[shape.Length];
                for(int i = 0; i < loc.Length - 1; ++i)
                {
                    loc[i] = (int)Math.Floor(index / (float)strides[i]);
                    index -= loc[i] * strides[i];
                }
                loc[loc.Length - 1] = index;
                return loc;
            }

            internal static void SliceGet(Half[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, Half[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(float[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, float[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(double[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, double[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(byte[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, byte[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(sbyte[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, sbyte[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(short[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, short[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(int[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, int[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(long[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, long[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            internal static void SliceGet(bool[] x, int[] x_shape, int[] x_strides, int[] begin, int[] size, bool[] y, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < y.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    y[loc_to_index(loc, size, y_strides)] = x[loc_to_index(xLoc, x_shape, x_strides)];
                }
            }

            #endregion

        }

    }

}
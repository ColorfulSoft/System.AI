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

            #region dSliceGet

            internal static void dSliceGet(Half[] dx, int[] x_shape, int[] x_strides, int[] begin, int[] size, Half[] dy, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < dy.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    dx[loc_to_index(xLoc, x_shape, x_strides)] += dy[loc_to_index(loc, size, y_strides)];
                }
            }

            internal static void dSliceGet(float[] dx, int[] x_shape, int[] x_strides, int[] begin, int[] size, float[] dy, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < dy.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    dx[loc_to_index(xLoc, x_shape, x_strides)] += dy[loc_to_index(loc, size, y_strides)];
                }
            }

            internal static void dSliceGet(double[] dx, int[] x_shape, int[] x_strides, int[] begin, int[] size, double[] dy, int[] y_strides)
            {
                var xLoc = new int[x_shape.Length];
                for(int i = 0; i < dy.Length; ++i)
                {
                    var loc = index_to_loc(i, size, y_strides);
                    for(int j = 0; j < x_shape.Length; j++)
                    {
                        xLoc[j] = loc[j] + begin[j];
                    }
                    dx[loc_to_index(xLoc, x_shape, x_strides)] += dy[loc_to_index(loc, size, y_strides)];
                }
            }

            #endregion

        }

    }

}
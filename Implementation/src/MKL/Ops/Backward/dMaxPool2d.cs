//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 30.03.2021

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

            #region dMaxPool2d

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMaxPool2d(Half[] dx, long[] indices, Half[] dy, int[] y_shape)
            {
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                for(int b = 0; b < y_batch; b++)
                {
                    Parallel.For(0, y_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var i = ((b * y_channel + c) * y_height + oy) * y_width + ox;
                                dx[indices[i]] += dy[i];
                            }
                        }
                    });
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMaxPool2d(float[] dx, long[] indices, float[] dy, int[] y_shape)
            {
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                for(int b = 0; b < y_batch; b++)
                {
                    Parallel.For(0, y_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var i = ((b * y_channel + c) * y_height + oy) * y_width + ox;
                                dx[indices[i]] += dy[i];
                            }
                        }
                    });
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMaxPool2d(double[] dx, long[] indices, double[] dy, int[] y_shape)
            {
                int y_width = y_shape[3];
                int y_height = y_shape[2];
                int y_channel = y_shape[1];
                int y_batch = y_shape[0];
                for(int b = 0; b < y_batch; b++)
                {
                    Parallel.For(0, y_channel, (int c) =>
                    {
                        for(int ox = 0; ox < y_width; ox++)
                        {
                            for(int oy = 0; oy < y_height; oy++)
                            {
                                var i = ((b * y_channel + c) * y_height + oy) * y_width + ox;
                                dx[indices[i]] += dy[i];
                            }
                        }
                    });
                }
            }

            #endregion

        }

    }

}
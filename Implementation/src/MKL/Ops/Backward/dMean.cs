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

            #region mean

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMean(Half[] dx, int reduce_size, Half[] dy)
            {
                for(int i = 0; i < dy.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = dy[i] / reduce_size;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        dx[offset + j] += sum;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMean(float[] dx, int reduce_size, float[] dy)
            {
                for(int i = 0; i < dy.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = dy[i] / reduce_size;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        dx[offset + j] += sum;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dMean(double[] dx, int reduce_size, double[] dy)
            {
                for(int i = 0; i < dy.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = dy[i] / reduce_size;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        dx[offset + j] += sum;
                    }
                }
            }

            #endregion

        }

    }

}
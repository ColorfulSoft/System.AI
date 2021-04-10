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
            public static void Mean(Half[] x, int reduce_size, Half[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    Half sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum / reduce_size;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Mean(float[] x, int reduce_size, float[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0f;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum / reduce_size;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Mean(double[] x, int reduce_size, double[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0.0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum / reduce_size;
                }
            }

            #endregion

        }

    }

}
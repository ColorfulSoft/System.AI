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

            #region sum

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(Half[] x, int reduce_size, Half[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    Half sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(float[] x, int reduce_size, float[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0f;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(double[] x, int reduce_size, double[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0.0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(byte[] x, int reduce_size, byte[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    byte sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(sbyte[] x, int reduce_size, sbyte[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    sbyte sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(short[] x, int reduce_size, short[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    short sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(int[] x, int reduce_size, int[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Sum(long[] x, int reduce_size, long[] y)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var offset = i * reduce_size;
                    var sum = 0l;
                    for(int j = 0; j < reduce_size; ++j)
                    {
                        sum += x[offset + j];
                    }
                    y[i] = sum;
                }
            }

            #endregion

        }

    }

}
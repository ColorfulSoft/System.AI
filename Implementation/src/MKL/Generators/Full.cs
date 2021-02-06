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

            #region Full

            public static void Full(Half[] x, Half fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(float[] x, float fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(double[] x, double fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(byte[] x, byte fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(sbyte[] x, sbyte fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(short[] x, short fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(int[] x, int fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(long[] x, long fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            public static void Full(bool[] x, bool fill_value)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = fill_value;
                }
            }

            #endregion

        }

    }

}
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

            #region Eye

            public static void Eye(Half[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(float[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(double[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(byte[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(sbyte[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(short[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(int[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(long[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = 1;
                }
            }

            public static void Eye(bool[] x, int h, int w)
            {
                var n = Math.Min(h, w);
                for(int i = 0; i < n; i++)
                {
                    x[i * w + i] = true;
                }
            }

            #endregion

        }

    }

}
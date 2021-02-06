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

            #region Uniform

            public static void Uniform(Half[] x, double min, double max)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = (Half)(rand.NextDouble() * (max - min) + min);
                }
            }

            public static void Uniform(float[] x, double min, double max)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = (float)(rand.NextDouble() * (max - min) + min);
                }
            }

            public static void Uniform(double[] x, double min, double max)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    x[i] = rand.NextDouble() * (max - min) + min;
                }
            }

            #endregion

        }

    }

}
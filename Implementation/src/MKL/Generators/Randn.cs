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

            public static Random rand = new Random();

            #region Randn

            public static void Randn(Half[] x)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    var u1 = 1f - rand.NextDouble();
                    var u2 = 1f - rand.NextDouble();
                    var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                    x[i] = (Half)randStdNormal;
                }
            }

            public static void Randn(float[] x)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    var u1 = 1f - rand.NextDouble();
                    var u2 = 1f - rand.NextDouble();
                    var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                    x[i] = (float)randStdNormal;
                }
            }

            public static void Randn(double[] x)
            {
                for(int i = 0; i < x.Length; i++)
                {
                    var u1 = 1f - rand.NextDouble();
                    var u2 = 1f - rand.NextDouble();
                    var randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2);
                    x[i] = randStdNormal;
                }
            }

            #endregion

        }

    }

}
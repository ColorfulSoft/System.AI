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

            #region rsqrt

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Rsqrt(Half[] x, Half[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = 1 / (Half)Math.Sqrt(x[j]);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = 1 / (Half)Math.Sqrt(x[j]);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Rsqrt(float[] x, float[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = 1 / (float)Math.Sqrt(x[j]);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = 1 / (float)Math.Sqrt(x[j]);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Rsqrt(double[] x, double[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = 1 / Math.Sqrt(x[j]);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = 1 / Math.Sqrt(x[j]);
                }
            }

            #endregion

        }

    }

}
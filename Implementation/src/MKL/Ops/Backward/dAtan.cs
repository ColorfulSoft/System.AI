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

            #region atan

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAtan(Half[] x, Half[] dx, Half[] dy)
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
                        dx[j] += 1 / (1 + x[j] * x[j]) * dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] += 1 / (1 + x[j] * x[j]) * dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAtan(float[] x, float[] dx, float[] dy)
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
                        dx[j] += 1f / (1f + x[j] * x[j]) * dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] += 1f / (1f + x[j] * x[j]) * dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dAtan(double[] x, double[] dx, double[] dy)
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
                        dx[j] += 1f / (1f + x[j] * x[j]) * dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] += 1f / (1f + x[j] * x[j]) * dy[j];
                }
            }

            #endregion

        }

    }

}
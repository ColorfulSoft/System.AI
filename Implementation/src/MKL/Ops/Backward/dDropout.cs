//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 20.03.2021

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

            #region dropout

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dDropout(Half[] dx, double p, bool[] dropmap, Half[] dy)
            {
                var k = (Half)(1 - p);
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(!dropmap[j])
                        {
                            dx[j] += dy[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(!dropmap[j])
                    {
                        dx[j] += dy[j] / k;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dDropout(float[] dx, double p, bool[] dropmap, float[] dy)
            {
                var k = (float)(1 - p);
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(!dropmap[j])
                        {
                            dx[j] += dy[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(!dropmap[j])
                    {
                        dx[j] += dy[j] / k;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dDropout(double[] dx, double p, bool[] dropmap, double[] dy)
            {
                var k = 1 - p;
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(!dropmap[j])
                        {
                            dx[j] += dy[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(!dropmap[j])
                    {
                        dx[j] += dy[j] / k;
                    }
                }
            }

            #endregion

        }

    }

}
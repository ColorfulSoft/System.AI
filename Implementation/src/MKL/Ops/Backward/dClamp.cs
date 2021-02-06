//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 20.01.2021

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

            #region dClamp

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dClamp(Half[] x, Half[] dx, double min, double max, Half[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var HMin = (Half)min;
                var HMax = (Half)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            continue;
                        }
                        if(xv > max)
                        {
                            continue;
                        }
                        dx[j] += dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        continue;
                    }
                    if(xv > max)
                    {
                        continue;
                    }
                    dx[j] += dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dClamp(float[] x, float[] dx, double min, double max, float[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var HMin = (float)min;
                var HMax = (float)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            continue;
                        }
                        if(xv > max)
                        {
                            continue;
                        }
                        dx[j] += dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        continue;
                    }
                    if(xv > max)
                    {
                        continue;
                    }
                    dx[j] += dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dClamp(double[] x, double[] dx, double min, double max, double[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var HMin = min;
                var HMax = max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            continue;
                        }
                        if(xv > max)
                        {
                            continue;
                        }
                        dx[j] += dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        continue;
                    }
                    if(xv > max)
                    {
                        continue;
                    }
                    dx[j] += dy[j];
                }
            }

            #endregion

        }

    }

}
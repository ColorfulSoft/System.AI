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
            public static void Dropout(Half[] x, double p, Half[] y, bool[] dropmap)
            {
                var k = (Half)(1 - p);
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var rand = new Random(i);
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(rand.NextDouble() < p)
                        {
                            y[j] = 0;
                            dropmap[j] = true;
                        }
                        else
                        {
                            y[j] = x[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                var rand_ = new Random();
                for(int j = start_; j < end_; j++)
                {
                    if(rand_.NextDouble() < p)
                    {
                        y[j] = 0;
                        dropmap[j] = true;
                    }
                    else
                    {
                        y[j] = x[j] / k;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Dropout(float[] x, double p, float[] y, bool[] dropmap)
            {
                var k = (float)(1 - p);
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var rand = new Random(i);
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(rand.NextDouble() < p)
                        {
                            y[j] = 0;
                            dropmap[j] = true;
                        }
                        else
                        {
                            y[j] = x[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                var rand_ = new Random();
                for(int j = start_; j < end_; j++)
                {
                    if(rand_.NextDouble() < p)
                    {
                        y[j] = 0;
                        dropmap[j] = true;
                    }
                    else
                    {
                        y[j] = x[j] / k;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Dropout(double[] x, double p, double[] y, bool[] dropmap)
            {
                var k = 1 - p;
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var rand = new Random(i);
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        if(rand.NextDouble() < p)
                        {
                            y[j] = 0;
                            dropmap[j] = true;
                        }
                        else
                        {
                            y[j] = x[j] / k;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                var rand_ = new Random();
                for(int j = start_; j < end_; j++)
                {
                    if(rand_.NextDouble() < p)
                    {
                        y[j] = 0;
                        dropmap[j] = true;
                    }
                    else
                    {
                        y[j] = x[j] / k;
                    }
                }
            }

            #endregion

        }

    }

}
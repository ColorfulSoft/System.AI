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

            #region relu

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(Half[] x, Half[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(float[] x, float[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(double[] x, double[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(byte[] x, byte[] y)
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
                        y[j] = x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(sbyte[] x, sbyte[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(short[] x, short[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(int[] x, int[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void ReLU(long[] x, long[] y)
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
                        if(x[j] > 0)
                        {
                            y[j] = x[j];
                        }
                        else
                        {
                            y[j] = 0;
                        }
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    if(x[j] > 0)
                    {
                        y[j] = x[j];
                    }
                    else
                    {
                        y[j] = 0;
                    }
                }
            }

            #endregion

        }

    }

}
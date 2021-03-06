﻿//***************************************************************************************************
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

            #region abs

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(Half[] x, Half[] y)
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
                            y[j] = -x[j];
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
                        y[j] = -x[j];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(float[] x, float[] y)
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
                            y[j] = -x[j];
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
                        y[j] = -x[j];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(double[] x, double[] y)
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
                            y[j] = -x[j];
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
                        y[j] = -x[j];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(byte[] x, byte[] y)
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
            public static void Abs(sbyte[] x, sbyte[] y)
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
                            y[j] = (sbyte)(-x[j]);
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
                        y[j] = (sbyte)(-x[j]);
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(short[] x, short[] y)
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
                            y[j] = (short)(-x[j]);
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
                        y[j] = (short)(-x[j]);
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(int[] x, int[] y)
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
                            y[j] = -x[j];
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
                        y[j] = -x[j];
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Abs(long[] x, long[] y)
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
                            y[j] = -x[j];
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
                        y[j] = -x[j];
                    }
                }
            }

            #endregion

        }

    }

}
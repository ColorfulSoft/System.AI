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

            #region clamp

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(Half[] x, double min, double max, Half[] y)
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
                            y[j] = HMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = HMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = HMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = HMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(float[] x, double min, double max, float[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var FMin = (float)min;
                var FMax = (float)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = FMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = FMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = FMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = FMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(double[] x, double min, double max, double[] y)
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
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = min;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = max;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = min;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = max;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(byte[] x, double min, double max, byte[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var BMin = (byte)min;
                var BMax = (byte)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = BMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = BMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = BMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = BMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(sbyte[] x, double min, double max, sbyte[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var SMin = (sbyte)min;
                var SMax = (sbyte)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = SMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = SMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = SMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = SMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(short[] x, double min, double max, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var SMin = (short)min;
                var SMax = (short)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = SMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = SMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = SMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = SMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(int[] x, double min, double max, int[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var IMin = (int)min;
                var IMax = (int)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = IMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = IMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = IMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = IMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Clamp(long[] x, double min, double max, long[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = x.Length / Threads;
                var TaskRemainder = x.Length % Threads;
                var LMin = (long)min;
                var LMax = (long)max;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        var xv = x[j];
                        if(xv < min)
                        {
                            y[j] = LMin;
                            continue;
                        }
                        if(xv > max)
                        {
                            y[j] = LMax;
                            continue;
                        }
                        y[j] = xv;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    var xv = x[j];
                    if(xv < min)
                    {
                        y[j] = LMin;
                        continue;
                    }
                    if(xv > max)
                    {
                        y[j] = LMax;
                        continue;
                    }
                    y[j] = xv;
                }
            }

            #endregion

        }

    }

}
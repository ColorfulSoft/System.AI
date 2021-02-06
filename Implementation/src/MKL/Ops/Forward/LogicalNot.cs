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

            #region logical_not

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(Half[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(float[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(double[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(byte[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(sbyte[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(short[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(int[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, bool[] y)
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
                        y[j] = !(x[j] != 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !(x[j] != 0);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, Half[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, float[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, double[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, byte[] y)
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
                        y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, sbyte[] y)
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
                        y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, short[] y)
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
                        y[j] = (x[j] != 0) ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, int[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(long[] x, long[] y)
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
                        y[j] = (x[j] != 0) ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (x[j] != 0) ? 0 : 1;
                }
            }
            //
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, bool[] y)
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
                        y[j] = !x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = !x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, Half[] y)
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
                        y[j] = x[j] ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, float[] y)
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
                        y[j] = x[j] ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, double[] y)
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
                        y[j] = x[j] ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, byte[] y)
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
                        y[j] = x[j] ? (byte)0 : (byte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? (byte)0 : (byte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, sbyte[] y)
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
                        y[j] = x[j] ? (sbyte)0 : (sbyte)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? (sbyte)0 : (sbyte)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, short[] y)
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
                        y[j] = x[j] ? (short)0 : (short)1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? (short)0 : (short)1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, int[] y)
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
                        y[j] = x[j] ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? 0 : 1;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void LogicalNot(bool[] x, long[] y)
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
                        y[j] = x[j] ? 0 : 1;
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = x[j] ? 0 : 1;
                }
            }

            #endregion

        }

    }

}
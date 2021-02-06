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

            #region to_int16

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(Half* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(float* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(double* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(sbyte* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(byte* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(short* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
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
            public unsafe static void ToInt16(int* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(long* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)x[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)x[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public unsafe static void ToInt16(bool* x, int length, short[] y)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = length / Threads;
                var TaskRemainder = length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        y[j] = (short)(x[j] ? 1 : 0);
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    y[j] = (short)(x[j] ? 1 : 0);
                }
            }

            #endregion

        }

    }

}
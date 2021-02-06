﻿//***************************************************************************************************
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

            #region dNeg

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dNeg(Half[] dx, Half[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        dx[j] -= dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] -= dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dNeg(float[] dx, float[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        dx[j] -= dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] -= dy[j];
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void dNeg(double[] dx, double[] dy)
            {
                var Threads = Environment.ProcessorCount;
                var TaskPart = dx.Length / Threads;
                var TaskRemainder = dx.Length % Threads;
                Parallel.For(0, Threads, (int i) =>
                {
                    var start = TaskPart * i;
                    var end = start + TaskPart;
                    for(int j = start; j < end; j++)
                    {
                        dx[j] -= dy[j];
                    }
                });
                var start_ = TaskPart * Threads;
                var end_ = start_ + TaskRemainder;
                for(int j = start_; j < end_; j++)
                {
                    dx[j] -= dy[j];
                }
            }

            #endregion

        }

    }

}
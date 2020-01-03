//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2019.

using System;
using System.Threading.Tasks;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public static partial class functional
                {

                    [ThreadStatic]
                    private static Random __random = new Random();

                    internal static double __rand()
                    {
                        if (__random == null) 
                        {
                            __random = new Random();
                        }
                        return __random.NextDouble();
                    }

                    ///<summary>During training, randomly zeroes some of the elements of the input tensor with probability p using samples from a Bernoulli distribution. Each channel will be zeroed out independently on every forward call.</summary>
                    ///<param name = "x">Input tensor.</param>
                    public static Tensor dropout(Tensor x, float p = 0.5f, bool training = false)
                    {
                        if(x.__restricted)
                        {
                            x = x.clone();
                        }
                        var Result = x.zeros_like(requires_grad: x.requires_grad);
                        var dropped = new bool[x.__width * x.__height * x.__depth * x.__time * x.__batch];
                        switch(Result.dtype)
                        {
                            case torch.dtype.float32:
                            {
                                var src = x.__data_float32;
                                var dest = Result.__data_float32;
                                var Threads = Environment.ProcessorCount;
                                var TaskPart = src.Length / Threads;
                                if(training)
                                {
                                    Parallel.For(0, Threads, (long tp) =>
                                    {
                                        for(long i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                                        {
                                            if(__rand() < p)
                                            {
                                                dropped[i] = true;
                                            }
                                            else
                                            {
                                                dest[i] = src[i] / (1f - p);
                                                dropped[i] = false;
                                            }
                                        }
                                    });
                                    for(long i = Threads * TaskPart; i < src.Length; i++)
                                    {
                                        if(__rand() < p)
                                        {
                                            dropped[i] = true;
                                        }
                                        else
                                        {
                                            dest[i] = src[i] / (1f - p);
                                            dropped[i] = false;
                                        }
                                    }
                                }
                                else
                                {
                                    Parallel.For(0, Threads, (long tp) =>
                                    {
                                        for(long i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                                        {
                                            dest[i] = src[i];
                                        }
                                    });
                                    for(long i = Threads * TaskPart; i < src.Length; i++)
                                    {
                                        dest[i] = src[i];
                                    }
                                }
                                break;
                            }
                            case torch.dtype.uint8:
                            case torch.dtype.int64:
                            {
                                throw new torch.TorchException("TorchException: nn.functional.dropout is not implemented for int tensors.");
                            }
                        }
                        if(x.requires_grad)
                        {
                            Result.__backward_fn = () =>
                            {
                                switch(x.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        var srcDW = x.__grad_float32;
                                        var destDW = Result.__grad_float32;
                                        var Threads = Environment.ProcessorCount;
                                        var TaskPart = srcDW.Length / Threads;
                                        Parallel.For(0, Threads, (long tp) =>
                                        {
                                            for(long i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                                            {
                                                if(!(dropped[i]))
                                                {
                                                    srcDW[i] += destDW[i];
                                                }
                                            }
                                        });
                                        for(long i = Threads * TaskPart; i < srcDW.Length; i++)
                                        {
                                            if(!(dropped[i]))
                                            {
                                                srcDW[i] += destDW[i];
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        return Result;
                    }

                }

            }

        }

    }

}
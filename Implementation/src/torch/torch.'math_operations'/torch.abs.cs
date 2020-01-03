//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;
using System.Threading.Tasks;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static Tensor abs(Tensor x)
            {
                if(x.__restricted)
                {
                    x = x.clone();
                }
                var Result = x.zeros_like(requires_grad: x.requires_grad);
                switch(Result.dtype)
                {
                    case torch.dtype.float32:
                    {
                        var src = x.__data_float32;
                        var dest = Result.__data_float32;
                        var Threads = Environment.ProcessorCount;
                        var TaskPart = src.Length / Threads;
                        Parallel.For(0, Threads, (int tp) =>
                        {
                            for(int i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                            {
                                var v = src[i];
                                dest[i] = (float)Math.Abs(v);
                            }
                        });
                        for(int i = Threads * TaskPart; i < src.Length; i++)
                        {
                            var v = src[i];
                            dest[i] = (float)Math.Abs(v);
                        }
                        break;
                    }
                    case torch.dtype.uint8:
                    {
                        var src = x.__data_uint8;
                        var dest = Result.__data_uint8;
                        var Threads = Environment.ProcessorCount;
                        var TaskPart = src.Length / Threads;
                        Parallel.For(0, Threads, (int tp) =>
                        {
                            for(int i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                            {
                                dest[i] = src[i];
                            }
                        });
                        for(int i = Threads * TaskPart; i < src.Length; i++)
                        {
                            dest[i] = src[i];
                        }
                        break;
                    }
                    case torch.dtype.int64:
                    {
                        var src = x.__data_int64;
                        var dest = Result.__data_int64;
                        var Threads = Environment.ProcessorCount;
                        var TaskPart = src.Length / Threads;
                        Parallel.For(0, Threads, (int tp) =>
                        {
                            for(int i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                            {
                                var v = src[i];
                                dest[i] = Math.Abs(v);
                            }
                        });
                        for(int i = Threads * TaskPart; i < src.Length; i++)
                        {
                            var v = src[i];
                            dest[i] = Math.Abs(v);
                        }
                        break;
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
                                var srcW = x.__data_float32;
                                var srcDW = x.__grad_float32;
                                var destDW = Result.__grad_float32;
                                var Threads = Environment.ProcessorCount;
                                var TaskPart = srcW.Length / Threads;
                                Parallel.For(0, Threads, (int tp) =>
                                {
                                    for(int i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                                    {
                                        var vW = srcW[i];
                                        var vDW = destDW[i];
                                        srcDW[i] += (vW > 0f) ? vDW : (-vDW);
                                    }
                                });
                                for(int i = Threads * TaskPart; i < srcW.Length; i++)
                                {
                                    var vW = srcW[i];
                                    var vDW = destDW[i];
                                    srcDW[i] += (vW > 0f) ? vDW : (-vDW);
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
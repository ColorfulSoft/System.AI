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

            ///<summary>Applies the element-wise function: Tanh(x) = tanh(x) = (e^x - e^(-x))/(e^x + e^(-x)).</summary>
            ///<param name = "x">Input tensor.</param>
            public static Tensor tanh(Tensor x)
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
                                dest[i] = (float)Math.Tanh(v);
                            }
                        });
                        for(int i = Threads * TaskPart; i < src.Length; i++)
                        {
                            var v = src[i];
                            dest[i] = (float)Math.Tanh(v);
                        }
                        break;
                    }
                    case torch.dtype.uint8:
                    case torch.dtype.int64:
                    {
                        throw new torch.TorchException("TorchException: torch.tanh is not implemented for int tensors.");
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
                                var destW = Result.__data_float32;
                                var srcDW = x.__grad_float32;
                                var destDW = Result.__grad_float32;
                                var Threads = Environment.ProcessorCount;
                                var TaskPart = destW.Length / Threads;
                                Parallel.For(0, Threads, (int tp) =>
                                {
                                    for(int i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                                    {
                                        var vW = destW[i];
                                        var vDW = destDW[i];
                                        srcDW[i] += (1f - vW * vW) * vDW;
                                    }
                                });
                                for(int i = Threads * TaskPart; i < destW.Length; i++)
                                {
                                    var vW = destW[i];
                                    var vDW = destDW[i];
                                    srcDW[i] += (1f - vW * vW) * vDW;
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
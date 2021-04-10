//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region Reduction Ops

            public static Tensor sum(this Tensor x, Union<int, int[]> dim, bool keepdim = false)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.sum is not implemented for bool tensors.");
                }
                int[] dims;
                if((int[])dim != null)
                {
                    dims = (int[])dim;
                }
                else
                {
                    dims = new int[]{(int)dim};
                }
                for(int i = 0; i < dims.Length; i++)
                {
                    dims[i] = (dims[i] >= 0) ? dims[i] : (x.__shape.Length + dims[i]);
                }
                var shape_permutation = new int[x.__shape.Length];
                int p1 = 0;
                int p2 = 0;
                int p3 = 0;
                var y_shape = new int[keepdim ? x.__shape.Length : (x.__shape.Length - dims.Length)];
                var reduce_size = 1;
                for(int i = 0; i < x.__shape.Length; i++)
                {
                    if(dims.Contains(i))
                    {
                        reduce_size *= x.__shape[i];
                        if(keepdim)
                        {
                            y_shape[p3++] = 1;
                        }
                        shape_permutation[p2++ + (x.__shape.Length - dims.Length)] = i;
                    }
                    else
                    {
                        shape_permutation[p1++] = i;
                        y_shape[p3++] = x.__shape[i];
                    }
                }
                var xp = x.permute(shape_permutation);
                var y = new Tensor(y_shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Sum(xp.__half, reduce_size, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSum(x.grad.__half, reduce_size, y.grad.__half);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.float32:
                    {
                        MKL.Sum(xp.__float, reduce_size, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSum(x.grad.__float, reduce_size, y.grad.__float);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.float64:
                    {
                        MKL.Sum(xp.__double, reduce_size, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSum(x.grad.__double, reduce_size, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    {
                        MKL.Sum(xp.__int8, reduce_size, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Sum(xp.__uint8, reduce_size, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Sum(xp.__int16, reduce_size, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Sum(xp.__int32, reduce_size, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Sum(xp.__int64, reduce_size, y.__int64);
                        break;
                    }
                }
                return y;
            }

            public static Tensor mean(this Tensor x, Union<int, int[]> dim, bool keepdim = false)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.mean is not implemented for bool tensors.");
                }
                int[] dims;
                if((int[])dim != null)
                {
                    dims = (int[])dim;
                }
                else
                {
                    dims = new int[]{(int)dim};
                }
                for(int i = 0; i < dims.Length; i++)
                {
                    dims[i] = (dims[i] >= 0) ? dims[i] : (x.__shape.Length + dims[i]);
                }
                var shape_permutation = new int[x.__shape.Length];
                int p1 = 0;
                int p2 = 0;
                int p3 = 0;
                var y_shape = new int[keepdim ? x.__shape.Length : (x.__shape.Length - dims.Length)];
                var reduce_size = 1;
                for(int i = 0; i < x.__shape.Length; i++)
                {
                    if(dims.Contains(i))
                    {
                        reduce_size *= x.__shape[i];
                        if(keepdim)
                        {
                            y_shape[p3++] = 1;
                        }
                        shape_permutation[p2++ + (x.__shape.Length - dims.Length)] = i;
                    }
                    else
                    {
                        shape_permutation[p1++] = i;
                        y_shape[p3++] = x.__shape[i];
                    }
                }
                var xp = x.permute(shape_permutation);
                var y = new Tensor(y_shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Mean(xp.__half, reduce_size, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dMean(x.grad.__half, reduce_size, y.grad.__half);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.float32:
                    {
                        MKL.Mean(xp.__float, reduce_size, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dMean(x.grad.__float, reduce_size, y.grad.__float);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.float64:
                    {
                        MKL.Mean(xp.__double, reduce_size, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dMean(x.grad.__double, reduce_size, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.mean is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            #endregion

        }

    }

}
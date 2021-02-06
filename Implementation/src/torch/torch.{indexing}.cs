//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region Indexing, Slicing, Joining, Mutating Ops

            public static Tensor squeeze(this Tensor input, int dim)
            {
                var idim = input.__shape;
                var odim = new int[idim.Length - 1];
                var odim_i = 0;
                for(int i = 0; i < idim.Length; ++i)
                {
                    if(dim == i)
                    {
                        continue;
                    }
                    odim[odim_i] = idim[i];
                    odim_i += 1;
                }
                var y = new Tensor(odim);
                y.__half = input.__half;
                y.__float = input.__float;
                y.__double = input.__double;
                y.__uint8 = input.__uint8;
                y.__int8 = input.__int8;
                y.__int16 = input.__int16;
                y.__int32 = input.__int32;
                y.__int64 = input.__int64;
                y.__bool = input.__bool;
                y.grad = input.grad;
                y.requires_grad = input.requires_grad;
                y.__backward_fn = input.__backward_fn;
                y.dtype = input.dtype;
                return y;
            }

            public static Tensor unsqueeze(this Tensor input, int dim)
            {
                var idim = input.__shape;
                var odim = new int[idim.Length + 1];
                if(dim >= 0)
                {
                    odim[dim] = 1;
                }
                else
                {
                    odim[idim.Length + dim] = 1;
                }
                bool m1 = false;
                for(int i = 0; i < odim.Length; ++i)
                {
                    if(odim[i] == 1)
                    {
                        m1 = true;
                        continue;
                    }
                    else
                    {
                        odim[i] = idim[(m1) ? (i - 1) : i];
                    }
                }
                var y = new Tensor(odim);
                y.__half = input.__half;
                y.__float = input.__float;
                y.__double = input.__double;
                y.__uint8 = input.__uint8;
                y.__int8 = input.__int8;
                y.__int16 = input.__int16;
                y.__int32 = input.__int32;
                y.__int64 = input.__int64;
                y.__bool = input.__bool;
                y.grad = input.grad;
                y.requires_grad = input.requires_grad;
                y.__backward_fn = input.__backward_fn;
                y.dtype = input.dtype;
                return y;
            }

            public static Tensor transpose(this Tensor x, int dim1, int dim2)
            {
                var shape = new int[x.__shape.Length];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = x.__shape[i];
                }
                var t = shape[dim2];
                shape[dim2] = shape[dim1];
                shape[dim1] = t;
                var y = new Tensor(shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Transpose(x.__half, x.__shape, x.__strides, dim1, dim2, y.__half, y.__shape, y.__strides);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTranspose(x.grad.__half, x.__shape, x.__strides, dim1, dim2, y.grad.__half, y.__shape, y.__strides);
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
                        MKL.Transpose(x.__float, x.__shape, x.__strides, dim1, dim2, y.__float, y.__shape, y.__strides);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTranspose(x.grad.__float, x.__shape, x.__strides, dim1, dim2, y.grad.__float, y.__shape, y.__strides);
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
                        MKL.Transpose(x.__double, x.__shape, x.__strides, dim1, dim2, y.__double, y.__shape, y.__strides);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTranspose(x.grad.__double, x.__shape, x.__strides, dim1, dim2, y.grad.__double, y.__shape, y.__strides);
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
                        MKL.Transpose(x.__int8, x.__shape, x.__strides, dim1, dim2, y.__int8, y.__shape, y.__strides);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Transpose(x.__uint8, x.__shape, x.__strides, dim1, dim2, y.__uint8, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Transpose(x.__int16, x.__shape, x.__strides, dim1, dim2, y.__int16, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Transpose(x.__int32, x.__shape, x.__strides, dim1, dim2, y.__int32, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Transpose(x.__int64, x.__shape, x.__strides, dim1, dim2, y.__int64, y.__shape, y.__strides);
                        break;
                    }
                    case torch.@bool:
                    {
                        MKL.Transpose(x.__bool, x.__shape, x.__strides, dim1, dim2, y.__bool, y.__shape, y.__strides);
                        break;
                    }
                }
                return y;
            }

            #endregion

        }

    }

}
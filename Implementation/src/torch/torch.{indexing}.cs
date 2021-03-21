//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
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

            public static Tensor flatten(this Tensor x, int start_dim = 0, int end_dim = -1)
            {
                if(end_dim < 0)
                {
                    end_dim = x.__shape.Length + end_dim;
                }
                var shape = new int[x.__shape.Length - (end_dim - start_dim)];
                for(int i = 0; i < start_dim; i++)
                {
                    shape[i] = x.__shape[i];
                }
                var n = 1;
                for(int i = start_dim; i <= end_dim; i++)
                {
                    n *= x.__shape[i];
                }
                shape[start_dim] = n;
                for(int i = end_dim + 1; i < x.__shape.Length; i++)
                {
                    shape[i - end_dim + start_dim] = x.__shape[i];
                }
                var y = new Tensor(shape);
                y.dtype = x.dtype;
                y.__half = x.__half;
                y.__float = x.__float;
                y.__double = x.__double;
                y.__int8 = x.__int8;
                y.__uint8 = x.__uint8;
                y.__int16 = x.__int16;
                y.__int32 = x.__int32;
                y.__int64 = x.__int64;
                y.__bool = x.__bool;
                y.requires_grad = x.requires_grad;
                if(y.requires_grad)
                {
                    y.grad = x.grad.flatten(start_dim, end_dim);
                    y.__backward_fn = () =>
                    {
                        if((y.grad.__half != x.grad.__half) ||
                           (y.grad.__float != x.grad.__float) ||
                           (y.grad.__double != x.grad.__double))
                        {
                            switch(x.dtype)
                            {
                                case torch.float16:
                                {
                                    var dy = y.grad.__half;
                                    var dx = x.grad.__half;
                                    for(int i = 0; i < dy.Length; i++)
                                    {
                                        dx[i] += dy[i];
                                    }
                                    break;
                                }
                                case torch.float32:
                                {
                                    var dy = y.grad.__float;
                                    var dx = x.grad.__float;
                                    for(int i = 0; i < dy.Length; i++)
                                    {
                                        dx[i] += dy[i];
                                    }
                                    break;
                                }
                                case torch.float64:
                                {
                                    var dy = y.grad.__double;
                                    var dx = x.grad.__double;
                                    for(int i = 0; i < dy.Length; i++)
                                    {
                                        dx[i] += dy[i];
                                    }
                                    break;
                                }
                            }
                        }
                        if(x.__backward_fn != null)
                        {
                            x.__backward_fn();
                        }
                    };
                }
                return y;
            }

            public static bool is_floating_point(this DType dtype)
            {
                if((dtype == torch.float16) || (dtype == torch.float32) || (dtype == torch.float64))
                {
                    return true;
                }
                return false;
            }

            public static int @sizeof(this DType dtype)
            {
                switch(dtype)
                {
                    case torch.int8:
                    case torch.uint8:
                    case torch.@bool:
                    {
                        return 1;
                    }
                    case torch.float16:
                    case torch.int16:
                    {
                        return 2;
                    }
                    case torch.int32:
                    case torch.float32:
                    {
                        return 4;
                    }
                    case torch.int64:
                    case torch.float64:
                    {
                        return 8;
                    }
                }
                return -1;
            }

            public static Tensor cat(Tensor[] x, int dim)
            {
                var dtype = x[0].dtype;
                var data = new object[x.Length];
                var shapes = new int[x.Length][];
                var strides = new int[x.Length][];
                var y_shape = new int[x[0].__shape.Length];
                for(int i = 0; i < x[0].__shape.Length; i++)
                {
                    y_shape[i] = x[0].__shape[i];
                }
                var requires_grad = false;
                for(int i = 0; i < x.Length; i++)
                {
                    var t = x[i];
                    if(t.requires_grad)
                    {
                        requires_grad = true;
                    }
                    shapes[i] = t.__shape;
                    strides[i] = t.__strides;
                    if(i > 0)
                    {
                        if(t.__shape.Length != y_shape.Length)
                        {
                            throw new TorchException("TorchException: Invalid tensor sizes for torch.cat: the number of dimensions must be the same.");
                        }
                        for(int j = 0; j < t.__shape.Length; j++)
                        {
                            if(j == dim)
                            {
                                y_shape[j] += t.__shape[j];
                                continue;
                            }
                            if(t.__shape[j] != y_shape[j])
                            {
                                throw new TorchException(string.Format("TorchException: Invalid tensor sizes for torch.cat: impossible to match shapes {0} and {1} of dimention {2} of tensors {3} and {4}.", t.__shape[j], y_shape[j], j, i - 1, i));
                            }
                        }
                    }
                    switch(t.dtype)
                    {
                        case torch.uint8:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__uint8;
                            break;
                        }
                        case torch.int8:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__int8;
                            if(dtype == torch.uint8)
                            {
                                dtype = torch.int8;
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__int16;
                            if(@sizeof(dtype) == 1)
                            {
                                dtype = torch.int16;
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__int32;
                            if(@sizeof(dtype) < 4)
                            {
                                dtype = torch.int32;
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__int64;
                            if(@sizeof(dtype) == 8)
                            {
                                dtype = torch.int64;
                            }
                            break;
                        }
                        case torch.half:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__half;
                            if(!dtype.is_floating_point())
                            {
                                switch(@sizeof(dtype))
                                {
                                    case 1:
                                    case 2:
                                    {
                                        dtype = torch.float16;
                                        break;
                                    }
                                    case 4:
                                    {
                                        dtype = torch.float32;
                                        break;
                                    }
                                    case 8:
                                    {
                                        dtype = torch.float64;
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__float;
                            if(!dtype.is_floating_point())
                            {
                                switch(@sizeof(dtype))
                                {
                                    case 1:
                                    case 2:
                                    case 4:
                                    {
                                        dtype = torch.float32;
                                        break;
                                    }
                                    case 8:
                                    {
                                        dtype = torch.float64;
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                if(dtype == torch.float16)
                                {
                                    dtype = torch.float32;
                                    break;
                                }
                                if(dtype == torch.float64)
                                {
                                    dtype = torch.float64;
                                    break;
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            if(dtype == torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__double;
                            dtype = torch.float64;
                            break;
                        }
                        case torch.@bool:
                        {
                            if(dtype != torch.@bool)
                            {
                                throw new TorchException("TorchException: unable to cat bool tensor and non-bool tensor.");
                            }
                            data[i] = t.__bool;
                            break;
                        }
                    }
                }
                var y = new Tensor(y_shape, dtype, (!torch.autograd.grad_mode.no_grad.prev) && requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__half, y.__shape, y.__strides);
                        break;
                    }
                    case torch.float32:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__float, y.__shape, y.__strides);
                        break;
                    }
                    case torch.float64:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__double, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int8:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__int8, y.__shape, y.__strides);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__uint8, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__int16, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__int32, y.__shape, y.__strides);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__int64, y.__shape, y.__strides);
                        break;
                    }
                    case torch.@bool:
                    {
                        MKL.Cat(data, shapes, strides, dim, y.__bool, y.__shape, y.__strides);
                        break;
                    }
                }
                return y;
            }

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
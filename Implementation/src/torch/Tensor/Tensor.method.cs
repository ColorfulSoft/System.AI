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

            public sealed partial class Tensor
            {

                public Tensor clone()
                {
                    var sz = this.size();
                    var result = (sz.__size == null) ? (torch.tensor(0f, this.dtype, this.requires_grad)) : (new Tensor(sz, this.dtype, this.requires_grad));
                    if(this.__restricted)
                    {
                        switch(this.dtype)
                        {
                            case torch.float32:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    result.__data_float32[((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b] = this.__unsafe_get_value(this.__data_float32, w, h, d, t, b);
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.uint8:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    result.__data_uint8[((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b] = this.__unsafe_get_value(this.__data_uint8, w, h, d, t, b);
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.int64:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    result.__data_int64[((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b] = this.__unsafe_get_value(this.__data_int64, w, h, d, t, b);
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                        }
                        if(result.requires_grad)
                        {
                            result.__backward_fn = () =>
                            {
                                switch(this.dtype)
                                {
                                    case torch.float32:
                                    {
                                        Parallel.For(0, this.__width, (long w) =>
                                        {
                                            for(long h = 0; h < this.__height; h++)
                                            {
                                                for(long d = 0; d < this.__depth; d++)
                                                {
                                                    for(long t = 0; t < this.__time; t++)
                                                    {
                                                        for(long b = 0; b < this.__batch; b++)
                                                        {
                                                            this.__unsafe_add_grad(result.__grad_float32[((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b], this.__grad_float32, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        });
                                        break;
                                    }
                                }
                                if(this.__backward_fn != null)
                                {
                                    this.__backward_fn();
                                }
                            };
                        }
                    }
                    else
                    {
                        switch(this.dtype)
                        {
                            case torch.float32:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    var i = ((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b;
                                                    result.__data_float32[i] = this.__data_float32[i];
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.uint8:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    var i = ((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b;
                                                    result.__data_uint8[i] = this.__data_uint8[i];
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.int64:
                            {
                                Parallel.For(0, this.__width, (long w) =>
                                {
                                    for(long h = 0; h < this.__height; h++)
                                    {
                                        for(long d = 0; d < this.__depth; d++)
                                        {
                                            for(long t = 0; t < this.__time; t++)
                                            {
                                                for(long b = 0; b < this.__batch; b++)
                                                {
                                                    var i = ((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b;
                                                    result.__data_int64[i] = this.__data_int64[i];
                                                }
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                        }
                        if(result.requires_grad)
                        {
                            result.__backward_fn = () =>
                            {
                                switch(this.dtype)
                                {
                                    case torch.float32:
                                    {
                                        Parallel.For(0, this.__width, (long w) =>
                                        {
                                            for(long h = 0; h < this.__height; h++)
                                            {
                                                for(long d = 0; d < this.__depth; d++)
                                                {
                                                    for(long t = 0; t < this.__time; t++)
                                                    {
                                                        for(long b = 0; b < this.__batch; b++)
                                                        {
                                                            var i = ((((h * result.__width) + w) * result.__depth + d) * result.__time + t) * result.__batch + b;
                                                            this.__grad_float32[i] += result.__grad_float32[i];
                                                        }
                                                    }
                                                }
                                            }
                                        });
                                        break;
                                    }
                                }
                                if(this.__backward_fn != null)
                                {
                                    this.__backward_fn();
                                }
                            };
                        }
                    }
                    return result;
                }

                ///<summary>Returns a tensor filled with the scalar value 0, with the same size as input.</summary>
                ///<param name = "input">The size of input will determine size of the output tensor.</param>
                ///<param name = "dtype">The desired data type of returned Tensor. Default: if default, defaults to the dtype of input.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor zeros_like(dtype dtype = dtype.@default, bool requires_grad = false)
                {
                    var result = new Tensor(this.size(), (dtype == dtype.@default) ? this.dtype : dtype, requires_grad);
                    return result;
                }

                ///<summary>Returns a tensor filled with the scalar value 1, with the same size as input.</summary>
                ///<param name = "input">The size of input will determine size of the output tensor.</param>
                ///<param name = "dtype">The desired data type of returned Tensor. Default: if default, defaults to the dtype of input.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor ones_like(dtype dtype = dtype.@default, bool requires_grad = false)
                {
                    var result = new Tensor(this.size(), (dtype == dtype.@default) ? this.dtype : dtype, requires_grad);
                    switch(result.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            for(int i = 0; i < result.__data_float32.Length; i++)
                            {
                                result.__data_float32[i] = 1;
                            }
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            for(int i = 0; i < result.__data_uint8.Length; i++)
                            {
                                result.__data_uint8[i] = 1;
                            }
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            for(int i = 0; i < result.__data_int64.Length; i++)
                            {
                                result.__data_int64[i] = 1;
                            }
                            break;
                        }
                    }
                    return result;
                }

                ///<summary>Returns a tensor with all the dimensions of input of size 1 removed.</summary>
                public Tensor squeeze()
                {
                    switch(this.__ndim)
                    {
                        case 0:
                        {
                            return this.__link();
                        }
                        case 1:
                        {
                            var y = this.__link();
                            if(y.__width == 1)
                            {
                                y.__ndim = 0;
                            }
                            return y;
                        }
                        case 2:
                        {
                            var y = this.__link();
                            if(y.__width == 1)
                            {
                                if(y.__height == 1)
                                {
                                    y.__ndim = 0;
                                }
                                else
                                {
                                    y.__ndim = 1;
                                    y.__width = y.__height;
                                }
                            }
                            else
                            {
                                if(y.__height == 1)
                                {
                                    y.__ndim = 1;
                                }
                            }
                            return y;
                        }
                        case 3:
                        {
                            var y = this.__link();
                            if(y.__width == 1)
                            {
                                if(y.__height == 1)
                                {
                                    if(y.__depth == 1)
                                    {
                                        y.__ndim = 0;
                                    }
                                    else
                                    {
                                        y.__ndim = 1;
                                        y.__width = y.__depth;
                                    }
                                }
                                else
                                {
                                    if(y.__depth == 1)
                                    {
                                        y.__ndim = 1;
                                        y.__width = y.__height;
                                    }
                                    else
                                    {
                                        y.__width = y.__height;
                                        y.__height = y.__depth;
                                    }
                                }
                            }
                            else
                            {
                                if(y.__height == 1)
                                {
                                    if(y.__depth == 1)
                                    {
                                        y.__ndim = 1;
                                    }
                                    else
                                    {
                                        y.__ndim = 2;
                                        y.__height = y.__depth;
                                    }
                                }
                            }
                            return y;
                        }
                        case 4:
                        {
                            var y = this.__link();
                            if(y.__width == 1)
                            {
                                if(y.__height == 1)
                                {
                                    if(y.__depth == 1)
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 0;
                                        }
                                        else
                                        {
                                            y.__ndim = 1;
                                            y.__width = y.__time;
                                        }
                                    }
                                    else
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 1;
                                            y.__width = y.__depth;
                                        }
                                        else
                                        {
                                            y.__ndim = 2;
                                            y.__width = y.__depth;
                                            y.__height = y.__time;
                                        }
                                    }
                                }
                                else
                                {
                                    if(y.__depth == 1)
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 1;
                                            y.__width = y.__height;
                                        }
                                        else
                                        {
                                            y.__ndim = 2;
                                            y.__width = y.__height;
                                            y.__height = y.__time;
                                        }
                                    }
                                    else
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 2;
                                            y.__width = y.__height;
                                            y.__height = y.__depth;
                                        }
                                        else
                                        {
                                            y.__ndim = 3;
                                            y.__width = y.__height;
                                            y.__height = y.__depth;
                                            y.__depth = y.__time;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if(y.__height == 1)
                                {
                                    if(y.__depth == 1)
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 1;
                                        }
                                        else
                                        {
                                            y.__ndim = 2;
                                            y.__height = y.__time;
                                        }
                                    }
                                    else
                                    {
                                        if(y.__time == 1)
                                        {
                                            y.__ndim = 2;
                                            y.__height = y.__depth;
                                        }
                                        else
                                        {
                                            y.__ndim = 3;
                                            y.__height = y.__depth;
                                            y.__depth = y.__time;
                                        }
                                    }
                                }
                            }
                            return y;
                        }
                        default:
                        {
                            return null;
                        }
                    }
                }

                ///<summary>This attribute is None by default and becomes a Tensor the first time a call to backward() computes gradients for self. The attribute will then contain the gradients computed and future calls to backward() will accumulate (add) gradients into it.</summary>
                public Tensor grad
                {

                    get
                    {
                        try
                        {
                            return new Tensor(this.__grad_float32, this.__ndim, this.__width, this.__height, this.__depth, this.__time, this.__batch);
                        }
                        catch(Exception e)
                        {
                            return null;
                        }
                    }

                }

                ///<summary>Computes the gradient of current tensor w.r.t. graph leaves. The graph is differentiated using the chain rule. If the tensor is non-scalar (i.e. its data has more than one element) and requires gradient, the function additionally requires specifying gradient. It should be a tensor of matching type and location, that contains the gradient of the differentiated function w.r.t. self. This function accumulates gradients in the leaves - you might need to zero them before calling it.</summary>
                public void backward(Tensor gradient = null)
                {
                    if(this.__ndim == 0)
                    {
                        if(this.requires_grad == false)
                        {
                            throw new torch.TorchException("TorchException: element 0 of the tensor does not require grad and does not have a backward function.");
                        }
                        if(gradient == null)
                        {
                            switch(this.dtype)
                            {
                                case torch.dtype.float32:
                                {
                                    this.__grad_float32[0] = 1f;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if((gradient.__data_float32 == null) == (this.__grad_float32 == null))
                            {
                                if((gradient.__width == this.__width) &&
                                   (gradient.__height == this.__height) &&
                                   (gradient.__depth == this.__depth) &&
                                   (gradient.__time == this.__time) &&
                                   (gradient.__batch == this.__batch))
                                {
                                    this.__grad_float32 = gradient.__data_float32;
                                }
                                else
                                {
                                    throw new TorchException("TorchException: The gradient dimensions should repeat the dimensions of the current tensor.");
                                }
                            }
                            else
                            {
                                throw new TorchException("TorchException: The gradient data type must repeat the tensor data type.");
                            }
                        }
                    }
                    else
                    {
                        if(gradient != null)
                        {
                            if((gradient.__data_float32 == null) == (this.__grad_float32 == null))
                            {
                                if((gradient.__width == this.__width) &&
                                   (gradient.__height == this.__height) &&
                                   (gradient.__depth == this.__depth) &&
                                   (gradient.__time == this.__time) &&
                                   (gradient.__batch == this.__batch))
                                {
                                    this.__grad_float32 = gradient.__data_float32;
                                }
                                else
                                {
                                    throw new TorchException("TorchException: The gradient dimensions should repeat the dimensions of the current tensor.");
                                }
                            }
                            else
                            {
                                throw new TorchException("TorchException: The gradient data type must repeat the tensor data type.");
                            }
                        }
                        else
                        {
                            throw new TorchException("TorchException: Grad can be implicitly created only for scalar outputs.");
                        }
                    }
                    if(this.__backward_fn != null)
                    {
                        this.__backward_fn();
                    }
                }

                ///<summary>Change if autograd should record operations on this tensor: sets this tensor’s requires_grad attribute in-place. Returns this tensor.</summary>
                ///<param name = "requires_grad">If autograd should record operations on this tensor. Default: true.</param>
                public void requires_grad_(bool requires_grad = true)
                {
                    if(this.requires_grad != requires_grad)
                    {
                        if(requires_grad)
                        {
                            this.requires_grad = true;
                            this.__InitializeGrad();
                        }
                        else
                        {
                            this.requires_grad = false;
                            this.__DeleteGrad();
                        }
                    }
                }

                ///<summary>Converts the current instance to a string representation.</summary>
                public override string ToString()
                {
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            return this.__print_tensor(this.__data_float32);
                        }
                        case torch.dtype.uint8:
                        {
                            return this.__print_tensor(this.__data_uint8);
                        }
                        case torch.dtype.int64:
                        {
                            return this.__print_tensor(this.__data_int64);
                        }
                        default:
                        {
                            return "tensor";
                        }
                    }
                }

                ///<summary>Returns the size of the current tensor.</summary>
                public torch.Size size()
                {
                    if(this.__ndim == 0)
                    {
                        return new torch.Size();
                    }
                    switch(this.__ndim)
                    {
                        case 0:
                        {
                            return new torch.Size();
                        }
                        case 1:
                        {
                            return new torch.Size(this.__width);
                        }
                        case 2:
                        {
                            return new torch.Size(this.__height, this.__width);
                        }
                        case 3:
                        {
                            return new torch.Size(this.__depth, this.__height, this.__width);
                        }
                        case 4:
                        {
                            return new torch.Size(this.__time, this.__depth, this.__height, this.__width);
                        }
                        case 5:
                        {
                            return new torch.Size(this.__batch, this.__time, this.__depth, this.__height, this.__width);
                        }
                        default:
                        {
                            throw new torch.TorchException("TorchException: Internal data error.");
                        }
                    }
                }

            }

        }

    }

}
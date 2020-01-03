//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public sealed partial class Tensor
            {

                public Tensor item
                {

                    get
                    {
                        var result = this.__link();
                        result.__ndim = 0;
                        result.__width = 1;
                        result.__height = 1;
                        result.__depth = 1;
                        result.__time = 1;
                        result.__batch = 1;
                        result.__start_width = 0;
                        result.__start_height = 0;
                        result.__start_depth = 0;
                        result.__start_time = 0;
                        result.__start_batch = 0;
                        result.__restricted = true;
                        return result;
                    }

                    set
                    {
                        switch(this.dtype)
                        {
                            case torch.dtype.float32:
                            {
                                switch(value.dtype)
                                {
                                    case dtype.float32:
                                    {
                                        this.__unsafe_set_value(value.__unsafe_get_value(value.__data_float32, 0), this.__data_float32, 0);
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                    }

                }

                ///<summary>Index property of the tensor.</summary>
                ///<param name = "i">The index(es) of the tensor.</param>
                public Tensor this[params long[] i]
                {

                    get
                    {
                        if(i.Length > this.__ndim)
                        {
                            throw new TorchException("TorchException: The number of indices must be less than or equal to the number of dimensions of the current tensor.");
                        }
                        var _i = new long[5];
                        for(long j = 0; j < _i.Length; j++)
                        {
                            _i[j] = -1;
                        }
                        for(long j = 0; j < i.Length; j++)
                        {
                            _i[_i.Length - this.__ndim + j] = i[j];
                        }
                        long maxB = (_i[0] == -1) ? this.__batch : (_i[0] + 1);
                        long minB = (_i[0] == -1) ? 0 : _i[0];
                        long maxT = (_i[1] == -1) ? this.__time : (_i[1] + 1);
                        long minT = (_i[1] == -1) ? 0 : _i[1];
                        long maxD = (_i[2] == -1) ? this.__depth : (_i[2] + 1);
                        long minD = (_i[2] == -1) ? 0 : _i[2];
                        long maxH = (_i[3] == -1) ? this.__height : (_i[3] + 1);
                        long minH = (_i[3] == -1) ? 0 : _i[3];
                        long maxW = (_i[4] == -1) ? this.__width : (_i[4] + 1);
                        long minW = (_i[4] == -1) ? 0 : _i[4];
                        var result = this.__link();
                        result.__ndim = (byte)(this.__ndim - i.Length);
                        result.__width = maxW - minW;
                        result.__height = maxH - minH;
                        result.__depth = maxD - minD;
                        result.__time = maxT - minT;
                        result.__batch = maxB - minB;
                        result.__start_width = minW;
                        result.__start_height = minH;
                        result.__start_depth = minD;
                        result.__start_time = minT;
                        result.__start_batch = minB;
                        result.__restricted = true;
                        return result;
                    }

                    set
                    {
                        if(i.Length > this.__ndim)
                        {
                            throw new TorchException("TorchException: The number of indices must be less than or equal to the number of dimensions of the current tensor.");
                        }
                        var _i = new long[5];
                        for(long j = 0; j < _i.Length; j++)
                        {
                            _i[j] = -1;
                        }
                        for(long j = 0; j < i.Length; j++)
                        {
                            _i[_i.Length - this.__ndim + j] = i[j];
                        }
                        if(_i[0] >= this.__batch)
                        {
                            throw new TorchException("Index of tensor is out of range in dimension " + (this.__ndim - 5));
                        }
                        if(_i[1] >= this.__time)
                        {
                            throw new TorchException("Index of tensor is out of range in dimension " + (this.__ndim - 4));
                        }
                        if(_i[2] >= this.__depth)
                        {
                            throw new TorchException("Index of tensor is out of range in dimension " + (this.__ndim - 3));
                        }
                        if(_i[3] >= this.__height)
                        {
                            throw new TorchException("Index of tensor is out of range in dimension " + (this.__ndim - 2));
                        }
                        if(_i[4] >= this.__width)
                        {
                            throw new TorchException("Index of tensor is out of range in dimension " + (this.__ndim - 1));
                        }
                        long maxB = (_i[0] == -1) ? this.__batch : (_i[0] + 1);
                        long minB = (_i[0] == -1) ? 0 : _i[0];
                        long maxT = (_i[1] == -1) ? this.__time : (_i[1] + 1);
                        long minT = (_i[1] == -1) ? 0 : _i[1];
                        long maxD = (_i[2] == -1) ? this.__depth : (_i[2] + 1);
                        long minD = (_i[2] == -1) ? 0 : _i[2];
                        long maxH = (_i[3] == -1) ? this.__height : (_i[3] + 1);
                        long minH = (_i[3] == -1) ? 0 : _i[3];
                        long maxW = (_i[4] == -1) ? this.__width : (_i[4] + 1);
                        long minW = (_i[4] == -1) ? 0 : _i[4];
                        switch(this.dtype)
                        {
                            case torch.dtype.float32:
                            {
                                switch(value.dtype)
                                {
                                    case dtype.float32:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value((float)value.__unsafe_get_value(value.__data_float32, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_float32, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    case dtype.uint8:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value((float)value.__unsafe_get_value(value.__data_uint8, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_float32, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    case dtype.int64:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value((float)value.__unsafe_get_value(value.__data_int64, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_float32, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                            case torch.dtype.uint8:
                            {
                                switch(value.dtype)
                                {
                                    case dtype.float32:
                                    {
                                        throw new TorchException("TorchException: It is not possible to convert a floating point tensor to a tensor of integer or bool type.");
                                    }
                                    case dtype.uint8:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value(value.__unsafe_get_value(value.__data_uint8, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_uint8, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    case dtype.int64:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value((byte)value.__unsafe_get_value(value.__data_int64, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_uint8, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                            case torch.dtype.int64:
                            {
                                switch(value.dtype)
                                {
                                    case dtype.float32:
                                    {
                                        throw new TorchException("TorchException: It is not possible to convert a floating point tensor to a tensor of integer or bool type.");
                                    }
                                    case dtype.uint8:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value((long)value.__unsafe_get_value(value.__data_uint8, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_int64, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                    case dtype.int64:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_value(value.__unsafe_get_value(value.__data_int64, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0), this.__data_int64, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                break;
                            }
                        }
                        if((this.requires_grad) && (value.requires_grad))
                        {
                            var old_backward = this.__backward_fn;
                            this.__backward_fn = () =>
                            {
                                switch(this.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        switch(value.dtype)
                                        {
                                            case dtype.float32:
                                            {
                                                for(long b = minB; b < maxB; b++)
                                                {
                                                    for(long t = minT; t < maxT; t++)
                                                    {
                                                        for(long d = minD; d < maxD; d++)
                                                        {
                                                            for(long h = minH; h < maxH; h++)
                                                            {
                                                                for(long w = minW; w < maxW; w++)
                                                                {
                                                                    value.__unsafe_add_grad(this.__unsafe_get_grad(this.__grad_float32, w, h, d, t, b), value.__grad_float32, (value.__width == this.__width) ? (w - minW) : 0, (value.__height == this.__height) ? (h - minH) : 0, (value.__depth == this.__depth) ? (d - minD) : 0, (value.__time == this.__time) ? (t - minT) : 0, (value.__batch == this.__batch) ? (b - minB) : 0);
                                                                    this.__unsafe_set_grad(0f, this.__grad_float32, w, h, d, t, b);
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                                break;
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(old_backward != null)
                                {
                                    old_backward();
                                }
                                if(value.__backward_fn != null)
                                {
                                    value.__backward_fn();
                                }
                            };
                        }
                        if((this.requires_grad) && (!(value.requires_grad)))
                        {
                            var old_backward = this.__backward_fn;
                            this.__backward_fn = () =>
                            {
                                switch(this.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        for(long b = minB; b < maxB; b++)
                                        {
                                            for(long t = minT; t < maxT; t++)
                                            {
                                                for(long d = minD; d < maxD; d++)
                                                {
                                                    for(long h = minH; h < maxH; h++)
                                                    {
                                                        for(long w = minW; w < maxW; w++)
                                                        {
                                                            this.__unsafe_set_grad(0f, this.__grad_float32, w, h, d, t, b);
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(old_backward != null)
                                {
                                    old_backward();
                                }
                            };
                        }
                    }

                }

            }

        }

    }

}
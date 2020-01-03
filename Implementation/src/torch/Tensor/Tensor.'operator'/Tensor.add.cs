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

                public static Tensor operator +(Tensor a, float b)
                {
                    return a + torch.tensor(b, dtype: a.dtype);
                }

                public static Tensor operator +(Tensor a, sbyte b)
                {
                    return a + torch.tensor(b, dtype: a.dtype);
                }

                public static Tensor operator +(Tensor a, short b)
                {
                    return a + torch.tensor(b, dtype: a.dtype);
                }

                public static Tensor operator +(Tensor a, int b)
                {
                    return a + torch.tensor(b, dtype: a.dtype);
                }

                public static Tensor operator +(Tensor a, long b)
                {
                    return a + torch.tensor(b, dtype: a.dtype);
                }

                public static Tensor operator +(Tensor a, Tensor b)
                {
                    var _result_shape = new int[Math.Max(a.__ndim, b.__ndim)];
                    if(a.__width != b.__width)
                    {
                        if((a.__width != 1) && (b.__width != 1))
                        {
                            throw new TorchException("TorchException: Tensors are not broacastable.");
                        }
                    }
                    if(a.__height != b.__height)
                    {
                        if((a.__height != 1) && (b.__height != 1))
                        {
                            throw new TorchException("TorchException: Tensors are not broacastable.");
                        }
                    }
                    if(a.__depth != b.__depth)
                    {
                        if((a.__depth != 1) && (b.__depth != 1))
                        {
                            throw new TorchException("TorchException: Tensors are not broacastable.");
                        }
                    }
                    if(a.__time != b.__time)
                    {
                        if((a.__time != 1) && (b.__time != 1))
                        {
                            throw new TorchException("TorchException: Tensors are not broacastable.");
                        }
                    }
                    if(a.__batch != b.__batch)
                    {
                        if((a.__batch != 1) && (b.__batch != 1))
                        {
                            throw new TorchException("TorchException: Tensors are not broacastable.");
                        }
                    }
                    if(a.__ndim > b.__ndim)
                    {
                        var aSize = (int[])a.size();
                        for(int i = 0; i < a.__ndim; i++)
                        {
                            _result_shape[i] = aSize[i];
                        }
                    }
                    else
                    {
                        if(a.__ndim == b.__ndim)
                        {
                            var aSize = (int[])a.size();
                            var bSize = (int[])b.size();
                            for(int i = 0; i < a.__ndim; i++)
                            {
                                _result_shape[i] = Math.Max(aSize[i], bSize[i]);
                            }
                        }
                        else
                        {
                            var bSize = (int[])b.size();
                            for(int i = 0; i < b.__ndim; i++)
                            {
                                _result_shape[i] = bSize[i];
                            }
                        }
                    }
                    var __result_shape = new int[_result_shape.Length];
                    for(int i = 0; i < _result_shape.Length; i++)
                    {
                        __result_shape[_result_shape.Length - 1 - i] = _result_shape[i];
                    }
                    var result_batch = (__result_shape.Length > 4) ? __result_shape[4] : 1;
                    var result_time = (__result_shape.Length > 3) ? __result_shape[3] : 1;
                    var result_depth = (__result_shape.Length > 2) ? __result_shape[2] : 1;
                    var result_height = (__result_shape.Length > 1) ? __result_shape[1] : 1;
                    var result_width = (__result_shape.Length > 0) ? __result_shape[0] : 1;
                    if(a.dtype != b.dtype)
                    {
                        throw new TorchException("TorchException: Tensors must have the same data type.");
                    }
                    var result = torch.zeros((Size)_result_shape, dtype: a.dtype, requires_grad: (a.requires_grad || b.requires_grad));
                    switch(a.dtype)
                    {
                        case torch.float32:
                        {
                            for(int _b = 0; _b < result_batch; _b++)
                            {
                                for(int _t = 0; _t < result_time; _t++)
                                {
                                    for(int _d = 0; _d < result_depth; _d++)
                                    {
                                        for(int _h = 0; _h < result_height; _h++)
                                        {
                                            for(int _w = 0; _w < result_width; _w++)
                                            {
                                                result.__data_float32[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b] = a.__data_float32[(((((((_h > (a.__height - 1)) ? 0 : _h) * a.__width) + ((_w > (a.__width - 1)) ? 0 : _w)) * a.__depth + ((_d > (a.__depth - 1)) ? 0 : _d)) * a.__time + ((_t > (a.__time - 1)) ? 0 : _t)) * a.__batch + ((_b > (a.__batch - 1)) ? 0 : _b))] + b.__data_float32[(((((((_h > (b.__height - 1)) ? 0 : _h) * b.__width) + ((_w > (b.__width - 1)) ? 0 : _w)) * b.__depth + ((_d > (b.__depth - 1)) ? 0 : _d)) * b.__time + ((_t > (b.__time - 1)) ? 0 : _t)) * b.__batch + ((_b > (b.__batch - 1)) ? 0 : _b))];
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            for(int _b = 0; _b < result_batch; _b++)
                            {
                                for(int _t = 0; _t < result_time; _t++)
                                {
                                    for(int _d = 0; _d < result_depth; _d++)
                                    {
                                        for(int _h = 0; _h < result_height; _h++)
                                        {
                                            for(int _w = 0; _w < result_width; _w++)
                                            {
                                                result.__data_uint8[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b] = (byte)(a.__data_uint8[(((((((_h > (a.__height - 1)) ? 0 : _h) * a.__width) + ((_w > (a.__width - 1)) ? 0 : _w)) * a.__depth + ((_d > (a.__depth - 1)) ? 0 : _d)) * a.__time + ((_t > (a.__time - 1)) ? 0 : _t)) * a.__batch + ((_b > (a.__batch - 1)) ? 0 : _b))] + b.__data_uint8[(((((((_h > (b.__height - 1)) ? 0 : _h) * b.__width) + ((_w > (b.__width - 1)) ? 0 : _w)) * b.__depth + ((_d > (b.__depth - 1)) ? 0 : _d)) * b.__time + ((_t > (b.__time - 1)) ? 0 : _t)) * b.__batch + ((_b > (b.__batch - 1)) ? 0 : _b))]);
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            for(int _b = 0; _b < result_batch; _b++)
                            {
                                for(int _t = 0; _t < result_time; _t++)
                                {
                                    for(int _d = 0; _d < result_depth; _d++)
                                    {
                                        for(int _h = 0; _h < result_height; _h++)
                                        {
                                            for(int _w = 0; _w < result_width; _w++)
                                            {
                                                result.__data_int64[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b] = a.__data_int64[(((((((_h > (a.__height - 1)) ? 0 : _h) * a.__width) + ((_w > (a.__width - 1)) ? 0 : _w)) * a.__depth + ((_d > (a.__depth - 1)) ? 0 : _d)) * a.__time + ((_t > (a.__time - 1)) ? 0 : _t)) * a.__batch + ((_b > (a.__batch - 1)) ? 0 : _b))] + b.__data_int64[(((((((_h > (b.__height - 1)) ? 0 : _h) * b.__width) + ((_w > (b.__width - 1)) ? 0 : _w)) * b.__depth + ((_d > (b.__depth - 1)) ? 0 : _d)) * b.__time + ((_t > (b.__time - 1)) ? 0 : _t)) * b.__batch + ((_b > (b.__batch - 1)) ? 0 : _b))];
                                            }
                                        }
                                    }
                                }
                            }
                            break;
                        }
                    }
                    if(a.requires_grad || b.requires_grad)
                    {
                        result.__backward_fn = () =>
                        {
                            if((a.requires_grad) && (b.requires_grad))
                            {
                                switch(a.dtype)
                                {
                                    case torch.float32:
                                    {
                                        for(int _b = 0; _b < result_batch; _b++)
                                        {
                                            for(int _t = 0; _t < result_time; _t++)
                                            {
                                                for(int _d = 0; _d < result_depth; _d++)
                                                {
                                                    for(int _h = 0; _h < result_height; _h++)
                                                    {
                                                        for(int _w = 0; _w < result_width; _w++)
                                                        {
                                                            var dw = result.__grad_float32[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b];
                                                            a.__grad_float32[(((((((_h > (a.__height - 1)) ? 0 : _h) * a.__width) + ((_w > (a.__width - 1)) ? 0 : _w)) * a.__depth + ((_d > (a.__depth - 1)) ? 0 : _d)) * a.__time + ((_t > (a.__time - 1)) ? 0 : _t)) * a.__batch + ((_b > (a.__batch - 1)) ? 0 : _b))] += dw;
                                                            b.__grad_float32[(((((((_h > (b.__height - 1)) ? 0 : _h) * b.__width) + ((_w > (b.__width - 1)) ? 0 : _w)) * b.__depth + ((_d > (b.__depth - 1)) ? 0 : _d)) * b.__time + ((_t > (b.__time - 1)) ? 0 : _t)) * b.__batch + ((_b > (b.__batch - 1)) ? 0 : _b))] += dw;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(a.__backward_fn != null)
                                {
                                    a.__backward_fn();
                                }
                                if(b.__backward_fn != null)
                                {
                                    b.__backward_fn();
                                }
                            }
                            if((a.requires_grad) && (!(b.requires_grad)))
                            {
                                switch(a.dtype)
                                {
                                    case torch.float32:
                                    {
                                        for(int _b = 0; _b < result_batch; _b++)
                                        {
                                            for(int _t = 0; _t < result_time; _t++)
                                            {
                                                for(int _d = 0; _d < result_depth; _d++)
                                                {
                                                    for(int _h = 0; _h < result_height; _h++)
                                                    {
                                                        for(int _w = 0; _w < result_width; _w++)
                                                        {
                                                            var dw = result.__grad_float32[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b];
                                                            a.__grad_float32[(((((((_h > (a.__height - 1)) ? 0 : _h) * a.__width) + ((_w > (a.__width - 1)) ? 0 : _w)) * a.__depth + ((_d > (a.__depth - 1)) ? 0 : _d)) * a.__time + ((_t > (a.__time - 1)) ? 0 : _t)) * a.__batch + ((_b > (a.__batch - 1)) ? 0 : _b))] += dw;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(a.__backward_fn != null)
                                {
                                    a.__backward_fn();
                                }
                            }
                            if((!(a.requires_grad)) && (b.requires_grad))
                            {
                                switch(a.dtype)
                                {
                                    case torch.float32:
                                    {
                                        for(int _b = 0; _b < result_batch; _b++)
                                        {
                                            for(int _t = 0; _t < result_time; _t++)
                                            {
                                                for(int _d = 0; _d < result_depth; _d++)
                                                {
                                                    for(int _h = 0; _h < result_height; _h++)
                                                    {
                                                        for(int _w = 0; _w < result_width; _w++)
                                                        {
                                                            var dw = result.__grad_float32[((((_h * result.__width) + _w) * result.__depth + _d) * result.__time + _t) * result.__batch + _b];
                                                            b.__grad_float32[(((((((_h > (b.__height - 1)) ? 0 : _h) * b.__width) + ((_w > (b.__width - 1)) ? 0 : _w)) * b.__depth + ((_d > (b.__depth - 1)) ? 0 : _d)) * b.__time + ((_t > (b.__time - 1)) ? 0 : _t)) * b.__batch + ((_b > (b.__batch - 1)) ? 0 : _b))] += dw;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                if(b.__backward_fn != null)
                                {
                                    b.__backward_fn();
                                }
                            }
                        };
                    }
                    return result;
                }

            }

        }

    }

}
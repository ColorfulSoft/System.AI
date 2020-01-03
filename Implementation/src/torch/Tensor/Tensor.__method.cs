//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;
using System.Runtime.CompilerServices;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public sealed partial class Tensor
            {

                //-> layout: ((((y * this.__width) + x) * this.__depth + d) * this.__time + t) * this.__batch + b

                ///<summary>Gets the value of a 5-D Tensor without checking that the indices are out of the Tensor.</summary>
                ///<param name = "data">Data array.</param>
                ///<param name = "x">Index by Width.</param>
                ///<param name = "y">Index by Height.</param>
                ///<param name = "d">Index by Channel.</param>
                ///<param name = "t">Index by Time.</param>
                ///<param name = "b">Index by Batch.</param>
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal T __unsafe_get_value<T>(T[] data, long x = 0, long y = 0, long d = 0, long t = 0, long b = 0)
                {
                    return data[(((((y + this.__start_height) * this.__base_width) + (x + this.__start_width)) * this.__base_depth + (d + this.__start_depth)) * this.__base_time + (t + this.__start_time)) * this.__base_batch + (b + this.__start_batch)];
                }

                ///<summary>Sets the value of a 5-D Tensor without checking that the indices are out of the Tensor.</summary>
                ///<param name = "data">Data.</param>
                ///<param name = "storage">Data array.</param>
                ///<param name = "x">Index by Width.</param>
                ///<param name = "y">Index by Height.</param>
                ///<param name = "d">Index by Channel.</param>
                ///<param name = "t">Index by Time.</param>
                ///<param name = "b">Index by Batch.</param>
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal void __unsafe_set_value<T>(T data, T[] storage, long x = 0, long y = 0, long d = 0, long t = 0, long b = 0)
                {
                    storage[(((((y + this.__start_height) * this.__base_width) + (x + this.__start_width)) * this.__base_depth + (d + this.__start_batch)) * this.__base_time + (t + this.__start_time)) * this.__base_batch + (b + this.__start_batch)] = data;
                }

                ///<summary>Gets the gradient of a 5-D Tensor without checking that the indices are out of the Tensor.</summary>
                ///<param name = "data">Grad array.</param>
                ///<param name = "x">Index by Width.</param>
                ///<param name = "y">Index by Height.</param>
                ///<param name = "d">Index by Channel.</param>
                ///<param name = "t">Index by Time.</param>
                ///<param name = "b">Index by Batch.</param>
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal T __unsafe_get_grad<T>(T[] grad, long x = 0, long y = 0, long d = 0, long t = 0, long b = 0)
                {
                    return grad[(((((y + this.__start_height) * this.__base_width) + (x + this.__start_width)) * this.__base_depth + (d + this.__start_depth)) * this.__base_time + (t + this.__start_time)) * this.__base_batch + (b + this.__start_batch)];
                }

                ///<summary>Sets the grad of a 5-D Tensor without checking that the indices are out of the Tensor.</summary>
                ///<param name = "grad">Gradient.</param>
                ///<param name = "storage">Data array.</param>
                ///<param name = "x">Index by Width.</param>
                ///<param name = "y">Index by Height.</param>
                ///<param name = "d">Index by Channel.</param>
                ///<param name = "t">Index by Time.</param>
                ///<param name = "b">Index by Batch.</param>
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal void __unsafe_set_grad<T>(T grad, T[] storage, long x = 0, long y = 0, long d = 0, long t = 0, long b = 0)
                {
                    storage[(((((y + this.__start_height) * this.__base_width) + (x + this.__start_width)) * this.__base_depth + (d + this.__start_depth)) * this.__base_time + (t + this.__start_time)) * this.__base_batch + (b + this.__start_batch)] = grad;
                }

                ///<summary>Adds the gradient of a 5-D Tensor without checking that the indices are out of the Tensor.</summary>
                ///<param name = "grad">Grad.</param>
                ///<param name = "storage">Grad array.</param>
                ///<param name = "x">Index by Width.</param>
                ///<param name = "y">Index by Height.</param>
                ///<param name = "d">Index by Channel.</param>
                ///<param name = "t">Index by Time.</param>
                ///<param name = "b">Index by Batch.</param>
                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal void __unsafe_add_grad(float grad, float[] storage, long x = 0, long y = 0, long d = 0, long t = 0, long b = 0)
                {
                    storage[(((((y + this.__start_height) * this.__base_width) + (x + this.__start_width)) * this.__base_depth + (d + this.__start_depth)) * this.__base_time + (t + this.__start_time)) * this.__base_batch + (b + this.__start_batch)] += grad;
                }

                //------------------------------
                //-> Initialization.
                //------------------------------

                ///<summary>Initializes the data storage.</summary>
                private void __InitializeData()
                {
                    switch(this.dtype)
                    {
                        case(torch.dtype.float32):
                        {
                            this.__data_float32 = new float[this.__width * this.__height * this.__depth * this.__time * this.__batch];
                            break;
                        }
                        case(torch.dtype.uint8):
                        {
                            this.__data_uint8 = new byte[this.__width * this.__height * this.__depth * this.__time * this.__batch];
                            break;
                        }
                        case(torch.dtype.int64):
                        {
                            this.__data_int64 = new long[this.__width * this.__height * this.__depth * this.__time * this.__batch];
                            break;
                        }
                    }
                }

                ///<summary>Initializes the grad storage.</summary>
                private void __InitializeGrad()
                {
                    switch(this.dtype)
                    {
                        case(torch.dtype.float32):
                        {
                            this.__grad_float32 = new float[this.__width * this.__height * this.__depth * this.__time * this.__batch];
                            break;
                        }
                    }
                }

                ///<summary>Deletes the grad storage.</summary>
                private void __DeleteGrad()
                {
                    switch(this.dtype)
                    {
                        case(torch.dtype.float32):
                        {
                            this.__grad_float32 = null;
                            break;
                        }
                    }
                }

                ///<summary>Throws an exception if the specified tensor size is invalid.</summary>
                ///<param name = "width">The width of the tensor (5-dim).</param>
                ///<param name = "height">The height of the tensor (5-dim).</param>
                ///<param name = "depth">The depth of the tensor (5-dim).</param>
                ///<param name = "time">The number of times in the tensor (video) (5-dim).</param>
                ///<param name = "batch">The batch size of the tensor (5-dim).</param>
                private void __RaiseIfDimensionIsInvalid(long width = 1, long height = 1, long depth = 1, long time = 1, long batch = 1)
                {
                    if(width <= 0)
                    {
                        throw new torch.TorchException("The width of the tensor must be positive and greater than 0.");
                    }
                    if(height <= 0)
                    {
                        throw new torch.TorchException("The height of the tensor must be positive and greater than 0.");
                    }
                    if(depth <= 0)
                    {
                        throw new torch.TorchException("The depth of the tensor must be positive and greater than 0.");
                    }
                    if(time <= 0)
                    {
                        throw new torch.TorchException("The number of times of the tensor must be positive and greater than 0.");
                    }
                    if(batch <= 0)
                    {
                        throw new torch.TorchException("The batch size of the tensor must be positive and greater than 0.");
                    }
                }

                ///<summary>Converts the input data to the output data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __convert<I, D>(ref I input, ref D output)
                {
                    if(input is float)
                    {
                        if(output is float)
                        {
                            output = (D)(object)(float)(object)input;
                        }
                        if(output is byte)
                        {
                            output = (D)(object)(byte)(float)(object)input;
                        }
                        if(output is long)
                        {
                            output = (D)(object)(long)(float)(object)input;
                        }
                    }
                    if(input is byte)
                    {
                        if(output is float)
                        {
                            output = (D)(object)(float)(byte)(object)input;
                        }
                        if(output is byte)
                        {
                            output = (D)(object)(byte)(object)input;
                        }
                        if(output is long)
                        {
                            output = (D)(object)(long)(byte)(object)input;
                        }
                    }
                    if(input is long)
                    {
                        if(output is float)
                        {
                            output = (D)(object)(float)(long)(object)input;
                        }
                        if(output is byte)
                        {
                            output = (D)(object)(byte)(long)(object)input;
                        }
                        if(output is long)
                        {
                            output = (D)(object)(long)(object)input;
                        }
                    }
                }

                ///<summary>Converts the input data array to the output array data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __match<I, D>(I[] input, D[] output)
                {
                    for(long i = 0; i < input.Length; i++)
                    {
                        __convert(ref input[i], ref output[i]);
                    }
                }

                ///<summary>Converts the input data array to the output array data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __match<I, D>(I[,] input, D[] output)
                {
                    var width = input.GetLength(1);
                    var height = input.GetLength(0);
                    for(long y = 0; y < height; y++)
                    {
                        for(long x = 0; x < width; x++)
                        {
                            __convert(ref input[y, x], ref output[((y * width) + x)]);
                        }
                    }
                }

                ///<summary>Converts the input data array to the output array data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __match<I, D>(I[,,] input, D[] output)
                {
                    var width = input.GetLength(2);
                    var height = input.GetLength(1);
                    var depth = input.GetLength(0);
                    for(long d = 0; d < depth; d++)
                    {
                        for(long y = 0; y < height; y++)
                        {
                            for(long x = 0; x < width; x++)
                            {
                                __convert(ref input[d, y, x], ref output[((y * width) + x) * depth + d]);
                            }
                        }
                    }
                }

                ///<summary>Converts the input data array to the output array data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __match<I, D>(I[,,,] input, D[] output)
                {
                    var width = input.GetLength(3);
                    var height = input.GetLength(2);
                    var depth = input.GetLength(1);
                    var time = input.GetLength(0);
                    for(long t = 0; t < time; t++)
                    {
                        for(long d = 0; d < depth; d++)
                        {
                            for(long y = 0; y < height; y++)
                            {
                                for(long x = 0; x < width; x++)
                                {
                                    __convert(ref input[t, d, y, x], ref output[(((y * width) + x) * depth + d) * time + t]);
                                }
                            }
                        }
                    }
                }

                ///<summary>Converts the input data array to the output array data type and writes the converted result to the corresponding parameter.</summary>
                ///<param name = "input">Input data.</param>
                ///<param name = "output">Output data.</param>
                private static void __match<I, D>(I[,,,,] input, D[] output)
                {
                    var width = input.GetLength(4);
                    var height = input.GetLength(3);
                    var depth = input.GetLength(2);
                    var time = input.GetLength(1);
                    var batch = input.GetLength(0);
                    for(long b = 0; b < batch; b++)
                    {
                        for(long t = 0; t < time; t++)
                        {
                            for(long d = 0; d < depth; d++)
                            {
                                for(long y = 0; y < height; y++)
                                {
                                    for(long x = 0; x < width; x++)
                                    {
                                        __convert(ref input[b, t, d, y, x], ref output[((((y * width) + x) * depth + d) * time + t) * batch + b]);
                                    }
                                }
                            }
                        }
                    }
                }

                ///<summary>Converts the data of this tensor to a string representation.</summary>
                ///<param name = "data">The data of the tensor.</param>
                private string __print_tensor<T>(T[] data)
                {
                    var result = "tensor(";
                    switch(this.__ndim)
                    {
                        case 0:
                        {
                            result += this.__unsafe_get_value(data, 0).ToString() + ", dtype=" + this.dtype.ToString() + ((this.requires_grad == true) ? ", requires_grad=true" : "") + ")";
                            return result;
                        }
                        case 1:
                        {
                            result += "[";
                            for(long i = 0; i < this.__width; i++)
                            {
                                result += this.__unsafe_get_value(data, i).ToString() + (((i + 1) == this.__width) ? "" : ", ");
                            }
                            result += "], dtype=" + this.dtype.ToString() + ((this.requires_grad == true) ? ", requires_grad=true" : "") + ")";
                            return result;
                        }
                        case 2:
                        {
                            result += "[";
                            for(long y = 0; y < this.__height; y++)
                            {
                                if(y > 0)
                                {
                                    result += "        ";
                                }
                                result += "[";
                                for(long x = 0; x < this.__width; x++)
                                {
                                    result += this.__unsafe_get_value(data, x, y).ToString() + (((x + 1) == this.__width) ? "" : ", ");
                                }
                                result += "]";
                                if(!(y + 1 == this.__height))
                                {
                                    result += ",";
                                    result = result + (char)13 + (char)10;
                                }
                            }
                            result += "], dtype=" + this.dtype.ToString() + ((this.requires_grad == true) ? ", requires_grad=true" : "") + ")";
                            return result;
                        }
                        case 3:
                        {
                            result += "[";
                            for(long d = 0; d < this.__depth; d++)
                            {
                                if(d > 0)
                                {
                                    result += "        ";
                                } 
                                result += "[";
                                for(long y = 0; y < this.__height; y++)
                                {
                                    if(y > 0)
                                    {
                                        result += "         ";
                                    }
                                    result += "[";
                                    for(long x = 0; x < this.__width; x++)
                                    {
                                        result += this.__unsafe_get_value(data, x, y, d).ToString() + (((x + 1) == this.__width) ? "" : ", ");
                                    }
                                    result += "]";
                                    if(!(y + 1 == this.__height))
                                    {
                                        result += ",";
                                        result = result + (char)13 + (char)10;
                                    }
                                }
                                result += "]";
                                if(!(d + 1 == this.__depth))
                                {
                                    result += ",";
                                    result = result + (char)13 + (char)10;
                                    result = result + (char)13 + (char)10;
                                }
                            }
                            result += "], dtype=" + this.dtype.ToString() + ((this.requires_grad == true) ? ", requires_grad=true" : "") + ")";
                            return result;
                        }
                        case 4:
                        {
                            result += "[";
                            for(long n = 0; n < this.__time; n++)
                            {
                                if(n > 0)
                                {
                                    result += "        ";
                                } 
                                result += "[";
                                for(long d = 0; d < this.__depth; d++)
                                {
                                    if(d > 0)
                                    {
                                        result += "         ";
                                    } 
                                    result += "[";
                                    for(long y = 0; y < this.__height; y++)
                                    {
                                        if(y > 0)
                                        {
                                            result += "          ";
                                        }
                                        result += "[";
                                        for(long x = 0; x < this.__width; x++)
                                        {
                                            result += this.__unsafe_get_value(data, x, y, d, n).ToString() + (((x + 1) == this.__width) ? "" : ", ");
                                        }
                                        result += "]";
                                        if(!(y + 1 == this.__height))
                                        {
                                            result += ",";
                                            result = result + (char)13 + (char)10;
                                        }
                                    }
                                    result += "]";
                                    if(!(d + 1 == this.__depth))
                                    {
                                        result += ",";
                                        result = result + (char)13 + (char)10;
                                        result = result + (char)13 + (char)10;
                                    }
                                }
                                result += "]";
                                if(!(n + 1 == this.__time))
                                {
                                    result += ",";
                                    result = result + (char)13 + (char)10;
                                    result = result + (char)13 + (char)10;
                                    result = result + (char)13 + (char)10;
                                }
                            }
                            result += "], dtype=" + this.dtype.ToString() + ((this.requires_grad == true) ? ", requires_grad=true" : "") + ")";
                            return result;
                        }
                        default:
                        {
                            return "tensor";
                        }
                    }
                }

                ///<summary>Copies a reference to the internal data container of tensor t to the current tensor.</summary>
                ///<param name = "t">Data tensor.</param>
                internal void __link_data_from_tensor(Tensor t)
                {
                    this.__data_float32 = t.__data_float32;
                    this.__data_uint8 = t.__data_uint8;
                    this.__data_int64 = t.__data_int64;
                }

                ///<summary>Returns a new tensor that references the data store and gradients of the current tensor.</summary>
                private Tensor __link()
                {
                    var y = (Tensor)0f;
                    y.dtype = this.dtype;
                    y.requires_grad = this.requires_grad;
                    y.__ndim = this.__ndim;
                    y.__width = this.__width;
                    y.__height = this.__height;
                    y.__depth = this.__depth;
                    y.__time = this.__time;
                    y.__batch = this.__batch;
                    y.__start_width = this.__start_width;
                    y.__start_height = this.__start_height;
                    y.__start_depth = this.__start_depth;
                    y.__start_time = this.__start_time;
                    y.__start_batch = this.__start_batch;
                    y.__base_width = this.__base_width;
                    y.__base_height = this.__base_height;
                    y.__base_depth = this.__base_depth;
                    y.__base_time = this.__base_time;
                    y.__base_batch = this.__base_batch;
                    y.__data_float32 = this.__data_float32;
                    y.__data_uint8 = this.__data_uint8;
                    y.__data_int64 = this.__data_int64;
                    y.__grad_float32 = this.__grad_float32;
                    y.__backward_fn = this.__backward_fn;
                    return y;
                }

            }

        }

    }

}
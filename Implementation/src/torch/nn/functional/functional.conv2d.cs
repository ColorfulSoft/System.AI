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

            public static partial class nn
            {

                public static partial class functional
                {

                    ///<summary>Applies a 2D convolution over an input image composed of several input planes.</summary>
                    ///<param name = "input">Input tensor of shape (minibatch,in_channels,iH,iW).</param>
                    ///<param name = "weight">Filters of shape (out_channels, groups / in_channels, kH, kW).</param>
                    ///<param name = "bias">Optional bias tensor of shape (out_channels). Default: null.</param>
                    ///<param name = "stride">The stride of the convolving kernel. Can be a single number or a tuple (sH, sW). Default: 1.</param>
                    ///<param name = "padding">Implicit paddings on both sides of the input. Can be a single number or a tuple (padH, padW). Default: 0.</param>
                    ///<param name = "dilation">The spacing between kernel elements. Can be a single number or a tuple (dH, dW). Default: 1.</param>
                    ///<param name = "groups">Split input into groups, in_channels should be divisible by the number of groups. Default: 1.</param>
                    public static Tensor conv2d(Tensor input, Tensor weight, Tensor bias = null, int stride = 1, int padding = 0, int dilation = 1, int groups = 1)
                    {
                        return conv2d(input, weight, bias, new int[]{stride, stride}, new int[]{padding, padding}, new int[]{dilation, dilation}, groups);
                    }

                    ///<summary>Applies a 2D convolution over an input image composed of several input planes.</summary>
                    ///<param name = "input">Input tensor of shape (minibatch,in_channels,iH,iW).</param>
                    ///<param name = "weight">Filters of shape (out_channels, groups / in_channels, kH, kW).</param>
                    ///<param name = "bias">Optional bias tensor of shape (out_channels). Default: null.</param>
                    ///<param name = "stride">The stride of the convolving kernel. Can be a single number or a tuple (sH, sW). Default: 1.</param>
                    ///<param name = "padding">Implicit paddings on both sides of the input. Can be a single number or a tuple (padH, padW). Default: 0.</param>
                    ///<param name = "dilation">The spacing between kernel elements. Can be a single number or a tuple (dH, dW). Default: 1.</param>
                    ///<param name = "groups">Split input into groups, in_channels should be divisible by the number of groups. Default: 1.</param>
                    public static Tensor conv2d(Tensor input, Tensor weight, Tensor bias = null, int[] stride = null, int[] padding = null, int[] dilation = null, int groups = 1)
                    {
                        input = input.clone();
                        var strideX = 1;
                        var strideY = 1;
                        var paddingX = 0;
                        var paddingY = 0;
                        var dilationX = 1;
                        var dilationY = 1;
                        if(stride != null)
                        {
                            if((stride.Length != 2) && (stride.Length != 1))
                            {
                                throw new TorchException("TorchException: stride must contain null, 1 or 2 values.");
                            }
                            strideY = stride[0];
                            if(stride.Length == 2)
                            {
                                strideX = stride[1];
                            }
                            else
                            {
                                strideX = stride[0];
                            }
                        }
                        if(padding != null)
                        {
                            if((padding.Length != 2) && (padding.Length != 1))
                            {
                                throw new TorchException("TorchException: padding must contain null, 1 or 2 values.");
                            }
                            paddingY = padding[0];
                            if(padding.Length == 2)
                            {
                                paddingX = padding[1];
                            }
                            else
                            {
                                paddingX = padding[0];
                            }
                        }
                        if(dilation != null)
                        {
                            if((dilation.Length != 2) && (dilation.Length != 1))
                            {
                                throw new TorchException("TorchException: dilation must contain null, 1 or 2 values.");
                            }
                            dilationY = dilation[0];
                            if(dilation.Length == 2)
                            {
                                dilationX = dilation[1];
                            }
                            else
                            {
                                dilationX = dilation[0];
                            }
                        }
                        if((input.dtype != weight.dtype) || (input.dtype != (bias == null ? input.dtype : bias.dtype)))
                        {
                            throw new TorchException("TorchException: The data type of the input, weight and bias should be the same.");
                        }
                        var outW = (input.__width + 2 * paddingX - dilationX * (weight.__width - 1) - 1) / strideX + 1;
                        var outH = (input.__height + 2 * paddingY - dilationY * (weight.__height - 1) - 1) / strideY + 1;
                        var outD = weight.__time;
                        var outB = input.__time;
                        var inW = input.__width;
                        var inH = input.__height;
                        var inD = input.__depth;
                        var inB = input.__time;
                        var kernelN = weight.__time;
                        var kernelD = weight.__depth;
                        var kernelH = weight.__height;
                        var kernelW = weight.__width;
                        var Result = new Tensor(outB, outD, outH, outW, dtype: input.dtype, requires_grad: input.requires_grad);
                        switch(Result.dtype)
                        {
                            case torch.dtype.float32:
                            {
                                var _input = input.__data_float32;
                                var _result = Result.__data_float32;
                                var depth_stride = kernelN / groups;
                                for(long group = 0; group < groups; ++group)
                                {
                                    Parallel.For(depth_stride * group, depth_stride * (group + 1), (long o_depth) =>
                                    {
                                        var f = weight[o_depth].clone();
                                        for(long batch = 0; batch < outB; ++batch)
                                        {
                                            for(long height = 0; height < outH; height++)
                                            {
                                                var i_height = height * strideY - paddingY;
                                                for(long width = 0; width < outW; ++width)
                                                {
                                                    var result_base = ((height * outW) + width) * outD;
                                                    var i_width = width * strideX - paddingX;
                                                    float sum = 0f;
                                                    for(int f_height = 0; f_height < kernelH; f_height++)
                                                    {
                                                        var iy = i_height + f_height * dilationY;
                                                        if((iy < 0) || (iy >= inH))
                                                        {
                                                            continue;
                                                        }
                                                        for(int f_width = 0; f_width < kernelW; f_width++)
                                                        {
                                                            var ix = i_width + f_width * dilationX;
                                                            if((ix < 0) || (ix >= inW))
                                                            {
                                                                continue;
                                                            }
                                                            var weight_base = ((f_height * kernelW) + f_width) * kernelD;
                                                            var input_base = ((iy * inW) + ix) * inD; 
                                                            for(long depth = kernelD * group; depth < kernelD * (group + 1); depth++)
                                                            {
                                                                sum += f.__data_float32[weight_base + depth - kernelD * group] * _input[(input_base + depth) * inB + batch];
                                                            }
                                                        }
                                                    }
                                                    _result[(result_base + o_depth) * outB + batch] = sum;
                                                }
                                            }
                                        }
                                    });
                                }
                                if(bias != null)
                                {
                                    Parallel.For(0, outD, (long depth) =>
                                    {
                                        for(long height = 0; height < outH; height++)
                                        {
                                            for(long width = 0; width < outW; width++)
                                            {
                                                for(long batch = 0; batch < outB; batch++)
                                                {
                                                    Result.__data_float32[(((height * outW) + width) * outD + depth) * outB + batch] += bias.__data_float32[depth];
                                                }
                                            }
                                        }
                                    });
                                }
                                break;
                            }
                            case torch.dtype.uint8:
                            {
                                var _input = input.__data_uint8;
                                var _result = Result.__data_uint8;
                                var depth_stride = kernelN / groups;
                                for(long group = 0; group < groups; ++group)
                                {
                                    Parallel.For(depth_stride * group, depth_stride * (group + 1), (long o_depth) =>
                                    {
                                        var f = weight[o_depth];
                                        for(long batch = 0; batch < outB; ++batch)
                                        {
                                            for(long height = 0; height < outH; height++)
                                            {
                                                var i_height = height * strideY - paddingY;
                                                for(long width = 0; width < outW; ++width)
                                                {
                                                    var result_base = ((height * outW) + width) * outD;
                                                    var i_width = width * strideX - paddingX;
                                                    byte sum = 0;
                                                    for(int f_height = 0; f_height < kernelH; f_height++)
                                                    {
                                                        var iy = i_height + f_height * dilationY;
                                                        if((iy < 0) || (iy >= inH))
                                                        {
                                                            continue;
                                                        }
                                                        for(int f_width = 0; f_width < kernelW; f_width++)
                                                        {
                                                            var ix = i_width + f_width * dilationX;
                                                            if((ix < 0) || (ix >= inW))
                                                            {
                                                                continue;
                                                            }
                                                            var weight_base = ((f_height * kernelW) + f_width) * kernelD;
                                                            var input_base = ((iy * inW) + ix) * inD; 
                                                            for(long depth = kernelD * group; depth < kernelD * (group + 1); depth++)
                                                            {
                                                                sum += (byte)(f.__data_uint8[weight_base + depth - kernelD * group] * _input[(input_base + depth) * inB + batch]);
                                                            }
                                                        }
                                                    }
                                                    _result[(result_base + o_depth) * outB + batch] = sum;
                                                }
                                            }
                                        }
                                    });
                                }
                                if(bias != null)
                                {
                                    Parallel.For(0, outD, (long depth) =>
                                    {
                                        for(long height = 0; height < outH; height++)
                                        {
                                            for(long width = 0; width < outW; width++)
                                            {
                                                for(long batch = 0; batch < outB; batch++)
                                                {
                                                    Result.__data_uint8[(((height * outW) + width) * outD + depth) * outB + batch] += bias.__data_uint8[depth];
                                                }
                                            }
                                        }
                                    });
                                }
                                break;
                            }
                            case torch.dtype.int64:
                            {
                                var _input = input.__data_int64;
                                var _result = Result.__data_int64;
                                var depth_stride = kernelN / groups;
                                for(long group = 0; group < groups; ++group)
                                {
                                    Parallel.For(depth_stride * group, depth_stride * (group + 1), (long o_depth) =>
                                    {
                                        var f = weight[o_depth];
                                        for(long batch = 0; batch < outB; ++batch)
                                        {
                                            for(long height = 0; height < outH; height++)
                                            {
                                                var i_height = height * strideY - paddingY;
                                                for(long width = 0; width < outW; ++width)
                                                {
                                                    var result_base = ((height * outW) + width) * outD;
                                                    var i_width = width * strideX - paddingX;
                                                    long sum = 0;
                                                    for(int f_height = 0; f_height < kernelH; f_height++)
                                                    {
                                                        var iy = i_height + f_height * dilationY;
                                                        if((iy < 0) || (iy >= inH))
                                                        {
                                                            continue;
                                                        }
                                                        for(int f_width = 0; f_width < kernelW; f_width++)
                                                        {
                                                            var ix = i_width + f_width * dilationX;
                                                            if((ix < 0) || (ix >= inW))
                                                            {
                                                                continue;
                                                            }
                                                            var weight_base = ((f_height * kernelW) + f_width) * kernelD;
                                                            var input_base = ((iy * inW) + ix) * inD; 
                                                            for(long depth = kernelD * group; depth < kernelD * (group + 1); depth++)
                                                            {
                                                                sum += f.__data_int64[weight_base + depth - kernelD * group] * _input[(input_base + depth) * inB + batch];
                                                            }
                                                        }
                                                    }
                                                    _result[(result_base + o_depth) * outB + batch] = sum;
                                                }
                                            }
                                        }
                                    });
                                }
                                if(bias != null)
                                {
                                    Parallel.For(0, outD, (long depth) =>
                                    {
                                        for(long height = 0; height < outH; height++)
                                        {
                                            for(long width = 0; width < outW; width++)
                                            {
                                                for(long batch = 0; batch < outB; batch++)
                                                {
                                                    Result.__data_int64[(((height * outW) + width) * outD + depth) * outB + batch] += bias.__data_int64[depth];
                                                }
                                            }
                                        }
                                    });
                                }
                                break;
                            }
                        }
                        if((input.requires_grad) && (weight.requires_grad))
                        {
                            Result.__backward_fn = () =>
                            {
                                switch(input.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        var df = weight.grad;
                                        var inputGrad = input.__grad_float32;
                                        var inputData = input.__data_float32;
                                        var resultGrad = Result.__grad_float32;
                                        var depth_stride = kernelN / groups;
                                        for(long group = 0; group < groups; ++group)
                                        {
                                            Parallel.For(depth_stride * group, depth_stride * (group + 1), (long o_depth) =>
                                            {
                                                var _f = weight[o_depth];
                                                for(long batch = 0; batch < outB; ++batch)
                                                {
                                                    for(long height = 0; height < outH; height++)
                                                    {
                                                        var i_height = height * strideY - paddingY;
                                                        for(long width = 0; width < outW; ++width)
                                                        {
                                                            var result_base = ((height * outW) + width) * outD;
                                                            var i_width = width * strideX - paddingX;
                                                            float chain_grad = resultGrad[(result_base + o_depth) * outB + batch];
                                                            for(int f_height = 0; f_height < kernelH; f_height++)
                                                            {
                                                                var iy = i_height + f_height * dilationY;
                                                                if((iy < 0) || (iy >= inH))
                                                                {
                                                                    continue;
                                                                }
                                                                for(int f_width = 0; f_width < kernelW; f_width++)
                                                                {
                                                                    var ix = i_width + f_width * dilationX;
                                                                    if((ix < 0) || (ix >= inW))
                                                                    {
                                                                        continue;
                                                                    }
                                                                    var weight_base = ((f_height * kernelW) + f_width) * kernelD;
                                                                    var input_base = ((iy * inW) + ix) * inD; 
                                                                    for(long depth = kernelD * group; depth < kernelD * (group + 1); depth++)
                                                                    {
                                                                        inputGrad[(input_base + depth) * inB + batch] += _f.__data_float32[weight_base + depth - kernelD * group] * chain_grad;
                                                                        df.__data_float32[(weight_base + depth - kernelD * group) * df.__time + o_depth] += inputData[(input_base + depth) * inB + batch] * chain_grad;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            });
                                        }
                                        if(bias == null)
                                        {
                                            break;
                                        }
                                        if(!(bias.requires_grad))
                                        {
                                            break;
                                        }
                                        var biasGrad = bias.__grad_float32;
                                        Parallel.For(0, outB, (long batch) =>
                                        {
                                            for(long height = 0; height < outH; height++)
                                            {
                                                var i_height = height * strideY - paddingY;
                                                for(long width = 0; width < outW; width++)
                                                {
                                                    var i_width = width * strideX - paddingX;
                                                    for(long group = 0; group < groups; group++)
                                                    {
                                                        for(long o_depth = kernelN / groups * group; o_depth < kernelN / groups * (group + 1); o_depth++)
                                                        {
                                                            var chain_grad = resultGrad[(((height * outW) + width) * outD + o_depth) * outB + batch];
                                                            biasGrad[o_depth] += chain_grad;
                                                        }
                                                    }
                                                }
                                            }
                                        });
                                        break;
                                    }
                                }
                                if(input.__backward_fn != null)
                                {
                                    input.__backward_fn();
                                }
                                if(weight.__backward_fn != null)
                                {
                                    weight.__backward_fn();
                                }
                            };
                        }
                        if((input.requires_grad) && (!(weight.requires_grad)))
                        {
                            Result.__backward_fn = () =>
                            {
                                switch(input.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        var inputGrad = input.__grad_float32;
                                        var inputData = input.__data_float32;
                                        var resultGrad = Result.__grad_float32;
                                        var depth_stride = kernelN / groups;
                                        for(long group = 0; group < groups; ++group)
                                        {
                                            Parallel.For(depth_stride * group, depth_stride * (group + 1), (long o_depth) =>
                                            {
                                                var _f = weight[o_depth];
                                                for(long batch = 0; batch < outB; ++batch)
                                                {
                                                    for(long height = 0; height < outH; height++)
                                                    {
                                                        var i_height = height * strideY - paddingY;
                                                        for(long width = 0; width < outW; ++width)
                                                        {
                                                            var result_base = ((height * outW) + width) * outD;
                                                            var i_width = width * strideX - paddingX;
                                                            float chain_grad = resultGrad[(result_base + o_depth) * outB + batch];
                                                            for(int f_height = 0; f_height < kernelH; f_height++)
                                                            {
                                                                var iy = i_height + f_height * dilationY;
                                                                if((iy < 0) || (iy >= inH))
                                                                {
                                                                    continue;
                                                                }
                                                                for(int f_width = 0; f_width < kernelW; f_width++)
                                                                {
                                                                    var ix = i_width + f_width * dilationX;
                                                                    if((ix < 0) || (ix >= inW))
                                                                    {
                                                                        continue;
                                                                    }
                                                                    var weight_base = ((f_height * kernelW) + f_width) * kernelD;
                                                                    var input_base = ((iy * inW) + ix) * inD; 
                                                                    for(long depth = kernelD * group; depth < kernelD * (group + 1); depth++)
                                                                    {
                                                                        inputGrad[(input_base + depth) * inB + batch] += _f.__data_float32[weight_base + depth - kernelD * group] * chain_grad;
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            });
                                        }
                                        if(bias == null)
                                        {
                                            break;
                                        }
                                        if(!(bias.requires_grad))
                                        {
                                            break;
                                        }
                                        var biasGrad = bias.__grad_float32;
                                        Parallel.For(0, outB, (long batch) =>
                                        {
                                            for(long height = 0; height < outH; height++)
                                            {
                                                var i_height = height * strideY - paddingY;
                                                for(long width = 0; width < outW; width++)
                                                {
                                                    var i_width = width * strideX - paddingX;
                                                    for(long group = 0; group < groups; group++)
                                                    {
                                                        for(long o_depth = kernelN / groups * group; o_depth < kernelN / groups * (group + 1); o_depth++)
                                                        {
                                                            var chain_grad = resultGrad[(((height * outW) + width) * outD + o_depth) * outB + batch];
                                                            biasGrad[o_depth] += chain_grad;
                                                        }
                                                    }
                                                }
                                            }
                                        });
                                        break;
                                    }
                                }
                                if(input.__backward_fn != null)
                                {
                                    input.__backward_fn();
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
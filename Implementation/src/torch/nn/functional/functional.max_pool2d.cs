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

                    public static Tensor max_pool2d(Tensor input, int kernel_size = 2, int stride = 2, int padding = 0, int dilation = 1)
                    {
                        var outW = (input.__width + 2 * padding - dilation * (kernel_size - 1) - 1) / stride + 1;
                        var outH = (input.__height + 2 * padding - dilation * (kernel_size - 1) - 1) / stride + 1;
                        var outD = input.__time;
                        var outB = input.__batch;
                        var inW = input.__width;
                        var inH = input.__height;
                        var inD = input.__depth;
                        var inB = input.__time;
                        var Result = new Tensor(outB, outD, outH, outW, dtype: input.dtype, requires_grad: input.requires_grad);
                        var IndicesX = new long[outW * outH * outD * outB];
                        var IndicesY = new long[outW * outH * outD * outB];
                        switch(Result.dtype)
                        {
                            case torch.dtype.float32:
                            {
                                Parallel.For(0, outB, (long batch) =>
                                {
                                    for(long out_depth = 0; out_depth < outD; out_depth++)
                                    {
                                        for(long out_width = 0; out_width < outW; out_width++)
                                        {
                                            for(long out_height = 0; out_height < outH; out_height++)
                                            {
                                                var x = out_width * stride - padding;
                                                var y = out_height * stride - padding;
                                                float max = float.MinValue;
                                                long max_x = -1;
                                                long max_y = -1;
                                                for(int fx = 0; fx < kernel_size; fx++)
                                                {
                                                    var ox = x + fx * dilation;
                                                    for(int fy = 0; fy < kernel_size; fy++)
                                                    {
                                                        var oy = y + fy * dilation;
                                                        if((oy >= 0) && (oy < inH) && (ox >= 0) && (ox < inW))
                                                        {
                                                            var v = input.__data_float32[(((oy * inW) + ox) * inD + out_depth) * inB + batch];
                                                            if(v > max)
                                                            {
                                                                max = v;
                                                                max_x = ox;
                                                                max_y = oy;
                                                            }
                                                        }
                                                    }
                                                }
                                                Result.__data_float32[(((out_height * outW) + out_width) * outD + out_depth) * outB + batch] = max;
                                                var i = (((out_height * outW) + out_width) * outD + out_depth) * outB + batch;
                                                IndicesX[i] = max_x;
                                                IndicesY[i] = max_y;
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.dtype.uint8:
                            {
                                Parallel.For(0, outB, (long batch) =>
                                {
                                    for(long out_depth = 0; out_depth < outD; out_depth++)
                                    {
                                        for(long out_width = 0; out_width < outW; out_width++)
                                        {
                                            for(long out_height = 0; out_height < outH; out_height++)
                                            {
                                                var x = out_width * stride - padding;
                                                var y = out_height * stride - padding;
                                                byte max = byte.MinValue;
                                                long max_x = -1;
                                                long max_y = -1;
                                                for(int fx = 0; fx < kernel_size; fx++)
                                                {
                                                    var ox = x + fx * dilation;
                                                    for(int fy = 0; fy < kernel_size; fy++)
                                                    {
                                                        var oy = y + fy * dilation;
                                                        if((oy >= 0) && (oy < inH) && (ox >= 0) && (ox < inW))
                                                        {
                                                            var v = input.__data_uint8[(((oy * inW) + ox) * inD + out_depth) * inB + batch];
                                                            if(v > max)
                                                            {
                                                                max = v;
                                                                max_x = ox;
                                                                max_y = oy;
                                                            }
                                                        }
                                                    }
                                                }
                                                Result.__data_uint8[(((out_height * outW) + out_width) * outD + out_depth) * outB + batch] = max;
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                            case torch.dtype.int64:
                            {
                                Parallel.For(0, outB, (long batch) =>
                                {
                                    for(long out_depth = 0; out_depth < outD; out_depth++)
                                    {
                                        for(long out_width = 0; out_width < outW; out_width++)
                                        {
                                            for(long out_height = 0; out_height < outH; out_height++)
                                            {
                                                var x = out_width * stride - padding;
                                                var y = out_height * stride - padding;
                                                long max = long.MinValue;
                                                long max_x = -1;
                                                long max_y = -1;
                                                for(int fx = 0; fx < kernel_size; fx++)
                                                {
                                                    var ox = x + fx * dilation;
                                                    for(int fy = 0; fy < kernel_size; fy++)
                                                    {
                                                        var oy = y + fy * dilation;
                                                        if((oy >= 0) && (oy < inH) && (ox >= 0) && (ox < inW))
                                                        {
                                                            var v = input.__data_int64[(((oy * inW) + ox) * inD + out_depth) * inB + batch];
                                                            if(v > max)
                                                            {
                                                                max = v;
                                                                max_x = ox;
                                                                max_y = oy;
                                                            }
                                                        }
                                                    }
                                                }
                                                Result.__data_int64[(((out_height * outW) + out_width) * outD + out_depth) * outB + batch] = max;
                                            }
                                        }
                                    }
                                });
                                break;
                            }
                        }
                        if(input.requires_grad)
                        {
                            Result.__backward_fn = () =>
                            {
                                switch(input.dtype)
                                {
                                    case torch.dtype.float32:
                                    {
                                        Parallel.For(0, outB, (long batch) =>
                                        {
                                            for(long out_depth = 0; out_depth < outD; out_depth++)
                                            {
                                                for(long out_width = 0; out_width < outW; out_width++)
                                                {
                                                    for(long out_height = 0; out_height < outH; out_height++)
                                                    {
                                                        var i = (((out_height * outW) + out_width) * outD + out_depth) * outB + batch;
                                                        var max_x = IndicesX[i];
                                                        var max_y = IndicesY[i];
                                                        var v = Result.__grad_float32[(((out_height * outW) + out_width) * outD + out_depth) * outB + batch];
                                                        input.__grad_float32[(((max_y * inW) + max_x) * inD + out_depth) * inB + batch] += v;
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
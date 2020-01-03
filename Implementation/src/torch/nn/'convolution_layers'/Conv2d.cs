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

                ///<summary>Applies a 2D convolution over an input image composed of several input planes.</summary>
                public sealed class Conv2d : Module
                {

                    ///<summary>Number of channels in the input image.</summary>
                    public int in_channels;

                    ///<summary>Number of channels produced by the convolution.</summary>
                    public int out_channels;

                    ///<summary>Size of the convolving kernel.</summary>
                    public int[] kernel_size;

                    ///<summary>Stride of the convolution. Default: 1.</summary>
                    public int[] stride;

                    ///<summary>Zero-padding added to both sides of the input. Default: 0.</summary>
                    public int[] padding;

                    ///<summary>Spacing between kernel elements. Default: 1.</summary>
                    public int[] dilation;

                    ///<summary>Number of blocked connections from input channels to output channels. Default: 1.</summary>
                    public int groups;

                    ///<summary>The learnable weights of the module of shape (out_channels, groups, in_channels, kernel_size[0], kernel_size[1]).</summary>
                    public Parameter weight;

                    ///<summary>The learnable bias of the module of shape (out_channels)</summary>
                    public Parameter bias;

                    ///<summary>Initializes the module.</summary>
                    ///<param name = "in_channels">Number of channels in the input image.</param>
                    ///<param name = "out_channels">Number of channels produced by the convolution.</param>
                    ///<param name = "kernel_size">Size of the convolving kernel.</param>
                    ///<param name = "stride">Stride of the convolution. Default: 1.</param>
                    ///<param name = "padding">Zero-padding added to both sides of the input. Default: 0.</param>
                    ///<param name = "dilation">Spacing between kernel elements. Default: 1.</param>
                    ///<param name = "groups">Number of blocked connections from input channels to output channels. Default: 1.</param>
                    ///<param name = "bias">If True, adds a learnable bias to the output. Default: True.</param>
                    public Conv2d(int in_channels, int out_channels, int[] kernel_size, int[] stride = null, int[] padding = null, int[] dilation = null, int groups = 1, bool bias = true) : base()
                    {
                        if(stride != null)
                        {
                            if((stride.Length != 2) && (stride.Length != 1))
                            {
                                throw new TorchException("TorchException: stride must contain null, 1 or 2 values.");
                            }
                            if(stride.Length != 2)
                            {
                                stride = new int[]{stride[0], stride[0]};
                            }
                        }
                        else
                        {
                            stride = new int[]{1, 1};
                        }
                        if(padding != null)
                        {
                            if((padding.Length != 2) && (padding.Length != 1))
                            {
                                throw new TorchException("TorchException: padding must contain null, 1 or 2 values.");
                            }
                            if(padding.Length != 2)
                            {
                                padding = new int[]{padding[0], padding[0]};
                            }
                        }
                        else
                        {
                            padding = new int[]{0, 0};
                        }
                        if(dilation != null)
                        {
                            if((dilation.Length != 2) && (dilation.Length != 1))
                            {
                                throw new TorchException("TorchException: stride must contain null, 1 or 2 values.");
                            }
                            if(dilation.Length != 2)
                            {
                                dilation = new int[]{dilation[0], dilation[0]};
                            }
                        }
                        else
                        {
                            dilation = new int[]{1, 1};
                        }
                        float k = 1f / (in_channels * kernel_size[0] * kernel_size[1]);
                        this.weight = new Parameter(torch.uniform(out_channels, in_channels / groups, kernel_size[0], kernel_size[1], -(float)Math.Sqrt(k), (float)Math.Sqrt(k)));
                        if(bias)
                        {
                            this.bias = new Parameter(torch.uniform(out_channels, -(float)Math.Sqrt(k), (float)Math.Sqrt(k)));
                        }
                        this.in_channels = in_channels;
                        this.out_channels = out_channels;
                        this.kernel_size = new int[]{kernel_size[0], kernel_size[1]};
                        this.stride = new int[]{stride[0], stride[1]};
                        this.padding = new int[]{padding[0], padding[1]};
                        this.dilation = new int[]{dilation[0], dilation[1]};
                        this.groups = groups;
                    }

                    ///<summary>Initializes the module.</summary>
                    ///<param name = "in_channels">Number of channels in the input image.</param>
                    ///<param name = "out_channels">Number of channels produced by the convolution.</param>
                    ///<param name = "kernel_size">Size of the convolving kernel.</param>
                    ///<param name = "stride">Stride of the convolution. Default: 1.</param>
                    ///<param name = "padding">Zero-padding added to both sides of the input. Default: 0.</param>
                    ///<param name = "dilation">Spacing between kernel elements. Default: 1.</param>
                    ///<param name = "groups">Number of blocked connections from input channels to output channels. Default: 1.</param>
                    ///<param name = "bias">If True, adds a learnable bias to the output. Default: True.</param>
                    public Conv2d(int in_channels, int out_channels, int kernel_size, int stride = 1, int padding = 0, int dilation = 1, int groups = 1, bool bias = true) : base()
                    {
                        float k = 1f / (in_channels * kernel_size * kernel_size);
                        this.weight = new Parameter(torch.uniform(out_channels, in_channels / groups, kernel_size, kernel_size, -(float)Math.Sqrt(k), (float)Math.Sqrt(k)));
                        if(bias)
                        {
                            this.bias = new Parameter(torch.uniform(out_channels, -(float)Math.Sqrt(k), (float)Math.Sqrt(k)));
                        }
                        this.in_channels = in_channels;
                        this.out_channels = out_channels;
                        this.kernel_size = new int[]{kernel_size, kernel_size};
                        this.stride = new int[]{stride, stride};
                        this.padding = new int[]{padding, padding};
                        this.dilation = new int[]{dilation, dilation};
                        this.groups = groups;
                    }

                    ///<summary>Applies a 2D convolution over an input signal composed of several input planes.</summary>
                    ///<param name = "input">Input tensor.</param>
                    public Tensor forward(Tensor input)
                    {
                        return functional.conv2d(input, this.weight.data, (this.bias == null) ? null : this.bias.data, this.stride, this.padding, this.dilation, this.groups);
                    }

                }

            }

        }

    }

}
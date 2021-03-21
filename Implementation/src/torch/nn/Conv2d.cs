//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 20.01.2021.

using System;
using System.Reflection;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public sealed class Conv2d : Module
                {

                    public Parameter weight;

                    public Parameter bias;

                    public Tuple<int, int> kernel_size;

                    public Tuple<int, int> stride;

                    public Tuple<int, int> padding;

                    public Tuple<int, int> dilation;

                    public int groups;

                    public Conv2d(int in_channels, int out_channels, Union<int, Tuple<int, int>> kernel_size, Union<int, Tuple<int, int>> stride = null, Union<int, Tuple<int, int>> padding = null, Union<int, Tuple<int, int>> dilation = null, int groups = 1, bool bias = true)
                    {
                        if(kernel_size == null)
                        {
                            throw new TorchException("TorchException: kernel_size is not an optional parameter.");
                        }
                        else
                        {
                            if((Tuple<int, int>)kernel_size != null)
                            {
                                this.kernel_size = (Tuple<int, int>)kernel_size;
                            }
                            else
                            {
                                this.kernel_size = new Tuple<int, int>((int)kernel_size, (int)kernel_size);
                            }
                        }
                        if(stride == null)
                        {
                            this.stride = new Tuple<int, int>(1, 1);
                        }
                        else
                        {
                            if((Tuple<int, int>)stride != null)
                            {
                                this.stride = (Tuple<int, int>)stride;
                            }
                            else
                            {
                                this.stride = new Tuple<int, int>((int)stride, (int)stride);
                            }
                        }
                        if(padding == null)
                        {
                            this.padding = new Tuple<int, int>(0, 0);
                        }
                        else
                        {
                            if((Tuple<int, int>)padding != null)
                            {
                                this.padding = (Tuple<int, int>)padding;
                            }
                            else
                            {
                                this.padding = new Tuple<int, int>((int)padding, (int)padding);
                            }
                        }
                        if(dilation == null)
                        {
                            this.dilation = new Tuple<int, int>(1, 1);
                        }
                        else
                        {
                            if((Tuple<int, int>)dilation != null)
                            {
                                this.dilation = (Tuple<int, int>)dilation;
                            }
                            else
                            {
                                this.dilation = new Tuple<int, int>((int)dilation, (int)dilation);
                            }
                        }
                        if((this.kernel_size.Item1 < 1) || (this.kernel_size.Item2 < 1))
                        {
                            throw new TorchException("TorchException: kernel size should be >= 1.");
                        }
                        if((this.stride.Item1 < 1) || (this.stride.Item2 < 1))
                        {
                            throw new TorchException("TorchException: stride should be >= 1.");
                        }
                        if((this.padding.Item1 < 0) || (this.padding.Item2 < 0))
                        {
                            throw new TorchException("TorchException: padding should be >= 0.");
                        }
                        if((this.dilation.Item1 < 1) || (this.dilation.Item2 < 1))
                        {
                            throw new TorchException("TorchException: dilation should be >= 1.");
                        }
                        this.groups = groups;
                        this.weight = new Parameter(torch.zeros(out_channels, in_channels, this.kernel_size.Item1, this.kernel_size.Item2, requires_grad: true));
                        if(bias)
                        {
                            this.bias = new Parameter(torch.zeros(out_channels, requires_grad: true));
                        }
                    }

                    public override Tensor forward(Tensor x)
                    {
                        return functional.conv2d(x, this.weight, this.bias, this.stride, this.padding, this.dilation, this.groups);
                    }

                }

            }

        }

    }

}
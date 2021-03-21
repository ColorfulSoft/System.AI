//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public sealed class MaxPool2d : Module
                {

                    public Union<int, Tuple<int, int>> kernel_size;

                    public Union<int, Tuple<int, int>> stride;

                    public Union<int, Tuple<int, int>> padding;

                    public Union<int, Tuple<int, int>> dilation;

                    public MaxPool2d(Union<int, Tuple<int, int>> kernel_size, Union<int, Tuple<int, int>> stride = null, Union<int, Tuple<int, int>> padding = null, Union<int, Tuple<int, int>> dilation = null)
                    {
                        this.kernel_size = kernel_size;
                        if(stride == null)
                        {
                            this.stride = 1;
                        }
                        else
                        {
                            this.stride = stride;
                        }
                        if(padding == null)
                        {
                            this.padding = 0;
                        }
                        else
                        {
                            this.padding = padding;
                        }
                        if(dilation == null)
                        {
                            this.dilation = 1;
                        }
                        else
                        {
                            this.dilation = dilation;
                        }
                    }

                    public Tensor forward(Tensor x)
                    {
                        return functional.max_pool2d(x, this.kernel_size, this.stride, this.padding, this.dilation);
                    }

                }

            }

        }

    }

}
using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public static class functional
                {

                    public static Tuple<Tensor, Tensor> max_pool2d_with_indices(Tensor x, Union<int, Tuple<int, int>> kernel_size, Union<int, Tuple<int, int>> stride = null, Union<int, Tuple<int, int>> padding = null, Union<int, Tuple<int, int>> dilation = null)
                    {
                        if(x.dtype == torch.@bool)
                        {
                            throw new TorchException("TorchException: nn.functional.max_pool2d_with_indices is not implemented for bool tensors.");
                        }
                        if(x.__shape.Length != 4)
                        {
                            throw new TorchException("TorchException: nn.functional.max_pool2d_with_indices requires 4D input, but " + x.__shape.Length.ToString() + "D given.");
                        }
                        Tuple<int, int> kernel_size__;
                        if(kernel_size == null)
                        {
                            throw new TorchException("TorchException: kernel_size is not an optional parameter.");
                        }
                        else
                        {
                            if((Tuple<int, int>)kernel_size != null)
                            {
                                kernel_size__ = (Tuple<int, int>)kernel_size;
                            }
                            else
                            {
                                kernel_size__ = new Tuple<int, int>((int)kernel_size, (int)kernel_size);
                            }
                        }
                        Tuple<int, int> stride__;
                        if(stride == null)
                        {
                            stride__ = kernel_size__;
                        }
                        else
                        {
                            if((Tuple<int, int>)stride != null)
                            {
                                stride__ = (Tuple<int, int>)stride;
                            }
                            else
                            {
                                stride__ = new Tuple<int, int>((int)stride, (int)stride);
                            }
                        }
                        Tuple<int, int> padding__;
                        if(padding == null)
                        {
                            padding__ = new Tuple<int, int>(0, 0);
                        }
                        else
                        {
                            if((Tuple<int, int>)padding != null)
                            {
                                padding__ = (Tuple<int, int>)padding;
                            }
                            else
                            {
                                padding__ = new Tuple<int, int>((int)padding, (int)padding);
                            }
                        }
                        Tuple<int, int> dilation__;
                        if(dilation == null)
                        {
                            dilation__ = new Tuple<int, int>(1, 1);
                        }
                        else
                        {
                            if((Tuple<int, int>)dilation != null)
                            {
                                dilation__ = (Tuple<int, int>)dilation;
                            }
                            else
                            {
                                dilation__ = new Tuple<int, int>((int)dilation, (int)dilation);
                            }
                        }
                        if((kernel_size__.Item1 < 1) || (kernel_size__.Item2 < 1))
                        {
                            throw new TorchException("TorchException: kernel size should be >= 1.");
                        }
                        if((kernel_size__.Item1 == 1) || (kernel_size__.Item2 == 1))
                        {
                            __Warnings.warn("MaxPool2d with kernel size = 1 is useless.");
                        }
                        if((stride__.Item1 < 1) || (stride__.Item2 < 1))
                        {
                            throw new TorchException("TorchException: stride should be >= 1.");
                        }
                        if((padding__.Item1 < 0) || (padding__.Item2 < 0))
                        {
                            throw new TorchException("TorchException: padding should be >= 0.");
                        }
                        if((dilation__.Item1 < 1) || (dilation__.Item2 < 1))
                        {
                            throw new TorchException("TorchException: dilation should be >= 1.");
                        }
                        var y = new Tensor(x.__shape[0], x.__shape[1],
                                           (x.__shape[2] + 2 * padding__.Item1 - dilation__.Item1 * (kernel_size__.Item1 - 1) - 1) / stride__.Item1 + 1,
                                           (x.__shape[3] + 2 * padding__.Item2 - dilation__.Item2 * (kernel_size__.Item2 - 1) - 1) / stride__.Item2 + 1,
                                           dtype: x.dtype, requires_grad: (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                        var indices = new Tensor(y.__shape, dtype: torch.int64, requires_grad: false);
                        switch(x.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.MaxPool2d(x.__half, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__half, y.__shape, indices.__int64);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dMaxPool2d(x.grad.__half, indices.__int64, y.grad.__half, y.__shape);
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
                                MKL.MaxPool2d(x.__float, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__float, y.__shape, indices.__int64);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dMaxPool2d(x.grad.__float, indices.__int64, y.grad.__float, y.__shape);
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
                                MKL.MaxPool2d(x.__double, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__double, y.__shape, indices.__int64);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dMaxPool2d(x.grad.__double, indices.__int64, y.grad.__double, y.__shape);
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
                                MKL.MaxPool2d(x.__int8, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__int8, y.__shape, indices.__int64);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.MaxPool2d(x.__uint8, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__uint8, y.__shape, indices.__int64);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.MaxPool2d(x.__int16, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__int16, y.__shape, indices.__int64);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.MaxPool2d(x.__int32, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__int32, y.__shape, indices.__int64);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.MaxPool2d(x.__int64, x.__shape, kernel_size__, stride__, padding__, dilation__, y.__int64, y.__shape, indices.__int64);
                                break;
                            }
                        }
                        return new Tuple<Tensor, Tensor>(y, indices);
                    }

                    public static Tensor max_pool2d(Tensor x, Union<int, Tuple<int, int>> kernel_size, Union<int, Tuple<int, int>> stride = null, Union<int, Tuple<int, int>> padding = null, Union<int, Tuple<int, int>> dilation = null)
                    {
                        return max_pool2d_with_indices(x, kernel_size, stride, padding, dilation).Item1;
                    }

                    public static Tensor sigmoid(Tensor x)
                    {
                        return x.sigmoid();
                    }

                    public static Tensor relu(Tensor x)
                    {
                        return x.relu();
                    }

                    public static Tensor tanh(Tensor x)
                    {
                        return x.tanh();
                    }

                    public static Tensor conv2d(Tensor x, Tensor weight, Tensor bias = null, Union<int, Tuple<int, int>> stride = null, Union<int, Tuple<int, int>> padding = null, Union<int, Tuple<int, int>> dilation = null, int groups = 1)
                    {
                        if(x.dtype == torch.@bool)
                        {
                            throw new TorchException("TorchException: nn.functional.conv2d is not implemented for bool tensors.");
                        }
                        if(x.__shape.Length != 4)
                        {
                            throw new TorchException("TorchException: nn.functional.conv2d requires 4D input, but " + x.__shape.Length.ToString() + "D given.");
                        }
                        Tuple<int, int> stride__;
                        if(stride == null)
                        {
                            stride__ = new Tuple<int, int>(1, 1);
                        }
                        else
                        {
                            if((Tuple<int, int>)stride != null)
                            {
                                stride__ = (Tuple<int, int>)stride;
                            }
                            else
                            {
                                stride__ = new Tuple<int, int>((int)stride, (int)stride);
                            }
                        }
                        Tuple<int, int> padding__;
                        if(padding == null)
                        {
                            padding__ = new Tuple<int, int>(0, 0);
                        }
                        else
                        {
                            if((Tuple<int, int>)padding != null)
                            {
                                padding__ = (Tuple<int, int>)padding;
                            }
                            else
                            {
                                padding__ = new Tuple<int, int>((int)padding, (int)padding);
                            }
                        }
                        Tuple<int, int> dilation__;
                        if(dilation == null)
                        {
                            dilation__ = new Tuple<int, int>(1, 1);
                        }
                        else
                        {
                            if((Tuple<int, int>)dilation != null)
                            {
                                dilation__ = (Tuple<int, int>)dilation;
                            }
                            else
                            {
                                dilation__ = new Tuple<int, int>((int)dilation, (int)dilation);
                            }
                        }
                        if((stride__.Item1 < 1) || (stride__.Item2 < 1))
                        {
                            throw new TorchException("TorchException: stride should be >= 1.");
                        }
                        if((padding__.Item1 < 0) || (padding__.Item2 < 0))
                        {
                            throw new TorchException("TorchException: padding should be >= 0.");
                        }
                        if((dilation__.Item1 < 1) || (dilation__.Item2 < 1))
                        {
                            throw new TorchException("TorchException: dilation should be >= 1.");
                        }
                        int srcB = x.__shape[0];
                        int srcC = x.__shape[1];
                        int srcH = x.__shape[2];
                        int srcW = x.__shape[3];
                        int padX = padding__.Item2;
                        int padY = padding__.Item1;
                        int padH = padding__.Item1;
                        int padW = padding__.Item2;
                        int dilationX = dilation__.Item2;
                        int dilationY = dilation__.Item1;
                        int strideX = stride__.Item2;
                        int strideY = stride__.Item1;
                        int kernelX = weight.__shape[3];
                        int kernelY = weight.__shape[2];
                        int dstC = weight.__shape[0];
                        int dstH = (srcH + padY + padH - (dilationY * (kernelY - 1) + 1)) / strideY + 1;
                        int dstW = (srcW + padX + padW - (dilationX * (kernelX - 1) + 1)) / strideX + 1;
                        switch(x.dtype)
                        {
                            case torch.float32:
                            {
                                switch(weight.dtype)
                                {
                                    case torch.float32:
                                    {
                                        var y = new Tensor(new int[]{srcB, dstC, dstH, dstW}, torch.float32, (!torch.autograd.grad_mode.no_grad.prev) && (x.requires_grad || weight.requires_grad));
                                        MKL.Conv2d(x.__float, srcB, srcC, srcH, srcW, kernelY, kernelX, dilationY, dilationX, strideY, strideX, padY, padX, padH, padW, groups, weight.__float, y.__float, dstC, dstH, dstW);
                                        if((object)bias != null)
                                        {
                                            y = y + torch.unsqueeze(torch.unsqueeze(torch.unsqueeze(bias, 0), 2), 3);
                                        }
                                        return y;
                                    }
                                }
                                break;
                            }
                        }
                        return null;
                    }

                }

            }

        }

    }

}
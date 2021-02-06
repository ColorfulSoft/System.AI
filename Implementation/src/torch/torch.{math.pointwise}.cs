//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region Pointwise

            public static Tensor abs(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.abs is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Abs(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAbs(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Abs(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAbs(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Abs(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAbs(x.__double, x.grad.__double, y.grad.__double);
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
                        MKL.Abs(x.__int8, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Abs(x.__uint8, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Abs(x.__int16, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Abs(x.__int32, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Abs(x.__int64, y.__int64);
                        break;
                    }
                }
                return y;
            }

            public static Tensor absolute(this Tensor x)
            {
                return torch.abs(x);
            }

            public static Tensor acos(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.acos is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Acos(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAcos(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Acos(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAcos(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Acos(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAcos(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.acos is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor arccos(this Tensor x)
            {
                return torch.acos(x);
            }

            public static Tensor asin(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.asin is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Asin(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAsin(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Asin(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAsin(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Asin(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAsin(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.asin is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor arcsin(this Tensor x)
            {
                return torch.asin(x);
            }

            public static Tensor atan(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.atan is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Atan(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAtan(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Atan(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAtan(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Atan(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dAtan(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.atan is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor arctan(this Tensor x)
            {
                return torch.atan(x);
            }

            public static Tensor bitwise_not(this Tensor x)
            {
                if(x.requires_grad)
                {
                    throw new TorchException("TorchException: torch.bitwise_not is not supported by autodiff, but x requires grad.");
                }
                var y = new Tensor(x.__shape, x.dtype, false);
                switch(x.dtype)
                {
                    case torch.float16:
                    case torch.float32:
                    case torch.float64:
                    {
                        throw new TorchException("TorchException: torch.bitwise_not is not implemented for floating point tensors.");
                    }
                    case torch.int8:
                    {
                        MKL.BitwiseNot(x.__int8, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.BitwiseNot(x.__uint8, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.BitwiseNot(x.__int16, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.BitwiseNot(x.__int32, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.BitwiseNot(x.__int64, y.__int64);
                        break;
                    }
                    case torch.@bool:
                    {
                        MKL.BitwiseNot(x.__bool, y.__bool);
                        break;
                    }
                }
                return y;
            }

            public static Tensor ceil(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.ceil is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Ceil(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
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
                        MKL.Ceil(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
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
                        MKL.Ceil(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.ceil is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor clamp(this Tensor x, double min, double max)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.clamp is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Clamp(x.__half, min, max, y.__half);
                        if(y.requires_grad)
                        {
                            MKL.dClamp(x.__half, x.grad.__half, min, max, y.grad.__half);
                            y.__backward_fn = () =>
                            {
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
                        MKL.Clamp(x.__float, min, max, y.__float);
                        if(y.requires_grad)
                        {
                            MKL.dClamp(x.__float, x.grad.__float, min, max, y.grad.__float);
                            y.__backward_fn = () =>
                            {
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
                        MKL.Clamp(x.__double, min, max, y.__double);
                        if(y.requires_grad)
                        {
                            MKL.dClamp(x.__double, x.grad.__double, min, max, y.grad.__double);
                            y.__backward_fn = () =>
                            {
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
                        MKL.Clamp(x.__int8, min, max, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Clamp(x.__uint8, min, max, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Clamp(x.__int16, min, max, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Clamp(x.__int32, min, max, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Clamp(x.__int64, min, max, y.__int64);
                        break;
                    }
                }
                return y;
            }

            public static Tensor cos(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.cos is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Cos(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCos(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Cos(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCos(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Cos(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCos(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.cos is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor cosh(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.cosh is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Cosh(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCosh(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Cosh(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCosh(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Cosh(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dCosh(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.cosh is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor exp(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.exp is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Exp(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dExp(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Exp(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dExp(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Exp(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dExp(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.exp is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor neg(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.neg is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Neg(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dNeg(x.grad.__half, y.grad.__half);
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
                        MKL.Neg(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dNeg(x.grad.__float, y.grad.__float);
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
                        MKL.Neg(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dNeg(x.grad.__double, y.grad.__double);
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
                        MKL.Neg(x.__int8, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.Neg(x.__uint8, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.Neg(x.__int16, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.Neg(x.__int32, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.Neg(x.__int64, y.__int64);
                        break;
                    }
                }
                return y;
            }

            public static Tensor relu(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.relu is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.ReLU(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dReLU(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.ReLU(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dReLU(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.ReLU(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dReLU(x.__double, x.grad.__double, y.grad.__double);
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
                        MKL.ReLU(x.__int8, y.__int8);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.ReLU(x.__uint8, y.__uint8);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.ReLU(x.__int16, y.__int16);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.ReLU(x.__int32, y.__int32);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.ReLU(x.__int64, y.__int64);
                        break;
                    }
                }
                return y;
            }

            public static Tensor logical_not(this Tensor x)
            {
                if(x.requires_grad)
                {
                    throw new TorchException("TorchException: torch.logical_not is not supported by autodiff, but x requires grad.");
                }
                var y = new Tensor(x.__shape, torch.@bool, false);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.LogicalNot(x.__half, y.__bool);
                        break;
                    }
                    case torch.float32:
                    {
                        MKL.LogicalNot(x.__float, y.__bool);
                        break;
                    }
                    case torch.float64:
                    {
                        MKL.LogicalNot(x.__double, y.__bool);
                        break;
                    }
                    case torch.int8:
                    {
                        MKL.LogicalNot(x.__int8, y.__bool);
                        break;
                    }
                    case torch.uint8:
                    {
                        MKL.LogicalNot(x.__uint8, y.__bool);
                        break;
                    }
                    case torch.int16:
                    {
                        MKL.LogicalNot(x.__int16, y.__bool);
                        break;
                    }
                    case torch.int32:
                    {
                        MKL.LogicalNot(x.__int32, y.__bool);
                        break;
                    }
                    case torch.int64:
                    {
                        MKL.LogicalNot(x.__int64, y.__bool);
                        break;
                    }
                    case torch.@bool:
                    {
                        MKL.LogicalNot(x.__bool, y.__bool);
                        break;
                    }
                }
                return y;
            }

            public static Tensor logical_not(this Tensor x, ref Tensor @out)
            {
                if(x.requires_grad)
                {
                    throw new TorchException("TorchException: torch.logical_not is not supported by autodiff, but x requires grad.");
                }
                if(@out.requires_grad)
                {
                    throw new TorchException("TorchException: torch.logical_not is not supported by autodiff, but out requires grad.");
                }
                var y = (@out.shape == x.shape) ? @out : new Tensor(x.__shape, @out.dtype, false);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__half, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__half, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__half, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__half, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__half, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__half, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__half, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__half, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__half, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.float32:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__float, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__float, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__float, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__float, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__float, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__float, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__float, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__float, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__float, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.float64:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__double, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__double, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__double, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__double, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__double, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__double, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__double, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__double, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__double, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.int8:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__int8, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__int8, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__int8, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__int8, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__int8, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__int8, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__int8, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__int8, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__int8, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.uint8:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__uint8, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__uint8, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__uint8, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__uint8, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__uint8, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__uint8, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__uint8, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__uint8, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__uint8, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.int16:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__int16, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__int16, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__int16, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__int16, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__int16, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__int16, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__int16, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__int16, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__int16, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.int32:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__int32, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__int32, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__int32, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__int32, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__int32, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__int32, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__int32, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__int32, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__int32, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.int64:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__int64, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__int64, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__int64, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__int64, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__int64, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__int64, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__int64, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__int64, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__int64, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                    case torch.@bool:
                    {
                        switch(@out.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.LogicalNot(x.__bool, y.__half);
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.LogicalNot(x.__bool, y.__float);
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.LogicalNot(x.__bool, y.__double);
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.LogicalNot(x.__bool, y.__int8);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.LogicalNot(x.__bool, y.__uint8);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.LogicalNot(x.__bool, y.__int16);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.LogicalNot(x.__bool, y.__int32);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.LogicalNot(x.__bool, y.__int64);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.LogicalNot(x.__bool, y.__bool);
                                break;
                            }
                        }
                        break;
                    }
                }
                @out = y;
                return y;
            }

            public static Tensor sigmoid(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.sigmoid is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Sigmoid(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSigmoid(x.grad.__half, y.__half, y.grad.__half);
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
                        MKL.Sigmoid(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSigmoid(x.grad.__float, y.__float, y.grad.__float);
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
                        MKL.Sigmoid(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSigmoid(x.grad.__double, y.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.sigmoid is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor sin(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.sin is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Sin(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSin(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Sin(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSin(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Sin(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSin(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.sin is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor sinh(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.sinh is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Sinh(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSinh(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Sinh(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSinh(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Sinh(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dSinh(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.sinh is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            public static Tensor tanh(this Tensor x)
            {
                if(x.dtype == torch.@bool)
                {
                    throw new TorchException("TorchException: torch.tanh is not implemented for bool tensors.");
                }
                var y = new Tensor(x.__shape, x.dtype, (!torch.autograd.grad_mode.no_grad.prev) && x.requires_grad);
                switch(x.dtype)
                {
                    case torch.float16:
                    {
                        MKL.Tanh(x.__half, y.__half);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTanh(x.__half, x.grad.__half, y.grad.__half);
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
                        MKL.Tanh(x.__float, y.__float);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTanh(x.__float, x.grad.__float, y.grad.__float);
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
                        MKL.Tanh(x.__double, y.__double);
                        if(y.requires_grad)
                        {
                            y.__backward_fn = () =>
                            {
                                MKL.dTanh(x.__double, x.grad.__double, y.grad.__double);
                                if(x.__backward_fn != null)
                                {
                                    x.__backward_fn();
                                }
                            };
                        }
                        break;
                    }
                    case torch.int8:
                    case torch.uint8:
                    case torch.int16:
                    case torch.int32:
                    case torch.int64:
                    {
                        throw new TorchException("TorchException: torch.tanh is not implemented for integer tensors.");
                    }
                }
                return y;
            }

            #endregion

        }

    }

}
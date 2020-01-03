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

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                if(dtype == dtype.@default)
                {
                    dtype = torch.default_dtype;
                }
                if(dtype != torch.float32)
                {
                    throw new TorchException("TorchException: torch.uniform is not implemented for int tensors.");
                }
                var result =  new Tensor(dtype, requires_grad);
                var Threads = Environment.ProcessorCount;
                var _numel = (result.__width * result.__height * result.__depth * result.__time * result.__batch);
                var TaskPart = _numel / Threads;
                switch(dtype)
                {
                    case torch.float32:
                    {
                        Parallel.For(0, Threads, (long tp) =>
                        {
                            for(long i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                            {
                                result.__data_float32[i] = (float)(__rand() * (max - min) + min);
                            }
                        });
                        for(long i = Threads * TaskPart; i < _numel; i++)
                        {
                            result.__data_float32[i] = (float)(__rand() * (max - min) + min);
                        }
                        break;
                    }
                }
                return result;
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long w, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return uniform(new long[]{w}, min, max, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long h, long w, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return uniform(new long[]{h, w}, min, max, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long d, long h, long w, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return uniform(new long[]{d, h, w}, min, max, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long t, long d, long h, long w, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return uniform(new long[]{t, d, h, w}, min, max, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long b, long t, long d, long h, long w, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return uniform(new long[]{b, t, d, h, w}, min, max, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(int[] size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                switch(size.Length)
                {
                    case 1:
                    {
                        return randn(new long[]{size[0]}, dtype, requires_grad);
                    }
                    case 2:
                    {
                        return randn(new long[]{size[0], size[1]}, dtype, requires_grad);
                    }
                    case 3:
                    {
                        return randn(new long[]{size[0], size[1], size[2]}, dtype, requires_grad);
                    }
                    case 4:
                    {
                        return randn(new long[]{size[0], size[1], size[2], size[3]}, dtype, requires_grad);
                    }
                    case 5:
                    {
                        return randn(new long[]{size[0], size[1], size[2], size[3], size[4]}, dtype, requires_grad);
                    }
                }
                return null;
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(long[] size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                if(dtype == dtype.@default)
                {
                    dtype = torch.default_dtype;
                }
                if(dtype != torch.float32)
                {
                    throw new TorchException("TorchException: torch.uniform is not implemented for int tensors.");
                }
                var result =  new Tensor((Size)size, dtype: dtype, requires_grad: requires_grad);
                var Threads = Environment.ProcessorCount;
                var _numel = (result.__width * result.__height * result.__depth * result.__time * result.__batch);
                var TaskPart = _numel / Threads;
                switch(dtype)
                {
                    case torch.float32:
                    {
                        Parallel.For(0, Threads, (long tp) =>
                        {
                            for(long i = tp * TaskPart; i < (tp + 1) * TaskPart; i++)
                            {
                                result.__data_float32[i] = (float)(__rand() * (max - min) + min);
                            }
                        });
                        for(long i = Threads * TaskPart; i < _numel; i++)
                        {
                            result.__data_float32[i] = (float)(__rand() * (max - min) + min);
                        }
                        break;
                    }
                }
                return result;
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<int> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<int, int> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<int, int, int> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<int, int, int, int> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3, size.Item4}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<int, int, int, int, int> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3, size.Item4, size.Item5}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<long> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<long, long> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<long, long, long> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<long, long, long, long> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3, size.Item4}, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor uniform(Tuple<long, long, long, long, long> size, float min, float max, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return randn(new long[]{size.Item1, size.Item2, size.Item3, size.Item4, size.Item5}, dtype, requires_grad);
            }

        }

    }

}
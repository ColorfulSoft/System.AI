//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;

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
            public static Tensor zeros(dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long w, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(w), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long h, long w, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(h, w), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long d, long h, long w, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(d, h, w), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long t, long d, long h, long w, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(t, d, h, w), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long b, long t, long d, long h, long w, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(b, t, d, h, w), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(int[] size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor((Size)size, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(long[] size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor((Size)size, dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<int> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<int, int> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<int, int, int> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<int, int, int, int> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3, size.Item4), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<int, int, int, int, int> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3, size.Item4, size.Item5), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<long> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<long, long> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<long, long, long> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<long, long, long, long> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3, size.Item4), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Tuple<long, long, long, long, long> size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(new Size(size.Item1, size.Item2, size.Item3, size.Item4, size.Item5), dtype, requires_grad);
            }

            ///<summary>Returns a tensor filled with the scalar value 0, with the shape defined by the variable argument size.</summary>
            ///<param name = "size">A sequence of integers defining the shape of the output tensor. Can be a variable number of arguments or a collection like a list or tuple.</param>
            ///<param name = "dtype">the desired data type of returned tensor. Default: if None, uses a global default(see torch.set_default_tensor_type()).</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: False.</param>
            public static Tensor zeros(Size size, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return new Tensor(size, dtype, requires_grad);
            }

        }

    }

}
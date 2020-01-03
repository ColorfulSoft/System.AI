//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float[] data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float[,] data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float[,,] data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float[,,,] data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float[,,,,] data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte[] data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte[,] data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte[,,] data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte[,,,] data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte[,,,,] data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long[] data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long[,] data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long[,,] data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long[,,,] data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long[,,,,] data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                return new Tensor(data, dtype, requires_grad);
            }

            //-> from single value

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(float data, dtype dtype = torch.dtype.float32, bool requires_grad = false)
            {
                var result = new Tensor(new float[]{data}, dtype, requires_grad);
                result.__ndim = 0;
                return result;
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(byte data, dtype dtype = torch.dtype.uint8, bool requires_grad = false)
            {
                var result = new Tensor(new byte[]{data}, dtype, requires_grad);
                result.__ndim = 0;
                return result;
            }

            ///<summary>Constructs a tensor with data.</summary>
            ///<param name = "data">Initial data for the tensor.</param>
            ///<param name = "dtype">The desired data type of returned tensor. Default: if not passed, infers data type from data.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor tensor(long data, dtype dtype = torch.dtype.int64, bool requires_grad = false)
            {
                var result = new Tensor(new long[]{data}, dtype, requires_grad);
                result.__ndim = 0;
                return result;
            }

        }

    }

}
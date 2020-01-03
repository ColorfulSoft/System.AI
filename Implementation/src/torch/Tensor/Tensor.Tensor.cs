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

            public sealed partial class Tensor
            {

                //**************************************************
                //-> float array to torch.Tensor
                //**************************************************

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">float 1-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(float[] data, torch.dtype dtype = torch.dtype.float32, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 1;
                    this.__width = data.Length;
                    this.__height = 1;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">float 2-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(float[,] data, torch.dtype dtype = torch.dtype.float32, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 2;
                    this.__width = data.GetLength(1);
                    this.__height = data.GetLength(0);
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">float 3-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(float[,,] data, torch.dtype dtype = torch.dtype.float32, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 3;
                    this.__width = data.GetLength(2);
                    this.__height = data.GetLength(1);
                    this.__depth = data.GetLength(0);
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">float 4-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(float[,,,] data, torch.dtype dtype = torch.dtype.float32, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 4;
                    this.__width = data.GetLength(3);
                    this.__height = data.GetLength(2);
                    this.__depth = data.GetLength(1);
                    this.__time = data.GetLength(0);
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">float 5-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(float[,,,,] data, torch.dtype dtype = torch.dtype.float32, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 5;
                    this.__width = data.GetLength(4);
                    this.__height = data.GetLength(3);
                    this.__depth = data.GetLength(2);
                    this.__time = data.GetLength(1);
                    this.__batch = data.GetLength(0);
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                //**************************************************
                //-> byte array to torch.Tensor
                //**************************************************

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">byte 1-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(byte[] data, torch.dtype dtype = torch.dtype.uint8, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 1;
                    this.__width = data.Length;
                    this.__height = 1;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">byte 2-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(byte[,] data, torch.dtype dtype = torch.dtype.uint8, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 2;
                    this.__width = data.GetLength(1);
                    this.__height = data.GetLength(0);
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">byte 3-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(byte[,,] data, torch.dtype dtype = torch.dtype.uint8, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 3;
                    this.__width = data.GetLength(2);
                    this.__height = data.GetLength(1);
                    this.__depth = data.GetLength(0);
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">byte 4-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(byte[,,,] data, torch.dtype dtype = torch.dtype.uint8, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 4;
                    this.__width = data.GetLength(3);
                    this.__height = data.GetLength(2);
                    this.__depth = data.GetLength(1);
                    this.__time = data.GetLength(0);
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">byte 5-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(byte[,,,,] data, torch.dtype dtype = torch.dtype.uint8, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 5;
                    this.__width = data.GetLength(4);
                    this.__height = data.GetLength(3);
                    this.__depth = data.GetLength(2);
                    this.__time = data.GetLength(1);
                    this.__batch = data.GetLength(0);
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                //**************************************************
                //-> long array to torch.Tensor
                //**************************************************

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">long 1-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(long[] data, torch.dtype dtype = torch.dtype.int64, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 1;
                    this.__width = data.Length;
                    this.__height = 1;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">long 2-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(long[,] data, torch.dtype dtype = torch.dtype.int64, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 2;
                    this.__width = data.GetLength(1);
                    this.__height = data.GetLength(0);
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">long 3-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(long[,,] data, torch.dtype dtype = torch.dtype.int64, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 3;
                    this.__width = data.GetLength(2);
                    this.__height = data.GetLength(1);
                    this.__depth = data.GetLength(0);
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">long 4-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(long[,,,] data, torch.dtype dtype = torch.dtype.int64, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 4;
                    this.__width = data.GetLength(3);
                    this.__height = data.GetLength(2);
                    this.__depth = data.GetLength(1);
                    this.__time = data.GetLength(0);
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                ///<summary>Initialize Tensor from a given standard .NET array.</summary>
                ///<param name="data">long 5-dim array.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name="requires_grad">If false, torch.autograd will not record operations with this Tensor.</param>
                public Tensor(long[,,,,] data, torch.dtype dtype = torch.dtype.int64, bool requires_grad = false)
                {
                    if(data == null)
                    {
                        throw new NullReferenceException("The parameter had an invalid null value.");
                    }
                    this.__ndim = 5;
                    this.__width = data.GetLength(4);
                    this.__height = data.GetLength(3);
                    this.__depth = data.GetLength(2);
                    this.__time = data.GetLength(1);
                    this.__batch = data.GetLength(0);
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                    switch(this.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            __match(data, this.__data_float32);
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            __match(data, this.__data_uint8);
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            __match(data, this.__data_int64);
                            break;
                        }
                    }
                }

                //--------------------------------------------------
                //-> Initialization of tensor elements by zeros by tensor size and data type.
                //--------------------------------------------------

                ///<summary>Initializes a 0-dimensional tensor of the default data type and assigns all its elements a value of 0.</summary>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(torch.dtype dtype = torch.dtype.@default, bool requires_grad = false)
                {
                    //-> Initialize the dimensions...
                    this.__ndim = 0;
                    this.__width = 1;
                    this.__height = 1;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "width">The width of the tensor.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(int width, bool requires_grad = false, torch.dtype dtype = torch.dtype.@default)
                {
                    //-> Initialize the dimensions...
                    this.__RaiseIfDimensionIsInvalid(width, 1, 1, 1, 1);
                    this.__ndim = 1;
                    this.__width = width;
                    this.__height = 1;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "height">The height of the tensor.</param>
                ///<param name = "width">The width of the tensor.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(long height, long width, bool requires_grad = false, torch.dtype dtype = torch.dtype.@default)
                {
                    //-> Initialize the dimensions...
                    this.__RaiseIfDimensionIsInvalid(width, height, 1, 1, 1);
                    this.__ndim = 2;
                    this.__width = width;
                    this.__height = height;
                    this.__depth = 1;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "depth">The depth of the tensor.</param>
                ///<param name = "height">The height of the tensor.</param>
                ///<param name = "width">The width of the tensor.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(long depth, long height, long width, bool requires_grad = false, torch.dtype dtype = torch.dtype.@default)
                {
                    //-> Initialize the dimensions...
                    this.__RaiseIfDimensionIsInvalid(width, height, depth, 1, 1);
                    this.__ndim = 3;
                    this.__width = width;
                    this.__height = height;
                    this.__depth = depth;
                    this.__time = 1;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "time">The number of times in the tensor (video).</param>
                ///<param name = "depth">The depth of the tensor.</param>
                ///<param name = "height">The height of the tensor.</param>
                ///<param name = "width">The width of the tensor.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(long time, long depth, long height, long width, bool requires_grad = false, torch.dtype dtype = torch.dtype.@default)
                {
                    //-> Initialize the dimensions...
                    this.__RaiseIfDimensionIsInvalid(width, height, depth, time, 1);
                    this.__ndim = 4;
                    this.__width = width;
                    this.__height = height;
                    this.__depth = depth;
                    this.__time = time;
                    this.__batch = 1;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "batch">The batch dimension. Highest dimension.</param>
                ///<param name = "time">The number of times in the tensor (video).</param>
                ///<param name = "depth">The depth of the tensor.</param>
                ///<param name = "height">The height of the tensor.</param>
                ///<param name = "width">The width of the tensor.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(long batch, long time, long depth, long height, long width, bool requires_grad = false, torch.dtype dtype = torch.dtype.@default)
                {
                    //-> Initialize the dimensions...
                    this.__RaiseIfDimensionIsInvalid(width, height, depth, time, batch);
                    this.__ndim = 5;
                    this.__width = width;
                    this.__height = height;
                    this.__depth = depth;
                    this.__time = time;
                    this.__batch = batch;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                    this.__InitializeData();
                }

                ///<summary>Initializes a tensor of the default data type with the specified dimensions and sets all elements to 0.</summary>
                ///<param name = "width">The width of the tensor or 1.</param>
                ///<param name = "height">The height of the tensor or 1.</param>
                ///<param name = "depth">The depth of the tensor or 1.</param>
                ///<param name = "time">The number of times in the tensor (video) or 1.</param>
                ///<param name = "batch">The batch dimension. Highest dimension or 1.</param>
                ///<param name = "dtype">Tensor data type.</param>
                ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
                public Tensor(torch.Size size, torch.dtype dtype = torch.dtype.@default, bool requires_grad = false)
                {
                    this.__ndim = (byte)size.__size.Length;
                    switch(this.__ndim)
                    {
                        case 0:
                        {
                            this.__width = 1;
                            this.__height = 1;
                            this.__depth = 1;
                            this.__time = 1;
                            this.__batch = 1;
                            break;
                        }
                        case 1:
                        {
                            this.__width = size.__size[0];
                            this.__height = 1;
                            this.__depth = 1;
                            this.__time = 1;
                            this.__batch = 1;
                            break;
                        }
                        case 2:
                        {
                            this.__width = size.__size[1];
                            this.__height = size.__size[0];
                            this.__depth = 1;
                            this.__time = 1;
                            this.__batch = 1;
                            break;
                        }
                        case 3:
                        {
                            this.__width = size.__size[2];
                            this.__height = size.__size[1];
                            this.__depth = size.__size[0];
                            this.__time = 1;
                            this.__batch = 1;
                            break;
                        }
                        case 4:
                        {
                            this.__width = size.__size[3];
                            this.__height = size.__size[2];
                            this.__depth = size.__size[1];
                            this.__time = size.__size[0];
                            this.__batch = 1;
                            break;
                        }
                        case 5:
                        {
                            this.__width = size.__size[4];
                            this.__height = size.__size[3];
                            this.__depth = size.__size[2];
                            this.__time = size.__size[1];
                            this.__batch = size.__size[0];
                            break;
                        }
                    }
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    //-> Initialize the data storage...
                    if(dtype == torch.dtype.@default)
                    {
                        dtype = torch.default_dtype;
                    }
                    this.dtype = dtype;
                    this.requires_grad = requires_grad;
                    if((requires_grad) && (dtype != torch.dtype.float32))
                    {
                        throw new torch.TorchException("TorchException: Only Tensors of floating point dtype can require gradients.");
                    }
                    this.__InitializeData();
                    if(requires_grad)
                    {
                        this.__InitializeGrad();
                    }
                }

                ///<summary>Initializes a tensor with references to specified gradient stores as a data store. Required for the Tensor.grad property.</summary>
                ///<param name = "grad_float32">float32 gradient.</param>
                ///<param name = "ndim">Number of dimensions of the tensor.</param>
                ///<param name = "width">The width of the dectination tensor.</param>
                ///<param name = "height">The height of the dectination tensor.</param>
                ///<param name = "depth">The depth of the dectination tensor.</param>
                ///<param name = "time">The time of the dectination tensor.</param>
                ///<param name = "batch">The batch of the dectination tensor.</param>
                private Tensor(float[] grad_float32, byte ndim = 0, long width = 1, long height = 1, long depth = 1, long time = 1, long batch = 1)
                {
                    this.__ndim = ndim;
                    this.__width = width;
                    this.__height = height;
                    this.__depth = depth;
                    this.__time = time;
                    this.__batch = batch;
                    this.__base_width = this.__width;
                    this.__base_height = this.__height;
                    this.__base_depth = this.__depth;
                    this.__base_time = this.__time;
                    this.__base_batch = this.__batch;
                    this.dtype = torch.dtype.float32;
                    this.__data_float32 = grad_float32;
                }

                ///<summary>Converts the .NET standard number to 0-dim Tensor.</summary>
                ///<param name="data">System.Single (C# float).</param>
                public static implicit operator Tensor(float data)
                {
                    var r = new Tensor(torch.dtype.@float, true);
                    r.__data_float32[0] = data;
                    return r;
                }

                ///<summary>Converts the .NET standard number to 0-dim Tensor.</summary>
                ///<param name="data">System.Byte (C# byte).</param>
                public static implicit operator Tensor(byte data)
                {
                    var r = new Tensor(torch.dtype.uint8);
                    r.__data_uint8[0] = data;
                    return r;
                }

                ///<summary>Converts the .NET standard number to 0-dim Tensor.</summary>
                ///<param name="data">System.Int64 (C# long).</param>
                public static implicit operator Tensor(long data)
                {
                    var r = new Tensor(torch.dtype.@long);
                    r.__data_int64[0] = data;
                    return r;
                }

            }

        }

    }

}
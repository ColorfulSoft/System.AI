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

            public static partial class api
            {

                public sealed class Tensor
                {

                    private torch.Tensor __tensor;

                    public Tensor(torch.Tensor t)
                    {
                        this.__tensor = t;
                    }

                    ///<summary>Data inside the tensor. Float32(float, single) data type.</summary>
                    public float[] float32_data
                    {

                        get
                        {
                            return this.__tensor.__data_float32;
                        }

                        set
                        {
                            this.__tensor.__data_float32 = value;
                        }

                    }

                    ///<summary>Data inside the tensor. UInt8(byte) data type.</summary>
                    public byte[] uint8_data
                    {

                        get
                        {
                            return this.__tensor.__data_uint8;
                        }

                        set
                        {
                            this.__tensor.__data_uint8 = value;
                        }

                    }

                    ///<summary>Data inside the tensor. Int64(long) data type.</summary>
                    public long[] int64_data
                    {

                        get
                        {
                            return this.__tensor.__data_int64;
                        }

                        set
                        {
                            this.__tensor.__data_int64 = value;
                        }

                    }

                    ///<summary>Gradients of the tensor. Float32(Single) data type.</summary>
                    public float[] float32_grad
                    {

                        get
                        {
                            return this.__tensor.__grad_float32;
                        }

                        set
                        {
                            this.__tensor.__data_float32 = value;
                        }

                    }

                    public long width
                    {

                        get
                        {
                            return this.__tensor.__width;
                        }

                        set
                        {
                            this.__tensor.__width = value;
                        }

                    }

                    public long height
                    {

                        get
                        {
                            return this.__tensor.__height;
                        }

                        set
                        {
                            this.__tensor.__height = value;
                        }

                    }

                    public long depth
                    {

                        get
                        {
                            return this.__tensor.__depth;
                        }

                        set
                        {
                            this.__tensor.__depth = value;
                        }

                    }

                    public long time
                    {

                        get
                        {
                            return this.__tensor.__time;
                        }

                        set
                        {
                            this.__tensor.__time = value;
                        }

                    }

                    public long batch
                    {

                        get
                        {
                            return this.__tensor.__batch;
                        }

                        set
                        {
                            this.__tensor.__batch = value;
                        }

                    }

                    public long start_width
                    {

                        get
                        {
                            return this.__tensor.__start_width;
                        }

                        set
                        {
                            this.__tensor.__start_width = value;
                        }

                    }

                    public long start_height
                    {

                        get
                        {
                            return this.__tensor.__start_height;
                        }

                        set
                        {
                            this.__tensor.__start_height = value;
                        }

                    }

                    public long start_depth
                    {

                        get
                        {
                            return this.__tensor.__start_depth;
                        }

                        set
                        {
                            this.__tensor.__start_depth = value;
                        }

                    }

                    public long start_time
                    {

                        get
                        {
                            return this.__tensor.__start_time;
                        }

                        set
                        {
                            this.__tensor.__start_time = value;
                        }

                    }

                    public long start_batch
                    {

                        get
                        {
                            return this.__tensor.__start_batch;
                        }

                        set
                        {
                            this.__tensor.__start_batch = value;
                        }

                    }

                    public long base_width
                    {

                        get
                        {
                            return this.__tensor.__base_width;
                        }

                        set
                        {
                            this.__tensor.__base_width = value;
                        }

                    }

                    public long base_height
                    {

                        get
                        {
                            return this.__tensor.__base_height;
                        }

                        set
                        {
                            this.__tensor.__base_height = value;
                        }

                    }

                    public long base_depth
                    {

                        get
                        {
                            return this.__tensor.__base_depth;
                        }

                        set
                        {
                            this.__tensor.__base_depth = value;
                        }

                    }

                    public long base_time
                    {

                        get
                        {
                            return this.__tensor.__base_time;
                        }

                        set
                        {
                            this.__tensor.__base_time = value;
                        }

                    }

                    public long base_batch
                    {

                        get
                        {
                            return this.__tensor.__base_batch;
                        }

                        set
                        {
                            this.__tensor.__base_batch = value;
                        }

                    }

                    public bool restricted
                    {

                        get
                        {
                            return this.__tensor.__restricted;
                        }

                        set
                        {
                            this.__tensor.__restricted = value;
                        }

                    }

                }

            }

        }

    }

}
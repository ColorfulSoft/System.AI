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

            ///<summary>Represents a multidimensional matrix of elements of a fixed type.</summary>
            public sealed partial class Tensor
            {

                //------------------------------
                //-> Data.
                //------------------------------

                ///<summary>Data type of this tensor.</summary>
                public torch.dtype dtype
                {

                    get;

                    internal set;

                }

                ///<summary>If autograd should record operations on the returned tensor. Default: false.</summary>
                public bool requires_grad
                {

                    get;

                    internal set;

                }

                ///<summary>Data inside the tensor. Float32(float, single) data type.</summary>
                internal float[] __data_float32;

                ///<summary>Data inside the tensor. UInt8(byte) data type.</summary>
                internal byte[] __data_uint8;

                ///<summary>Data inside the tensor. Int64(long) data type.</summary>
                internal long[] __data_int64;

                //------------------------------
                //-> Gradients.
                //------------------------------

                ///<summary>Gradients of the tensor. Float32(Single) data type.</summary>
                internal float[] __grad_float32;

                //------------------------------
                //-> Backward
                //------------------------------

                ///<summary>The delegate type for the error back propagation method.</summary>
                internal delegate void __backward();

                ///<summary>Error back propagation method for this tensor.</summary>
                internal __backward __backward_fn;

                //------------------------------
                //-> Dimensions information.
                //------------------------------

                ///<summary>Number of tensor measurements.</summary>
                internal byte __ndim;

                ///<summary>The width of the tensor.</summary>
                internal long __width;

                ///<summary>The height of the tensor.</summary>
                internal long __height;

                ///<summary>The depth of the tensor.</summary>
                internal long __depth;

                ///<summary>Dimension of time(for video processing).</summary>
                internal long __time;

                ///<summary>Batch's dimension. Higher dimension.</summary>
                internal long __batch;

                ///<summary>The start-slicing width of the tensor.</summary>
                internal long __start_width;

                ///<summary>The start-slicing height of the tensor.</summary>
                internal long __start_height;

                ///<summary>The start-slicing depth of the tensor.</summary>
                internal long __start_depth;

                ///<summary>The start-slicing dimension of time(for video processing).</summary>
                internal long __start_time;

                ///<summary>The start-slicing batch's dimension. Higher dimension.</summary>
                internal long __start_batch;

                ///<summary>The base width of the tensor.</summary>
                internal long __base_width;

                ///<summary>The base height of the tensor.</summary>
                internal long __base_height;

                ///<summary>The base depth of the tensor.</summary>
                internal long __base_depth;

                ///<summary>The base dimension of time(for video processing).</summary>
                internal long __base_time;

                ///<summary>The base batch's dimension. Higher dimension.</summary>
                internal long __base_batch;

                internal bool __restricted = false;

            }

        }

    }

}
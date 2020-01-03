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

            ///<summary>Returns a tensor filled with the scalar value 1, with the same size as input.</summary>
            ///<param name = "input">The size of input will determine size of the output tensor.</param>
            ///<param name = "dtype">The desired data type of returned Tensor. Default: if default, defaults to the dtype of input.</param>
            ///<param name = "requires_grad">If autograd should record operations on the returned tensor. Default: false.</param>
            public static Tensor ones_like(Tensor input, dtype dtype = dtype.@default, bool requires_grad = false)
            {
                return input.ones_like(dtype, requires_grad);
            }

        }

    }

}
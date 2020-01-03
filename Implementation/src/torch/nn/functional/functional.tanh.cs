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

            public static partial class nn
            {

                public static partial class functional
                {

                    ///<summary>Applies the element-wise function: Tanh(x) = tanh(x) = (e^x - e^(-x))/(e^x + e^(-x)).</summary>
                    ///<param name = "x">Input tensor.</param>
                    public static Tensor tanh(Tensor x)
                    {
                        return torch.tanh(x);
                    }

                }

            }

        }

    }

}
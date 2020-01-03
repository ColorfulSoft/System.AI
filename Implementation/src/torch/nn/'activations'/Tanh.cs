//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

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

                ///<summary>Applies the element-wise function: Tanh(x) = tanh(x) = (e^x - e^(-x))/(e^x + e^(-x)).</summary>
                public sealed class Tanh : Module
                {

                    ///<summary>Initializes the module.</summary>
                    public Tanh() : base()
                    {
                    }

                    ///<summary>Applies the element-wise function: Tanh(x) = tanh(x) = (e^x - e^(-x))/(e^x + e^(-x)).</summary>
                    ///<param name = "input">Input tensor.</param>
                    public Tensor forward(Tensor input)
                    {
                        return functional.tanh(input);
                    }

                }

            }

        }

    }

}
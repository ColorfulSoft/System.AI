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

                ///<summary>Applies the rectified linear unit function element-wise: ReLU(x)=max(0,x).</summary>
                public sealed class ReLU : Module
                {

                    ///<summary>Initializes the module.</summary>
                    public ReLU() : base()
                    {
                    }

                    ///<summary>Applies the rectified linear unit function element-wise: ReLU(x)=max(0,x).</summary>
                    ///<param name = "input">Input tensor.</param>
                    public Tensor forward(Tensor input)
                    {
                        return functional.relu(input);
                    }

                }

            }

        }

    }

}
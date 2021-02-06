//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 20.01.2021.

using System;
using System.Reflection;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public sealed class Sigmoid : Module
                {

                    public Sigmoid()
                    {
                    }

                    public Tensor forward(Tensor x)
                    {
                        return functional.sigmoid(x);
                    }

                }

            }

        }

    }

}
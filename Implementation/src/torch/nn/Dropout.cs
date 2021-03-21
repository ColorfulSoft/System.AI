//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                public sealed class Dropout : Module
                {

                    public double p;

                    public Dropout(double p = 0.5)
                    {
                        this.p = p;
                    }

                    public override Tensor forward(Tensor x)
                    {
                        return functional.dropout(x, this.p);
                    }

                }

            }

        }

    }

}
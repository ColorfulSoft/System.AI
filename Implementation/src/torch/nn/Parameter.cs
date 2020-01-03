//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static partial class nn
            {

                ///<summary>A kind of Tensor that is to be considered a module parameter.</summary>
                public sealed class Parameter
                {

                    ///<summary>Parameter name(for serialization).</summary>
                    internal string __name;

                    ///<summary>Parameter tensor.</summary>
                    public Tensor data
                    {

                        get;

                        internal set;

                    }

                    ///<summary>If the parameter requires gradient. Default: true</summary>
                    public bool requires_grad
                    {

                        get;

                        internal set;

                    }

                    ///<summary>Initializes the parameter for the data tensor and sets the requires_grad value for the current parameter.</summary>
                    ///<param name="data">Parameter tensor.</param>
                    ///<param name="name">Parameter name.</param>
                    ///<param name="requires_grad">If the parameter requires gradient. Default: true.</param>
                    internal Parameter(Tensor data, string name, bool requires_grad = true)
                    {
                        this.data = data;
                        this.data.requires_grad_(requires_grad);
                        this.__name = name;
                        this.requires_grad = requires_grad;
                    }

                    ///<summary>Initializes the parameter for the data tensor and sets the requires_grad value for the current parameter.</summary>
                    ///<param name="data">Parameter tensor.</param>
                    ///<param name="requires_grad">If the parameter requires gradient. Default: true.</param>
                    public Parameter(Tensor data, bool requires_grad = true)
                    {
                        this.data = data;
                        this.data.requires_grad_(requires_grad);
                        this.requires_grad = requires_grad;
                    }

                    ///<summary>Converts the information in this parameter to a string representation.</summary>
                    public override string ToString()
                    {
                        return "Parameter containing: " + (char)13 + this.data.ToString() + (char)13;
                    }

                }

            }

        }

    }

}
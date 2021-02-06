//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 22.08.2020.

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
                public sealed class Parameter : Tensor
                {

                    ///<summary>Parameter name(for serialization).</summary>
                    internal string __name;

                    ///<summary>Parameter tensor.</summary>
                    public Tensor data
                    {

                        get
                        {
                            return this;
                        }

                    }

                    ///<summary>Initializes the parameter for the data tensor and sets the requires_grad value for the current parameter.</summary>
                    ///<param name="data">Parameter tensor.</param>
                    ///<param name="name">Parameter name.</param>
                    ///<param name="requires_grad">If the parameter requires gradient. Default: true.</param>
                    internal Parameter(Tensor data, string name, bool requires_grad = true)
                    {
                        this.__shape = data.__shape;
                        this.__strides = data.__strides;
                        this.dtype = data.dtype;
                        this.requires_grad_(requires_grad);
                        this.__half = data.__half;
                        this.__float = data.__float;
                        this.__double = data.__double;
                        this.__int8 = data.__int8;
                        this.__uint8 = data.__uint8;
                        this.__int16 = data.__int16;
                        this.__int32 = data.__int32;
                        this.__int64 = data.__int64;
                        this.__bool = data.__bool;
                        this.__name = name;
                    }

                    ///<summary>Initializes the parameter for the data tensor and sets the requires_grad value for the current parameter.</summary>
                    ///<param name="data">Parameter tensor.</param>
                    ///<param name="requires_grad">If the parameter requires gradient. Default: true.</param>
                    public Parameter(Tensor data, bool requires_grad = true)
                    {
                        this.__shape = data.__shape;
                        this.__strides = data.__strides;
                        this.dtype = data.dtype;
                        this.requires_grad_(requires_grad);
                        this.__half = data.__half;
                        this.__float = data.__float;
                        this.__double = data.__double;
                        this.__int8 = data.__int8;
                        this.__uint8 = data.__uint8;
                        this.__int16 = data.__int16;
                        this.__int32 = data.__int32;
                        this.__int64 = data.__int64;
                        this.__bool = data.__bool;
                    }

                    ///<summary>Converts the information in this parameter to a string representation.</summary>
                    public override string ToString()
                    {
                        return "Parameter containing: " + (char)10 + base.ToString();
                    }

                }

            }

        }

    }

}
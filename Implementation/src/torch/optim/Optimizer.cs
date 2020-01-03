//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;
using System.Reflection;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        using Parameter = torch.nn.Parameter;

        public static partial class torch
        {

            public static partial class optim
            {

                ///<summary>Base class for all optimizers.</summary>
                public abstract class Optimizer
                {

                    ///<summary>Returns an iterator over optimizer parameters.</summary>
                    internal virtual List<Parameter> parameters()
                    {
                        var this_type = this.GetType();
                        var this_fields = this_type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                        var param = new List<Parameter>();
                        for(int i = 0; i < this_fields.Length; i++)
                        {
                            if(this_fields[i].FieldType == typeof(Parameter))
                            {
                                var p = this_fields[i].GetValue(this) as Parameter;
                                p.__name = this_type.Name + "." + this_fields[i].Name;
                                param.Add(p);
                            }
                        }
                        return param;
                    }

                    ///<summary>Returns a dictionary containing a whole state of the optimizer. Keys are corresponding parameter and buffer names.</summary>
                    public Dictionary<string, Tensor> state_dict()
                    {
                        var result = new Dictionary<string, Tensor>();
                        var @params = this.parameters();
                        for(int i = 0; i < @params.Count; i++)
                        {
                            result.Add(@params[i].__name, @params[i].data);
                        }
                        return result;
                    }

                    public delegate void closure();

                    public void step(closure closure)
                    {
                    }

                }

            }

        }

    }

}
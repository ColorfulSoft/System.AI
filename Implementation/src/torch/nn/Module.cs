//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

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

                ///<summary>Base class for all neural network modules. Your models should also subclass this class.</summary>
                public abstract class Module
                {

                    ///<summary>Retrieves all parameters and submodules from the provided list of modules. Necessary to recursively obtain the parameters in the parameters().</summary>
                    ///<param name="container">Modules from which to extract parameters and submodules.</param>
                    ///<param name="modules">Extracted modules. Ref - parameter.</param>
                    ///<param name="module_names">Full path to the input modules. After executing the method, it will be overwritten with paths to the extracted modules. Ref-parameter.</param>
                    ///<param name="parameters">General list of parameters. The parameters extracted during the method execution will be added to it.</param>
                    private static bool __get_params_and_modules(List<Module> container, ref List<Module> modules, ref List<string> module_names, List<Parameter> parameters)
                    {
                        var result = false;
                        var module = new List<Module>();
                        var _module_names = new List<string>();
                        for(int n = 0; n < container.Count; n++)
                        {
                            var this_type = container[n].GetType();
                            var this_fields = this_type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                            for(int i = 0; i < this_fields.Length; i++)
                            {
                                if(this_fields[i].FieldType == typeof(Parameter))
                                {
                                    var p = this_fields[i].GetValue(container[n]) as Parameter;
                                    p.__name = module_names[n] + "." + this_fields[i].Name;
                                    parameters.Add(p);
                                }
                                else
                                {
                                    if(this_fields[i].FieldType.BaseType == typeof(Module))
                                    {
                                        result = true;
                                        module.Add(this_fields[i].GetValue(container[n]) as Module);
                                        _module_names.Add(module_names[n] + "." + this_fields[i].Name);
                                    }
                                }
                            }
                        }
                        modules = module;
                        module_names = _module_names;
                        return result;
                    }

                    ///<summary>Returns an iterator over module parameters.</summary>
                    ///<param name="recurse">if True, then yields parameters of this module and all submodules. Otherwise, yields only parameters that are direct members of this module. Default: true.</param>
                    public virtual List<Parameter> parameters(bool recurse = true)
                    {
                        var this_type = this.GetType();
                        var this_fields = this_type.GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                        if(recurse == false)
                        {
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
                        else
                        {
                            var @params = new List<Parameter>();
                            var modules = new List<Module>();
                            var module_names = new List<string>();
                            for(int i = 0; i < this_fields.Length; i++)
                            {
                                if(this_fields[i].FieldType == typeof(Parameter))
                                {
                                    var p = this_fields[i].GetValue(this) as Parameter;
                                    p.__name = this_type.Name + "." + this_fields[i].Name;
                                    @params.Add(p);
                                }
                                if(this_fields[i].FieldType.BaseType == typeof(Module))
                                {
                                    modules.Add(this_fields[i].GetValue(this) as Module);
                                    module_names.Add(this_type.Name + "." + this_fields[i].Name);
                                }
                            }
                            while(__get_params_and_modules(modules, ref modules, ref module_names, @params))
                            {
                            }
                            return @params;
                        }
                    }

                    ///<summary>Returns a dictionary containing a whole state of the module. Both parameters and persistent buffers (e.g. running averages) are included. Keys are corresponding parameter and buffer names.</summary>
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

                    ///<summary>Copies parameters and buffers from state_dict into this module and its descendants.</summary>
                    public void load_state_dict(Dictionary<string, Tensor> state_dict)
                    {
                        var @params = this.state_dict();
                        foreach(var p in @params)
                        {
                            p.Value.__link_data_from_tensor(state_dict[p.Key]);
                        }
                    }

                }

            }

        }

    }

}
//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 21.03.2021.

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
                            if(this_type == typeof(Sequential))
                            {
                                var sequential = container[n] as Sequential;
                                if(sequential.__modules.Count > 0)
                                {
                                    result = true;
                                }
                                for(int j = 0; j < sequential.__modules.Count; j++)
                                {
                                    module.Add(sequential.__modules[j]);
                                    _module_names.Add(module_names[n] + "." + j.ToString());
                                }
                                break;
                            }
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
                                    if((this_fields[i].FieldType.BaseType == typeof(Module)) && (this_fields[i].FieldType != typeof(Sequential)))
                                    {
                                        result = true;
                                        module.Add(this_fields[i].GetValue(container[n]) as Module);
                                        _module_names.Add(module_names[n] + "." + this_fields[i].Name);
                                    }
                                    else
                                    {
                                        if(this_fields[i].FieldType == typeof(Sequential))
                                        {
                                            var sequential = this_fields[i].GetValue(container[n]) as Sequential;
                                            if(sequential.__modules.Count > 0)
                                            {
                                                result = true;
                                            }
                                            for(int j = 0; j < sequential.__modules.Count; j++)
                                            {
                                                module.Add(sequential.__modules[j]);
                                                _module_names.Add(module_names[n] + "." + this_fields[i].Name + "." + j.ToString());
                                            }
                                        }
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
                        if(this is Sequential)
                        {
                            var @params = new List<Parameter>();
                            var modules = new List<Module>();
                            var module_names = new List<string>();
                            var sequential = this as Sequential;
                            for(int j = 0; j < sequential.__modules.Count; j++)
                            {
                                modules.Add(sequential.__modules[j]);
                                module_names.Add(j.ToString());
                            }
                            while(__get_params_and_modules(modules, ref modules, ref module_names, @params))
                            {
                            }
                            return @params;
                        }
                        else
                        {
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
                                    if((this_fields[i].FieldType.BaseType == typeof(Module)) && (this_fields[i].FieldType != typeof(Sequential)))
                                    {
                                        modules.Add(this_fields[i].GetValue(this) as Module);
                                        module_names.Add(this_type.Name + "." + this_fields[i].Name);
                                    }
                                    if(this_fields[i].FieldType == typeof(Sequential))
                                    {
                                        var sequential = this_fields[i].GetValue(this) as Sequential;
                                        for(int j = 0; j < sequential.__modules.Count; j++)
                                        {
                                            modules.Add(sequential.__modules[j]);
                                            module_names.Add(this_type.Name + "." + this_fields[i].Name + "." + j.ToString());
                                        }
                                    }
                                }
                                while(__get_params_and_modules(modules, ref modules, ref module_names, @params))
                                {
                                }
                                return @params;
                            }
                        }
                    }

                    ///<summary>Returns a dictionary containing a whole state of the module. Both parameters and persistent buffers (e.g. running averages) are included. Keys are corresponding parameter and buffer names.</summary>
                    public Dictionary<string, Tensor> state_dict()
                    {
                        var result = new Dictionary<string, Tensor>();
                        var @params = this.parameters();
                        var pad = this.GetType().Name.Length + 1;
                        for(int i = 0; i < @params.Count; i++)
                        {
                            result.Add(@params[i].__name.Substring(pad), @params[i].data);
                        }
                        return result;
                    }

                    ///<summary>Copies parameters and buffers from state_dict into this module and its descendants.</summary>
                    public void load_state_dict(Dictionary<string, Tensor> state_dict)
                    {
                        var @params = this.state_dict();
                        foreach(var p in state_dict)
                        {
                            if(!@params.ContainsKey(p.Key))
                            {
                                throw new TorchException("TorchException: Error(s) in loading state_dict for " + this.GetType().Name + ": " + (char)10 + "  State dict contains the '" + p.Key + "' parameter, but it is not exists in module.");
                            }
                        }
                        foreach(var p in @params)
                        {
                            if(!state_dict.ContainsKey(p.Key))
                            {
                                throw new TorchException("TorchException: Error(s) in loading state_dict for " + this.GetType().Name + ": " + (char)10 + "  Module contains the '" + p.Key + "' parameter, but it is not exists in state_dict.");
                            }
                            if(p.Value.dtype != state_dict[p.Key].dtype)
                            {
                                throw new TorchException("TorchException: Error(s) in loading state_dict for " + this.GetType().Name + ": " + (char)10 + "  Type of '" + p.Key + "' parameter in module and state_dict is not the same.");
                            }
                            if(p.Value.shape != state_dict[p.Key].shape)
                            {
                                throw new TorchException("TorchException: Error(s) in loading state_dict for " + this.GetType().Name + ": " + (char)10 + "  Size mismatch for '" + p.Key + "': copying a param of " + state_dict[p.Key].shape.ToString() + " from checkpoint, where the shape is " + p.Value.shape.ToString() + " in current model.");
                            }
                            p.Value.__half = state_dict[p.Key].__half;
                            p.Value.__float = state_dict[p.Key].__float;
                            p.Value.__double = state_dict[p.Key].__double;
                            p.Value.__int8 = state_dict[p.Key].__int8;
                            p.Value.__uint8 = state_dict[p.Key].__uint8;
                            p.Value.__int16 = state_dict[p.Key].__int16;
                            p.Value.__int32 = state_dict[p.Key].__int32;
                            p.Value.__int64 = state_dict[p.Key].__int64;
                            p.Value.__bool = state_dict[p.Key].__bool;
                        }
                    }

                    public virtual Tensor forward(Tensor x)
                    {
                        throw new NotImplementedException("Forward pass through the abstract module is not implemented.");
                    }

                    public override string ToString()
                    {
                        return this.GetType().Name + "()";
                    }

                }

            }

        }

    }

}
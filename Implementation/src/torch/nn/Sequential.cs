//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 21.08.2020.

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
                public sealed class Sequential : Module
                {

                    internal List<Module> __modules;

                    public Sequential(params Module[] args)
                    {
                        this.__modules = new List<Module>();
                        if(args == null)
                        {
                            return;
                        }
                        for(int i = 0; i < args.Length; i++)
                        {
                            this.__modules.Add(args[i]);
                        }
                    }

                    public Module this[int i]
                    {
                        get
                        {
                            return this.__modules[i];
                        }
                        set
                        {
                            this.__modules[i] = value;
                        }
                    }

                    private string __format_print(string s, int tab)
                    {
                        s += "Sequential(";
                        if(this.__modules.Count == 0)
                        {
                            return s + ")";
                        }
                        s += (char)10;
                        for(int i = 0; i < this.__modules.Count; i++)
                        {
                            for(int j = 0; j < tab; j++)
                            {
                                s += "  ";
                            }
                            s += "(" + i.ToString() + "): ";
                            s = (this.__modules[i] is Sequential) ? (this.__modules[i] as Sequential).__format_print(s, tab + 1) : (s + this.__modules[i].ToString());
                            s += (char)10;
                        }
                        for(int i = 0; i < (tab - 1); i++)
                        {
                            s += "  ";
                        }
                        return s + ")";
                    }

                    public object forward(params object[] x)
                    {
                        object y = x;
                        for(int i = 0; i < this.__modules.Count; i++)
                        {
                            var m = this.__modules[i];
                            if(y is object[])
                            {
                                y = m.GetType().GetMethod("forward").Invoke(m, y as object[]);
                            }
                            else
                            {
                                y = m.GetType().GetMethod("forward").Invoke(m, new object[]{y});
                            }
                        }
                        return y;
                    }

                    public override string ToString()
                    {
                        var s = "Sequential(";
                        if(this.__modules.Count == 0)
                        {
                            return s + ")";
                        }
                        s += (char)10;
                        for(int i = 0; i < this.__modules.Count; i++)
                        {
                            s += "  (" + i.ToString() + "): ";
                            s = (this.__modules[i] is Sequential) ? (this.__modules[i] as Sequential).__format_print(s, 2) : (s + this.__modules[i].ToString());
                            s += (char)10;
                        }
                        return s + ")";
                    }

                }

            }

        }

    }

}
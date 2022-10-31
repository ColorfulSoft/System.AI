//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

// This code is based on https://github.com/karpathy/micrograd

//**************************************************
//* The MIT License (MIT) Copyright (c) 2020 Andrej Karpathy
//*
//* Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:
//*
//* The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.
//*
//* THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//**************************************************

using System;
using System.Collections.Generic;

namespace System.AI
{

    public static partial class micrograd
    {

        public static class nn
        {

            public class Module
            {

                public void zero_grad()
                {
                    foreach(var p in this.parameters())
                    {
                        p.grad = 0;
                    }
                }

                public virtual List<engine.Value> parameters()
                {
                    return new List<engine.Value>();
                }

            }

            public class Neuron : Module
            {

                public engine.Value[] w
                {

                    get;

                    set;

                }

                public engine.Value b;

                public bool nonlin
                {

                    get;

                    set;

                }

                public Neuron(int nin, bool nonlin = true)
                {
                    this.w = new engine.Value[nin];
                    var rand = new Random();
                    for(int i = 0; i < nin; ++i)
                    {
                        this.w[i] = (float)rand.NextDouble() * 2 - 1;
                    }
                    this.b = new engine.Value(0);
                    this.nonlin = nonlin;
                }

                public engine.Value call(engine.Value[] x)
                {
                    engine.Value act = 0;
                    for(int i = 0; i < this.w.Length; ++i)
                    {
                        act += this.w[i] * x[i];
                    }
                    act += this.b;
                    if(this.nonlin)
                    {
                        act = act.relu();
                    }
                    return act;
                }

                public override List<engine.Value> parameters()
                {
                    var ps = new List<engine.Value>(this.w);
                    ps.Add(this.b);
                    return ps;
                }

                public override string ToString()
                {
                    return string.Format("{0}Neuron({1})", this.nonlin ? "ReLU" : "Linear", this.w.Length);
                }

            }

        }

    }

}
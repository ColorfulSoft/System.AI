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

    /// <summary>
    /// A tiny scalar-valued autograd engine and a neural net library on top of it with Torch.NET-like API
    /// </summary>
    public static partial class micrograd
    {

        public static class engine
        {

            /// <summary>
            /// Stores a single scalar value and its gradient.
            /// </summary>
            public sealed class Value
            {

                public float data
                {

                    get;

                    set;

                }

                public float grad
                {

                    get;

                    set;

                }

                private delegate void __backward_fn();

                private __backward_fn _backward;

                private HashSet<Value> _prev;

                private string _op;

                public Value(float data, ICollection<Value> _prev = null, string _op = "")
                {
                    this.data = data;
                    this.grad = 0;
                    // internal variables used for autograd graph construction
                    this._backward = () => {};
                    this._prev = (_prev == null) ? null : new HashSet<Value>(_prev);
                    this._op = _op; // the op that produced this node, for graphviz / debugging / etc
                }

                public static implicit operator Value(float other)
                {
                    return new Value(other);
                }

                public static Value operator +(Value left, Value right)
                {
                    var @out = new Value(left.data + right.data, new []{left, right}, "+");
                    @out._backward = () =>
                    {
                        left.grad += @out.grad;
                        right.grad += @out.grad;
                    };
                    return @out;
                }

                public static Value operator *(Value left, Value right)
                {
                    var @out = new Value(left.data * right.data, new []{left, right}, "*");
                    @out._backward = () =>
                    {
                        left.grad += right.data * @out.grad;
                        right.grad += left.data * @out.grad;
                    };
                    return @out;
                }

                public static Value operator -(Value other) // -self
                {
                    var @out = new Value(-other.data, new []{other}, "neg");
                    @out._backward = () =>
                    {
                        other.grad -= @out.grad;
                    };
                    return @out;
                }

                public static Value operator -(Value left, Value right)
                {
                    var @out = new Value(left.data - right.data, new []{left, right}, "-");
                    @out._backward = () =>
                    {
                        left.grad += @out.grad;
                        right.grad -= @out.grad;
                    };
                    return @out;
                }

                public static Value operator /(Value left, Value right)
                {
                    var @out = new Value(left.data / right.data, new []{left, right}, "/");
                    @out._backward = () =>
                    {
                        left.grad += 1 / right.data * @out.grad;
                        right.grad -= left.data / (right.data * right.data) * @out.grad;
                    };
                    return @out;
                }

                public static Value operator ^(Value left, Value right)
                {
                    var @out = new Value((float)Math.Pow(left.data, right.data), new []{left, right}, "^");
                    @out._backward = () =>
                    {
                        left.grad += right.data * (float)Math.Pow(left.data, right.data - 1) * @out.grad;
                        right.grad += (float)Math.Pow(left.data, right.data) * (float)Math.Log(left.data) * @out.grad;
                    };
                    return @out;
                }

                public Value relu()
                {
                    var @out = new Value((this.data < 0) ? 0 : this.data, new []{this}, "ReLU");
                    @out._backward = () =>
                    {
                        this.grad += (@out.data > 0) ? @out.grad : 0;
                    };
                    return @out;
                }

                public void backward()
                {
                    // topological order all of the children in the graph
                    var topo = new List<Value>();
                    var visited = new HashSet<Value>();
                    Action<Value> build_topo = null;
                    build_topo = (Value v) =>
                    {
                        if(!visited.Contains(v))
                        {
                            visited.Add(v);
                            if(v._prev != null)
                            {
                                foreach(var child in v._prev)
                                {
                                    build_topo(child);
                                }
                            }
                            topo.Add(v);
                        }
                    };
                    build_topo(this);
                    // go one variable at a time and apply the chain rule to get its gradient
                    this.grad = 1;
                    topo.Reverse();
                    foreach(var v in topo)
                    {
                        v._backward();
                    }
                }

                public override string ToString()
                {
                    return string.Format("Value(data={0}, grad={1})", this.data, this.grad);
                }

            }

        }

    }

}
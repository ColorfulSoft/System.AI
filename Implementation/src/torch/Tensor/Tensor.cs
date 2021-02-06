//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            /// <summary>
            /// A torch.Tensor is a multi-dimensional matrix
            /// containing elements of a single data type.
            /// </summary>
            public class Tensor : IList<Tensor>
            {

                #region IList

                public void Add(Tensor o)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public bool Contains(Tensor o)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public void Clear()
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public int IndexOf(Tensor o)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public void Insert(int i, Tensor o)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public bool Remove(Tensor o)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public void RemoveAt(int i)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public Tensor this[params object[] locs]
                {

                    get
                    {
                        var begin = new List<int>();
                        var size = new List<int>();
                        for(int i = 0; i < this.__shape.Length; i++)
                        {
                            begin.Add(0);
                            size.Add(this.__shape[i]);
                        }
                        if(locs.Length > size.Count)
                        {
                            throw new ArgumentException("The number of indexes must not exceed the rank of the tensor.");
                        }
                        for(int i = 0; i < locs.Length; i++)
                        {
                            if(locs[i].GetType() == typeof(string))
                            {
                                var v = locs[i] as string;
                                var start = 0;
                                var end = size[i];
                                if(v[0] == ':')
                                {
                                    if(v.Length > 1)
                                    {
                                        if(!int.TryParse(v.Substring(1), out end))
                                        {
                                            throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                        }
                                    }
                                }
                                else
                                {
                                    if(v.IndexOf(':') == -1)
                                    {
                                        if(!int.TryParse(v, out start))
                                        {
                                            throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                        }
                                        end = start + 1;
                                    }
                                    else
                                    {
                                        if(!int.TryParse(v.Substring(0, v.IndexOf(':')), out start))
                                        {
                                            throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                        }
                                        if(v.IndexOf(':') < (v.Length - 1))
                                        {
                                            if(!int.TryParse(v.Substring(v.IndexOf(':') + 1), out end))
                                            {
                                                throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                            }
                                        }
                                    }
                                }
                                if(start >= end)
                                {
                                    throw new ArgumentException("The initial index of the slice must not exceed the final index.");
                                }
                                begin[i] = start;
                                size[i] = end - start;
                            }
                            else
                            {
                                if(locs[i].GetType() == typeof(int))
                                {
                                    begin[i] = (int)locs[i];
                                    size[i] = 1;
                                }
                                else
                                {
                                    if(locs[i].GetType() == typeof(uint))
                                    {
                                        begin[i] = (int)(uint)locs[i];
                                        size[i] = 1;
                                    }
                                    else
                                    {
                                        if(locs[i].GetType() == typeof(long))
                                        {
                                            begin[i] = (int)(long)locs[i];
                                            size[i] = 1;
                                        }
                                        else
                                        {
                                            if(locs[i].GetType() == typeof(ulong))
                                            {
                                                begin[i] = (int)(ulong)locs[i];
                                                size[i] = 1;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        var y = new Tensor(size.ToArray(), requires_grad: (!torch.autograd.grad_mode.no_grad.prev) && this.requires_grad, dtype: this.dtype);
                        switch(this.dtype)
                        {
                            case torch.float16:
                            {
                                MKL.SliceGet(this.__half, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__half, y.__strides);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dSliceGet(this.grad.__half, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.grad.__half, y.__strides);
                                        if(this.__backward_fn != null)
                                        {
                                            this.__backward_fn();
                                        }
                                    };
                                }
                                break;
                            }
                            case torch.float32:
                            {
                                MKL.SliceGet(this.__float, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__float, y.__strides);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dSliceGet(this.grad.__float, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.grad.__float, y.__strides);
                                        if(this.__backward_fn != null)
                                        {
                                            this.__backward_fn();
                                        }
                                    };
                                }
                                break;
                            }
                            case torch.float64:
                            {
                                MKL.SliceGet(this.__double, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__double, y.__strides);
                                if(y.requires_grad)
                                {
                                    y.__backward_fn = () =>
                                    {
                                        MKL.dSliceGet(this.grad.__double, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.grad.__double, y.__strides);
                                        if(this.__backward_fn != null)
                                        {
                                            this.__backward_fn();
                                        }
                                    };
                                }
                                break;
                            }
                            case torch.int8:
                            {
                                MKL.SliceGet(this.__int8, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__int8, y.__strides);
                                break;
                            }
                            case torch.uint8:
                            {
                                MKL.SliceGet(this.__uint8, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__uint8, y.__strides);
                                break;
                            }
                            case torch.int16:
                            {
                                MKL.SliceGet(this.__int16, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__int16, y.__strides);
                                break;
                            }
                            case torch.int32:
                            {
                                MKL.SliceGet(this.__int32, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__int32, y.__strides);
                                break;
                            }
                            case torch.int64:
                            {
                                MKL.SliceGet(this.__int64, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__int64, y.__strides);
                                break;
                            }
                            case torch.@bool:
                            {
                                MKL.SliceGet(this.__bool, this.__shape, this.__strides, begin.ToArray(), size.ToArray(), y.__bool, y.__strides);
                                break;
                            }
                        }
                        int j = 0;
                        while(size.Remove(1));
                        y.__InitializeHeader(size.ToArray());
                        return y;
                    }

                }

                public Tensor this[int i]
                {

                    get
                    {
                        return this[new object[]{i}];
                    }

                    set{}

                }

                public void CopyTo(Tensor[] o, int i)
                {
                    throw new NotImplementedException("This method does not belong to this class.");
                }

                public int Count
                {

                    get
                    {
                        throw new NotImplementedException("This method does not belong to this class.");
                    }

                }

                public bool IsReadOnly
                {
                    get
                    {
                        throw new NotImplementedException("This method does not belong to this class.");
                    }
                }

                IEnumerator System.Collections.IEnumerable.GetEnumerator()
                {
                    return null;
                }

                IEnumerator<Tensor> System.Collections.Generic.IEnumerable<Tensor>.GetEnumerator()
                {
                    for(int i = 0; i < this.__shape[0]; i++)
                    {
                        yield return this[i];
                    }
                }

                #endregion

                #region data containers

                #region floating point data containers

                internal Half[] __half;

                internal float[] __float;

                internal double[] __double;

                #endregion

                #region integer data containers

                internal byte[] __uint8;

                internal sbyte[] __int8;

                internal short[] __int16;

                internal int[] __int32;

                internal long[] __int64;

                #endregion

                #region boolean data container

                internal bool[] __bool;

                #endregion

                #endregion

                #region dimension info

                internal int[] __shape;

                internal int[] __strides;

                #endregion

                #region backward

                internal delegate void __backward();

                internal __backward __backward_fn;

                /// <summary>
                /// Computes the gradient of current tensor w.r.t. graph leaves.
                /// The graph is differentiated using the chain rule.
                /// If the tensor is non-scalar (i.e. its data has more than one element) and requires gradient,
                /// the function additionally requires specifying gradient.
                /// It should be a tensor of matching type and location, that contains the gradient of the differentiated function w.r.t. self.
                /// This function accumulates gradients in the leaves - you might need to zero them before calling it.
                /// </summary>
                public void backward(Tensor gradient = null)
                {
                    if(this.__shape.Length == 0)
                    {
                        if(this.requires_grad == false)
                        {
                            throw new TorchException("TorchException: element 0 of the tensor does not require grad and does not have a backward function.");
                        }
                        if((object)gradient == null)
                        {
                            this.grad = torch.tensor(1, this.dtype);
                            if(this.__backward_fn != null)
                            {
                                this.__backward_fn();
                            }
                        }
                        else
                        {
                            this.grad = gradient;
                            if(this.__backward_fn != null)
                            {
                                this.__backward_fn();
                            }
                        }
                    }
                    else
                    {
                        if((object)gradient == null)
                        {
                            throw new TorchException("TorchException: grad can be implicitly created only for scalar outputs");
                        }
                        else
                        {
                            this.grad = gradient;
                            if(this.__backward_fn != null)
                            {
                                this.__backward_fn();
                            }
                        }
                    }
                }

                #endregion

                #region properties

                public Size shape
                {

                    get
                    {
                        return (Size)this.__shape;
                    }

                }

                /// <summary>
                /// Tensor data type.
                /// </summary>
                public DType dtype
                {

                    get;

                    internal set;

                }

                /// <summary>
                /// Gradients.
                /// </summary>
                public Tensor grad
                {

                    get;

                    set;

                }

                public bool requires_grad
                {

                    get;

                    internal set;

                }

                #endregion

                #region intialization

                internal void __InitializeHeader(int[] shape)
                {
                    this.__shape = new int[shape.Length];
                    var length = 1;
                    for(int i = 0; i < shape.Length; i++)
                    {
                        length *= shape[i];
                        this.__shape[i] = shape[i];
                    }
                    if(shape.Length < 2)
                    {
                        this.__strides = new int[0];
                    }
                    else
                    {
                        this.__strides = new int[shape.Length - 1];
                        this.__strides[shape.Length - 2] = shape[shape.Length - 1];
                        for(int i = shape.Length - 3; i >= 0; --i)
                        {
                            this.__strides[i] = this.__strides[i + 1] * shape[i + 1];
                        }
                    }
                }

                internal void __InitializeTensor(int[] shape,
                                                 DType dtype = DType.@default,
                                                 bool requires_grad = false)
                {
                    if(dtype == torch.float16)
                    {
                        __Warnings.warn("float16 data type is not native in .NET, so software emulation are used. If you need high speed of computations, use float32 or float64 data types.");
                    }
                    this.requires_grad = requires_grad;
                    this.__shape = new int[shape.Length];
                    var length = 1;
                    for(int i = 0; i < shape.Length; i++)
                    {
                        length *= shape[i];
                        this.__shape[i] = shape[i];
                    }
                    if(shape.Length < 2)
                    {
                        this.__strides = new int[0];
                    }
                    else
                    {
                        this.__strides = new int[shape.Length - 1];
                        this.__strides[shape.Length - 2] = shape[shape.Length - 1];
                        for(int i = shape.Length - 3; i >= 0; --i)
                        {
                            this.__strides[i] = this.__strides[i + 1] * shape[i + 1];
                        }
                    }
                    dtype = (dtype == DType.@default) ? torch.default_dtype : dtype;
                    this.dtype = dtype;
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            this.__half = new Half[length];
                            if(requires_grad)
                            {
                                this.grad = new Tensor(this.__shape, this.dtype, false);
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            this.__float = new float[length];
                            if(requires_grad)
                            {
                                this.grad = new Tensor(this.__shape, this.dtype, false);
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            this.__double = new double[length];
                            if(requires_grad)
                            {
                                this.grad = new Tensor(this.__shape, this.dtype, false);
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            this.__int8 = new sbyte[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            this.__uint8 = new byte[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            this.__int16 = new short[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            this.__int32 = new int[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            this.__int64 = new long[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            this.__bool = new bool[length];
                            if(requires_grad)
                            {
                                throw new TorchException("TorchException: Only floating point tensors may require grad.");
                            }
                            break;
                        }
                    }
                }

                #endregion

                #region constructors

                #region from shape

                internal Tensor(int[] shape)
                {
                    this.__InitializeHeader(shape);
                }

                public Tensor(int[] shape,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(shape, dtype, requires_grad);
                }

                public Tensor(DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[0], dtype, requires_grad);
                }

                public Tensor(long a,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              long B,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A,
                                                      (int)B}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              long B,
                              long C,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A,
                                                      (int)B,
                                                      (int)C}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              long B,
                              long C,
                              long D,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A,
                                                      (int)B,
                                                      (int)C,
                                                      (int)D}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              long B,
                              long C,
                              long D,
                              long E,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A,
                                                      (int)B,
                                                      (int)C,
                                                      (int)D,
                                                      (int)E}, dtype, requires_grad);
                }

                public Tensor(long a,
                              long b,
                              long c,
                              long d,
                              long e,
                              long f,
                              long g,
                              long h,
                              long i,
                              long j,
                              long k,
                              long l,
                              long m,
                              long n,
                              long o,
                              long p,
                              long q,
                              long r,
                              long s,
                              long t,
                              long u,
                              long v,
                              long w,
                              long x,
                              long y,
                              long z,
                              long A,
                              long B,
                              long C,
                              long D,
                              long E,
                              long F,
                              DType dtype = DType.@default,
                              bool requires_grad = false)
                {
                    this.__InitializeTensor(new int[]{(int)a,
                                                      (int)b,
                                                      (int)c,
                                                      (int)d,
                                                      (int)e,
                                                      (int)f,
                                                      (int)g,
                                                      (int)h,
                                                      (int)i,
                                                      (int)j,
                                                      (int)k,
                                                      (int)l,
                                                      (int)m,
                                                      (int)n,
                                                      (int)o,
                                                      (int)p,
                                                      (int)q,
                                                      (int)r,
                                                      (int)s,
                                                      (int)t,
                                                      (int)u,
                                                      (int)v,
                                                      (int)w,
                                                      (int)x,
                                                      (int)y,
                                                      (int)z,
                                                      (int)A,
                                                      (int)B,
                                                      (int)C,
                                                      (int)D,
                                                      (int)E,
                                                      (int)F}, dtype, requires_grad);
                }

                #endregion

                #endregion

                #region conversion

                public unsafe Array dotnet()
                {
                    Array array = null;
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new Half[]{this.__half[0]};
                            }
                            array = Array.CreateInstance(typeof(Half), this.__shape);
                            switch(this.__shape.Length)
                            {
                                case 1:
                                {
                                    fixed(Half* arr = (array as Half[]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 2:
                                {
                                    fixed(Half* arr = (array as Half[,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 3:
                                {
                                    fixed(Half* arr = (array as Half[,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 4:
                                {
                                    fixed(Half* arr = (array as Half[,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 5:
                                {
                                    fixed(Half* arr = (array as Half[,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 6:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 7:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 8:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 9:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 10:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 11:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 12:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 13:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 14:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 15:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 16:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 17:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 18:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 19:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 20:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 21:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 22:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 23:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 24:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 25:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 26:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 27:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 28:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 29:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 30:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 31:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                                case 32:
                                {
                                    fixed(Half* arr = (array as Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,]))
                                    {
                                        var dest = arr;
                                        for(int i = 0; i < this.__half.Length; ++i)
                                        {
                                            *dest++ = this.__half[i];
                                        }
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new float[]{this.__float[0]};
                            }
                            array = Array.CreateInstance(typeof(float), this.__shape);
                            Buffer.BlockCopy(this.__float, 0, array as Array, 0, this.__float.Length * 4);
                            break;
                        }
                        case torch.float64:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new double[]{this.__double[0]};
                            }
                            array = Array.CreateInstance(typeof(double), this.__shape);
                            Buffer.BlockCopy(this.__double, 0, array as Array, 0, this.__double.Length * 8);
                            break;
                        }
                        case torch.int8:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new sbyte[]{this.__int8[0]};
                            }
                            array = Array.CreateInstance(typeof(sbyte), this.__shape);
                            Buffer.BlockCopy(this.__int8, 0, array as Array, 0, this.__int8.Length);
                            break;
                        }
                        case torch.uint8:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new byte[]{this.__uint8[0]};
                            }
                            array = Array.CreateInstance(typeof(byte), this.__shape);
                            Buffer.BlockCopy(this.__uint8, 0, array as Array, 0, this.__uint8.Length);
                            break;
                        }
                        case torch.int16:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new short[]{this.__int16[0]};
                            }
                            array = Array.CreateInstance(typeof(short), this.__shape);
                            Buffer.BlockCopy(this.__int16, 0, array as Array, 0, this.__int16.Length * 2);
                            break;
                        }
                        case torch.int32:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new int[]{this.__int32[0]};
                            }
                            array = Array.CreateInstance(typeof(int), this.__shape);
                            Buffer.BlockCopy(this.__int32, 0, array as Array, 0, this.__int32.Length * 4);
                            break;
                        }
                        case torch.int64:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new long[]{this.__int64[0]};
                            }
                            array = Array.CreateInstance(typeof(long), this.__shape);
                            Buffer.BlockCopy(this.__int64, 0, array as Array, 0, this.__int64.Length * 8);
                            break;
                        }
                        case torch.@bool:
                        {
                            if(this.__shape.Length == 0)
                            {
                                return new bool[]{this.__bool[0]};
                            }
                            array = Array.CreateInstance(typeof(bool), this.__shape);
                            Buffer.BlockCopy(this.__bool, 0, array as Array, 0, this.__bool.Length);
                            break;
                        }
                    }
                    return array;
                }

                public object item()
                {
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            return this.__half[0];
                        }
                        case torch.float32:
                        {
                            return this.__float[0];
                        }
                        case torch.float64:
                        {
                            return this.__double[0];
                        }
                        case torch.int8:
                        {
                            return this.__int8[0];
                        }
                        case torch.uint8:
                        {
                            return this.__uint8[0];
                        }
                        case torch.int16:
                        {
                            return this.__int16[0];
                        }
                        case torch.int32:
                        {
                            return this.__int32[0];
                        }
                        case torch.int64:
                        {
                            return this.__int64[0];
                        }
                        case torch.@bool:
                        {
                            return this.__bool[0];
                        }
                    }
                    return null;
                }

                public Tensor half()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.float16)
                    {
                        Result = new Tensor(this.__shape, torch.float16, this.requires_grad && (!torch.autograd.grad_mode.no_grad.prev));
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            return this;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat16(this.__float, Result.__half);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat32(Result.grad.__half, this.grad.__float);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat16(this.__double, Result.__half);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat64(Result.grad.__half, this.grad.__double);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToFloat16(this.__uint8, Result.__half);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToFloat16(this.__int8, Result.__half);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToFloat16(this.__int16, Result.__half);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToFloat16(this.__int32, Result.__half);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToFloat16(this.__int64, Result.__half);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToFloat16(this.__bool, Result.__half);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @float()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.float32)
                    {
                        Result = new Tensor(this.__shape, torch.float32, this.requires_grad && (!torch.autograd.grad_mode.no_grad.prev));
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat32(this.__half, Result.__float);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat16(Result.grad.__float, this.grad.__half);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.float32:
                        {
                            return this;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat32(this.__double, Result.__float);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat64(Result.grad.__float, this.grad.__double);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToFloat32(this.__uint8, Result.__float);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToFloat32(this.__int8, Result.__float);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToFloat32(this.__int16, Result.__float);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToFloat32(this.__int32, Result.__float);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToFloat32(this.__int64, Result.__float);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToFloat32(this.__bool, Result.__float);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @double()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.float64)
                    {
                        Result = new Tensor(this.__shape, torch.float64, this.requires_grad && (!torch.autograd.grad_mode.no_grad.prev));
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat64(this.__half, Result.__double);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat16(Result.grad.__double, this.grad.__half);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat64(this.__float, Result.__double);
                            if(Result.requires_grad)
                            {
                                Result.__backward_fn = () =>
                                {
                                    MKL.ToFloat32(Result.grad.__double, this.grad.__float);
                                    if(this.__backward_fn != null)
                                    {
                                        this.__backward_fn();
                                    }
                                };
                            }
                            return Result;
                        }
                        case torch.float64:
                        {
                            return this;
                        }
                        case torch.uint8:
                        {
                            MKL.ToFloat64(this.__uint8, Result.__double);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToFloat64(this.__int8, Result.__double);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToFloat64(this.__int16, Result.__double);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToFloat64(this.__int32, Result.__double);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToFloat64(this.__int64, Result.__double);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToFloat64(this.__bool, Result.__double);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @byte()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.uint8)
                    {
                        Result = new Tensor(this.__shape, torch.uint8, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToUint8(this.__half, Result.__uint8);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToUint8(this.__float, Result.__uint8);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToUint8(this.__double, Result.__uint8);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            return this;
                        }
                        case torch.int8:
                        {
                            MKL.ToUint8(this.__int8, Result.__uint8);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToUint8(this.__int16, Result.__uint8);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToUint8(this.__int32, Result.__uint8);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToUint8(this.__int64, Result.__uint8);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToUint8(this.__bool, Result.__uint8);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @char()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.int8)
                    {
                        Result = new Tensor(this.__shape, torch.int8, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToInt8(this.__half, Result.__int8);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToInt8(this.__float, Result.__int8);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToInt8(this.__double, Result.__int8);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToInt8(this.__uint8, Result.__int8);
                            return Result;
                        }
                        case torch.int8:
                        {
                            return this;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt8(this.__int16, Result.__int8);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt8(this.__int32, Result.__int8);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt8(this.__int64, Result.__int8);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToInt8(this.__bool, Result.__int8);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @short()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.int16)
                    {
                        Result = new Tensor(this.__shape, torch.int16, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToInt16(this.__half, Result.__int16);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToInt16(this.__float, Result.__int16);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToInt16(this.__double, Result.__int16);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToInt16(this.__uint8, Result.__int16);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt16(this.__int8, Result.__int16);
                            return Result;
                        }
                        case torch.int16:
                        {
                            return this;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt16(this.__int32, Result.__int16);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt16(this.__int64, Result.__int16);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToInt16(this.__bool, Result.__int16);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @int()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.int32)
                    {
                        Result = new Tensor(this.__shape, torch.int32, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToInt32(this.__half, Result.__int32);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToInt32(this.__float, Result.__int32);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToInt32(this.__double, Result.__int32);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToInt32(this.__uint8, Result.__int32);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt32(this.__int8, Result.__int32);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt32(this.__int16, Result.__int32);
                            return Result;
                        }
                        case torch.int32:
                        {
                            return this;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt32(this.__int64, Result.__int32);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            MKL.ToInt32(this.__bool, Result.__int32);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @long()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.int64)
                    {
                        Result = new Tensor(this.__shape, torch.int64, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToInt64(this.__half, Result.__int64);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToInt64(this.__float, Result.__int64);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToInt64(this.__double, Result.__int64);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToInt64(this.__uint8, Result.__int64);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt64(this.__int8, Result.__int64);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt64(this.__int16, Result.__int64);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt64(this.__int32, Result.__int64);
                            return Result;
                        }
                        case torch.int64:
                        {
                            return this;
                        }
                        case torch.@bool:
                        {
                            MKL.ToInt64(this.__bool, Result.__int64);
                            return Result;
                        }
                    }
                    return Result;
                }

                public Tensor @bool()
                {
                    Tensor Result = null;
                    if(this.dtype != torch.@bool)
                    {
                        Result = new Tensor(this.__shape, torch.@bool, false);
                    }
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToBool(this.__half, Result.__bool);
                            return Result;
                        }
                        case torch.float32:
                        {
                            MKL.ToBool(this.__float, Result.__bool);
                            return Result;
                        }
                        case torch.float64:
                        {
                            MKL.ToBool(this.__double, Result.__bool);
                            return Result;
                        }
                        case torch.uint8:
                        {
                            MKL.ToBool(this.__uint8, Result.__bool);
                            return Result;
                        }
                        case torch.int8:
                        {
                            MKL.ToBool(this.__int8, Result.__bool);
                            return Result;
                        }
                        case torch.int16:
                        {
                            MKL.ToBool(this.__int16, Result.__bool);
                            return Result;
                        }
                        case torch.int32:
                        {
                            MKL.ToBool(this.__int32, Result.__bool);
                            return Result;
                        }
                        case torch.int64:
                        {
                            MKL.ToBool(this.__int64, Result.__bool);
                            return Result;
                        }
                        case torch.@bool:
                        {
                            return this;
                        }
                    }
                    return Result;
                }

                #endregion

                #region methods

                public void requires_grad_(bool requires_grad = true)
                {
                    if(requires_grad && (this.dtype != torch.float16) && (this.dtype != torch.float32) && (this.dtype != torch.float64))
                    {
                        throw new TorchException("TorchException: Only floating point tensors may require grad.");
                    }
                    if(requires_grad && (!this.requires_grad))
                    {
                        this.grad = new Tensor(this.__shape, this.dtype, false);
                    }
                    else
                    {
                        if((!requires_grad) && this.requires_grad)
                        {
                            this.grad = null;
                        }
                    }
                    this.requires_grad = requires_grad;
                }

                #endregion

                #region IndexMath

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal static void compute_broadcast_shapes(int[] shapeA, int[] shapeB, int l, int[] newShape, int ARank, int[] aBroadcastDims, int BRank, int[] bBroadcastDims)
                {
                    for(int i = 0; i < l; i++)
                    {
                        int az = (shapeA.Length - i - 1) < shapeA.Length && (shapeA.Length - i - 1) > -1 ? shapeA[shapeA.Length - i - 1] : 1;
                        int bz = (shapeB.Length - i - 1) < shapeB.Length && (shapeB.Length - i - 1) > -1 ? shapeB[shapeB.Length - i - 1] : 1;
                        if((az > 1) && (bz > 1) && (az != bz))
                        {
                            throw new TorchException("TorchException: Tensors are not broadcastable.");
                        }
                        newShape[newShape.Length - 1 - i] = Math.Max(az, bz);
                        if(i < ARank)
                        {
                            var dimA = ARank - 1 - i;
                            var azA = (dimA) > -1 && (dimA) < shapeA.Length ? shapeA[dimA] : 1;
                            var bzA = (((newShape.Length - i - 1) > -1) && ((newShape.Length - 1 - i) < newShape.Length)) ? newShape[newShape.Length - 1 - i] : 1;
                            if((bzA > 1) && (azA == 1))
                            {
                                aBroadcastDims[(aBroadcastDims.Length - 1) - i] = 1;
                            }
                        }
                        if(i < BRank)
                        {
                            var dimB = BRank - 1 - i;
                            var azB = ((dimB > -1) && (dimB < shapeB.Length)) ? shapeB[dimB] : 1;
                            var bzB = (((newShape.Length - i - 1) > -1) && ((newShape.Length - 1 - i) < newShape.Length)) ? newShape[newShape.Length - 1 - i] : 1;
                            if((bzB > 1) && (azB == 1))
                            {
                                bBroadcastDims[(bBroadcastDims.Length - 1) - i] = 1;
                            }
        
                        }
                    }
                }

                [MethodImpl(MethodImplOptions.AggressiveInlining)]
                internal int loc_to_index(params int[] indexes)
                {
                    if(this.__shape.Length == 0)
                    {
                        return 0;
                    }
                    else
                    {
                        if(this.__shape.Length == 1)
                        {
                            return indexes[0];
                        }
                    }
                    var index = indexes[indexes.Length - 1];
                    for(int i = 0; i < indexes.Length - 1; ++i)
                    {
                        index += this.__strides[i] * indexes[i];
                    }
                    return index;
                }

                internal int[] index_to_loc(int index)
                {
                    if(this.__shape.Length == 0)
                    {
                        return new int[0];
                    }
                    else
                    {
                        if(this.__shape.Length == 1)
                        {
                            return new int[]{index};
                        }
                    }
                    var loc = new int[this.__shape.Length];
                    for(int i = 0; i < loc.Length - 1; ++i)
                    {
                        loc[i] = (int)Math.Floor(index / (float)this.__strides[i]);
                        index -= loc[i] * this.__strides[i];
                    }
                    loc[loc.Length - 1] = index;
                    return loc;
                }

                #endregion

                #region ops

                public Tensor t()
                {
                    if(this.__shape.Length > 2)
                    {
                        throw new TorchException("TorchException: t() expects a tensor with <= 2 dimensions, but this is " + this.__shape.Length.ToString() + "D");
                    }
                    return ((this.__shape.Length == 0) || (this.__shape.Length == 1)) ? this : this.transpose(0, 1);
                }

                #endregion

                #region operators

                public static implicit operator Tensor(Half v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(float v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(double v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(byte v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(sbyte v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(short v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(int v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(long v)
                {
                    return torch.tensor(v);
                }

                public static implicit operator Tensor(bool v)
                {
                    return torch.tensor(v);
                }

                public static Tensor operator ==(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The == operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.Equals(a.__bool, a.__shape, a.__strides, aBroadcastDims, b.__bool, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator !=(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The != operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    var y = new Tensor(newShape, dtype: torch.@bool, requires_grad: false);
                                    MKL.NotEquals(a.__bool, a.__shape, a.__strides, aBroadcastDims, b.__bool, b.__shape, b.__strides, bBroadcastDims, y.__bool, y.__shape, y.__strides);
                                    return y;
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator +(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((Half[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, (Half[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, (float[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (Half[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (float[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPlus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (double[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPlus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.uint8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__uint8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Plus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The + operator is not implemented for bool and bool tensors.");
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator -(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((Half[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__half, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, (Half[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, (float[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__float, a.__shape, a.__strides, aBroadcastDims, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((float[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (Half[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (float[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMinus(a.grad.__double, a.__shape, a.__strides, aBroadcastDims, (double[])null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMinus((double[])null, a.__shape, a.__strides, aBroadcastDims, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.uint8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__uint8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Minus(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The - operator is not implemented for bool and bool tensors.");
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator *(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dMultiply(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.uint8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__uint8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dMultiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Multiply(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The * operator is not implemented for bool and bool tensors.");
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator /(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dDivide(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.uint8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__uint8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dDivide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Divide(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The / operator is not implemented for bool and bool tensors.");
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                public static Tensor operator ^(Tensor a, Tensor b)
                {
                    var shapeA = a.__shape;
                    var shapeB = b.__shape;
                    int l = Math.Max(shapeA.Length, shapeB.Length);
                    var newShape = new int[l];
                    var ARank = shapeA.Length;
                    int[] aBroadcastDims = new int[shapeA.Length];
                    var BRank = shapeB.Length;
                    int[] bBroadcastDims = new int[shapeB.Length];
                    compute_broadcast_shapes(shapeA, shapeB, l, newShape, ARank, aBroadcastDims, BRank, bBroadcastDims);
                    switch(a.dtype)
                    {
                        case torch.float16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__half, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__half, a.grad.__half, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for float16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__float, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__float, a.grad.__float, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for float32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__half, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__float, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            if(a.requires_grad)
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                                else
                                                {
                                                    MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__double, null, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(a.__backward_fn != null)
                                                    {
                                                        a.__backward_fn();
                                                    }
                                                }
                                            }
                                            else
                                            {
                                                if(b.requires_grad)
                                                {
                                                    MKL.dPower(a.__double, null, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                                    if(b.__backward_fn != null)
                                                    {
                                                        b.__backward_fn();
                                                    }
                                                }
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__double, a.grad.__double, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for float64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for int8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.uint8, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__uint8, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__uint8, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for uint8 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__half, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__half, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int16, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int16, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int16, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for int16 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__float, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__float, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int32, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int32, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int32, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for int32 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__half, b.grad.__half, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__float, b.grad.__float, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.float64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.float64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.__shape, b.__strides, bBroadcastDims, y.__double, y.__shape, y.__strides);
                                    if(y.requires_grad)
                                    {
                                        y.__backward_fn = () =>
                                        {
                                            MKL.dPower(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__double, b.grad.__double, b.__shape, b.__strides, bBroadcastDims, y.grad.__double, y.__shape, y.__strides);
                                            if(a.__backward_fn != null)
                                            {
                                                a.__backward_fn();
                                            }
                                        };
                                    }
                                    return y;
                                }
                                case torch.int8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.uint8:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__uint8, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int16:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int16, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int32:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int32, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.int64:
                                {
                                    var y = new Tensor(newShape, dtype: torch.int64, requires_grad: ((a.requires_grad || b.requires_grad) && (!torch.autograd.grad_mode.no_grad.prev)));
                                    MKL.Power(a.__int64, a.__shape, a.__strides, aBroadcastDims, b.__int64, b.__shape, b.__strides, bBroadcastDims, y.__int64, y.__shape, y.__strides);
                                    return y;
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for int64 and bool tensors.");
                                }
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            switch(b.dtype)
                            {
                                case torch.float16:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and float16 tensors.");
                                }
                                case torch.float32:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and float32 tensors.");
                                }
                                case torch.float64:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and float64 tensors.");
                                }
                                case torch.int8:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and int8 tensors.");
                                }
                                case torch.uint8:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and uint8 tensors.");
                                }
                                case torch.int16:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and int16 tensors.");
                                }
                                case torch.int32:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and int32 tensors.");
                                }
                                case torch.int64:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and int64 tensors.");
                                }
                                case torch.@bool:
                                {
                                    throw new TorchException("TorchException: The ^ operator is not implemented for bool and bool tensors.");
                                }
                            }
                            break;
                        }
                    }
                    return null;
                }

                #endregion

                #region ToString

                private void recursive_unrolling<T> (ref string @base, int dim, int[] indices, T[] data, string format)
                {
                    if(dim > 0)
                    {
                        if(indices[dim - 1] > 0)
                        {
                            @base += "       ";
                            for(int i = 0; i < dim; i++)
                            {
                                @base += " ";
                            }
                        }
                    }
                    @base += "[";
                    if((dim + 1) == this.__shape.Length)
                    {
                        for(int i = 0; i < this.__shape[dim]; i++)
                        {
                            indices[dim] = i;
                            @base += string.Format(format, data[this.loc_to_index(indices)]) + (((i + 1) == this.__shape[dim]) ? "" : ", ");
                        }
                    }
                    else
                    {
                        for(int i = 0; i < this.__shape[dim]; i++)
                        {
                            indices[dim] = i;
                            recursive_unrolling(ref @base, dim + 1, indices, data, format);
                        }
                    }
                    @base += "]";
                    if(dim > 0)
                    {
                        if((indices[dim - 1] + 1) != this.__shape[dim - 1])
                        {
                            @base += ",";
                            var n = this.__shape.Length - dim;
                            for(int i = 0; i < n; i++)
                            {
                                @base += (char)10;
                            }
                        }
                    }
                }

                private static string __ArrayController(Half[] x)
                {
                    var max = Half.MinValue;
                    var min = Half.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "7:0.####}";
                    }
                    return format;
                }

                private static string __ArrayController(float[] x)
                {
                    var max = float.MinValue;
                    var min = float.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "7:0.####}";
                    }
                    return format;
                }

                private static string __ArrayController(double[] x)
                {
                    var max = double.MinValue;
                    var min = double.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "7:0.####}";
                    }
                    return format;
                }

                private static string __ArrayController(byte[] x)
                {
                    return "{0,3}";
                }

                private static string __ArrayController(sbyte[] x)
                {
                    return "{0,4}";
                }

                private static string __ArrayController(short[] x)
                {
                    var max = short.MinValue;
                    var min = short.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "5}";
                    }
                    return format;
                }

                private static string __ArrayController(int[] x)
                {
                    var max = int.MinValue;
                    var min = int.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "5}";
                    }
                    return format;
                }

                private static string __ArrayController(long[] x)
                {
                    var max = long.MinValue;
                    var min = long.MaxValue;
                    foreach(var v in x)
                    {
                        if(v > max)
                        {
                            max = v;
                        }
                        if(v < min)
                        {
                            min = v;
                        }
                    }
                    var format = "{0,";
                    if((max >= 10000) || (min <= -10000))
                    {
                        format += "10:e2}";
                    }
                    else
                    {
                        format += "5}";
                    }
                    return format;
                }

                private static string __ArrayController(bool[] x)
                {
                    return "{0,5}";
                }

                public override string ToString()
                {
                    if(this.__shape.Length == 0)
                    {
                        switch(this.dtype)
                        {
                            case torch.float16:
                            {
                                return "tensor(" + this.__half[0].ToString() + ", dtype = torch.float16" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                            }
                            case torch.float32:
                            {
                                return "tensor(" + this.__float[0].ToString() + ", dtype = torch.float32" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                            }
                            case torch.float64:
                            {
                                return "tensor(" + this.__double[0].ToString() + ", dtype = torch.float64" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                            }
                            case torch.int8:
                            {
                                return "tensor(" + this.__int8[0].ToString() + ", dtype = torch.int8)";
                            }
                            case torch.uint8:
                            {
                                return "tensor(" + this.__uint8[0].ToString() + ", dtype = torch.uint8)";
                            }
                            case torch.int16:
                            {
                                return "tensor(" + this.__int16[0].ToString() + ", dtype = torch.int16)";
                            }
                            case torch.int32:
                            {
                                return "tensor(" + this.__int32[0].ToString() + ", dtype = torch.int32)";
                            }
                            case torch.int64:
                            {
                                return "tensor(" + this.__int64[0].ToString() + ", dtype = torch.int64)";
                            }
                            case torch.@bool:
                            {
                                return "tensor(" + this.__bool[0].ToString() + ", dtype = torch.bool)";
                            }
                        }
                    }
                    var indices = new int[this.__shape.Length];
                    switch(this.dtype)
                    {
                        case torch.float16:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__half, __ArrayController(this.__half));
                            return @base + ", dtype = torch.float16" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                        }
                        case torch.float32:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__float, __ArrayController(this.__float));
                            return @base + ", dtype = torch.float32" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                        }
                        case torch.float64:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__double, __ArrayController(this.__double));
                            return @base + ", dtype = torch.float64" + (this.requires_grad ? ", requires_grad = true" : "") + ")";
                        }
                        case torch.int8:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__int8, __ArrayController(this.__int8));
                            return @base + ", dtype = torch.int8)";
                        }
                        case torch.uint8:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__uint8, __ArrayController(this.__uint8));
                            return @base + ", dtype = torch.uint8)";
                        }
                        case torch.int16:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__int16, __ArrayController(this.__int16));
                            return @base + ", dtype = torch.int16)";
                        }
                        case torch.int32:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__int32, __ArrayController(this.__int32));
                            return @base + ", dtype = torch.int32)";
                        }
                        case torch.int64:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__int64, __ArrayController(this.__int64));
                            return @base + ", dtype = torch.int64)";
                        }
                        case torch.@bool:
                        {
                            var @base = "tensor(";
                            this.recursive_unrolling(ref @base, 0, indices, this.__bool, __ArrayController(this.__bool));
                            return @base + ", dtype = torch.bool)";
                        }
                    }
                    return "tensor()";
                }

                #endregion

            }

        }

    }

}
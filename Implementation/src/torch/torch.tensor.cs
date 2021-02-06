//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region tensor from dotnet array

            #region from half

            public static unsafe Tensor tensor(Half[] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(Half* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from float

            public static unsafe Tensor tensor(float[] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(float* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from double

            public static unsafe Tensor tensor(double[] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(double* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from int8

            public static unsafe Tensor tensor(sbyte[] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(sbyte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from uint8

            public static unsafe Tensor tensor(byte[] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(byte* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from int16

            public static unsafe Tensor tensor(short[] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(short* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from int32

            public static unsafe Tensor tensor(int[] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(int* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from int64

            public static unsafe Tensor tensor(long[] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(long* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            #endregion

            #region from bool

            public static unsafe Tensor tensor(bool[] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var t = new Tensor(new int[]{src.Length}, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static unsafe Tensor tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var shape = new int[src.Rank];
                for(int i = 0; i < shape.Length; i++)
                {
                    shape[i] = src.GetLength(i);
                }
                var t = new Tensor(shape, dtype, requires_grad);
                fixed(bool* p = src)
                {
                    switch(dtype)
                    {
                        case torch.float16:
                        {
                            MKL.ToFloat16(p, src.Length, t.__half);
                            break;
                        }
                        case torch.float32:
                        {
                            MKL.ToFloat32(p, src.Length, t.__float);
                            break;
                        }
                        case torch.float64:
                        {
                            MKL.ToFloat64(p, src.Length, t.__double);
                            break;
                        }
                        case torch.int8:
                        {
                            MKL.ToInt8(p, src.Length, t.__int8);
                            break;
                        }
                        case torch.uint8:
                        {
                            MKL.ToUint8(p, src.Length, t.__uint8);
                            break;
                        }
                        case torch.int16:
                        {
                            MKL.ToInt16(p, src.Length, t.__int16);
                            break;
                        }
                        case torch.int32:
                        {
                            MKL.ToInt32(p, src.Length, t.__int32);
                            break;
                        }
                        case torch.int64:
                        {
                            MKL.ToInt64(p, src.Length, t.__int64);
                            break;
                        }
                        case torch.@bool:
                        {
                            MKL.ToBool(p, src.Length, t.__bool);
                            break;
                        }
                    }
                }
                return t;
            }

            public static Tensor tensor(Half src, DType dtype = torch.float16, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(float src, DType dtype = torch.float32, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(double src, DType dtype = torch.float64, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(sbyte src, DType dtype = torch.int8, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(byte src, DType dtype = torch.uint8, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(short src, DType dtype = torch.int16, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(int src, DType dtype = torch.int32, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (Half)src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (long)src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(long src, DType dtype = torch.int64, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = src;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (float)src;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (double)src;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)src;
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)src;
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)src;
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (int)src;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = src;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src != 0;
                        break;
                    }
                }
                return t;
            }

            public static Tensor tensor(bool src, DType dtype = torch.@bool, bool requires_grad = false)
            {
                var t = new Tensor(new int[0], dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        t.__half[0] = (src) ? 1 : 0;
                        break;
                    }
                    case torch.float32:
                    {
                        t.__float[0] = (src) ? 1 : 0;
                        break;
                    }
                    case torch.float64:
                    {
                        t.__double[0] = (src) ? 1 : 0;
                        break;
                    }
                    case torch.int8:
                    {
                        t.__int8[0] = (sbyte)((src) ? 1 : 0);
                        break;
                    }
                    case torch.uint8:
                    {
                        t.__uint8[0] = (byte)((src) ? 1 : 0);
                        break;
                    }
                    case torch.int16:
                    {
                        t.__int16[0] = (short)((src) ? 1 : 0);
                        break;
                    }
                    case torch.int32:
                    {
                        t.__int32[0] = (src) ? 1 : 0;
                        break;
                    }
                    case torch.int64:
                    {
                        t.__int64[0] = (src) ? 1 : 0;
                        break;
                    }
                    case torch.@bool:
                    {
                        t.__bool[0] = src;
                        break;
                    }
                }
                return t;
            }

            #endregion

            #endregion

        }

    }

}    
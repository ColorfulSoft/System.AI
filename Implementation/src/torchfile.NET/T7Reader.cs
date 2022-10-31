//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.IO
{

    public static partial class torchfile
    {

        private sealed unsafe class T7Reader
        {

            #region fields

            private readonly BinaryReader f;

            private readonly Dictionary<int, object> objects;

            private readonly bool use_list_heuristic;

            private readonly bool use_int_heuristic;

            private readonly bool utf8_decode_strings;

            private readonly bool force_8bytes_long;

            #endregion

            public T7Reader(BinaryReader fileobj,
                            bool use_list_heuristic = true,
                            bool use_int_heuristic = true,
                            bool utf8_decode_strings = false,
                            object force_deserialize_classes = null,
                            bool force_8bytes_long = true)
            {
                this.f = fileobj;
                this.objects = new Dictionary<int, object>();
                this.use_list_heuristic = use_list_heuristic;
                this.use_int_heuristic = use_int_heuristic;
                this.utf8_decode_strings = utf8_decode_strings;
                this.force_8bytes_long = force_8bytes_long;
            }

            #region primitive readers

            /// <summary>
            /// Reads a boolean value.
            /// </summary>
            /// <returns>Boolean value.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private bool read_boolean()
            {
                return this.read_int() == 1;
            }

            /// <summary>
            /// Reads an integer value.
            /// </summary>
            /// <returns>Int32 value.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private int read_int()
            {
                return this.f.ReadInt32();
            }

            /// <summary>
            /// Reads a long value.
            /// </summary>
            /// <returns>Int64 value.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private long read_long()
            {
                if(this.force_8bytes_long)
                {
                    return this.f.ReadInt64();
                }
                return this.f.ReadInt32();
            }

            /// <summary>
            /// Reads a long array.
            /// </summary>
            /// <param name="n">Length of the array.</param>
            /// <returns>Long array.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private long[] read_long_array(int n)
            {
                var lst = new long[n];
                for(int i = 0; i < n; ++i)
                {
                    lst[i] = this.read_long();
                }
                return lst;
            }

            /// <summary>
            /// Reads a float value.
            /// </summary>
            /// <returns>Float value.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private float read_float()
            {
                return this.f.ReadSingle();
            }

            /// <summary>
            /// Reads a double value.
            /// </summary>
            /// <returns>Double value.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private double read_double()
            {
                return this.f.ReadDouble();
            }

            /// <summary>
            /// Reads a string.
            /// </summary>
            /// <param name="disable_utf8">Disables utf8 encoding.</param>
            /// <returns>String.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private string read_string(bool disable_utf8 = false)
            {
                var size = this.read_int();
                var s = this.f.ReadBytes(size);
                if(disable_utf8 || !this.utf8_decode_strings)
                {
                    return new Text.ASCIIEncoding().GetString(s);
                }
                return new Text.UTF8Encoding().GetString(s);
            }

            #endregion

            /// <summary>
            /// Data type to read (instead of numpy).
            /// </summary>
            private enum th_dtype : byte
            {

                /// <summary>
                /// 8-bit signed integer.
                /// </summary>
                int8,

                /// <summary>
                /// 8-bit unsigned integer.
                /// </summary>
                uint8,

                /// <summary>
                /// 16-bit signed integer.
                /// </summary>
                int16,

                /// <summary>
                /// 32-bit signed integer.
                /// </summary>
                int32,

                /// <summary>
                /// 64-bit signed integer.
                /// </summary>
                int64,

                /// <summary>
                /// 16-bit floating point.
                /// </summary>
                float16,

                /// <summary>
                /// 32-bit floating point.
                /// </summary>
                float32,

                /// <summary>
                /// 64-bit floating point.
                /// </summary>
                float64

            }

            /// <summary>
            /// Reads a storage object to dotnet array.
            /// </summary>
            /// <param name="dtype">Data type of storage.</param>
            /// <param name="reader">T7Reader object.</param>
            /// <param name="version">T7 version.</param>
            /// <returns>Dotnet array.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static Array read_storage(th_dtype dtype, T7Reader reader, string version)
            {
                var size = reader.read_long();
                var br = reader.f;
                switch(dtype)
                {
                    case th_dtype.int8:
                    {
                        var arr = new sbyte[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadSByte();
                        }
                        return arr;
                    }
                    case th_dtype.uint8:
                    {
                        var arr = new byte[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadByte();
                        }
                        return arr;
                    }
                    case th_dtype.int16:
                    {
                        var arr = new short[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadInt16();
                        }
                        return arr;
                    }
                    case th_dtype.int32:
                    {
                        var arr = new int[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadInt32();
                        }
                        return arr;
                    }
                    case th_dtype.int64:
                    {
                        var arr = new long[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadInt64();
                        }
                        return arr;
                    }
                    case th_dtype.float16:
                    {
                        var arr = new Half[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadHalf();
                        }
                        return arr;
                    }
                    case th_dtype.float32:
                    {
                        var arr = new float[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadSingle();
                        }
                        return arr;
                    }
                    case th_dtype.float64:
                    {
                        var arr = new double[size];
                        for(long i = 0; i < size; ++i)
                        {
                            arr[i] = br.ReadDouble();
                        }
                        return arr;
                    }
                    default:
                    {
                        throw new NotImplementedException();
                    }
                }
            }

            /// <summary>
            /// Converts 1-d dotnet array of sbyte, byte, short, int, long, Half, float or double data type to multidimensional (with maximum 4 dimensions).
            /// </summary>
            /// <param name="storage">1-d dotnet array.</param>
            /// <param name="shape">Shape of multidimensional array.</param>
            /// <param name="storage_offset">Offset.</param>
            /// <returns>Multidimensional dotnet array.</returns>
            private static Array make_multidimensional(Array storage, long[] shape, long storage_offset)
            {
                if(storage is sbyte[])
                {
                    var arr = storage as sbyte[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new sbyte[shape[0],
                                               shape[1]];
                            fixed(sbyte* psrc = arr)
                            {
                                fixed(sbyte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new sbyte[shape[0],
                                               shape[1],
                                               shape[2]];
                            fixed(sbyte* psrc = arr)
                            {
                                fixed(sbyte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new sbyte[shape[0],
                                               shape[1],
                                               shape[2],
                                               shape[3]];
                            fixed(sbyte* psrc = arr)
                            {
                                fixed(sbyte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is byte[])
                {
                    var arr = storage as byte[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new byte[shape[0],
                                              shape[1]];
                            fixed(byte* psrc = arr)
                            {
                                fixed(byte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new byte[shape[0],
                                              shape[1],
                                              shape[2]];
                            fixed(byte* psrc = arr)
                            {
                                fixed(byte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new byte[shape[0],
                                              shape[1],
                                              shape[2],
                                              shape[3]];
                            fixed(byte* psrc = arr)
                            {
                                fixed(byte* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is short[])
                {
                    var arr = storage as short[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new short[shape[0],
                                               shape[1]];
                            fixed(short* psrc = arr)
                            {
                                fixed(short* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new short[shape[0],
                                               shape[1],
                                               shape[2]];
                            fixed(short* psrc = arr)
                            {
                                fixed(short* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new short[shape[0],
                                               shape[1],
                                               shape[2],
                                               shape[3]];
                            fixed(short* psrc = arr)
                            {
                                fixed(short* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is int[])
                {
                    var arr = storage as int[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new int[shape[0],
                                             shape[1]];
                            fixed(int* psrc = arr)
                            {
                                fixed(int* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new int[shape[0],
                                             shape[1],
                                             shape[2]];
                            fixed(int* psrc = arr)
                            {
                                fixed(int* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new int[shape[0],
                                             shape[1],
                                             shape[2],
                                             shape[3]];
                            fixed(int* psrc = arr)
                            {
                                fixed(int* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is long[])
                {
                    var arr = storage as long[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new long[shape[0],
                                              shape[1]];
                            fixed(long* psrc = arr)
                            {
                                fixed(long* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new long[shape[0],
                                              shape[1],
                                              shape[2]];
                            fixed(long* psrc = arr)
                            {
                                fixed(long* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new long[shape[0],
                                              shape[1],
                                              shape[2],
                                              shape[3]];
                            fixed(long* psrc = arr)
                            {
                                fixed(long* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is Half[])
                {
                    var arr = storage as Half[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new Half[shape[0],
                                              shape[1]];
                            fixed(Half* psrc = arr)
                            {
                                fixed(Half* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new Half[shape[0],
                                              shape[1],
                                              shape[2]];
                            fixed(Half* psrc = arr)
                            {
                                fixed(Half* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new Half[shape[0],
                                              shape[1],
                                              shape[2],
                                              shape[3]];
                            fixed(Half* psrc = arr)
                            {
                                fixed(Half* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is float[])
                {
                    var arr = storage as float[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new float[shape[0],
                                               shape[1]];
                            fixed(float* psrc = arr)
                            {
                                fixed(float* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new float[shape[0],
                                               shape[1],
                                               shape[2]];
                            fixed(float* psrc = arr)
                            {
                                fixed(float* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new float[shape[0],
                                               shape[1],
                                               shape[2],
                                               shape[3]];
                            fixed(float* psrc = arr)
                            {
                                fixed(float* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                if(storage is double[])
                {
                    var arr = storage as double[];
                    switch(shape.Length)
                    {
                        case 0:
                        case 1:
                        {
                            return arr;
                        }
                        case 2:
                        {
                            var md = new double[shape[0],
                                                shape[1]];
                            fixed(double* psrc = arr)
                            {
                                fixed(double* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 3:
                        {
                            var md = new double[shape[0],
                                                shape[1],
                                                shape[2]];
                            fixed(double* psrc = arr)
                            {
                                fixed(double* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        case 4:
                        {
                            var md = new double[shape[0],
                                                shape[1],
                                                shape[2],
                                                shape[3]];
                            fixed(double* psrc = arr)
                            {
                                fixed(double* pdst = md)
                                {
                                    for(int i = 0; i < md.Length; ++i)
                                    {
                                        pdst[i] = psrc[storage_offset + i];
                                    }
                                }
                            }
                            return md;
                        }
                        default:
                        {
                            throw new NotImplementedException();
                        }
                    }
                }
                throw new NotImplementedException();
            }

            /// <summary>
            /// Reads a tensor and returns multidimensional dotnet array.
            /// </summary>
            /// <param name="dtype">Data type of tensor.</param>
            /// <param name="reader">T7Reader object.</param>
            /// <param name="version">T7 version.</param>
            /// <returns>Multidimensional dotnet array.</returns>
            private static Array read_tensor_generic(th_dtype dtype, T7Reader reader, string version)
            {
                // https://github.com/torch/torch7/blob/1e86025/generic/Tensor.c#L1249
                var ndim = reader.read_int();
                var size = reader.read_long_array(ndim);
                var stride = reader.read_long_array(ndim);
                var storage_offset = reader.read_long() - 1; // 0-indexing
                // read storage:
                var storage = reader.read_obj();
                //Console.WriteLine(storage == null);
                if((storage == null) || (ndim == 0) || (size.Length == 0) || (stride.Length == 0))
                {
                    // empty torch tensor
                    switch(dtype)
                    {
                        case th_dtype.int8:
                        {
                            return new sbyte[0];
                        }
                        case th_dtype.uint8:
                        {
                            return new byte[0];
                        }
                        case th_dtype.int16:
                        {
                            return new short[0];
                        }
                        case th_dtype.int32:
                        {
                            return new int[0];
                        }
                        case th_dtype.int64:
                        {
                            return new long[0];
                        }
                        case th_dtype.float16:
                        {
                            return new Half[0];
                        }
                        case th_dtype.float32:
                        {
                            return new float[0];
                        }
                        case th_dtype.float64:
                        {
                            return new double[0];
                        }
                    }
                }
                return make_multidimensional(storage as Array, size, storage_offset);
            }

            #region object readers

            /// <summary>
            /// Reads a number.
            /// </summary>
            /// <returns>Number (int or float).</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private object read_number()
            {
                var x = this.read_double();
                // Extra checking for integral numbers:
                if(this.use_int_heuristic && ((x - Math.Truncate(x)) == 0))
                {
                    return (int)x;
                }
                return x;
            }

            /// <summary>
            /// Reads a function.
            /// </summary>
            /// <returns>LuaFunction object.</returns>
            private object read_function()
            {
                // read the object reference index
                var index = this.read_int();
                // check it is loaded already
                if(this.objects.ContainsKey(index))
                {
                    return this.objects[index];
                }
                var size = this.read_int();
                var dumped = this.f.ReadBytes(size);
                var upvalues = this.read_obj();
                var obj = new LuaFunction(size, dumped, upvalues);
                objects[index] = obj;
                return obj;
            }

            /// <summary>
            /// Loads a torch object.
            /// </summary>
            /// <returns>TorchObject instance or dotnet array.</returns>
            private object read_torch()
            {
                // read the object reference index
                var index = this.read_int();
                // check it is loaded already
                if(this.objects.ContainsKey(index))
                {
                    return this.objects[index];
                }
                var version = this.read_string(disable_utf8: true);
                int version_number;
                string class_name;
                if(version.StartsWith("V "))
                {
                    version_number = int.Parse(version.Substring(version.IndexOf(' ')));
                    class_name = this.read_string(disable_utf8: true);
                }
                else
                {
                    class_name = version;
                    // created before existence of versioning
                    version_number = 0;
                }
                object obj;
                switch(class_name)
                {
                    #region tensors
                    case "torch.ByteTensor":
                    case "torch.CudaByteTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.uint8, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.CharTensor":
                    case "torch.CudaCharTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.int8, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.ShortTensor":
                    case "torch.CudaShortTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.int16, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.IntTensor":
                    case "torch.CudaIntTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.int32, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.LongTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.int64, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.HalfTensor":
                    case "torch.CudaHalfTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.float16, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.FloatTensor":
                    case "torch.CudaTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.float32, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.DoubleTensor":
                    case "torch.CudaDoubleTensor":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_tensor_generic(th_dtype.float64, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    #endregion
                    #region storages
                    case "torch.ByteStorage":
                    case "torch.CudaByteStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.uint8, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.CharStorage":
                    case "torch.CudaCharStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.int8, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.ShortStorage":
                    case "torch.CudaShortStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.int16, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.IntStorage":
                    case "torch.CudaIntStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.int32, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.LongStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.int64, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.HalfStorage":
                    case "torch.CudaHalfStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.float16, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.FloatStorage":
                    case "torch.CudaStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.float32, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    case "torch.DoubleStorage":
                    case "torch.CudaDoubleStorage":
                    {
                        // TODO: can custom readers ever be self-referential?
                        this.objects[index] = null; // FIXME: if self-referential
                        obj = read_storage(th_dtype.float64, this, version);
                        this.objects[index] = obj;
                        break;
                    }
                    #endregion
                    default:
                    {
                        // This must be performed in two steps to allow objects
                        // to be a property of themselves.
                        obj = new TorchObject(class_name, version_number: version_number);
                        this.objects[index] = obj;
                        // After self.objects is populated, it's safe to read in
                        // case self-referential
                        (obj as TorchObject)._obj = this.read_obj();
                        break;
                    }
                }
                return obj;
            }

            /// <summary>
            /// Reads a table.
            /// </summary>
            /// <returns>object[] or Dictionary&lt;object, object&gt; instance.</returns>
            private object read_table()
            {
                // read the object reference index
                var index = this.read_int();
                // check it is loaded already
                if(this.objects.ContainsKey(index))
                {
                    return this.objects[index];
                }
                // it is a table: returns a custom dict or a list
                var size = this.read_int();
                // custom hashable dict, so that it can be a key, see above
                object obj = new Dictionary<object, object>();
                // For checking if keys are consecutive and positive ints;
                // if so, returns a list with indices converted to 0-indices.
                var key_sum = 0;
                var keys_natural = true;
                // bugfix: obj must be registered before reading keys and vals
                this.objects[index] = obj;
                for(int i = 0; i < size; ++i)
                {
                    var k = this.read_obj();
                    var v = this.read_obj();
                    (obj as Dictionary<object, object>)[k] = v;
                    if(this.use_list_heuristic)
                    {
                        if(!(k is int) || ((int)k <= 0))
                        {
                            keys_natural = false;
                        }
                        else
                        {
                            if(k is int)
                            {
                                key_sum += (int)k;
                            }
                        } 
                    }
                }
                if(this.use_list_heuristic)
                {
                    // n(n + 1) / 2 = sum <=> consecutive and natural numbers
                    var n = (obj as Dictionary<object, object>).Count;
                    if(keys_natural && (n * (n + 1) == 2 * key_sum))
                    {
                        var lst = new List<object>();
                        for(int i = 0; i < (obj as Dictionary<object, object>).Count; ++i)
                        {
                            var elem = (obj as Dictionary<object, object>)[i + 1];
                            // In case it is self-referential. This is not
                            // needed in lua torch since the tables are never
                            // modified as they are here.
                            if(elem == obj)
                            {
                                elem = lst;
                            }
                            lst.Add(elem);
                        }
                        this.objects[index] = obj = lst.ToArray();
                    }
                }
                return obj;
            }

            #endregion

            /// <summary>
            /// Reads an object.
            /// </summary>
            /// <returns>Null, number, boolean, string, LuaFunction, TorchObject, Array, object[] or Dictionary&lt;object, object&gt; instance.</returns>
            public object read_obj()
            {
                var typeidx = this.read_int();
                if(typeidx == TYPE_NIL)
                {
                    return null;
                }
                if(typeidx == TYPE_NUMBER)
                {
                    return this.read_number();
                }
                if(typeidx == TYPE_BOOLEAN)
                {
                    return this.read_boolean();
                }
                if(typeidx == TYPE_STRING)
                {
                    return this.read_string();
                }
                if((typeidx == TYPE_FUNCTION) || (typeidx == TYPE_RECUR_FUNCTION) ||
                   (typeidx == LEGACY_TYPE_RECUR_FUNCTION))
                {
                    return this.read_function();
                }
                if(typeidx == TYPE_TORCH)
                {
                    return this.read_torch();
                }
                if(typeidx == TYPE_TABLE)
                {
                    return this.read_table();
                }
                throw new T7ReaderException("unknown object type / typeidx: " + typeidx.ToString());
            }

        }

    }

}
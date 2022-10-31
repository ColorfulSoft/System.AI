//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// JIT computational backend. Targets to .NET Runtime's JIT.
        /// </summary>
        internal sealed class JITBackend : IBackend
        {

            #region void convert(<Type>* source, Storage destination)

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(Quarter* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(Half* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(BFloat16* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(float* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(double* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (float)src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (float)src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(CQuarter* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i].Real;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i].Real;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i].Real;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i].Real;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(CHalf* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i].Real;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CQuarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i].Real;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i].Real;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i].Real;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i].Real;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(CBFloat16* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i].Real;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i].Real;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CQuarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CHalf)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i].Real;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i].Real;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i].Real;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i].Real;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(CFloat* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i].Real;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i].Real;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i].Real;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CQuarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CHalf)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CBFloat16)src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i].Real;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i].Real;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i].Real;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i].Real;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(CDouble* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Quarter)src[i].Real;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (Half)src[i].Real;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (BFloat16)src[i].Real;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (float)src[i].Real;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CQuarter)src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CHalf)src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CBFloat16)src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (CFloat)src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i].Real;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i].Real;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i].Real;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i].Real;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i].Real;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i].Real != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(sbyte* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(byte* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(short* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(ushort* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(int* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(uint* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(long* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ulong)src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(ulong* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (sbyte)src[i];
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (byte)src[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (short)src[i];
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (ushort)src[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (int)src[i];
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (uint)src[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = (long)src[i];
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] != 0;
                        }
                        return;
                    }
                }
            }

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void convert(bool* source, Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var src = source;
                        var dst = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var src = source;
                        var dst = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var src = source;
                        var dst = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var src = source;
                        var dst = (float*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var src = source;
                        var dst = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var src = source;
                        var dst = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var src = source;
                        var dst = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var src = source;
                        var dst = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var src = source;
                        var dst = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var src = source;
                        var dst = (CDouble*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var src = source;
                        var dst = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (sbyte)1 : (sbyte)0;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var src = source;
                        var dst = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (byte)1 : (byte)0;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var src = source;
                        var dst = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (short)1 : (short)0;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var src = source;
                        var dst = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (ushort)1 : (ushort)0;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var src = source;
                        var dst = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var src = source;
                        var dst = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (uint)1 : (uint)0;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var src = source;
                        var dst = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? 1 : 0;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var src = source;
                        var dst = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i] ? (ulong)1 : (ulong)0;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var src = source;
                        var dst = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dst[i] = src[i];
                        }
                        return;
                    }
                }
            }

            #endregion

            #region void <initialization>(Storage destination)

            /// <summary>
            /// Fills the destination storage with default values for its data type.
            /// For numeric types, the default value is 0, for boolean - false.
            /// </summary>
            /// <param name="destination">The storage being cleaned up.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void zeros(Storage destination)
            {
                switch(destination.dtype)
                {
                    case torch.float8:
                    {
                        var p = (Quarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var p = (Half*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var p = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var p = (double*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var p = (CQuarter*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var p = (CHalf*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var p = (CBFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var p = (CFloat*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var p = (BFloat16*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var p = (sbyte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var p = (byte*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var p = (short*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var p = (ushort*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var p = (int*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var p = (uint*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var p = (long*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var p = (ulong*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = 0;
                        }
                        return;
                    }
                    case torch.@bool:
                    {
                        var p = (bool*)destination.data_ptr;
                        var n = destination.size;
                        for(int i = 0; i < n; ++i)
                        {
                            p[i] = false;
                        }
                        return;
                    }
                }
            }

            #endregion

            #region void <operation>(Storage source, Storage destination)

            /// <summary>
            /// Calculates the absolute value for each storage item.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void abs(Storage source, Storage destination)
            {
                if(((source.dtype == torch.complex16) && (destination.dtype != torch.float8)) ||
                   ((source.dtype == torch.complex32) && (destination.dtype != torch.float16)) ||
                   ((source.dtype == torch.bcomplex32) && (destination.dtype != torch.bfloat16)) ||
                   ((source.dtype == torch.complex64) && (destination.dtype != torch.float32)) ||
                   ((source.dtype == torch.complex128) && (destination.dtype != torch.float64)))
                {
                    throw new NotImplementedException("The destination storage data type must match the type of the real part of the complex source storage data type.");
                }
                if((source.dtype != torch.complex16) &&
                   (source.dtype != torch.complex32) &&
                   (source.dtype != torch.bcomplex32) &&
                   (source.dtype != torch.complex64) &&
                   (source.dtype != torch.complex128) &&
                   (source.dtype != destination.dtype))
                {
                    throw new NotImplementedException("The data type of the destination storage must be the same as that of the source.");
                }
                if(source.size != destination.size)
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var y = (Quarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Quarter.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var y = (Half*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Half.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var y = (BFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = BFloat16.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var y = (float*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var y = (double*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var y = (Quarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CQuarter.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var y = (Half*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CHalf.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var y = (BFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CBFloat16.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var y = (float*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CFloat.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var y = (double*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CDouble.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.int8:
                    {
                        var x = (sbyte*)source.data_ptr;
                        var y = (sbyte*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.uint8:
                    {
                        var x = (byte*)source.data_ptr;
                        var y = (byte*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = x[i];
                        }
                        return;
                    }
                    case torch.int16:
                    {
                        var x = (short*)source.data_ptr;
                        var y = (short*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.uint16:
                    {
                        var x = (ushort*)source.data_ptr;
                        var y = (ushort*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = x[i];
                        }
                        return;
                    }
                    case torch.int32:
                    {
                        var x = (int*)source.data_ptr;
                        var y = (int*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.uint32:
                    {
                        var x = (uint*)source.data_ptr;
                        var y = (uint*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = x[i];
                        }
                        return;
                    }
                    case torch.int64:
                    {
                        var x = (long*)source.data_ptr;
                        var y = (long*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Abs(x[i]);
                        }
                        return;
                    }
                    case torch.uint64:
                    {
                        var x = (ulong*)source.data_ptr;
                        var y = (ulong*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = x[i];
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The abs function is implemented only for floating-point and integer data types.");
                    }
                }
            }

            /// <summary>
            /// Calculates the sine value for each source storage element.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void sin(Storage source, Storage destination)
            {
                if(source.dtype != destination.dtype)
                {
                    throw new NotImplementedException("The data type of the output storage must be the same as that of the input.");
                }
                if(source.size != destination.size)
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var y = (Quarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (Quarter)Math.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var y = (Half*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (Half)Math.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var y = (BFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (BFloat16)Math.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var y = (float*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (float)Math.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var y = (double*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var y = (CQuarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CQuarter.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var y = (CHalf*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CHalf.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var y = (CBFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CBFloat16.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var y = (CFloat*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CFloat.Sin(x[i]);
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var y = (CDouble*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CDouble.Sin(x[i]);
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The sin function is implemented only for floating-point data types.");
                    }
                }
            }

            /// <summary>
            /// Calculates the cosine value for each source storage element.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void cos(Storage source, Storage destination)
            {
                if(source.dtype != destination.dtype)
                {
                    throw new NotImplementedException("The data type of the output storage must be the same as that of the input.");
                }
                if(source.size != destination.size)
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var y = (Quarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (Quarter)Math.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var y = (Half*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (Half)Math.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var y = (BFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (BFloat16)Math.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var y = (float*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = (float)Math.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var y = (double*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = Math.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var y = (CQuarter*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CQuarter.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var y = (CHalf*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CHalf.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var y = (CBFloat16*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CBFloat16.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var y = (CFloat*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CFloat.Cos(x[i]);
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var y = (CDouble*)destination.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            y[i] = CDouble.Cos(x[i]);
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The cos function is implemented only for floating-point data types.");
                    }
                }
            }

            #endregion

            #region void <operation>_backward([optional] Storage source, Storage source_grad, [optional] Storage destination, Storage destination_grad)

            /// <summary>
            /// Performs the error back propagation through the operation of extracting the absolute value.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination">Storage of the result values.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void abs_backward(Storage source, Storage source_grad, Storage destination, Storage destination_grad)
            {
                if(((source.dtype == torch.complex16) && (destination.dtype != torch.float8)) ||
                   ((source.dtype == torch.complex32) && (destination.dtype != torch.float16)) ||
                   ((source.dtype == torch.bcomplex32) && (destination.dtype != torch.bfloat16)) ||
                   ((source.dtype == torch.complex64) && (destination.dtype != torch.float32)) ||
                   ((source.dtype == torch.complex128) && (destination.dtype != torch.float64)))
                {
                    throw new NotImplementedException("The destination storage data type must match the type of the real part of the complex source storage data type.");
                }
                if((source.dtype != torch.complex16) &&
                   (source.dtype != torch.complex32) &&
                   (source.dtype != torch.bcomplex32) &&
                   (source.dtype != torch.complex64) &&
                   (source.dtype != torch.complex128) &&
                   (source.dtype != destination.dtype))
                {
                    throw new NotImplementedException("The data type of the destination storage must be the same as that of the source.");
                }
                if(source.dtype != source_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the source_grad storage must be the same as that of the source.");
                }
                if(destination.dtype != destination_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the destination_grad storage must be the same as that of the destination.");
                }
                if((source.size != destination.size) ||
                   (source_grad.size != destination_grad.size) ||
                   (source_grad.size != source.size))
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var dx = (Quarter*)source_grad.data_ptr;
                        var dy = (Quarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(x[i] > 0)
                            {
                                dx[i] += dy[i];
                            }
                            else
                            {
                                dx[i] -= dy[i];
                            }
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var dx = (Half*)source_grad.data_ptr;
                        var dy = (Half*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(x[i] > 0)
                            {
                                dx[i] += dy[i];
                            }
                            else
                            {
                                dx[i] -= dy[i];
                            }
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var dx = (BFloat16*)source_grad.data_ptr;
                        var dy = (BFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(x[i] > 0)
                            {
                                dx[i] += dy[i];
                            }
                            else
                            {
                                dx[i] -= dy[i];
                            }
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var dx = (float*)source_grad.data_ptr;
                        var dy = (float*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(x[i] > 0)
                            {
                                dx[i] += dy[i];
                            }
                            else
                            {
                                dx[i] -= dy[i];
                            }
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var dx = (double*)source_grad.data_ptr;
                        var dy = (double*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(x[i] > 0)
                            {
                                dx[i] += dy[i];
                            }
                            else
                            {
                                dx[i] -= dy[i];
                            }
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var dx = (CQuarter*)source_grad.data_ptr;
                        var y = (Quarter*)destination.data_ptr;
                        var dy = (Quarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(y[i] != 0)
                            {
                                dx[i] += new CQuarter(x[i].Real / y[i], x[i].Imaginary / y[i]) * dy[i];
                            }
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var dx = (CHalf*)source_grad.data_ptr;
                        var y = (Half*)destination.data_ptr;
                        var dy = (Half*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(y[i] != 0)
                            {
                                dx[i] += new CHalf(x[i].Real / y[i], x[i].Imaginary / y[i]) * dy[i];
                            }
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var dx = (CBFloat16*)source_grad.data_ptr;
                        var y = (BFloat16*)destination.data_ptr;
                        var dy = (BFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(y[i] != 0)
                            {
                                dx[i] += new CBFloat16(x[i].Real / y[i], x[i].Imaginary / y[i]) * dy[i];
                            }
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var dx = (CFloat*)source_grad.data_ptr;
                        var y = (float*)destination.data_ptr;
                        var dy = (float*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(y[i] != 0)
                            {
                                dx[i] += new CFloat(x[i].Real / y[i], x[i].Imaginary / y[i]) * dy[i];
                            }
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var dx = (CDouble*)source_grad.data_ptr;
                        var y = (double*)destination.data_ptr;
                        var dy = (double*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            if(y[i] != 0)
                            {
                                dx[i] += new CDouble(x[i].Real / y[i], x[i].Imaginary / y[i]) * dy[i];
                            }
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The error back propagation is possible only with floating-point data types.");
                    }
                }
            }

            /// <summary>
            /// Performs the error back propagation through the operation of calculating the sine.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void sin_backward(Storage source, Storage source_grad, Storage destination_grad)
            {
                if(source.dtype != destination_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the destination_grad storage must be the same as that of the source.");
                }
                if(source.dtype != source_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the source_grad storage must be the same as that of the source.");
                }
                if((source.size != destination_grad.size) ||
                   (source.size != source_grad.size))
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var dx = (Quarter*)source_grad.data_ptr;
                        var dy = (Quarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += (Quarter)Math.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var dx = (Half*)source_grad.data_ptr;
                        var dy = (Half*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += (Half)Math.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var dx = (BFloat16*)source_grad.data_ptr;
                        var dy = (BFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += (BFloat16)Math.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var dx = (float*)source_grad.data_ptr;
                        var dy = (float*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += (float)Math.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var dx = (double*)source_grad.data_ptr;
                        var dy = (double*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += Math.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var dx = (CQuarter*)source_grad.data_ptr;
                        var dy = (CQuarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += CQuarter.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var dx = (CHalf*)source_grad.data_ptr;
                        var dy = (CHalf*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += CHalf.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var dx = (CBFloat16*)source_grad.data_ptr;
                        var dy = (CBFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += CBFloat16.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var dx = (CFloat*)source_grad.data_ptr;
                        var dy = (CFloat*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += CFloat.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var dx = (CDouble*)source_grad.data_ptr;
                        var dy = (CDouble*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] += CDouble.Cos(x[i]) * dy[i];
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The error back propagation is possible only with floating-point data types.");
                    }
                }
            }

            /// <summary>
            /// Performs the error back propagation through the operation of calculating the cosine.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void cos_backward(Storage source, Storage source_grad, Storage destination_grad)
            {
                if(source.dtype != destination_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the destination_grad storage must be the same as that of the source.");
                }
                if(source.dtype != source_grad.dtype)
                {
                    throw new NotImplementedException("The data type of the source_grad storage must be the same as that of the source.");
                }
                if((source.size != destination_grad.size) ||
                   (source.size != source_grad.size))
                {
                    throw new ArgumentException("The storage sizes should be equal.");
                }
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x = (Quarter*)source.data_ptr;
                        var dx = (Quarter*)source_grad.data_ptr;
                        var dy = (Quarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= (Quarter)Math.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float16:
                    {
                        var x = (Half*)source.data_ptr;
                        var dx = (Half*)source_grad.data_ptr;
                        var dy = (Half*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= (Half)Math.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x = (BFloat16*)source.data_ptr;
                        var dx = (BFloat16*)source_grad.data_ptr;
                        var dy = (BFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= (BFloat16)Math.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float32:
                    {
                        var x = (float*)source.data_ptr;
                        var dx = (float*)source_grad.data_ptr;
                        var dy = (float*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= (float)Math.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.float64:
                    {
                        var x = (double*)source.data_ptr;
                        var dx = (double*)source_grad.data_ptr;
                        var dy = (double*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= Math.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex16:
                    {
                        var x = (CQuarter*)source.data_ptr;
                        var dx = (CQuarter*)source_grad.data_ptr;
                        var dy = (CQuarter*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= CQuarter.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex32:
                    {
                        var x = (CHalf*)source.data_ptr;
                        var dx = (CHalf*)source_grad.data_ptr;
                        var dy = (CHalf*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= CHalf.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x = (CBFloat16*)source.data_ptr;
                        var dx = (CBFloat16*)source_grad.data_ptr;
                        var dy = (CBFloat16*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= CBFloat16.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex64:
                    {
                        var x = (CFloat*)source.data_ptr;
                        var dx = (CFloat*)source_grad.data_ptr;
                        var dy = (CFloat*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= CFloat.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    case torch.complex128:
                    {
                        var x = (CDouble*)source.data_ptr;
                        var dx = (CDouble*)source_grad.data_ptr;
                        var dy = (CDouble*)destination_grad.data_ptr;
                        var n = source.size;
                        for(int i = 0; i < n; ++i)
                        {
                            dx[i] -= CDouble.Sin(x[i]) * dy[i];
                        }
                        return;
                    }
                    default:
                    {
                        throw new NotImplementedException("The error back propagation is possible only with floating-point data types.");
                    }
                }
            }

            #endregion

            #region Slicing ops

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static int loc_to_index(int* indexes, int* shape, int ndim)
            {
                if(ndim == 0)
                {
                    return 0;
                }
                var index = indexes[0];
                for(int i = 1; i < ndim; ++i)
                {
                    index *= shape[i];
                    index += indexes[i];
                }
                return index;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="index"></param>
            /// <param name="strides"></param>
            /// <param name="indexes"></param>
            /// <param name="ndim"></param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static void index_to_loc(int index, int* strides, int* indexes, int ndim)
            {
                if(ndim == 0)
                {
                    return;
                }
                else
                {
                    if(ndim == 1)
                    {
                        indexes[0] = index;
                        return;
                    }
                }
                for(int i = 0; i < ndim - 1; ++i)
                {
                    indexes[i] = index / strides[i];
                    index -= indexes[i] * strides[i];
                }
                indexes[ndim - 1] = index;
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void slice_get(Storage source, int* source_shape, int* begin_slice, Storage destination, int* destination_shape, int ndim)
            {
                var x_loc = (int*)Marshal.AllocHGlobal(ndim * sizeof(int)).ToPointer();
                for(int i = 0; i < ndim; ++i)
                {
                    x_loc[i] = 0;
                }
                var loc = (int*)Marshal.AllocHGlobal(ndim * sizeof(int)).ToPointer();
                var y_strides = (int*)Marshal.AllocHGlobal((ndim - 1) * sizeof(int)).ToPointer();
                y_strides[ndim - 2] = destination_shape[ndim - 1];
                for(int i = ndim - 3; i >= 0; --i)
                {
                    y_strides[i] = y_strides[i + 1] * destination_shape[i + 1];
                }
                var n = destination.size;
                switch(source.dtype)
                {
                    case torch.float8:
                    {
                        var x_data = (Quarter*)source.data_ptr;
                        var y_data = (Quarter*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float16:
                    {
                        var x_data = (Half*)source.data_ptr;
                        var y_data = (Half*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x_data = (BFloat16*)source.data_ptr;
                        var y_data = (BFloat16*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float32:
                    {
                        var x_data = (float*)source.data_ptr;
                        var y_data = (float*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float64:
                    {
                        var x_data = (double*)source.data_ptr;
                        var y_data = (double*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex16:
                    {
                        var x_data = (CQuarter*)source.data_ptr;
                        var y_data = (CQuarter*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex32:
                    {
                        var x_data = (CHalf*)source.data_ptr;
                        var y_data = (CHalf*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x_data = (CBFloat16*)source.data_ptr;
                        var y_data = (CBFloat16*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex64:
                    {
                        var x_data = (CFloat*)source.data_ptr;
                        var y_data = (CFloat*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex128:
                    {
                        var x_data = (CDouble*)source.data_ptr;
                        var y_data = (CDouble*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.int8:
                    {
                        var x_data = (sbyte*)source.data_ptr;
                        var y_data = (sbyte*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.uint8:
                    {
                        var x_data = (byte*)source.data_ptr;
                        var y_data = (byte*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.int16:
                    {
                        var x_data = (short*)source.data_ptr;
                        var y_data = (short*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.uint16:
                    {
                        var x_data = (ushort*)source.data_ptr;
                        var y_data = (ushort*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.int32:
                    {
                        var x_data = (int*)source.data_ptr;
                        var y_data = (int*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.uint32:
                    {
                        var x_data = (uint*)source.data_ptr;
                        var y_data = (uint*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.int64:
                    {
                        var x_data = (long*)source.data_ptr;
                        var y_data = (long*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.uint64:
                    {
                        var x_data = (ulong*)source.data_ptr;
                        var y_data = (ulong*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.@bool:
                    {
                        var x_data = (bool*)source.data_ptr;
                        var y_data = (bool*)destination.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            y_data[i] = x_data[loc_to_index(x_loc, source_shape, ndim)];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public void slice_get_backward(Storage source_grad, int* source_shape, int* begin_slice, Storage destination_grad, int* destination_shape, int ndim)
            {
                var x_loc = (int*)Marshal.AllocHGlobal(ndim * sizeof(int)).ToPointer();
                for(int i = 0; i < ndim; ++i)
                {
                    x_loc[i] = 0;
                }
                var loc = (int*)Marshal.AllocHGlobal(ndim * sizeof(int)).ToPointer();
                var y_strides = (int*)Marshal.AllocHGlobal((ndim - 1) * sizeof(int)).ToPointer();
                y_strides[ndim - 2] = destination_shape[ndim - 1];
                for(int i = ndim - 3; i >= 0; --i)
                {
                    y_strides[i] = y_strides[i + 1] * destination_shape[i + 1];
                }
                var n = destination_grad.size;
                switch(source_grad.dtype)
                {
                    case torch.float8:
                    {
                        var x_grad = (Quarter*)source_grad.data_ptr;
                        var y_grad = (Quarter*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float16:
                    {
                        var x_grad = (Half*)source_grad.data_ptr;
                        var y_grad = (Half*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.bfloat16:
                    {
                        var x_grad = (BFloat16*)source_grad.data_ptr;
                        var y_grad = (BFloat16*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float32:
                    {
                        var x_grad = (float*)source_grad.data_ptr;
                        var y_grad = (float*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.float64:
                    {
                        var x_grad = (double*)source_grad.data_ptr;
                        var y_grad = (double*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex16:
                    {
                        var x_grad = (CQuarter*)source_grad.data_ptr;
                        var y_grad = (CQuarter*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex32:
                    {
                        var x_grad = (CHalf*)source_grad.data_ptr;
                        var y_grad = (CHalf*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.bcomplex32:
                    {
                        var x_grad = (CBFloat16*)source_grad.data_ptr;
                        var y_grad = (CBFloat16*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex64:
                    {
                        var x_grad = (CFloat*)source_grad.data_ptr;
                        var y_grad = (CFloat*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    case torch.complex128:
                    {
                        var x_grad = (CDouble*)source_grad.data_ptr;
                        var y_grad = (CDouble*)destination_grad.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            index_to_loc(i, y_strides, loc, ndim);
                            for(int j = 0; j < ndim; ++j)
                            {
                                x_loc[j] = loc[j] + begin_slice[j];
                            }
                            x_grad[loc_to_index(x_loc, source_shape, ndim)] += y_grad[i];
                        }
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        return;
                    }
                    default:
                    {
                        Marshal.FreeHGlobal((IntPtr)x_loc);
                        Marshal.FreeHGlobal((IntPtr)loc);
                        Marshal.FreeHGlobal((IntPtr)y_strides);
                        throw new NotImplementedException("The error back propagation is possible only with floating-point data types.");
                    }
                }
            }

            #endregion

            #region Instance

            /// <summary>
            /// A JITBackend object for accessing functions.
            /// </summary>
            public static JITBackend instance
            {

                get;

                private set;

            }

            private JITBackend()
            {
            }

            static JITBackend()
            {
                instance = new JITBackend();
            }

            #endregion

        }

    }

}

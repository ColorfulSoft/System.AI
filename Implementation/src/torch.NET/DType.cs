//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// Data types supported by torch.NET.
        /// </summary>
        public enum DType : byte
        {

            /// <summary>
            /// 8-bit floating point. Alias for quarter.
            /// </summary>
            float8     = 0,

            /// <summary>
            /// 8-bit floating point. Alias for float8.
            /// </summary>
            quarter    = 0,

            /// <summary>
            /// 16-bit floating point. Alias for half.
            /// </summary>
            float16    = 1,

            /// <summary>
            /// 16-bit floating point. Alias for float16.
            /// </summary>
            half       = 1,

            /// <summary>
            /// 16-bit google brain floating point.
            /// </summary>
            bfloat16   = 2,

            /// <summary>
            /// 32-bit floating point. Alias for float.
            /// </summary>
            float32    = 3,

            /// <summary>
            /// 32-bit floating point. Alias for float32.
            /// </summary>
            @float     = 3,

            /// <summary>
            /// 64-bit floating point. Alias for double.
            /// </summary>
            float64    = 4,

            /// <summary>
            /// 64-bit floating point. Alias for float64.
            /// </summary>
            @double    = 4,

            /// <summary>
            /// 8-bit complex floating point. Alias for cquarter.
            /// </summary>
            complex16  = 5,

            /// <summary>
            /// 8-bit complex floating point. Alias for complex16.
            /// </summary>
            cquarter   = 5,

            /// <summary>
            /// 16-bit complex floating point. Alias for chalf.
            /// </summary>
            complex32  = 6,

            /// <summary>
            /// 16-bit complex floating point. Alias for complex32.
            /// </summary>
            chalf      = 6,

            /// <summary>
            /// 16-bit complex google brain floating point. Alias for cbfloat16.
            /// </summary>
            bcomplex32 = 7,

            /// <summary>
            /// 16-bit complex google brain floating point. Alias for bcomplex32.
            /// </summary>
            cbfloat16  = 7,

            /// <summary>
            /// 32-bit complex floating point. Alias for cfloat.
            /// </summary>
            complex64  = 8,

            /// <summary>
            /// 32-bit complex floating point. Alias for complex64.
            /// </summary>
            cfloat     = 8,

            /// <summary>
            /// 64-bit complex floating point. Alias for cdouble.
            /// </summary>
            complex128 = 9,

            /// <summary>
            /// 64-bit complex floating point. Alias for complex128.
            /// </summary>
            cdouble    = 9,

            /// <summary>
            /// 8-bit signed integer. Alias for sbyte.
            /// </summary>
            int8       = 10,

            /// <summary>
            /// 8-bit signed integer. Alias for int8.
            /// </summary>
            @sbyte     = 10,

            /// <summary>
            /// 8-bit unsigned integer. Alias for byte.
            /// </summary>
            uint8      = 11,

            /// <summary>
            /// 8-bit unsigned integer. Alias for uint8.
            /// </summary>
            @byte      = 11,

            /// <summary>
            /// 16-bit signed integer. Alias for short.
            /// </summary>
            int16      = 12,

            /// <summary>
            /// 16-bit signed integer. Alias for int16.
            /// </summary>
            @short     = 12,

            /// <summary>
            /// 16-bit unsigned integer. Alias for ushort.
            /// </summary>
            uint16     = 13,

            /// <summary>
            /// 16-bit unsigned integer. Alias for uint16.
            /// </summary>
            @ushort    = 13,

            /// <summary>
            /// 32-bit signed integer. Alias for int.
            /// </summary>
            int32      = 14,

            /// <summary>
            /// 32-bit signed integer. Alias for int32.
            /// </summary>
            @int       = 14,

            /// <summary>
            /// 32-bit unsigned integer. Alias for uint.
            /// </summary>
            uint32     = 15,

            /// <summary>
            /// 32-bit unsigned integer. Alias for uint32.
            /// </summary>
            @uint      = 15,

            /// <summary>
            /// 64-bit signed integer. Alias for long.
            /// </summary>
            int64      = 16,

            /// <summary>
            /// 64-bit signed integer. Alias for int64.
            /// </summary>
            @long      = 16,

            /// <summary>
            /// 64-bit unsigned integer. Alias for ulong.
            /// </summary>
            uint64     = 17,

            /// <summary>
            /// 64-bit unsigned integer. Alias for uint64.
            /// </summary>
            @ulong     = 17,

            /// <summary>
            /// Boolean.
            /// </summary>
            @bool      = 18,

            /// <summary>
            /// System value. Default data type for parameters with default value in methods.
            /// </summary>
            @default   = 255

        }

    }

}
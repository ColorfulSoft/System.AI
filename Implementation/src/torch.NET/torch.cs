//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

namespace System.AI
{

    /// <summary>
    /// An open source machine learning framework that accelerates the path from research prototyping to production deployment.
    /// </summary>
    public static unsafe partial class torch
    {

        /// <summary>
        /// Current torch version.
        /// </summary>
        public static string __version__
        {

            get;

            private set;

        }

        /// <summary>
        /// Default data type.
        /// </summary>
        private static DType __default_dtype;

        /// <summary>
        /// Default data type.
        /// </summary>
        public static DType default_dtype
        {

            get
            {
                return __default_dtype;
            }

            set
            {
                if(value != DType.@default)
                {
                    __default_dtype = value;
                }
            }

        }

        /// <summary>
        /// Initializes torch before usage.
        /// </summary>
        static torch()
        {
            __version__ = "0.3";
            default_dtype = torch.float32;
        }

        /// <summary>
        /// 8-bit floating point. Alias for quarter.
        /// </summary>
        public const DType float8     = DType.float8;

        /// <summary>
        /// 8-bit floating point. Alias for float8.
        /// </summary>
        public const DType quarter    = DType.float8;

        /// <summary>
        /// 16-bit floating point. Alias for half.
        /// </summary>
        public const DType float16    = DType.float16;

        /// <summary>
        /// 16-bit floating point. Alias for float16.
        /// </summary>
        public const DType half       = DType.float16;

        /// <summary>
        /// 16-bit google brain floating point.
        /// </summary>
        public const DType bfloat16   = DType.bfloat16;

        /// <summary>
        /// 32-bit floating point. Alias for float.
        /// </summary>
        public const DType float32    = DType.float32;

        /// <summary>
        /// 32-bit floating point. Alias for float32.
        /// </summary>
        public const DType @float     = DType.float32;

        /// <summary>
        /// 64-bit floating point. Alias for double.
        /// </summary>
        public const DType float64    = DType.float64;

        /// <summary>
        /// 64-bit floating point. Alias for float64.
        /// </summary>
        public const DType @double    = DType.float64;

        /// <summary>
        /// 8-bit complex floating point. Alias for cquarter.
        /// </summary>
        public const DType complex16  = DType.complex16;

        /// <summary>
        /// 8-bit complex floating point. Alias for complex16.
        /// </summary>
        public const DType cquarter   = DType.complex16;

        /// <summary>
        /// 16-bit complex floating point. Alias for chalf.
        /// </summary>
        public const DType complex32  = DType.complex32;

        /// <summary>
        /// 16-bit complex floating point. Alias for complex32.
        /// </summary>
        public const DType chalf      = DType.complex32;

        /// <summary>
        /// 16-bit complex google brain floating point. Alias for cbfloat16.
        /// </summary>
        public const DType bcomplex32 = DType.bcomplex32;

        /// <summary>
        /// 16-bit complex google brain floating point. Alias for bcomplex32.
        /// </summary>
        public const DType cbfloat16  = DType.bcomplex32;

        /// <summary>
        /// 32-bit complex floating point. Alias for cfloat.
        /// </summary>
        public const DType complex64  = DType.complex64;

        /// <summary>
        /// 32-bit complex floating point. Alias for complex64.
        /// </summary>
        public const DType cfloat     = DType.complex64;

        /// <summary>
        /// 64-bit complex floating point. Alias for cdouble.
        /// </summary>
        public const DType complex128 = DType.complex128;

        /// <summary>
        /// 64-bit complex floating point. Alias for complex128.
        /// </summary>
        public const DType cdouble    = DType.complex128;

        /// <summary>
        /// 8-bit signed integer. Alias for sbyte.
        /// </summary>
        public const DType int8       = DType.int8;

        /// <summary>
        /// 8-bit signed integer. Alias for int8.
        /// </summary>
        public const DType @sbyte     = DType.int8;

        /// <summary>
        /// 8-bit unsigned integer. Alias for byte.
        /// </summary>
        public const DType uint8      = DType.uint8;

        /// <summary>
        /// 8-bit unsigned integer. Alias for uint8.
        /// </summary>
        public const DType @byte      = DType.uint8;

        /// <summary>
        /// 16-bit signed integer. Alias for short.
        /// </summary>
        public const DType int16      = DType.int16;

        /// <summary>
        /// 16-bit signed integer. Alias for int16.
        /// </summary>
        public const DType @short     = DType.int16;

        /// <summary>
        /// 16-bit unsigned integer. Alias for ushort.
        /// </summary>
        public const DType uint16     = DType.uint16;

        /// <summary>
        /// 16-bit unsigned integer. Alias for uint16.
        /// </summary>
        public const DType @ushort    = DType.uint16;

        /// <summary>
        /// 32-bit signed integer. Alias for int.
        /// </summary>
        public const DType int32      = DType.int32;

        /// <summary>
        /// 32-bit signed integer. Alias for int32.
        /// </summary>
        public const DType @int       = DType.int32;

        /// <summary>
        /// 32-bit unsigned integer. Alias for uint.
        /// </summary>
        public const DType uint32     = DType.uint32;

        /// <summary>
        /// 32-bit unsigned integer. Alias for uint32
        /// </summary>
        public const DType @uint      = DType.uint32;

        /// <summary>
        /// 64-bit signed integer. Alias for long.
        /// </summary>
        public const DType int64      = DType.int64;

        /// <summary>
        /// 64-bit signed integer. Alias for int64.
        /// </summary>
        public const DType @long      = DType.int64;

        /// <summary>
        /// 64-bit unsigned integer. Alias for ulong.
        /// </summary>
        public const DType uint64     = DType.uint64;

        /// <summary>
        /// 64-bit unsigned integer. Alias for uint64.
        /// </summary>
        public const DType @ulong     = DType.uint64;

        /// <summary>
        /// Boolean.
        /// </summary>
        public const DType @bool      = DType.@bool;

        /// <summary>
        /// Gets the size in bytes occupied by a single value of the dtype data type.
        /// </summary>
        /// <param name="dtype">Data type to test.</param>
        /// <returns>Size in bytes.</returns>
        public static int size(this DType dtype)
        {
            dtype = (dtype == DType.@default) ? torch.default_dtype : dtype;
            switch(dtype)
            {
                case torch.float8:
                case torch.int8:
                case torch.uint8:
                case torch.@bool:
                {
                    return 1;
                }
                case torch.float16:
                case torch.bfloat16:
                case torch.complex16:
                case torch.int16:
                case torch.uint16:
                {
                    return 2;
                }
                case torch.float32:
                case torch.complex32:
                case torch.bcomplex32:
                case torch.int32:
                case torch.uint32:
                {
                    return 4;
                }
                case torch.float64:
                case torch.complex64:
                case torch.int64:
                case torch.uint64:
                {
                    return 8;
                }
                case torch.complex128:
                {
                    return 16;
                }
                default:
                {
                    throw new InvalidOperationException("Invalid dtype code.");
                }
            }
        }

    }

}
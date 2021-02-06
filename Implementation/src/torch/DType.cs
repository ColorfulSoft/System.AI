//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            /// <summary>
            /// Torch defines nine CPU tensor types and nine GPU tensor types
            /// </summary>
            public enum DType : byte
            {

                #region system constant for global default data type

                /// <summary>
                /// Default data type. System field. Use it if you want to set 
                /// the global-defined default data type as the parameter value
                /// </summary>
                @default = 9,

                #endregion

                #region floating point data types

                /// <summary>
                /// 16-bit floating point
                /// </summary>
                float16 = 0,

                /// <summary>
                /// 16-bit floating point
                /// </summary>
                half = 0,

                /// <summary>
                /// 32-bit floating point
                /// </summary>
                float32 = 1,

                /// <summary>
                /// 32-bit floating point
                /// </summary>
                @float = 1,

                /// <summary>
                /// 64-bit floating point
                /// </summary>
                float64 = 2,

                /// <summary>
                /// 64-bit floating point
                /// </summary>
                @double = 2,

                #endregion

                #region integer data types

                /// <summary>
                /// 8-bit integer (unsigned)
                /// </summary>
                uint8 = 3,

                /// <summary>
                /// 8-bit integer (signed)
                /// </summary>
                int8 = 4,

                /// <summary>
                /// 16-bit integer (signed)
                /// </summary>
                int16 = 5,

                /// <summary>
                /// 16-bit integer (signed)
                /// </summary>
                @short = 5,

                /// <summary>
                /// 32-bit integer (signed)
                /// </summary>
                int32 = 6,

                /// <summary>
                /// 32-bit integer (signed)
                /// </summary>
                @int = 6,

                /// <summary>
                /// 64-bit integer (signed)
                /// </summary>
                int64 = 7,

                /// <summary>
                /// 64-bit integer (signed)
                /// </summary>
                @long = 7,

                #endregion

                #region bool data type

                /// <summary>
                /// Boolean
                /// </summary>
                @bool = 8

                #endregion

            }

        }

    }

}
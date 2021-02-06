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

        /// <summary>
        /// The torch package contains data structures for 
        /// multi-dimensional tensors and mathematical operations 
        /// over these are defined. Additionally, it provides many 
        /// utilities for efficient serializing of Tensors and arbitrary 
        /// types, and other useful utilities.
        /// </summary>
        public static partial class torch
        {

            #region global properties

            /// <summary>
            /// The current torch version
            /// </summary>
            public static string version
            {

                get;

                private set;

            }

            /// <summary>
            /// Default tensor data type
            /// </summary>
            public static DType default_dtype
            {

                get;

                set;

            }

            public static bool warnings_are_enabled
            {

                get;

                set;

            }

            #endregion

            /// <summary>
            /// Initializes all global torch properties.
            /// </summary>
            static torch()
            {
                version = "0.0.1";
                default_dtype = float32;
                warnings_are_enabled = true;
            }

            #region constants for torch.<dtype name> access.

            #region floating point data types

            /// <summary>
            /// 32-bit floating point
            /// </summary>
            public const DType float32 = DType.float32;

            /// <summary>
            /// 32-bit floating point
            /// </summary>
            public const DType @float = DType.@float;

            /// <summary>
            /// 64-bit floating point
            /// </summary>
            public const DType float64 = DType.float64;

            /// <summary>
            /// 64-bit floating point
            /// </summary>
            public const DType @double = DType.@double;

            /// <summary>
            /// 16-bit floating point
            /// </summary>
            public const DType float16 = DType.float16;

            /// <summary>
            /// 16-bit floating point
            /// </summary>
            public const DType half = DType.@half;

            #endregion

            #region integer data types

            /// <summary>
            /// 8-bit integer (unsigned)
            /// </summary>
            public const DType uint8 = DType.uint8;

            /// <summary>
            /// 8-bit integer (signed)
            /// </summary>
            public const DType int8 = DType.int8;

            /// <summary>
            /// 16-bit integer (signed)
            /// </summary>
            public const DType int16 = DType.int16;

            /// <summary>
            /// 16-bit integer (signed)
            /// </summary>
            public const DType @short = DType.@short;

            /// <summary>
            /// 32-bit integer (signed)
            /// </summary>
            public const DType int32 = DType.int32;

            /// <summary>
            /// 32-bit integer (signed)
            /// </summary>
            public const DType @int = DType.@int;

            /// <summary>
            /// 64-bit integer (signed)
            /// </summary>
            public const DType int64 = DType.int64;

            /// <summary>
            /// 64-bit integer (signed)
            /// </summary>
            public const DType @long = DType.@long;

            #endregion

            #region bool data type

            /// <summary>
            /// Boolean
            /// </summary>
            public const DType @bool = DType.@bool;

            #endregion

            #endregion

            #region context-manager info

            public static autograd.grad_mode.no_grad set_grad_enabled(bool state)
            {
                var attr = new autograd.grad_mode.no_grad();
                autograd.grad_mode.no_grad.prev = state;
                return attr;
            }

            public static autograd.grad_mode.no_grad no_grad()
            {
                return new autograd.grad_mode.no_grad();
            }

            #endregion

        }

    }

}
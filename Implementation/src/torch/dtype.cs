//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 03.01.2020.

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            ///<summary>Supported data types.</summary>
            public enum dtype
            {

                ///<summary>32-bit floating point. Alias for dtype.float.</summary>
                float32 = 0,

                ///<summary>32-bit floating point. Alias for dtype.float32.</summary>
                @float = 0,

                ///<summary>8-bit integer (unsigned).</summary>
                uint8 = 1,

                ///<summary>64-bit integer (signed). Alias for dtype.long.</summary>
                int64 = 2,

                ///<summary>64-bit integer (signed). Alias for dtype.int64.</summary>
                @long = 2,

                @default = -1

            }

            ///<summary>32-bit floating point. Alias for torch.float.</summary>
            public const dtype float32 = dtype.float32;

            ///<summary>32-bit floating point. Alias for torch.float32.</summary>
            public const dtype @float = dtype.@float;

            ///<summary>8-bit integer (unsigned).</summary>
            public const dtype uint8 = dtype.uint8;

            ///<summary>64-bit integer (signed). Alias for torch.long.</summary>
            public const dtype int64 = dtype.int64;

            ///<summary>64-bit integer (signed). Alias for torch.int64.</summary>
            public const dtype @long = dtype.@long;

        }

    }

}
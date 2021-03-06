﻿//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System
{

    namespace IO
    {

        public static class BinaryReaderExtension
        {

            public static Half ReadHalf(this BinaryReader br)
            {
                return new Half{value = br.ReadUInt16()};
            }

        }

    }

}
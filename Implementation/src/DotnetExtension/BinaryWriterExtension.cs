//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020 - 2021. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System
{

    namespace IO
    {

        public static class BinaryWriterExtension
        {

            public static void Write(this BinaryWriter bw, Half v)
            {
                bw.Write(v.value);
            }

        }

    }

}
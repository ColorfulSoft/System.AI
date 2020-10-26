//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System
{

    namespace IO
    {

        public static class StreamExtension
        {

            public static void Write(this Stream s, byte[] data)
            {
                s.Write(data, 0, data.Length);
            }

        }

    }

}
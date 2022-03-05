//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System.IO
{

    public static partial class imageio
    {

        public sealed class ImageIOException : Exception
        {

            public ImageIOException(string text) : base(text)
            {
            }

        }

    }

}
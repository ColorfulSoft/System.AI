//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System.IO
{

    public static partial class torchfile
    {

        /// <summary>
        /// Represents an exception that occurs when reading Torch files.
        /// </summary>
        public sealed class T7ReaderException : Exception
        {

            /// <summary>
            /// Initializes a new T7ReaderException instance.
            /// </summary>
            /// <param name="message">Message.</param>
            public T7ReaderException(string message) : base(message)
            {
            }

        }

    }

}
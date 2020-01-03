//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            ///<summary>The exception raised by an internal error in the Torch library.</summary>
            public sealed class TorchException : Exception
            {

                ///<summary>Initializes an exception with the specified message.</summary>
                ///<param name = "message">Error message.</param>
                public TorchException(string message) : base(message)
                {
                }

            }

        }

    }

}
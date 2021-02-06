//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            /// <summary>
            /// Internal exception class Torch.NET
            /// </summary>
            public sealed class TorchException : Exception
            {

                /// <summary>
                /// Initializes exception instance.
                /// </summary>
                /// <param name="s">Message.</param>
                public TorchException(string s) : base(s)
                {
                }

            }

        }

    }

}
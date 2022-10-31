//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// Data storage for complex32 tensors.
        /// </summary>
        public sealed class CHalfStorage : Storage
        {

            /// <summary>
            /// Initializes the storage of the specified size.
            /// </summary>
            /// <param name="size">Size.</param>
            public CHalfStorage(int size) : base(size, torch.complex32)
            {
            }

        }

    }

}
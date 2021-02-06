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

            public static partial class autograd
            {

                public static partial class grad_mode
                {

                    /// <summary>
                    /// Context-manager that disabled gradient calculation.
                    /// </summary>
                    public sealed class no_grad : IDisposable
                    {

                        public static bool prev
                        {
                            get;
                            set;
                        }

                        /// <summary>
                        /// Creates manager.
                        /// </summary>
                        /// <example>
                        /// <code>
                        /// using(new torch.no_grad())
                        /// {
                        ///     a = torch.sigmoid(b);
                        /// }
                        /// </code>
                        /// </example>
                        public no_grad()
                        {
                            prev = true;
                        }

                        /// <summary>
                        /// Converts the current instance of ContextManager to 
                        /// string representation.
                        /// </summary>
                        /// <returns>String representation of context-manager.</returns>
                        public override string ToString()
                        {
                             return "ContextProperty: no_grad";
                        }

                        /// <summary>
                        /// Disables manager.
                        /// </summary>
                        public void Dispose()
                        {
                            prev = false;
                        }

                    }

                }

            }

        }

    }

}
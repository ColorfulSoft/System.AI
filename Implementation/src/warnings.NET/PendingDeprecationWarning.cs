//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;

namespace System
{

    /// <summary>
    /// Base category for warnings about features that will be deprecated in the future (ignored by default).
    /// </summary>
    public class PendingDeprecationWarning : Warning
    {

        /// <summary>
        /// Initializes the warning object with the specified arguments (data about the problem).
        /// </summary>
        /// <param name="args">Arguments</param>
        public PendingDeprecationWarning(params object[] args) : base(args)
        {
        }

    }

}
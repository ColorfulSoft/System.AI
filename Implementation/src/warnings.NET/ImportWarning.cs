//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;

namespace System
{

    /// <summary>
    /// Base category for warnings triggered during the process of importing a module (ignored by default).
    /// </summary>
    public class ImportWarning : Warning
    {

        /// <summary>
        /// Initializes the warning object with the specified arguments (data about the problem).
        /// </summary>
        /// <param name="args">Arguments</param>
        public ImportWarning(params object[] args) : base(args)
        {
        }

    }

}
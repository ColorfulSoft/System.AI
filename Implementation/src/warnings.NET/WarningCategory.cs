//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;

namespace System
{

    /// <summary>
    /// Warning categories.
    /// </summary>
    public enum WarningCategory : byte
    {

        /// <summary>
        /// This is the base class of all warning category classes. It is a subclass of Exception.
        /// </summary>
        Warning,

        /// <summary>
        /// The default category for warn().
        /// </summary>
        UserWarning,

        /// <summary>
        /// Base category for warnings about deprecated features
        /// when those warnings are intended for other .NET
        /// developers.
        /// </summary>
        DeprecationWarning,

        /// <summary>
        /// Base category for warnings about dubious syntactic features.
        /// </summary>
        SyntaxWarning,

        /// <summary>
        /// Base category for warnings about dubious runtime features.
        /// </summary>
        RuntimeWarning,

        /// <summary>
        /// Base category for warnings about deprecated
        /// features when those warnings are intended for
        /// end users of applications that are written in .NET language.
        /// </summary>
        FutureWarning,

        /// <summary>
        /// Base category for warnings about features that
        /// will be deprecated in the future.
        /// </summary>
        PendingDeprecationWarning,

        /// <summary>
        /// Base category for warnings triggered during the process of importing a module.
        /// </summary>
        ImportWarning,

        /// <summary>
        /// Base category for warnings related to Unicode.
        /// </summary>
        UnicodeWarning,

        /// <summary>
        /// Base category for warnings related to bytes and bytearray.
        /// </summary>
        BytesWarning,

        /// <summary>
        /// Base category for warnings related to resource usage.
        /// </summary>
        ResourceWarning

    }

}
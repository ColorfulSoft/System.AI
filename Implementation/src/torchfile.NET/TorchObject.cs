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
        /// Simple torch object, used by `add_trivial_class_reader`.
        /// Supports both forms of lua-style indexing, i.e. getattr and getitem.
        /// Use the `torch_typename` method to get the object's torch class name.
        /// Equality is by reference, as usual for lua (and the default for Python
        /// objects).
        /// </summary>
        public sealed class TorchObject
        {

            /// <summary>
            /// Type name.
            /// </summary>
            public string _typename
            {

                get;

                set;

            }

            /// <summary>
            /// Value.
            /// </summary>
            public object _obj
            {

                get;

                set;

            }

            /// <summary>
            /// Version.
            /// </summary>
            public int _version_number
            {

                get;

                set;

            }

            /// <summary>
            /// Initializes a new TorchObject instance with given values.
            /// </summary>
            /// <param name="typename">Type name.</param>
            /// <param name="obj">Value.</param>
            /// <param name="version_number">Version.</param>
            public TorchObject(string typename, object obj = null, int version_number = 0)
            {
                this._typename = typename;
                this._obj = obj;
                this._version_number = version_number;
            }

            /// <summary>
            /// Converts the TorchObject instance to readable string representation.
            /// </summary>
            /// <returns>String representation.</returns>
            public override string ToString()
            {
                return string.Format("TorchObject(Typename = {0}, Obj = {1}, Version_number = {2})", _typename, _obj, _version_number);
            }

        }

    }

}
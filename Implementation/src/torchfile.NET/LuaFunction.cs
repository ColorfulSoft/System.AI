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
        /// Represents the Lua function.
        /// </summary>
        public sealed class LuaFunction
        {

            /// <summary>
            /// Size in bytes.
            /// </summary>
            public int size
            {

                get;

                set;

            }

            /// <summary>
            /// Dumped code.
            /// </summary>
            public byte[] dumped
            {

                get;

                set;

            }

            /// <summary>
            /// Values.
            /// </summary>
            public object upvalues
            {

                get;

                set;

            }

            /// <summary>
            /// Initializes a new LuaFunction object instance with given values.
            /// </summary>
            /// <param name="size">Size in bytes.</param>
            /// <param name="dumped">Dumped code.</param>
            /// <param name="upvalues">Values.</param>
            public LuaFunction(int size, byte[] dumped, object upvalues)
            {
                this.size = size;
                this.dumped = dumped;
                this.upvalues = upvalues;
            }

            /// <summary>
            /// Converts the LuaFunction class instance to readable string representation.
            /// </summary>
            /// <returns>String representation.</returns>
            public override string ToString()
            {
                var repr = "LuaFunction(size = " + this.size.ToString() + ", dumped = (";
                for(int i = 0; i < this.dumped.Length; ++i)
                {
                    repr += this.dumped[i].ToString() + (((i + 1) < this.dumped.Length) ? ", " : "");
                }
                repr += "), upvalues = " + ((this.upvalues == null) ? "null" : this.upvalues.ToString()) + ")";
                return repr;
            }

        }

    }

}
//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Runtime.InteropServices;

namespace System
{

    public static class DotnetExtensions
    {

        /// <summary>
        /// Array syntax.
        /// </summary>
        public enum ArrayConvention : byte
        {

            /// <summary>
            /// C#-style array.
            /// </summary>
            CSharp,

            /// <summary>
            /// VB.NET-style array.
            /// </summary>
            VBNET,

            /// <summary>
            /// PascalABC.NET-style array.
            /// </summary>
            PascalABCNET,

            /// <summary>
            /// IronPython-style array.
            /// </summary>
            IronPython

        }

        /// <summary>
        /// Outputs an array with formatting to the console or to the passed TextWriter.
        /// </summary>
        /// <param name="arr">Array.</param>
        /// <param name="output">Output stream (if null, writes to Console.Out).</param>
        /// <param name="convention">Array convention.</param>
        public static void Print(this Array arr, TextWriter output = null, ArrayConvention convention = ArrayConvention.CSharp)
        {
            if(output == null)
            {
                output = Console.Out;
            }
            Func<int, string> arr_size = (int n) =>
            {
                var s = "";
                for(int i = 0; i < n; ++i)
                {
                    s += arr.GetLength(i).ToString();
                    if(i + 1 < n)
                    {
                        s += ", ";
                    }
                }
                return s;
            };
            var str = "";
            char begin_arr = '\0';
            char end_arr = '\0';
            switch(convention)
            {
                case ArrayConvention.CSharp:
                {
                    str = string.Format("{0}[{1}]", arr.GetType().GetElementType(), arr_size(arr.Rank));
                    begin_arr = '{';
                    end_arr = '}';
                    break;
                }
                case ArrayConvention.VBNET:
                {
                    str = string.Format("{0}({1})", arr.GetType().GetElementType(), arr_size(arr.Rank));
                    begin_arr = '{';
                    end_arr = '}';
                    break;
                }
                case ArrayConvention.PascalABCNET:
                {
                    str = string.Format("{0}[{1}]", arr.GetType().GetElementType(), arr_size(arr.Rank));
                    begin_arr = '(';
                    end_arr = ')';
                    break;
                }
                case ArrayConvention.IronPython:
                {
                    begin_arr = '[';
                    end_arr = ']';
                    break;
                }
            }
            var loc = new int[arr.Rank];
            Action<int, int> print = null;
            print = (int dim, int pad) =>
            {
                if((loc.Length - dim) != 0)
                {
                    if(dim > 0)
                    {
                        if(loc[dim - 1] > 0)
                        {
                            for(int i = 0; i < (pad + dim); ++i)
                            {
                                str += ' ';
                            }
                        }
                    }
                    str += begin_arr;
                    var size = arr.GetLength(dim);
                    for(int i = 0; i < size; ++i)
                    {
                        print(dim + 1, pad);
                        ++loc[dim];
                    }
                    loc[dim] = 0;
                    str += end_arr;
                    if(dim > 0)
                    {
                        if((loc[dim - 1] + 1) != arr.GetLength(dim - 1))
                        {
                            for(int j = 0; j < (arr.Rank - dim); ++j)
                            {
                                str += ',';
                                str += Environment.NewLine;
                            }
                        }
                    }
                }
                else
                {
                    str += arr.GetValue(loc);
                    if((dim - 1) >= 0)
                    {
                        if((loc[dim - 1] + 1) != arr.GetLength(dim - 1))
                        {
                            str += ", ";
                        }
                    }
                }
            };
            print(0, str.Length);
            output.WriteLine(str);
        }

        /// <summary>
        /// Returns an array as an array of bytes.
        /// </summary>
        /// <param name="arr">Array.</param>
        /// <returns>Bytes.</returns>
        public static unsafe byte[] tobytes(this Array arr)
        {
            if(!arr.GetType().GetElementType().IsValueType)
            {
                throw new ArgumentException("Array should be of struct.");
            }
            var bytes = new byte[arr.Length * Marshal.SizeOf(arr.GetType().GetElementType())];
            var handle = GCHandle.Alloc(arr, GCHandleType.Pinned);
            var ptr = (byte*)handle.AddrOfPinnedObject();
            for(int i = 0; i < bytes.Length; ++i)
            {
                bytes[i] = ptr[i];
            }
            handle.Free();
            return bytes;
        }

        /// <summary>
        /// Fills the array using data from the byte buffer.
        /// </summary>
        /// <param name="arr">Array.</param>
        /// <param name="buffer">Buffer.</param>
        public static unsafe void frombytes(this Array arr, byte[] buffer)
        {
            if(!arr.GetType().GetElementType().IsValueType)
            {
                throw new ArgumentException("Array should be of struct type.");
            }
            if(arr.Length * Marshal.SizeOf(arr.GetType().GetElementType()) != buffer.Length)
            {
                throw new ArgumentException("The buffer size does not match the size of the array.");
            }
            var handle = GCHandle.Alloc(arr, GCHandleType.Pinned);
            var ptr = (byte*)handle.AddrOfPinnedObject();
            for(int i = 0; i < buffer.Length; ++i)
            {
                ptr[i] = buffer[i];
            }
            handle.Free();
        }

    }

}
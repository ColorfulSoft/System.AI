//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// Represents the size of the tensor.
        /// </summary>
        public sealed class Size : IList<int>, IDisposable
        {

            /// <summary>
            /// Pointer to an array with dimensions.
            /// </summary>
            internal int* __data_ptr;

            /// <summary>
            /// The number of tensor dimensions (the length of the array with dimensions).
            /// </summary>
            private int __count;

            /// <summary>
            /// The number of tensor elements.
            /// </summary>
            public int numel
            {

                get;

                internal set;

            }

            /// <summary>
            /// The number of tensor dimensions.
            /// </summary>
            public int Count
            {

                get
                {
                    return this.__count;
                }

            }

            /// <summary>
            /// Initializes the Size object.
            /// </summary>
            /// <param name="size">Dimensions of the tensor.</param>
            public Size(params int[] size)
            {
                if(size == null)
                {
                    size = new int[0];
                }
                if(size.Length > 32)
                {
                    throw new NotImplementedException("The maximum number of measurements is 32.");
                }
                this.__count = size.Length;
                this.__data_ptr = (int*)Marshal.AllocHGlobal(this.__count).ToPointer();
                this.numel = 1;
                for(int i = 0; i < this.__count; ++i)
                {
                    if(size[i] <= 0)
                    {
                        throw new ArgumentException("The tensor measurement cannot have a value less than 1.");
                    }
                    this.__data_ptr[i] = size[i];
                    this.numel *= size[i];
                }
            }

            /// <summary>
            /// Releases unmanaged resources of the Size object.
            /// </summary>
            public void Dispose()
            {
                if(this.__data_ptr != null)
                {
                    Marshal.FreeHGlobal((IntPtr)this.__data_ptr);
                    this.__data_ptr = null;
                }
            }

            /// <summary>
            /// Releases unmanaged resources of the Size object.
            /// </summary>
            ~Size()
            {
                if(this.__data_ptr != null)
                {
                    Marshal.FreeHGlobal((IntPtr)this.__data_ptr);
                    this.__data_ptr = null;
                }
            }

            int IList<int>.IndexOf(int value)
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    if(this.__data_ptr[i] == value)
                    {
                        return i;
                    }
                }
                return -1;
            }

            void IList<int>.Insert(int index, int value)
            {
                throw new NotImplementedException();
            }

            void IList<int>.RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            public int this[int index]
            {

                get
                {
                    return this.__data_ptr[index];
                }

                set
                {
                    throw new NotImplementedException();
                }

            }

            void ICollection<int>.Add(int value)
            {
                throw new NotImplementedException();
            }

            void ICollection<int>.Clear()
            {
                throw new NotImplementedException();
            }

            bool ICollection<int>.Contains(int value)
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    if(this.__data_ptr[i] == value)
                    {
                        return true;
                    }
                }
                return false;
            }

            void ICollection<int>.CopyTo(int[] dest, int start)
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    dest[start + i] = this.__data_ptr[i];
                }
            }

            bool ICollection<int>.Remove(int value)
            {
                throw new NotImplementedException();
            }

            bool ICollection<int>.IsReadOnly
            {

                get
                {
                    return true;
                }

            }

            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    yield return this[i];
                }
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    yield return (object)this[i];
                }
            }

            /// <summary>
            /// Returns a string representation of the Size object.
            /// </summary>
            /// <returns>Size object as a string.</returns>
            public override string ToString()
            {
                var str = "torch.Size([";
                for(int i = 0; i < this.__count; ++i)
                {
                    str += this.__data_ptr[i].ToString();
                    if((i + 1) < this.__count)
                    {
                        str += ", ";
                    }
                }
                return str + "])";
            }

        }

    }

}
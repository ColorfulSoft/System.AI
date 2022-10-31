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
                this.__data_ptr = (int*)Marshal.AllocHGlobal(this.__count * sizeof(int)).ToPointer();
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

            /// <summary>
            /// Returns the index of the first occurrence of the specified value in the collection.
            /// In Size, returns the number of the first dimension equal to value.
            /// If none was found, it will return -1.
            /// </summary>
            /// <param name="value">The desired value.</param>
            /// <returns>The index of the first occurrence of the value value in the collection or -1.</returns>
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

            /// <summary>
            /// Does not belong to this class.
            /// </summary>
            void IList<int>.Insert(int index, int value)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Does not belong to this class.
            /// </summary>
            void IList<int>.RemoveAt(int index)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Returns a dimension by its number. Read-only. An attempt to write will create an exception.
            /// </summary>
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

            /// <summary>
            /// Does not belong to this class.
            /// </summary>
            void ICollection<int>.Add(int value)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Does not belong to this class.
            /// </summary>
            void ICollection<int>.Clear()
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Checks whether there is a dimension equal to value.
            /// </summary>
            /// <param name="value">The desired value.</param>
            /// <returns>Boolean value.</returns>
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

            /// <summary>
            /// Copies the values of the current Size object to the dest array,
            /// starting with the start index in it.
            /// </summary>
            /// <param name="dest">Target array.</param>
            /// <param name="start">The initial index of the dest array.</param>
            void ICollection<int>.CopyTo(int[] dest, int start)
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    dest[start + i] = this.__data_ptr[i];
                }
            }

            /// <summary>
            /// Does not belong to this class.
            /// </summary>
            bool ICollection<int>.Remove(int value)
            {
                throw new NotImplementedException();
            }

            /// <summary>
            /// Gets a value indicating whether the current collection is read-only. Size is read-only.
            /// </summary>
            bool ICollection<int>.IsReadOnly
            {

                get
                {
                    return true;
                }

            }

            /// <summary>
            /// Gets an enumerator (for foreach loops).
            /// </summary>
            /// <returns>IEnumerator&lt;int&gt;.</returns>
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
            {
                for(int i = 0; i < this.__count; ++i)
                {
                    yield return this[i];
                }
            }

            /// <summary>
            /// Gets an enumerator (for foreach loops).
            /// </summary>
            /// <returns>IEnumerator.</returns>
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
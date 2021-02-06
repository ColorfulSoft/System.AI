//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 22.08.2020.

using System;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            ///<summary>Represents the size of the tensor.</summary>
            public struct Size
            {

                ///<summary>The size of the tensor.</summary>
                internal int[] __size;

                internal Size(int rank)
                {
                    if(rank > 32)
                    {
                        throw new TorchException("TorchException: Unable to create the size with more than 32 dimensions.");
                    }
                    this.__size = new int[rank];
                }

                ///<summary>Initializes an instance of the Size structure.</summary>
                ///<param name = "length">The length of the tensor.</param>
                public Size(params long[] shape)
                {
                    if(shape.Length > 32)
                    {
                        throw new TorchException("TorchException: Unable to create the size with more than 32 dimensions.");
                    }
                    for(byte i = 0; i < shape.Length; i++)
                    {
                        if(shape[i] < 1)
                        {
                            throw new TorchException("TorchException: The dimension of the tensor must be positive and non-zero integer. Number of dimension: " + i.ToString());
                        }
                    }
                    this.__size = new int[shape.Length];
                    for(int i = 0; i < shape.Length; i++)
                    {
                        this.__size[i] = (int)shape[i];
                    }
                }

                ///<summary>Returns a dimension.</summary>
                public int this[int i]
                {

                    get
                    {
                        if(i > (this.__size.Length - 1))
                        {
                            throw new TorchException("TorchException: It is impossible to obtain a " + i.ToString() + " measurement of the " + this.__size.Length.ToString() + " - dimensional tensor.");
                        }
                        return this.__size[i];
                    }

                }

                public static bool operator !=(Size a, Size b)
                {
                    return !(a == b);
                }

                public static bool operator ==(Size a, Size b)
                {
                    if(a.__size.Length != b.__size.Length)
                    {
                        return false;
                    }
                    for(int i = 0; i < a.__size.Length; i++)
                    {
                        if(a.__size[i] != b.__size[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }

                public static implicit operator Size(int[] size)
                {
                    if(size == null)
                    {
                        throw new TorchException("TorchException: Cannot convert an empty object.");
                    }
                    var s = new Size(size.Length);
                    for(int i = 0; i < size.Length; i++)
                    {
                        s.__size[i] = size[i];
                    }
                    return s;
                }

                public static implicit operator Size(int size)
                {
                    return new Size(size);
                }

                public static implicit operator Size(long[] size)
                {
                    if(size == null)
                    {
                        throw new TorchException("TorchException: Cannot convert an empty object.");
                    }
                    return new Size(size);
                }

                public static implicit operator Size(long size)
                {
                    return new Size(size);
                }

                public static implicit operator int[](Size size)
                {
                    var result = new int[size.__size.Length];
                    for(int i = 0; i < result.Length; i++)
                    {
                        result[i] = size.__size[i];
                    }
                    return result;
                }

                public static implicit operator long[](Size size)
                {
                    var result = new long[size.__size.Length];
                    for(int i = 0; i < result.Length; i++)
                    {
                        result[i] = size.__size[i];
                    }
                    return result;
                }

                ///<summary>Converts the current instance of the Size structure to a string representation.</summary>
                public override string ToString()
                {
                    var str = "torch.Size([";
                    if(this.__size.Length == 0)
                    {
                        return str + "])";
                    }
                    for(int i = 0; i < this.__size.Length; i++)
                    {
                        str += this.__size[i].ToString();
                        if((i + 1) == this.__size.Length)
                        {
                            str += "])";
                            break;
                        }
                        str += ", ";
                    }
                    return str;
                }

            }

        }

    }

}
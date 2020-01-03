//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

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
                internal long[] __size;

                ///<summary>Initializes an instance of the Size structure.</summary>
                ///<param name = "length">The length of the tensor.</param>
                public Size(params long[] shape)
                {
                    if(shape.Length > 5)
                    {
                        throw new TorchException("TorchException: Unable to create the tensor with more than 5 dimensions.");
                    }
                    for(byte i = 0; i < shape.Length; i++)
                    {
                        if(shape[i] < 1)
                        {
                            throw new TorchException("TorchException: The dimension of the tensor must be positive and non-zero integer. Number of dimension: " + i.ToString());
                        }
                    }
                    
                    this.__size = shape;
                }

                ///<summary>Returns a dimension.</summary>
                public long this[int i]
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

                public static implicit operator Size(int[] size)
                {
                    if(size == null)
                    {
                        throw new TorchException("TorchException: Cannot convert an empty object.");
                    }
                    switch(size.Length)
                    {
                        case 0:
                        {
                            return new Size();
                        }
                        case 1:
                        {
                            return new Size(size[0]);
                        }
                        case 2:
                        {
                            return new Size(size[0], size[1]);
                        }
                        case 3:
                        {
                            return new Size(size[0], size[1], size[2]);
                        }
                        case 4:
                        {
                            return new Size(size[0], size[1], size[2], size[3]);
                        }
                        case 5:
                        {
                            return new Size(size[0], size[1], size[2], size[3], size[4]);
                        }
                        default:
                        {
                            throw new TorchException("TorchException: Invalid view of size. Arrays with more than 5 dimensions are not supported.");
                        }
                    }
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
                    switch(size.Length)
                    {
                        case 0:
                        {
                            return new Size();
                        }
                        case 1:
                        {
                            return new Size((int)size[0]);
                        }
                        case 2:
                        {
                            return new Size((int)size[0], (int)size[1]);
                        }
                        case 3:
                        {
                            return new Size((int)size[0], (int)size[1], (int)size[2]);
                        }
                        case 4:
                        {
                            return new Size((int)size[0], (int)size[1], (int)size[2], (int)size[3]);
                        }
                        case 5:
                        {
                            return new Size((int)size[0], (int)size[1], (int)size[2], (int)size[3], (int)size[4]);
                        }
                        default:
                        {
                            throw new TorchException("TorchException: Invalid view of size. Arrays with more than 5 dimensions are not supported.");
                        }
                    }
                }

                public static implicit operator Size(long size)
                {
                    return new Size((int)size);
                }

                public static implicit operator int[](Size size)
                {
                    var result = new int[size.__size.Length];
                    switch(size.__size.Length)
                    {
                        case 0:
                        {
                            return result;
                        }
                        case 1:
                        {
                            result[0] = (int)size.__size[0];
                            return result;
                        }
                        case 2:
                        {
                            result[0] = (int)size.__size[0];
                            result[1] = (int)size.__size[1];
                            return result;
                        }
                        case 3:
                        {
                            result[0] = (int)size.__size[0];
                            result[1] = (int)size.__size[1];
                            result[2] = (int)size.__size[2];
                            return result;
                        }
                        case 4:
                        {
                            result[0] = (int)size.__size[0];
                            result[1] = (int)size.__size[1];
                            result[2] = (int)size.__size[2];
                            result[3] = (int)size.__size[3];
                            return result;
                        }
                        case 5:
                        {
                            result[0] = (int)size.__size[0];
                            result[1] = (int)size.__size[1];
                            result[2] = (int)size.__size[2];
                            result[3] = (int)size.__size[3];
                            result[4] = (int)size.__size[4];
                            return result;
                        }
                        default:
                        {
                            throw new TorchException("TorchException: The original instance of the size structure is corrupted.");
                        }
                    }
                }

                public static implicit operator long[](Size size)
                {
                    
                    var result = new long[size.__size.Length];
                    for(byte i = 0; i < result.Length; i++)
                    {
                        result[i] = size.__size[i];
                    }
                    return result;
                }

                ///<summary>Converts the current instance of the Size structure to a string representation.</summary>
                public override string ToString()
                {
                    var str = "torch.Size([";
                    switch(this.__size.Length)
                    {
                        case 0:
                        {
                            str += "])";
                            break;
                        }
                        case 1:
                        {
                            str += this.__size[0].ToString() + "])";
                            break;
                        }
                        case 2:
                        {
                            str += this.__size[0].ToString() + ", " + this.__size[1].ToString() + "])";
                            break;
                        }
                        case 3:
                        {
                            str += this.__size[0].ToString() + ", " + this.__size[1].ToString() + ", " + this.__size[2].ToString() + "])";
                            break;
                        }
                        case 4:
                        {
                            str += this.__size[0].ToString() + ", " + this.__size[1].ToString() + ", " + this.__size[2].ToString() + ", " + this.__size[3].ToString() + "])";
                            break;
                        }
                        case 5:
                        {
                            str += this.__size[0].ToString() + ", " + this.__size[1].ToString() + ", " + this.__size[2].ToString() + ", " + this.__size[3].ToString() + ", " + this.__size[4].ToString() + "])";
                            break;
                        }
                        default:
                        {
                            throw new TorchException("TorchException: Internal data error.");
                        }
                    }
                    return str;
                }

            }

        }

    }

}
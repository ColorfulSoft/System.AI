//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System
{

    public static class ArrayExtension
    {

        private static unsafe void AddBytes(int dim, int[] shape, int[] index, Array dotnet, byte[] bytes, ref int byteindex, Type eltype)
        {
            if((dim + 1) < shape.Length)
            {
                for(int i = 0; i < shape[dim]; i++)
                {
                    index[dim] = i;
                    AddBytes(dim + 1, shape, index, dotnet, bytes, ref byteindex, eltype);
                }
            }
            else
            {
                if(eltype == typeof(Half))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (Half)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                    }
                }
                if(eltype == typeof(float))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (float)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                    }
                }
                if(eltype == typeof(double))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (double)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                        bytes[byteindex++] = pv[4];
                        bytes[byteindex++] = pv[5];
                        bytes[byteindex++] = pv[6];
                        bytes[byteindex++] = pv[7];
                    }
                }
                if(eltype == typeof(sbyte))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (sbyte)dotnet.GetValue(index);
                        bytes[byteindex++] = *(byte*)(void*)&@value;
                    }
                }
                if(eltype == typeof(byte))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        bytes[byteindex++] = (byte)dotnet.GetValue(index);
                    }
                }
                if(eltype == typeof(short))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (short)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                    }
                }
                if(eltype == typeof(ushort))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (ushort)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                    }
                }
                if(eltype == typeof(int))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (int)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                    }
                }
                if(eltype == typeof(uint))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (uint)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                    }
                }
                if(eltype == typeof(long))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (long)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                        bytes[byteindex++] = pv[4];
                        bytes[byteindex++] = pv[5];
                        bytes[byteindex++] = pv[6];
                        bytes[byteindex++] = pv[7];
                    }
                }
                if(eltype == typeof(ulong))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (ulong)dotnet.GetValue(index);
                        var pv = (byte*)(void*)&@value;
                        bytes[byteindex++] = pv[0];
                        bytes[byteindex++] = pv[1];
                        bytes[byteindex++] = pv[2];
                        bytes[byteindex++] = pv[3];
                        bytes[byteindex++] = pv[4];
                        bytes[byteindex++] = pv[5];
                        bytes[byteindex++] = pv[6];
                        bytes[byteindex++] = pv[7];
                    }
                }
                if(eltype == typeof(bool))
                {
                    for(int i = 0; i < shape[dim]; i++)
                    {
                        index[dim] = i;
                        var @value = (bool)dotnet.GetValue(index);
                        bytes[byteindex++] = *(byte*)(void*)&@value;
                    }
                }
            }
        }

        public static byte[] tobytes(this Array dotnet)
        {
            var eltype = dotnet.GetValue(new int[dotnet.Rank]).GetType();
            var elsize = 0;
            if((eltype == typeof(byte)) || (eltype == typeof(sbyte)) || (eltype == typeof(bool)))
            {
                elsize = 1;
            }
            else
            {
                if((eltype == typeof(Half)) || (eltype == typeof(short)) || (eltype == typeof(ushort)))
                {
                    elsize = 2;
                }
                else
                {
                    if((eltype == typeof(float)) || (eltype == typeof(int)) || (eltype == typeof(uint)))
                    {
                        elsize = 4;
                    }
                    else
                    {
                        if((eltype == typeof(double)) || (eltype == typeof(long)) || (eltype == typeof(ulong)))
                        {
                            elsize = 8;
                        }
                        else
                        {
                            throw new Exception("DotnetExtensionException: array of integer, floating point or boolean data type is required.");
                        }
                    }
                }
            }
            var shape = new int[dotnet.Rank];
            for(int i = 0; i < dotnet.Rank; i++)
            {
                shape[i] = dotnet.GetLength(i);
            }
            var bytes = new byte[dotnet.Length * elsize];
            int byteindex = 0;
            AddBytes(0, shape, new int[shape.Length], dotnet, bytes, ref byteindex, eltype);
            return bytes;
        }

    }

}
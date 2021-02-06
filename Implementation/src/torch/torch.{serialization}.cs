//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            #region serialization

            private const int __current_file_version = 0;

            ///<summary>Saves state dict to a file.</summary>
            ///<param name = "data">A tensor to save.</param>
            ///<param name = "fname">Output file name.</param>
            private static unsafe void save(Tensor data, Stream s)
            {
                var fs = new BinaryWriter(s);
                fs.Write("Torch.NET>");
                fs.Write(__current_file_version); // version
                fs.Write((byte)0);
                fs.Write((int)data.__shape.Length);
                for(int i = 0; i < data.__shape.Length; i++)
                {
                    fs.Write(data.__shape[i]);
                }
                switch(data.dtype)
                {
                    case torch.float16:
                    {
                        fs.Write((byte)0);
                        var src = data.__half;
                        for(int i = 0; i < src.Length; i++)
                        {
                            var val = src[i];
                            fs.Write(*(ushort*)(void*)&val);
                        }
                        break;
                    }
                    case torch.float32:
                    {
                        fs.Write((byte)1);
                        var src = data.__float;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.float64:
                    {
                        fs.Write((byte)2);
                        var src = data.__double;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.uint8:
                    {
                        fs.Write((byte)3);
                        var src = data.__uint8;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.int8:
                    {
                        fs.Write((byte)4);
                        var src = data.__int8;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.int16:
                    {
                        fs.Write((byte)5);
                        var src = data.__int16;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.int32:
                    {
                        fs.Write((byte)6);
                        var src = data.__int32;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.int64:
                    {
                        fs.Write((byte)7);
                        var src = data.__int64;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                    case torch.@bool:
                    {
                        fs.Write((byte)8);
                        var src = data.__bool;
                        for(int i = 0; i < src.Length; i++)
                        {
                            fs.Write(src[i]);
                        }
                        break;
                    }
                }
            }

            ///<summary>Saves state dict to a file.</summary>
            ///<param name = "state_dict">A dictionary containing a whole state of the module.</param>
            ///<param name = "fname">Output file name.</param>
            private static unsafe void save(Dictionary<string, Tensor> state_dict, Stream s)
            {
                var fs = new BinaryWriter(s);
                fs.Write("Torch.NET>");
                fs.Write(__current_file_version); // version
                fs.Write((byte)1);
                foreach(var x in state_dict.Keys)
                {
                    fs.Write(x);
                    var data = state_dict[x];
                    fs.Write((int)data.__shape.Length);
                    for(int i = 0; i < data.__shape.Length; i++)
                    {
                        fs.Write(data.__shape[i]);
                    }
                    switch(data.dtype)
                    {
                        case torch.float16:
                        {
                            fs.Write((byte)0);
                            var src = data.__half;
                            for(int i = 0; i < src.Length; i++)
                            {
                                var val = src[i];
                                fs.Write(*(ushort*)(void*)&val);
                            }
                            break;
                        }
                        case torch.float32:
                        {
                            fs.Write((byte)1);
                            var src = data.__float;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.float64:
                        {
                            fs.Write((byte)2);
                            var src = data.__double;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.uint8:
                        {
                            fs.Write((byte)3);
                            var src = data.__uint8;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.int8:
                        {
                            fs.Write((byte)4);
                            var src = data.__int8;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.int16:
                        {
                            fs.Write((byte)5);
                            var src = data.__int16;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.int32:
                        {
                            fs.Write((byte)6);
                            var src = data.__int32;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.int64:
                        {
                            fs.Write((byte)7);
                            var src = data.__int64;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.@bool:
                        {
                            fs.Write((byte)8);
                            var src = data.__bool;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                    }
                }
            }

            ///<summary>Saves state dict to a file.</summary>
            ///<param name = "state_dict">A dictionary containing a whole state of the module.</param>
            ///<param name = "fname">Output file name.</param>
            public static unsafe void save(SerializableObject obj, Stream s)
            {
                if((object)obj.__as_tensor == null)
                {
                    save((Dictionary<string, Tensor>)obj, s);
                }
                else
                {
                    save((Tensor)obj, s);
                }
            }

            ///<summary>Saves state dict to a file.</summary>
            ///<param name = "state_dict">A dictionary containing a whole state of the module.</param>
            ///<param name = "fname">Output file name.</param>
            public static unsafe void save(SerializableObject obj, string fname)
            {
                var fs = File.Create(fname);
                save(obj, fs);
                fs.Close();
            }

            public static unsafe SerializableObject load(Stream s, bool try_decode = false)
            {
                var fs = new BinaryReader(s);
                try
                {
                    var header = fs.ReadString();
                    if(header != "Torch.NET>")
                    {
                        throw new Exception();
                    }
                }
                catch(Exception ex)
                {
                    throw new TorchException("TorchException: not a Torch.NET file.");
                }
                try
                {
                    var version = fs.ReadInt32();
                    if(version < 0)
                    {
                        throw new Exception();
                    }
                    if((version > __current_file_version) && (!try_decode))
                    {
                        throw new TorchException("TorchException: unable to decode the file. Current serializator's version is " + __current_file_version.ToString() + ", but given " + version.ToString() + " version.");
                    }
                    var type = fs.ReadByte();
                    if(type == 0)
                    {
                        var rank = fs.ReadInt32();
                        if((rank > 32) || (rank < 0))
                        {
                            throw new Exception();
                        }
                        var shape = new int[rank];
                        for(int i = 0; i < rank; i++)
                        {
                            shape[i] = fs.ReadInt32();
                            if(shape[i] < 0)
                            {
                                throw new Exception();
                            }
                        }
                        var dtype = (DType)fs.ReadByte();
                        var data = new Tensor(shape, dtype: dtype);
                        switch(dtype)
                        {
                            case torch.float16:
                            {
                                var container = data.__half;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    var val = fs.ReadUInt16();
                                    container[i] = *(Half*)(void*)&val;
                                }
                                break;
                            }
                            case torch.float32:
                            {
                                var container = data.__float;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadSingle();
                                }
                                break;
                            }
                            case torch.float64:
                            {
                                var container = data.__double;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadDouble();
                                }
                                break;
                            }
                            case torch.int8:
                            {
                                var container = data.__int8;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadSByte();
                                }
                                break;
                            }
                            case torch.uint8:
                            {
                                var container = data.__uint8;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadByte();
                                }
                                break;
                            }
                            case torch.int16:
                            {
                                var container = data.__int16;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadInt16();
                                }
                                break;
                            }
                            case torch.int32:
                            {
                                var container = data.__int32;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadInt32();
                                }
                                break;
                            }
                            case torch.int64:
                            {
                                var container = data.__int64;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadInt64();
                                }
                                break;
                            }
                            case torch.@bool:
                            {
                                var container = data.__bool;
                                for(int i = 0; i < container.Length; i++)
                                {
                                    container[i] = fs.ReadBoolean();
                                }
                                break;
                            }
                        }
                        return data;
                    }
                    else
                    {
                        if(type == 1)
                        {
                            var state_dict = new Dictionary<string, Tensor>();
                            while((fs.BaseStream.Position + 1) < fs.BaseStream.Length)
                            {
                                var name = fs.ReadString();
                                var rank = fs.ReadInt32();
                                if((rank < 0) || (rank > 32))
                                {
                                    throw new Exception();
                                }
                                var shape = new int[rank];
                                for(int i = 0; i < rank; i++)
                                {
                                    shape[i] = fs.ReadInt32();
                                    if(shape[i] < 0)
                                    {
                                        throw new Exception();
                                    }
                                }
                                var dtype = (DType)fs.ReadByte();
                                var data = new Tensor(shape, dtype: dtype);
                                switch(dtype)
                                {
                                    case torch.float16:
                                    {
                                        var container = data.__half;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            var val = fs.ReadUInt16();
                                            container[i] = *(Half*)(void*)&val;
                                        }
                                        break;
                                    }
                                    case torch.float32:
                                    {
                                        var container = data.__float;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadSingle();
                                        }
                                        break;
                                    }
                                    case torch.float64:
                                    {
                                        var container = data.__double;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadDouble();
                                        }
                                        break;
                                    }
                                    case torch.int8:
                                    {
                                        var container = data.__int8;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadSByte();
                                        }
                                        break;
                                    }
                                    case torch.uint8:
                                    {
                                        var container = data.__uint8;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadByte();
                                        }
                                        break;
                                    }
                                    case torch.int16:
                                    {
                                        var container = data.__int16;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadInt16();
                                        }
                                        break;
                                    }
                                    case torch.int32:
                                    {
                                        var container = data.__int32;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadInt32();
                                        }
                                        break;
                                    }
                                    case torch.int64:
                                    {
                                        var container = data.__int64;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadInt64();
                                        }
                                        break;
                                    }
                                    case torch.@bool:
                                    {
                                        var container = data.__bool;
                                        for(int i = 0; i < container.Length; i++)
                                        {
                                            container[i] = fs.ReadBoolean();
                                        }
                                        break;
                                    }
                                }
                                state_dict.Add(name, data);
                            }
                            return state_dict;
                        }
                        else
                        {
                            throw new Exception();
                        }
                    }
                }
                catch(Exception ex)
                {
                    if(ex is TorchException)
                    {
                        throw;
                    }
                    throw new TorchException("TorchException: unable to decode the file. File may be corrupted or have unsupported format.");
                }
            }

            public static SerializableObject load(string fname)
            {
                var fs = File.OpenRead(fname);
                var obj = load(fs);
                fs.Close();
                return obj;
            }

            #endregion

        }

    }

}
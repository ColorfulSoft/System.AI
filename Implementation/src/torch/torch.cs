//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 01.01.2020.

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        ///<summary>The main class of Torch.NET. PyTorch Version: 0.4.1</summary>
        public static partial class torch
        {

            ///<summary>Required to protect against parameter changes during calculations. If true, the settings are available for making changes.</summary>
            internal static bool __settings_are_available;

            ///<summary>Information about the current version and build of the library. Read-only.</summary>
            public static string library_info
            {

                get;

                private set;

            }

            ///<summary>Indicates whether the torch warning module is active.</summary>
            public static bool warnings_are_enabled
            {

                get;

                internal set;

            }

            ///<summary>Default data type.</summary>
            public static dtype default_dtype
            {

                get;

                internal set;

            }

            ///<summary>Sets the default library settings.</summary>
            static torch()
            {
                default_dtype = dtype.float32;
                warnings_are_enabled = true;
                library_info = "Torch.NET ver. 0.3 -> build 03.01.2020";
            }

            ///<summary>Specifies the required default data type.</summary>
            public static void set_default_tensor_type(dtype dtype)
            {
                if(default_dtype == dtype)
                {
                    __Warnings.warn("The current default data type is the same as the required one.");
                }
                else
                {
                    default_dtype = dtype;
                }
            }

            ///<summary>Activates the torch warning module.</summary>
            public static void enable_warnings()
            {
                if(warnings_are_enabled)
                {
                    __Warnings.warn("Torch warnings are already enabled.");
                }
                else
                {
                    warnings_are_enabled = true;
                }
            }

            ///<summary>Deactivates the torch warning module.</summary>
            public static void disable_warnings()
            {
                if(!(warnings_are_enabled))
                {
                    __Warnings.warn("TorchWarning: Torch warnings are already disabled.");
                }
                else
                {
                    warnings_are_enabled = false;
                }
            }

            ///<summary>Saves state dict to a file.</summary>
            ///<param name = "state_dict">A dictionary containing a whole state of the module.</param>
            ///<param name = "fname">Output file name.</param>
            public static void save(Dictionary<string, Tensor> state_dict, string fname)
            {
                var fs = new BinaryWriter(File.Create(fname));
                foreach(var x in state_dict.Keys)
                {
                    fs.Write(x);
                    var data = state_dict[x].clone();
                    fs.Write(data.__ndim);
                    fs.Write(data.__batch);
                    fs.Write(data.__time);
                    fs.Write(data.__depth);
                    fs.Write(data.__height);
                    fs.Write(data.__width);
                    switch(data.dtype)
                    {
                        case torch.dtype.float32:
                        {
                            fs.Write((byte)0);
                            var src = data.__data_float32;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.dtype.uint8:
                        {
                            fs.Write((byte)1);
                            var src = data.__data_uint8;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                        case torch.dtype.int64:
                        {
                            fs.Write((byte)2);
                            var src = data.__data_int64;
                            for(int i = 0; i < src.Length; i++)
                            {
                                fs.Write(src[i]);
                            }
                            break;
                        }
                    }
                    data = null;
                }
                fs.Close();
            }

            ///<summary>Loads state dict from file.</summary>
            ///<param name = "fname">Input file name.</param>
            public static Dictionary<string, Tensor> load(string fname)
            {
                var fs = new BinaryReader(File.OpenRead(fname));
                var state_dict = new Dictionary<string, Tensor>();
                while(fs.BaseStream.Position + 1 < fs.BaseStream.Length)
                {
                    var name = fs.ReadString();
                    var ndim = fs.ReadByte();
                    var batch = fs.ReadInt32();
                    var time = fs.ReadInt32();
                    var depth = fs.ReadInt32();
                    var height = fs.ReadInt32();
                    var width = fs.ReadInt32();
                    var dtype = fs.ReadByte();
                    Tensor data = null;
                    switch(dtype)
                    {
                        case 0:
                        {
                            switch(ndim)
                            {
                                case 0:
                                {
                                    data = new Tensor(torch.dtype.float32);
                                    break;
                                }
                                case 1:
                                {
                                    data = new Tensor(width, dtype: torch.dtype.float32);
                                    break;
                                }
                                case 2:
                                {
                                    data = new Tensor(height, width, dtype: torch.dtype.float32);
                                    break;
                                }
                                case 3:
                                {
                                    data = new Tensor(depth, height, width, dtype: torch.dtype.float32);
                                    break;
                                }
                                case 4:
                                {
                                    data = new Tensor(time, depth, height, width, dtype: torch.dtype.float32);
                                    break;
                                }
                                case 5:
                                {
                                    data = new Tensor(batch, time, depth, height, width, dtype: torch.dtype.float32);
                                    break;
                                }
                            }
                            var src = data.__data_float32;
                            for(int i = 0; i < src.Length; i++)
                            {
                                src[i] = fs.ReadSingle();
                            }
                            break;
                        }
                        case 1:
                        {
                            switch(ndim)
                            {
                                case 0:
                                {
                                    data = new Tensor(torch.dtype.uint8);
                                    break;
                                }
                                case 1:
                                {
                                    data = new Tensor(width, dtype: torch.dtype.uint8);
                                    break;
                                }
                                case 2:
                                {
                                    data = new Tensor(height, width, dtype: torch.dtype.uint8);
                                    break;
                                }
                                case 3:
                                {
                                    data = new Tensor(depth, height, width, dtype: torch.dtype.uint8);
                                    break;
                                }
                                case 4:
                                {
                                    data = new Tensor(time, depth, height, width, dtype: torch.dtype.uint8);
                                    break;
                                }
                                case 5:
                                {
                                    data = new Tensor(batch, time, depth, height, width, dtype: torch.dtype.uint8);
                                    break;
                                }
                            }
                            var src = data.__data_uint8;
                            for(int i = 0; i < src.Length; i++)
                            {
                                src[i] = fs.ReadByte();
                            }
                            break;
                        }
                        case 2:
                        {
                            switch(ndim)
                            {
                                case 0:
                                {
                                    data = new Tensor(torch.dtype.int64);
                                    break;
                                }
                                case 1:
                                {
                                    data = new Tensor(width, dtype: torch.dtype.int64);
                                    break;
                                }
                                case 2:
                                {
                                    data = new Tensor(height, width, dtype: torch.dtype.int64);
                                    break;
                                }
                                case 3:
                                {
                                    data = new Tensor(depth, height, width, dtype: torch.dtype.int64);
                                    break;
                                }
                                case 4:
                                {
                                    data = new Tensor(time, depth, height, width, dtype: torch.dtype.int64);
                                    break;
                                }
                                case 5:
                                {
                                    data = new Tensor(batch, time, depth, height, width, dtype: torch.dtype.int64);
                                    break;
                                }
                            }
                            var src = data.__data_int64;
                            for(int i = 0; i < src.Length; i++)
                            {
                                src[i] = fs.ReadInt64();
                            }
                            break;
                        }
                    }
                    state_dict.Add(name, data);
                }
                return state_dict;
            }

        }

    }

}
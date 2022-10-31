//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System.Runtime.InteropServices;

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// Data storage for tensors.
        /// </summary>
        public class Storage : IDisposable
        {

            /// <summary>
            /// Data type.
            /// </summary>
            public DType dtype
            {

                get;

                internal set;

            }

            /// <summary>
            /// Size.
            /// </summary>
            public int size
            {

                get;

                internal set;

            }

            /// <summary>
            /// Pointer to the first element in unmanaged data array.
            /// </summary>
            public void* data_ptr
            {

                get;

                internal set;

            }

            /// <summary>
            /// Initializes the storage of the specified data type and size.
            /// </summary>
            /// <param name="size">Size.</param>
            /// <param name="dtype">Data type.</param>
            public Storage(int size, DType dtype = DType.@default)
            {
                if(size <= 0)
                {
                    throw new ArgumentException("The buffer size must be greater than 0.");
                }
                this.size = size;
                this.dtype = (dtype == DType.@default) ? torch.default_dtype : dtype;
                this.data_ptr = Marshal.AllocCoTaskMem(this.size * this.dtype.size()).ToPointer();
            }

            /// <summary>
            /// Converts the current storage object to a string representation.
            /// </summary>
            /// <returns>String representation of the current storage instance.</returns>
            public override string ToString()
            {
                var str = "";
                var n = this.size;
                switch(this.dtype)
                {
                    case torch.float8:
                    {
                        var ptr = (Quarter*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.QuarterStorage of size {0}]", n);
                        break;
                    }
                    case torch.float16:
                    {
                        var ptr = (Half*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.HalfStorage of size {0}]", n);
                        break;
                    }
                    case torch.bfloat16:
                    {
                        var ptr = (BFloat16*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.BFloat16Storage of size {0}]", n);
                        break;
                    }
                    case torch.float32:
                    {
                        var ptr = (float*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.FloatStorage of size {0}]", n);
                        break;
                    }
                    case torch.float64:
                    {
                        var ptr = (double*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.DoubleStorage of size {0}]", n);
                        break;
                    }
                    case torch.complex16:
                    {
                        var ptr = (CQuarter*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.CQuarterStorage of size {0}]", n);
                        break;
                    }
                    case torch.complex32:
                    {
                        var ptr = (CHalf*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.CHalfStorage of size {0}]", n);
                        break;
                    }
                    case torch.complex64:
                    {
                        var ptr = (CFloat*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.CFloatStorage of size {0}]", n);
                        break;
                    }
                    case torch.complex128:
                    {
                        var ptr = (CDouble*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.CDoubleStorage of size {0}]", n);
                        break;
                    }
                    case torch.int8:
                    {
                        var ptr = (sbyte*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.CharStorage of size {0}]", n);
                        break;
                    }
                    case torch.uint8:
                    {
                        var ptr = (byte*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.ByteStorage of size {0}]", n);
                        break;
                    }
                    case torch.int16:
                    {
                        var ptr = (short*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.ShortStorage of size {0}]", n);
                        break;
                    }
                    case torch.uint16:
                    {
                        var ptr = (ushort*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.UShortStorage of size {0}]", n);
                        break;
                    }
                    case torch.int32:
                    {
                        var ptr = (int*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.IntStorage of size {0}]", n);
                        break;
                    }
                    case torch.uint32:
                    {
                        var ptr = (uint*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.UIntStorage of size {0}]", n);
                        break;
                    }
                    case torch.int64:
                    {
                        var ptr = (long*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.LongStorage of size {0}]", n);
                        break;
                    }
                    case torch.uint64:
                    {
                        var ptr = (ulong*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.ULongStorage of size {0}]", n);
                        break;
                    }
                    case torch.@bool:
                    {
                        var ptr = (bool*)this.data_ptr;
                        for(int i = 0; i < n; ++i)
                        {
                            str += ptr[i].ToString() + '\n';
                        }
                        str += string.Format("[torch.BoolStorage of size {0}]", n);
                        break;
                    }
                }
                return str;
            }

            /// <summary>
            /// Releases unmanaged resources occupied by the current storage instance.
            /// </summary>
            void IDisposable.Dispose()
            {
                if(this.data_ptr != null)
                {
                    Marshal.FreeCoTaskMem((IntPtr)this.data_ptr);
                    this.data_ptr = null;
                }
            }

            /// <summary>
            /// Releases unmanaged resources occupied by the current storage instance.
            /// </summary>
            ~Storage()
            {
                if(this.data_ptr != null)
                {
                    Marshal.FreeCoTaskMem((IntPtr)this.data_ptr);
                    this.data_ptr = null;
                }
            }

        }

    }

}
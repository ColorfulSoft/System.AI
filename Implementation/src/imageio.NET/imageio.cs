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

        public static unsafe partial class imageio
        {

            public static bool warnings_are_enabled
            {
                get;
                set;
            }

            static imageio()
            {
                warnings_are_enabled = true;
            }

            public static string __version__
            {

                get
                {
                    return "1.1";
                }

            }

            public static void imwrite(Stream s, Array im, string format = "jpg", params object[] kwargs)
            {
                if(s == null)
                {
                    throw new ArgumentException("Null value is not valid for output stream s.");
                }
                if(!s.CanWrite)
                {
                    throw new ArgumentException("Stream s is not writable");
                }
                if(im == null)
                {
                    throw new ArgumentException("Null value is not valid for pixel array im.");
                }
                if(im.Rank != 3)
                {
                    throw new ImageIOException("The pixel array im is not three-dimensional.");
                }
                if(im.GetLength(2) != 3)
                {
                    throw new ImageIOException("Image should have 3 channels. Pixel array im have " + im.GetLength(2).ToString() + " channels (WHC data format).");
                }
                int quality = 80;
                bool quality_trigger = false;
                if(kwargs.Length == 1)
                {
                    if(kwargs[0] is byte)
                    {
                        quality = (byte)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is sbyte)
                    {
                        quality = (sbyte)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is short)
                    {
                        quality = (short)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is ushort)
                    {
                        quality = (ushort)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is int)
                    {
                        quality = (int)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is uint)
                    {
                        quality = (int)(uint)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is long)
                    {
                        quality = (int)(long)kwargs[0];
                        quality_trigger = true;
                    }
                    if(kwargs[0] is ulong)
                    {
                        quality = (int)(ulong)kwargs[0];
                        quality_trigger = true;
                    }
                    if(!quality_trigger)
                    {
                        throw new ImageIOException("The first optional argument is quality and it should be integer value.");
                    }
                }
                if((quality > 100) || (quality < 0))
                {
                    throw new ArgumentException("The first optional argument is quality and it should be in [0..100] range.");
                }
                var data = new byte[im.Length];
                var width = im.GetLength(1);
                var height = im.GetLength(0);
                if(im.GetType() == typeof(byte[,,]))
                {
                    var im_ = im as byte[,,];
                    fixed(byte* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                data[i] = pdata[i];
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(sbyte[,,]))
                {
                    float max = sbyte.MinValue;
                    float min = sbyte.MaxValue;
                    var im_ = im as sbyte[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from int8 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(sbyte* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(short[,,]))
                {
                    float max = short.MinValue;
                    float min = short.MaxValue;
                    var im_ = im as short[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from int16 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(short* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(ushort[,,]))
                {
                    float max = ushort.MinValue;
                    float min = ushort.MaxValue;
                    var im_ = im as ushort[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from uint16 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(ushort* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(int[,,]))
                {
                    double max = int.MinValue;
                    double min = int.MaxValue;
                    var im_ = im as int[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from int32 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(int* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(uint[,,]))
                {
                    double max = uint.MinValue;
                    double min = uint.MaxValue;
                    var im_ = im as uint[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from uint32 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(uint* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(long[,,]))
                {
                    double max = long.MinValue;
                    double min = long.MaxValue;
                    var im_ = im as long[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from int64 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(long* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(ulong[,,]))
                {
                    double max = ulong.MinValue;
                    double min = ulong.MaxValue;
                    var im_ = im as ulong[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from uint64 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(ulong* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(Half[,,]))
                {
                    float max = Half.MinValue;
                    float min = Half.MaxValue;
                    var im_ = im as Half[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from float16 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(Half* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(float[,,]))
                {
                    float max = float.MinValue;
                    float min = float.MaxValue;
                    var im_ = im as float[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from float32 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(float* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                if(im.GetType() == typeof(double[,,]))
                {
                    double max = double.MinValue;
                    double min = double.MaxValue;
                    var im_ = im as double[,,];
                    foreach(var v in im_)
                    {
                        if(max < v)
                        {
                            max = v;
                        }
                        if(min > v)
                        {
                            min = v;
                        }
                    }
                    __Warnings.warn("Lossy conversion from float64 to uint8. Range [" + min.ToString() + ", " + max.ToString() + "]. Convert image to uint8 prior to saving to suppress this warning.", true);
                    fixed(double* pdata = im_)
                    {
                        for(int i = 0; i < data.Length; i++)
                        {
                            unchecked
                            {
                                var p = (pdata[i] - min) / (max - min) * 255;
                                p = (p < 0) ? 0 : p;
                                p = (p > 255) ? 255 : p;
                                data[i] = (byte)p;
                            }
                        }
                    }
                }
                switch(format.ToLower())
                {
                    case "jpg":
                    case "jpe":
                    case "jpeg":
                    case "jfif":
                    {
                        new StbImageWriteSharp.ImageWriter().WriteJpg(data, width, height, ColorComponents.RedGreenBlue, s, quality);
                        return;
                    }
                    case "png":
                    {
                        new StbImageWriteSharp.ImageWriter().WritePng(data, width, height, ColorComponents.RedGreenBlue, s);
                        return;
                    }
                    case "hdr":
                    {
                        new StbImageWriteSharp.ImageWriter().WriteHdr(data, width, height, ColorComponents.RedGreenBlue, s);
                        return;
                    }
                    case "tga":
                    {
                        new StbImageWriteSharp.ImageWriter().WriteTga(data, width, height, ColorComponents.RedGreenBlue, s);
                        return;
                    }
                    case "bmp":
                    {
                        new StbImageWriteSharp.ImageWriter().WriteBmp(data, width, height, ColorComponents.RedGreenBlue, s);
                        return;
                    }
                    default:
                    {
                        throw new ImageIOException("Invalid image format.");
                    }
                }
            }

            public static void imwrite(string uri, Array im, string format = null, params object[] kwargs)
            {
                if(format == null)
                {
                    var probe = uri.ToLower();
                    if(uri.EndsWith(".jpg") || uri.EndsWith(".jpeg"))
                    {
                        format = "jpg";
                    }
                    if(uri.EndsWith(".png"))
                    {
                        format = "png";
                    }
                    if(uri.EndsWith(".bmp"))
                    {
                        format = "bmp";
                    }
                    if(uri.EndsWith(".hdr"))
                    {
                        format = "hdr";
                    }
                    if(uri.EndsWith(".tga"))
                    {
                        format = "tga";
                    }
                }
                if(format == null)
                {
                    throw new ImageIOException("Couldn't determine the image format to save. Specify the required format explicitly using the format parameter.");
                }
                var img = File.Create(uri);
                imwrite(img, im, format, kwargs);
                img.Close();
            }

            public static byte[,,] imread(Stream s)
            {
                if(s == null)
                {
                    throw new ArgumentException("The null value is invalid for the s parameter.");
                }
                var inf = StbImageSharp.ImageResult.FromStream(s, ColorComponents.RedGreenBlue);
                var data = new byte[inf.Height, inf.Width, 3];
                var idata = inf.Data;
                fixed(byte* pdata = data)
                {
                    for(int i = 0; i < idata.Length; i++)
                    {
                        pdata[i] = idata[i];
                    }
                }
                return data;
            }

            public static byte[,,] imread(string uri)
            {
                var fs = File.OpenRead(uri);
                var img = imread(fs);
                fs.Close();
                return img;
            }

            public static void show_formats()
            {
                Console.WriteLine("Reading:");
                Console.WriteLine("BMP-STB - Windows Bitmap [.bmp]");
                Console.WriteLine("GIF-STB - Static and animated gif [.gif]");
                Console.WriteLine("JPG-STB - JPEG (ISO 10918) [.jfif, .jpe, .jpg, .jpeg]");
                Console.WriteLine("PNG-STB - Portable network graphics [.png]");
                Console.WriteLine("PSD-STB - Adobe Photoshop [.psd]");
                Console.WriteLine("TGA-STB - Targa [.tga]");
                Console.WriteLine("Writing:");
                Console.WriteLine("BMP-STB - Windows Bitmap [.bmp]");
                Console.WriteLine("JPG-STB - JPEG (ISO 10918) [.jfif, .jpe, .jpg, .jpeg]");
                Console.WriteLine("PNG-STB - Portable network graphics [.png]");
                Console.WriteLine("HDR-STB - High Dynamic Range Image [.hdr]");
                Console.WriteLine("TGA-STB - Targa [.tga]");
            }

        }

    }

}
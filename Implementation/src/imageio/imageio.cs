//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;

namespace System
{

    namespace AI
    {

        public static partial class imageio
        {

            public static string __version__
            {

                get
                {
                    return "0.1";
                }

            }

            public static void imwrite(string uri, byte[,,] im, string format = null, params object[] kwargs)
            {
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
                        throw new Exception("The first optional argument is quality and it should be integer value.");
                    }
                }
                if((quality > 100) || (quality < 0))
                {
                    throw new ArgumentException("The first optional argument is quality and it should be in [0..100] range.");
                }
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
                var data = new byte[im.Length];
                var n = 0;
                var width = im.GetLength(0);
                var height = im.GetLength(1);
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                         data[n * 3] = im[j, i, 0];
                         data[n * 3 + 1] = im[j, i, 1];
                         data[n * 3 + 2] = im[j, i, 2];
                         n += 1;
                    }
                }
                switch(format.ToLower())
                {
                    case "jpg":
                    case "jpe":
                    case "jpeg":
                    case "jfif":
                    {
                        var img = File.Create(uri);
                        new StbImageWriteSharp.ImageWriter().WriteJpg(data, width, height, StbImageWriteSharp.ColorComponents.RedGreenBlue, img, quality);
                        img.Close();
                        return;
                    }
                    case "png":
                    {
                        var img = File.Create(uri);
                        new StbImageWriteSharp.ImageWriter().WritePng(data, width, height, StbImageWriteSharp.ColorComponents.RedGreenBlue, img);
                        img.Close();
                        return;
                    }
                    case "hdr":
                    {
                        var img = File.Create(uri);
                        new StbImageWriteSharp.ImageWriter().WriteHdr(data, width, height, StbImageWriteSharp.ColorComponents.RedGreenBlue, img);
                        img.Close();
                        return;
                    }
                    case "tga":
                    {
                        var img = File.Create(uri);
                        new StbImageWriteSharp.ImageWriter().WriteTga(data, width, height, StbImageWriteSharp.ColorComponents.RedGreenBlue, img);
                        img.Close();
                        return;
                    }
                    case "bmp":
                    {
                        var img = File.Create(uri);
                        new StbImageWriteSharp.ImageWriter().WriteBmp(data, width, height, StbImageWriteSharp.ColorComponents.RedGreenBlue, img);
                        img.Close();
                        return;
                    }
                }
            }

            public static byte[,,] imread(string uri)
            {
                var fs = File.OpenRead(uri);
                var inf = StbImageSharp.ImageResult.FromStream(fs, StbImageSharp.ColorComponents.RedGreenBlue);
                fs.Close();
                var data = new byte[inf.Width, inf.Height, 3];
                var n = 0;
                for(int i = 0; i < inf.Height; i++)
                {
                    for(int j = 0; j < inf.Width; j++)
                    {
                         data[j, i, 0] = inf.Data[n * 3];
                         data[j, i, 1] = inf.Data[n * 3 + 1];
                         data[j, i, 2] = inf.Data[n * 3 + 2];
                         n += 1;
                    }
                }
                return data;
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
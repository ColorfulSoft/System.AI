# API reference

* **imageio.imread(string uri) -> byte[,,]** - Reads an image from a file at the specified path uri. *Returns:* 3-d standard byte array with pixels in WHC RGB format.
* **imageio.imwrite(string uri, byte[,,] im, string format = null, params object[] kwargs) -> void** - Writes an image to a file at the specified path in the specified format.
* **imageio.__version__ -> string** - *Returns:* current imageio version as string.
* **imageio.show_formats() -> void** - Outputs supported image formats to the console.


# Sample programs

*Note: Android users need to specify full file paths. The full path usually starts with "/storage/emulated/0/". Only short file names are specified in the examples.*

Generate random noise and save it in png and jpeg with 75 quality.

```C#
using System;
using System.AI;

namespace imageio1
{
    class Program
    {
        public static void Main(string[] args)
        {
            var img = new byte[512, 512, 3];
            var rand = new Random();
            for(int y = 0; y < 512; y++)
            {
                for(int x = 0; x < 512; x++)
                {
                    img[x, y, 0] = (byte)rand.Next(0, 255);
                    img[x, y, 1] = (byte)rand.Next(0, 255);
                    img[x, y, 2] = (byte)rand.Next(0, 255);
                }
            }
            imageio.imwrite("Noise.png", img);
            imageio.imwrite("Noise.jpg", img, kwargs: 75);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
```

Generate mosaic and save to bmp.

```C#
using System;
using System.AI;

namespace imageio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var img = new byte[512, 512, 3];
            var rand = new Random();
            for(int y = 0; y < 512; y++)
            {
                for(int x = 0; x < 512; x++)
                {
                    unchecked
                    {
                        img[x, y, 0] = (byte)((2 * x - y) % 255);
                        img[x, y, 1] = (byte)((x - 3 * y) % 255);
                        img[x, y, 2] = (byte)((x + y) % 255);
                    }
                }
            }
            imageio.imwrite("Mosaic.bmp", img);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
```

Open a color image 1.jpg, convert to black and white and save as 2.png.

```C#
using System;
using System.AI;

namespace imageio3
{
    class Program
    {
        public static void Main(string[] args)
        {
            var img = imageio.imread("1.jpg");
            for(int y = 0; y < 512; y++)
            {
                for(int x = 0; x < 512; x++)
                {
                    var grayscale = (byte)((img[x, y, 0] + img[x, y, 1] + img[x, y, 2]) / 3);
                    img[x, y, 0] = grayscale;
                    img[x, y, 1] = grayscale;
                    img[x, y, 2] = grayscale;
                }
            }
            imageio.imwrite("2.png", img);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
```


# Third-party codes as part of imageio.NET

As a backend, imageio.NET uses a pure reimplementation of the STB(C language) library for C#. In accordance with the license of the original STB library, as well as those used in imageio.NET StbImageSharp and StbImageWriteSharp codes, the source codes were refactored and included in the library imageio.NET which is an integral part of the System.AI package.

* **StbImageWriteSharp original sources:** https://github.com/StbSharp/StbImageWriteSharp
* **StbImageSharp original sources:** https://github.com/StbSharp/StbImageSharp

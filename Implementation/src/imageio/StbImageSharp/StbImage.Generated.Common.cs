﻿using System.Runtime.InteropServices;

namespace System
{

    namespace AI
    {

        public static partial class imageio
        {

            internal static partial class StbImageSharp
            {

                public unsafe partial class StbImage
                {

                    public const int STBI_default = 0;
 
                    public const int STBI_grey = 1;

                    public const int STBI_grey_alpha = 2;

                    public const int STBI_rgb = 3;

                    public const int STBI_rgb_alpha = 4;

                    public const int STBI_ORDER_RGB = 0;

                    public const int STBI_ORDER_BGR = 1;

                    public const int STBI__SCAN_load = 0;

                    public const int STBI__SCAN_type = 1;

                    public const int STBI__SCAN_header = 2;

                    public static float stbi__h2l_gamma_i = 1.0f / 2.2f;

                    public static float stbi__h2l_scale_i = 1.0f;

                    public static int stbi__unpremultiply_on_load;

                    public static int stbi__de_iphone_flag;

                    public static uint[] mul_table = { 0, 0xff, 0x55, 0x49, 0x11, 0x21, 0x41, 0x81, 0x01 };

                    public static uint[] shift_table = { 0, 0, 0, 1, 0, 2, 4, 6, 0 };

                    public static int stbi__addsizes_valid(int a, int b)
                    {
                        if(b < 0)
                        {
                            return 0;
                        }
                        return (a <= (2147483647 - b)) ? 1 : 0;
                    }

                    public static int stbi__mul2sizes_valid(int a, int b)
                    {
                        if((a < 0) || (b < 0))
                        {
                            return 0;
                        }
                        if(b == 0)
                        {
                            return 1;
                        }
                        return (a <= (2147483647 / b)) ? 1 : 0;
                    }

                    public static int stbi__mad2sizes_valid(int a, int b, int add)
                    {
                        return ((stbi__mul2sizes_valid(a, b) != 0) && (stbi__addsizes_valid(a * b, add) != 0)) ? 1 : 0;
                    }

                    public static int stbi__mad3sizes_valid(int a, int b, int c, int add)
                    {
                        return ((stbi__mul2sizes_valid(a, b) != 0) && (stbi__mul2sizes_valid(a * b, c) != 0) && (stbi__addsizes_valid(a * b * c, add) != 0)) ? 1 : 0;
                    }

                    public static void* stbi__malloc_mad2(int a, int b, int add)
                    {
                        if(stbi__mad2sizes_valid(a, b, add) == 0)
                        {
                            return null;
                        }
                        return stbi__malloc((ulong)(a * b + add));
                    }

                    public static void* stbi__malloc_mad3(int a, int b, int c, int add)
                    {
                        if(stbi__mad3sizes_valid(a, b, c, add) == 0)
                        {
                            return null;
                        }
                        return stbi__malloc((ulong)(a * b * c + add));
                    }

                    public static void stbi_set_flip_vertically_on_load(int flag_true_if_should_flip)
                    {
                        stbi__vertically_flip_on_load = flag_true_if_should_flip;
                    }

                    public static void* stbi__load_main(stbi__context s, int* x, int* y, int* comp, int req_comp, stbi__result_info* ri, int bpc)
                    {
                      ri -> bits_per_channel = 8;
                      ri -> channel_order = STBI_ORDER_RGB;
                      ri -> num_channels = 0;
                      if(stbi__jpeg_test(s) != 0)
                      {
                          return stbi__jpeg_load(s, x, y, comp, req_comp, ri);
                      }
                      if(stbi__png_test(s) != 0)
                      {
                          return stbi__png_load(s, x, y, comp, req_comp, ri);
                      }
                      if(stbi__bmp_test(s) != 0)
                      {
                          return stbi__bmp_load(s, x, y, comp, req_comp, ri);
                      }
                      if(stbi__gif_test(s) != 0)
                      {
                          return stbi__gif_load(s, x, y, comp, req_comp, ri);
                      }
                      if(stbi__psd_test(s) != 0)
                      {
                          return stbi__psd_load(s, x, y, comp, req_comp, ri, bpc);
                      }
                      if(stbi__tga_test(s) != 0)
                      {
                          return stbi__tga_load(s, x, y, comp, req_comp, ri);
                      }
                      return (byte*)(ulong)((stbi__err("unknown image type") != 0) ? (byte*)null : null);
                    }

                    public static byte* stbi__convert_16_to_8(ushort* orig, int w, int h, int channels)
                    {
                        var i = 0;
                        var img_len = w * h * channels;
                        byte* reduced;
                        reduced = (byte*)stbi__malloc((ulong)img_len);
                        if(reduced == null)
                        {
                            return (byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                        }
                        for(i = 0; i < img_len; ++i)
                        {
                            reduced[i] = (byte)((orig[i] >> 8) & 0xFF);
                        }
                        CRuntime.free(orig);
                        return reduced;
                    }

                    public static ushort* stbi__convert_8_to_16(byte* orig, int w, int h, int channels)
                    {
                        var i = 0;
                        var img_len = w * h * channels;
                        ushort* enlarged;
                        enlarged = (ushort*)stbi__malloc((ulong)(img_len * 2));
                        if(enlarged == null)
                        {
                            return (ushort*)(byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                        }
                        for(i = 0; i < img_len; ++i)
                        {
                            enlarged[i] = (ushort)((orig[i] << 8) + orig[i]);
                        }
                        CRuntime.free(orig);
                        return enlarged;
                    }

                    public static void stbi__vertical_flip(void* image, int w, int h, int bytes_per_pixel)
                    {
                        var row = 0;
                        var bytes_per_row = (ulong)(w * bytes_per_pixel);
                        var temp = stackalloc byte[2048];
                        var bytes = (byte*)image;
                        for (row = 0; row < h >> 1; row++)
                        {
                            var row0 = bytes + (ulong)row * bytes_per_row;
                            var row1 = bytes + (ulong)(h - row - 1) * bytes_per_row;
                            var bytes_left = bytes_per_row;
                            while(bytes_left != 0)
                            {
                                var bytes_copy = (bytes_left < 2048) ? bytes_left : 2048;
                                CRuntime.memcpy(temp, row0, bytes_copy);
                                CRuntime.memcpy(row0, row1, bytes_copy);
                                CRuntime.memcpy(row1, temp, bytes_copy);
                                row0 += bytes_copy;
                                row1 += bytes_copy;
                                bytes_left -= bytes_copy;
                            }
                        }
                    }

                    public static void stbi__vertical_flip_slices(void* image, int w, int h, int z, int bytes_per_pixel)
                    {
                        var slice = 0;
                        var slice_size = w * h * bytes_per_pixel;
                        var bytes = (byte*)image;
                        for(slice = 0; slice < z; ++slice)
                        {
                            stbi__vertical_flip(bytes, w, h, bytes_per_pixel);
                            bytes += slice_size;
                        }
                    }

                    public static byte* stbi__load_and_postprocess_8bit(stbi__context s, int* x, int* y, int* comp, int req_comp)
                    {
                      var ri = new stbi__result_info();
                      var result = stbi__load_main(s, x, y, comp, req_comp, &ri, 8);
                      if(result == null)
                      {
                          return null;
                      }
                      if(ri.bits_per_channel != 8)
                      {
                          result = stbi__convert_16_to_8((ushort*)result, *x, *y, (req_comp == 0) ? *comp : req_comp);
                          ri.bits_per_channel = 8;
                      }
                      if(stbi__vertically_flip_on_load != 0)
                      {
                          var channels = (req_comp != 0) ? req_comp : *comp;
                          stbi__vertical_flip(result, *x, *y, channels * sizeof(byte));
                      }
                      return (byte*)result;
                    }

                    public static ushort* stbi__load_and_postprocess_16bit(stbi__context s, int* x, int* y, int* comp, int req_comp)
                    {
                        var ri = new stbi__result_info();
                        var result = stbi__load_main(s, x, y, comp, req_comp, &ri, 16);
                        if(result == null)
                        {
                            return null;
                        }
                        if(ri.bits_per_channel != 16)
                        {
                            result = stbi__convert_8_to_16((byte*)result, *x, *y, (req_comp == 0) ? *comp : req_comp);
                            ri.bits_per_channel = 16;
                        }
                        if(stbi__vertically_flip_on_load != 0)
                        {
                            var channels = (req_comp != 0) ? req_comp : *comp;
                            stbi__vertical_flip(result, *x, *y, channels * sizeof(ushort));
                        }
                        return (ushort*)result;
                    }

                    public static void stbi_hdr_to_ldr_gamma(float gamma)
                    {
                        stbi__h2l_gamma_i = 1 / gamma;
                    }

                    public static void stbi_hdr_to_ldr_scale(float scale)
                    {
                        stbi__h2l_scale_i = 1 / scale;
                    }

                    public static int stbi__get16be(stbi__context s)
                    {
                        var z = (int)stbi__get8(s);
                        return (z << 8) + stbi__get8(s);
                    }

                    public static uint stbi__get32be(stbi__context s)
                    {
                        var z = (uint)stbi__get16be(s);
                        return (uint)((z << 16) + stbi__get16be(s));
                    }

                    public static int stbi__get16le(stbi__context s)
                    {
                        var z = (int)stbi__get8(s);
                        return z + (stbi__get8(s) << 8);
                    }

                    public static uint stbi__get32le(stbi__context s)
                    {
                        var z = (uint)stbi__get16le(s);
                        return (uint)(z + (stbi__get16le(s) << 16));
                    }

                    public static byte stbi__compute_y(int r, int g, int b)
                    {
                        return (byte)((r * 77 + g * 150 + 29 * b) >> 8);
                    }

                    public static byte* stbi__convert_format(byte* data, int img_n, int req_comp, uint x, uint y)
                    {
                        var i = 0;
                        var j = 0;
                        byte* good;
                        if(req_comp == img_n)
                        {
                            return data;
                        }
                        good = (byte*)stbi__malloc_mad3(req_comp, (int)x, (int)y, 0);
                        if(good == null)
                        {
                            CRuntime.free(data);
                            return (byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                        }
                        for(j = 0; j < (int)y; ++j)
                        {
                            var src = data + j * x * img_n;
                            var dest = good + j * x * req_comp;
                            switch(img_n * 8 + req_comp)
                            {
                                case(1 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 2)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = 255;
                                    }
                                    break;
                                }
                                case(1 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 3)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                    }
                                    break;
                                }
                                case(1 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 4)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                        dest[3] = 255;
                                    }
                                    break;
                                }
                                case(2 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 1)
                                    {
                                        dest[0] = src[0];
                                    }
                                    break;
                                }
                                case(2 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 3)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                    }
                                    break;
                                }
                                case(2 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 4)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                        dest[3] = src[1];
                                    }
                                    break;
                                }
                                case(3 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 4)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = src[1];
                                        dest[2] = src[2];
                                        dest[3] = 255;
                                    }
                                    break;
                                }
                                case(3 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 1)
                                    {
                                        dest[0] = stbi__compute_y(src[0], src[1], src[2]);
                                    }
                                    break;
                                }
                                case(3 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 2)
                                    {
                                        dest[0] = stbi__compute_y(src[0], src[1], src[2]);
                                        dest[1] = 255;
                                    }
                                    break;
                                }
                                case(4 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 1)
                                    {
                                        dest[0] = stbi__compute_y(src[0], src[1], src[2]);
                                    }
                                    break;
                                }
                                case(4 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 2)
                                    {
                                        dest[0] = stbi__compute_y(src[0], src[1], src[2]);
                                        dest[1] = src[3];
                                    }
                                    break;
                                }
                                case(4 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 3)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = src[1];
                                        dest[2] = src[2];
                                    }
                                    break;
                                }
                                default:
                                {
                                    return (byte*)(ulong)((stbi__err("0") != 0) ? (byte*)null : null);
                                }
                            }
                        }
                        CRuntime.free(data);
                        return good;
                    }

                    public static ushort stbi__compute_y_16(int r, int g, int b)
                    {
                        return (ushort)((r * 77 + g * 150 + 29 * b) >> 8);
                    }

                    public static ushort* stbi__convert_format16(ushort* data, int img_n, int req_comp, uint x, uint y)
                    {
                        var i = 0;
                        var j = 0;
                        ushort* good;
                        if(req_comp == img_n)
                        {
                            return data;
                        }
                        good = (ushort*)stbi__malloc((ulong)(req_comp * x * y * 2));
                        if(good == null)
                        {
                            CRuntime.free(data);
                            return (ushort*)(byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                        }
                        for(j = 0; j < (int)y; ++j)
                        {
                            var src = data + j * x * img_n;
                            var dest = good + j * x * req_comp;
                            switch(img_n * 8 + req_comp)
                            {
                                case(1 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 2)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = 0xffff;
                                    }
                                    break;
                                }
                                case(1 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 3)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                    }
                                    break;
                                }
                                case(1 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 1, dest += 4)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                        dest[3] = 0xffff;
                                    }
                                    break;
                                }
                                case(2 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 1)
                                    {
                                        dest[0] = src[0];
                                    }
                                    break;
                                }
                                case(2 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 3)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                    }
                                    break;
                                }
                                case(2 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 2, dest += 4)
                                    {
                                        dest[0] = dest[1] = dest[2] = src[0];
                                        dest[3] = src[1];
                                    }
                                    break;
                                }
                                case(3 * 8 + 4):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 4)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = src[1];
                                        dest[2] = src[2];
                                        dest[3] = 0xffff;
                                    }
                                    break;
                                }
                                case(3 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 1)
                                    {
                                        dest[0] = stbi__compute_y_16(src[0], src[1], src[2]);
                                    }
                                    break;
                                }
                                case(3 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 3, dest += 2)
                                    {
                                        dest[0] = stbi__compute_y_16(src[0], src[1], src[2]);
                                        dest[1] = 0xffff;
                                    }
                                    break;
                                }
                                case(4 * 8 + 1):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 1)
                                    {
                                        dest[0] = stbi__compute_y_16(src[0], src[1], src[2]);
                                    }
                                    break;
                                }
                                case(4 * 8 + 2):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 2)
                                    {
                                        dest[0] = stbi__compute_y_16(src[0], src[1], src[2]);
                                        dest[1] = src[3];
                                    }
                                    break;
                                }
                                case(4 * 8 + 3):
                                {
                                    for(i = (int)(x - 1); i >= 0; --i, src += 4, dest += 3)
                                    {
                                        dest[0] = src[0];
                                        dest[1] = src[1];
                                        dest[2] = src[2];
                                    }
                                    break;
                                }
                                default:
                                {
                                    return (ushort*)(byte*)(ulong)((stbi__err("0") != 0) ? (byte*)null : null);
                                }
                            }
                        }
                        CRuntime.free(data);
                        return good;
                    }

                    public static byte stbi__clamp(int x)
                    {
                        if((uint)x > 255)
                        {
                            if(x < 0)
                            {
                                return 0;
                            }
                            if(x > 255)
                            {
                                return 255;
                            }
                        }
                        return (byte)x;
                    }

                    public static byte stbi__blinn_8x8(byte x, byte y)
                    {
                        var t = (uint)(x * y + 128);
                        return (byte)((t + (t >> 8)) >> 8);
                    }

                    public static int stbi__bitreverse16(int n)
                    {
                        n = ((n & 0xAAAA) >> 1) | ((n & 0x5555) << 1);
                        n = ((n & 0xCCCC) >> 2) | ((n & 0x3333) << 2);
                        n = ((n & 0xF0F0) >> 4) | ((n & 0x0F0F) << 4);
                        n = ((n & 0xFF00) >> 8) | ((n & 0x00FF) << 8);
                        return n;
                    }

                    public static int stbi__bit_reverse(int v, int bits)
                    {
                        return stbi__bitreverse16(v) >> (16 - bits);
                    }

                    public static int stbi__paeth(int a, int b, int c)
                    {
                        var p = a + b - c;
                        var pa = CRuntime.abs(p - a);
                        var pb = CRuntime.abs(p - b);
                        var pc = CRuntime.abs(p - c);
                        if((pa <= pb) && (pa <= pc))
                        {
                            return a;
                        }
                        if(pb <= pc)
                        {
                            return b;
                        }
                        return c;
                    }

                    public static void stbi_set_unpremultiply_on_load(int flag_true_if_should_unpremultiply)
                    {
                        stbi__unpremultiply_on_load = flag_true_if_should_unpremultiply;
                    }

                    public static void stbi_convert_iphone_png_to_rgb(int flag_true_if_should_convert)
                    {
                        stbi__de_iphone_flag = flag_true_if_should_convert;
                    }

                    public static int stbi__high_bit(uint z)
                    {
                        var n = 0;
                        if(z == 0)
                        {
                            return -1;
                        }
                        if(z >= 0x10000)
                        {
                            n += 16;
                            z >>= 16;
                        }
                        if(z >= 0x00100)
                        {
                            n += 8;
                            z >>= 8;
                        }
                        if(z >= 0x00010)
                        {
                            n += 4;
                            z >>= 4;
                        }
                        if(z >= 0x00004)
                        {
                            n += 2;
                            z >>= 2;
                        }
                        if(z >= 0x00002)
                        {
                            n += 1;
                            z >>= 1;
                        }
                        return n;
                    }

                    public static int stbi__bitcount(uint a)
                    {
                        a = (a & 0x55555555) + ((a >> 1) & 0x55555555);
                        a = (a & 0x33333333) + ((a >> 2) & 0x33333333);
                        a = (a + (a >> 4)) & 0x0f0f0f0f;
                        a = a + (a >> 8);
                        a = a + (a >> 16);
                        return (int)(a & 0xff);
                    }

                    public static int stbi__shiftsigned(uint v, int shift, int bits)
                    {
                        if(shift < 0)
                        {
                            v <<= -shift;
                        }
                        else
                        {
                            v >>= shift;
                        }
                        v >>= 8 - bits;
                        return (int)(v * (int)mul_table[bits]) >> (int)shift_table[bits];
                    }

                    public static int stbi__info_main(stbi__context s, int* x, int* y, int* comp)
                    {
                        if(stbi__jpeg_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        if(stbi__png_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        if(stbi__gif_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        if(stbi__bmp_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        if(stbi__psd_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        if(stbi__tga_info(s, x, y, comp) != 0)
                        {
                            return 1;
                        }
                        return stbi__err("unknown image type");
                    }

                    public static int stbi__is_16_main(stbi__context s)
                    {
                        if(stbi__png_is16(s) != 0)
                        {
                            return 1;
                        }
                        if(stbi__psd_is16(s) != 0)
                        {
                            return 1;
                        }
                        return 0;
                    }

                    [StructLayout(LayoutKind.Sequential)]
                    public struct stbi__result_info
                    {

                      public int bits_per_channel;

                      public int num_channels;

                      public int channel_order;

                    }

                }

            }

        }

    }

}
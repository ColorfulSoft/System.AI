﻿namespace System.AI
{

    public static partial class imageio
    {

        internal static partial class StbImageSharp
        {

            public unsafe partial class StbImage
            {

                public static int stbi__psd_test(stbi__context s)
                {
                    var r = (stbi__get32be(s) == 0x38425053) ? 1 : 0;
                    stbi__rewind(s);
                    return r;
                }

                public static int stbi__psd_decode_rle(stbi__context s, byte* p, int pixelCount)
                {
                    var count = 0;
                    var nleft = 0;
                    var len = 0;
                    count = 0;
                    while((nleft = pixelCount - count) > 0)
                    {
                        len = stbi__get8(s);
                        if(len == 128)
                        {
                        }
                        else
                        {
                            if(len < 128)
                            {
                                len++;
                                if(len > nleft)
                                {
                                    return 0;
                                }
                                count += len;
                                while(len != 0)
                                {
                                    *p = stbi__get8(s);
                                    p += 4;
                                    len--;
                                }
                            }
                            else
                            {
                                if(len > 128)
                                {
                                    byte val = 0;
                                    len = 257 - len;
                                    if(len > nleft)
                                    {
                                        return 0;
                                    }
                                    val = stbi__get8(s);
                                    count += len;
                                    while(len != 0)
                                    {
                                        *p = val;
                                        p += 4;
                                        len--;
                                    }
                                }
                            }
                        }
                    }
                    return 1;
                }

                public static void* stbi__psd_load(stbi__context s, int* x, int* y, int* comp,
                                                   int req_comp, stbi__result_info* ri, int bpc)
                {
                    var pixelCount = 0;
                    var channelCount = 0;
                    var compression = 0;
                    var channel = 0;
                    var i = 0;
                    var bitdepth = 0;
                    var w = 0;
                    var h = 0;
                    byte* _out_;
                    if(stbi__get32be(s) != 0x38425053)
                    {
                        return (byte*)(ulong)((stbi__err("not PSD") != 0) ? (byte*)null : null);
                    }
                    if(stbi__get16be(s) != 1)
                    {
                        return (byte*)(ulong)((stbi__err("wrong version") != 0) ? (byte*)null : null);
                    }
                    stbi__skip(s, 6);
                    channelCount = stbi__get16be(s);
                    if((channelCount < 0) || (channelCount > 16))
                    {
                        return (byte*)(ulong)((stbi__err("wrong channel count") != 0) ? (byte*)null : null);
                    }
                    h = (int)stbi__get32be(s);
                    w = (int)stbi__get32be(s);
                    bitdepth = stbi__get16be(s);
                    if((bitdepth != 8) && (bitdepth != 16))
                    {
                        return (byte*)(ulong)((stbi__err("unsupported bit depth") != 0) ? (byte*)null : null);
                    }
                    if(stbi__get16be(s) != 3)
                    {
                        return (byte*)(ulong)((stbi__err("wrong color format") != 0) ? (byte*)null : null);
                    }
                    stbi__skip(s, (int)stbi__get32be(s));
                    stbi__skip(s, (int)stbi__get32be(s));
                    stbi__skip(s, (int)stbi__get32be(s));
                    compression = stbi__get16be(s);
                    if(compression > 1)
                    {
                        return (byte*)(ulong)((stbi__err("bad compression") != 0) ? (byte*)null : null);
                    }
                    if(stbi__mad3sizes_valid(4, w, h, 0) == 0)
                    {
                        return (byte*)(ulong)((stbi__err("too large") != 0) ? (byte*)null : null);
                    }
                    if((compression == 0) && (bitdepth == 16) && (bpc == 16))
                    {
                        _out_ = (byte*)stbi__malloc_mad3(8, w, h, 0);
                        ri->bits_per_channel = 16;
                    }
                    else
                    {
                        _out_ = (byte*)stbi__malloc((ulong)(4 * w * h));
                    }
                    if(_out_ == null)
                    {
                        return (byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                    }
                    pixelCount = w * h;
                    if(compression != 0)
                    {
                        stbi__skip(s, h * channelCount * 2);
                        for(channel = 0; channel < 4; channel++)
                        {
                            byte* p;
                            p = _out_ + channel;
                            if(channel >= channelCount)
                            {
                                for(i = 0; i < pixelCount; i++, p += 4)
                                {
                                    *p = (byte)((channel == 3) ? 255 : 0);
                                }
                            }
                            else
                            {
                                if(stbi__psd_decode_rle(s, p, pixelCount) == 0)
                                {
                                    CRuntime.free(_out_);
                                    return (byte*)(ulong)((stbi__err("corrupt") != 0) ? (byte*)null : null);
                                }
                            }
                        }
                    }
                    else
                    {
                        for(channel = 0; channel < 4; channel++)
                        {
                            if(channel >= channelCount)
                            {
                                if((bitdepth == 16) && (bpc == 16))
                                {
                                    var q = (ushort*)_out_ + channel;
                                    var val = (ushort)((channel == 3) ? 65535 : 0);
                                    for(i = 0; i < pixelCount; i++, q += 4)
                                    {
                                        *q = val;
                                    }
                                }
                                else
                                {
                                    var p = _out_ + channel;
                                    var val = (byte)((channel == 3) ? 255 : 0);
                                    for(i = 0; i < pixelCount; i++, p += 4)
                                    {
                                        *p = val;
                                    }
                                }
                            }
                            else
                            {
                                if(ri->bits_per_channel == 16)
                                {
                                    var q = (ushort*)_out_ + channel;
                                    for(i = 0; i < pixelCount; i++, q += 4)
                                    {
                                        *q = (ushort)stbi__get16be(s);
                                    }
                                }
                                else
                                {
                                    var p = _out_ + channel;
                                    if(bitdepth == 16)
                                    {
                                        for(i = 0; i < pixelCount; i++, p += 4)
                                        {
                                            *p = (byte)(stbi__get16be(s) >> 8);
                                        }
                                    }
                                    else
                                    {
                                        for(i = 0; i < pixelCount; i++, p += 4)
                                        {
                                            *p = stbi__get8(s);
                                        }
                                    }
                                }
                            }
                        }
                    }
                    if(channelCount >= 4)
                    {
                        if(ri->bits_per_channel == 16)
                        {
                            for(i = 0; i < w * h; ++i)
                            {
                                var pixel = (ushort*)_out_ + 4 * i;
                                if((pixel[3] != 0) && (pixel[3] != 65535))
                                {
                                    var a = pixel[3] / 65535.0f;
                                    var ra = 1.0f / a;
                                    var inv_a = 65535.0f * (1 - ra);
                                    pixel[0] = (ushort)(pixel[0] * ra + inv_a);
                                    pixel[1] = (ushort)(pixel[1] * ra + inv_a);
                                    pixel[2] = (ushort)(pixel[2] * ra + inv_a);
                                }
                            }
                        }
                        else
                        {
                            for(i = 0; i < w * h; ++i)
                            {
                                var pixel = _out_ + 4 * i;
                                if((pixel[3] != 0) && (pixel[3] != 255))
                                {
                                    var a = pixel[3] / 255.0f;
                                    var ra = 1.0f / a;
                                    var inv_a = 255.0f * (1 - ra);
                                    pixel[0] = (byte)(pixel[0] * ra + inv_a);
                                    pixel[1] = (byte)(pixel[1] * ra + inv_a);
                                    pixel[2] = (byte)(pixel[2] * ra + inv_a);
                                }
                            }
                        }
                    }
                    if((req_comp != 0) && (req_comp != 4))
                    {
                        if(ri->bits_per_channel == 16)
                        {
                            _out_ = (byte*)stbi__convert_format16((ushort*)_out_, 4, req_comp, (uint)w, (uint)h);
                        }
                        else
                        {
                            _out_ = stbi__convert_format(_out_, 4, req_comp, (uint)w, (uint)h);
                        }
                        if(_out_ == null)
                        {
                            return _out_;
                        }
                    }
                    if(comp != null)
                    {
                        *comp = 4;
                    }
                    *y = h;
                    *x = w;
                    return _out_;
                }

                public static int stbi__psd_info(stbi__context s, int* x, int* y, int* comp)
                {
                    var channelCount = 0;
                    var dummy = 0;
                    var depth = 0;
                    if(x == null)
                    {
                        x = &dummy;
                    }
                    if(y == null)
                    {
                        y = &dummy;
                    }
                    if(comp == null)
                    {
                        comp = &dummy;
                    }
                    if(stbi__get32be(s) != 0x38425053)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    if(stbi__get16be(s) != 1)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    stbi__skip(s, 6);
                    channelCount = stbi__get16be(s);
                    if((channelCount < 0) || (channelCount > 16))
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    *y = (int)stbi__get32be(s);
                    *x = (int)stbi__get32be(s);
                    depth = stbi__get16be(s);
                    if((depth != 8) && (depth != 16))
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    if(stbi__get16be(s) != 3)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    *comp = 4;
                    return 1;
                }

                public static int stbi__psd_is16(stbi__context s)
                {
                    var channelCount = 0;
                    var depth = 0;
                    if(stbi__get32be(s) != 0x38425053)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    if(stbi__get16be(s) != 1)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    stbi__skip(s, 6);
                    channelCount = stbi__get16be(s);
                    if((channelCount < 0) || (channelCount > 16))
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    stbi__get32be(s);
                    stbi__get32be(s);
                    depth = stbi__get16be(s);
                    if(depth != 16)
                    {
                        stbi__rewind(s);
                        return 0;
                    }
                    return 1;
                }

            }

        }

    }

}
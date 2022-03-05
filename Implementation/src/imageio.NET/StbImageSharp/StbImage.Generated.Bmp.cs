﻿using System.Runtime.InteropServices;

namespace System.IO
{

    public static partial class imageio
    {

        internal static partial class StbImageSharp
        {

            public unsafe partial class StbImage
            {

                public static int stbi__bmp_test_raw(stbi__context s)
                {
                    var r = 0;
                    var sz = 0;
                    if(stbi__get8(s) != 'B')
                    {
                        return 0;
                    }
                    if(stbi__get8(s) != 'M')
                    {
                        return 0;
                    }
                    stbi__get32le(s);
                    stbi__get16le(s);
                    stbi__get16le(s);
                    stbi__get32le(s);
                    sz = (int)stbi__get32le(s);
                    r = ((sz == 12) || (sz == 40) || (sz == 56) || (sz == 108) || (sz == 124)) ? 1 : 0;
                    return r;
                }

                public static int stbi__bmp_test(stbi__context s)
                {
                    var r = stbi__bmp_test_raw(s);
                    stbi__rewind(s);
                    return r;
                }

                public static void* stbi__bmp_parse_header(stbi__context s, stbi__bmp_data* info)
                {
                    var hsz = 0;
                    if((stbi__get8(s) != 'B') || (stbi__get8(s) != 'M'))
                    {
                        return (byte*)(ulong)((stbi__err("not BMP") != 0) ? (byte*)null : null);
                    }
                    stbi__get32le(s);
                    stbi__get16le(s);
                    stbi__get16le(s);
                    info->offset = (int)stbi__get32le(s);
                    info->hsz = hsz = (int)stbi__get32le(s);
                    info->mr = info->mg = info->mb = info->ma = 0;
                    if((hsz != 12) && (hsz != 40) && (hsz != 56) && (hsz != 108) && (hsz != 124))
                    {
                        return (byte*)(ulong)((stbi__err("unknown BMP") != 0) ? (byte*)null : null);
                    }
                    if(hsz == 12)
                    {
                        s.img_x = (uint)stbi__get16le(s);
                        s.img_y = (uint)stbi__get16le(s);
                    }
                    else
                    {
                        s.img_x = stbi__get32le(s);
                        s.img_y = stbi__get32le(s);
                    }
                    if(stbi__get16le(s) != 1)
                    {
                        return (byte*)(ulong)((stbi__err("bad BMP") != 0) ? (byte*)null : null);
                    }
                    info->bpp = stbi__get16le(s);
                    if(hsz != 12)
                    {
                        var compress = (int)stbi__get32le(s);
                        if((compress == 1) || (compress == 2))
                        {
                            return (byte*)(ulong)((stbi__err("BMP RLE") != 0) ? (byte*)null : null);
                        }
                        stbi__get32le(s);
                        stbi__get32le(s);
                        stbi__get32le(s);
                        stbi__get32le(s);
                        stbi__get32le(s);
                        if((hsz == 40) || (hsz == 56))
                        {
                            if(hsz == 56)
                            {
                                stbi__get32le(s);
                                stbi__get32le(s);
                                stbi__get32le(s);
                                stbi__get32le(s);
                            }
                            if((info->bpp == 16) || (info->bpp == 32))
                            {
                                if(compress == 0)
                                {
                                    if(info->bpp == 32)
                                    {
                                        info->mr = 0xffu << 16;
                                        info->mg = 0xffu << 8;
                                        info->mb = 0xffu << 0;
                                        info->ma = 0xffu << 24;
                                        info->all_a = 0;
                                    }
                                    else
                                    {
                                        info->mr = 31u << 10;
                                        info->mg = 31u << 5;
                                        info->mb = 31u << 0;
                                    }
                                }
                                else
                                {
                                    if(compress == 3)
                                    {
                                        info->mr = stbi__get32le(s);
                                        info->mg = stbi__get32le(s);
                                        info->mb = stbi__get32le(s);
                                        if((info->mr == info->mg) && (info->mg == info->mb))
                                        {
                                            return (byte*)(ulong)((stbi__err("bad BMP") != 0) ? (byte*)null : null);
                                        }
                                    }
                                    else
                                    {
                                        return (byte*)(ulong)((stbi__err("bad BMP") != 0) ? (byte*)null : null);
                                    }
                                }
                            }
                        }
                        else
                        {
                            var i = 0;
                            if((hsz != 108) && (hsz != 124))
                            {
                                return (byte*)(ulong)((stbi__err("bad BMP") != 0) ? (byte*)null : null);
                            }
                            info->mr = stbi__get32le(s);
                            info->mg = stbi__get32le(s);
                            info->mb = stbi__get32le(s);
                            info->ma = stbi__get32le(s);
                            stbi__get32le(s);
                            for(i = 0; i < 12; ++i)
                            {
                                stbi__get32le(s);
                            }
                            if(hsz == 124)
                            {
                                stbi__get32le(s);
                                stbi__get32le(s);
                                stbi__get32le(s);
                                stbi__get32le(s);
                            }
                        }
                    }
                    return (void*)1;
                }

                public static void* stbi__bmp_load(stbi__context s, int* x, int* y, int* comp, int req_comp, stbi__result_info* ri)
                {
                    byte* _out_;
                    var mr = (uint)0;
                    var mg = (uint)0;
                    var mb = (uint)0;
                    var ma = (uint)0;
                    uint all_a = 0;
                    var pal = stackalloc byte[256 * 4];
                    var psize = 0;
                    var i = 0;
                    var j = 0;
                    var width = 0;
                    var flip_vertically = 0;
                    var pad = 0;
                    var target = 0;
                    var info = new stbi__bmp_data();
                    info.all_a = 255;
                    if(stbi__bmp_parse_header(s, &info) == null)
                    {
                        return null;
                    }
                    flip_vertically = ((int)s.img_y > 0) ? 1 : 0;
                    s.img_y = (uint)CRuntime.abs((int)s.img_y);
                    mr = info.mr;
                    mg = info.mg;
                    mb = info.mb;
                    ma = info.ma;
                    all_a = info.all_a;
                    if(info.hsz == 12)
                    {
                        if(info.bpp < 24)
                        {
                            psize = (info.offset - 14 - 24) / 3;
                        }
                    }
                    else
                    {
                        if(info.bpp < 16)
                        {
                            psize = (info.offset - 14 - info.hsz) >> 2;
                        }
                    }
                    s.img_n = (ma != 0) ? 4 : 3;
                    if((req_comp != 0) && (req_comp >= 3))
                    {
                        target = req_comp;
                    }
                    else
                    {
                        target = s.img_n;
                    }
                    if(stbi__mad3sizes_valid(target, (int)s.img_x, (int)s.img_y, 0) == 0)
                    {
                        return (byte*)(ulong)((stbi__err("too large") != 0) ? (byte*)null : null);
                    }
                    _out_ = (byte*)stbi__malloc_mad3(target, (int)s.img_x, (int)s.img_y, 0);
                    if(_out_ == null)
                    {
                        return (byte*)(ulong)((stbi__err("outofmem") != 0) ? (byte*)null : null);
                    }
                    if(info.bpp < 16)
                    {
                        var z = 0;
                        if((psize == 0) || (psize > 256))
                        {
                            CRuntime.free(_out_);
                            return (byte*)(ulong)((stbi__err("invalid") != 0) ? (byte*)null : null);
                        }
                        for(i = 0; i < psize; ++i)
                        {
                            pal[i * 4 + 2] = stbi__get8(s);
                            pal[i * 4 + 1] = stbi__get8(s);
                            pal[i * 4 + 0] = stbi__get8(s);
                            if(info.hsz != 12)
                            {
                                stbi__get8(s);
                            }
                            pal[i * 4 + 3] = 255;
                        }
                        stbi__skip(s, info.offset - 14 - info.hsz - psize * ((info.hsz == 12) ? 3 : 4));
                        if(info.bpp == 1)
                        {
                            width = (int)((s.img_x + 7) >> 3);
                        }
                        else
                        {
                            if(info.bpp == 4)
                            {
                                width = (int)((s.img_x + 1) >> 1);
                            }
                            else
                            {
                                if(info.bpp == 8)
                                {
                                    width = (int)s.img_x;
                                }
                                else
                                {
                                    CRuntime.free(_out_);
                                    return (byte*)(ulong)((stbi__err("bad bpp") != 0) ? (byte*)null : null);
                                }
                            }
                        }
                        pad = -width & 3;
                        if(info.bpp == 1)
                        {
                            for(j = 0; j < (int)s.img_y; ++j)
                            {
                                var bit_offset = 7;
                                var v = (int)stbi__get8(s);
                                for(i = 0; i < (int)s.img_x; ++i)
                                {
                                    var color = (v >> bit_offset) & 0x1;
                                    _out_[z++] = pal[color * 4 + 0];
                                    _out_[z++] = pal[color * 4 + 1];
                                    _out_[z++] = pal[color * 4 + 2];
                                    if(target == 4)
                                    {
                                        _out_[z++] = 255;
                                    }
                                    if((i + 1) == (int)s.img_x)
                                    {
                                        break;
                                    }
                                    if((--bit_offset) < 0)
                                    {
                                        bit_offset = 7;
                                        v = stbi__get8(s);
                                    }
                                }
                                stbi__skip(s, pad);
                            }
                        }
                        else
                        {
                            for(j = 0; j < (int)s.img_y; ++j)
                            {
                                for(i = 0; i < (int)s.img_x; i += 2)
                                {
                                    var v = (int)stbi__get8(s);
                                    var v2 = 0;
                                    if(info.bpp == 4)
                                    {
                                        v2 = v & 15;
                                        v >>= 4;
                                    }
                                    _out_[z++] = pal[v * 4 + 0];
                                    _out_[z++] = pal[v * 4 + 1];
                                    _out_[z++] = pal[v * 4 + 2];
                                    if(target == 4)
                                    {
                                        _out_[z++] = 255;
                                    }
                                    if((i + 1) == (int)s.img_x)
                                    {
                                        break;
                                    }
                                    v = (info.bpp == 8) ? stbi__get8(s) : v2;
                                    _out_[z++] = pal[v * 4 + 0];
                                    _out_[z++] = pal[v * 4 + 1];
                                    _out_[z++] = pal[v * 4 + 2];
                                    if(target == 4)
                                    {
                                        _out_[z++] = 255;
                                    }
                                }
                                stbi__skip(s, pad);
                            }
                        }
                    }
                    else
                    {
                        var rshift = 0;
                        var gshift = 0;
                        var bshift = 0;
                        var ashift = 0;
                        var rcount = 0;
                        var gcount = 0;
                        var bcount = 0;
                        var acount = 0;
                        var z = 0;
                        var easy = 0;
                        stbi__skip(s, info.offset - 14 - info.hsz);
                        if(info.bpp == 24)
                        {
                            width = (int)(3 * s.img_x);
                        }
                        else
                        {
                            if(info.bpp == 16)
                            {
                                width = (int)(2 * s.img_x);
                            }
                            else
                            {
                                width = 0;
                            }
                        }
                        pad = -width & 3;
                        if(info.bpp == 24)
                        {
                            easy = 1;
                        }
                        else
                        {
                            if(info.bpp == 32)
                            {
                                if((mb == 0xff) && (mg == 0xff00) && (mr == 0x00ff0000) && (ma == 0xff000000))
                                {
                                    easy = 2;
                                }
                            }
                        }
                        if(easy == 0)
                        {
                            if((mr == 0) || (mg == 0) || (mb == 0))
                            {
                                CRuntime.free(_out_);
                                return (byte*)(ulong)((stbi__err("bad masks") != 0) ? (byte*)null : null);
                            }
                            rshift = stbi__high_bit(mr) - 7;
                            rcount = stbi__bitcount(mr);
                            gshift = stbi__high_bit(mg) - 7;
                            gcount = stbi__bitcount(mg);
                            bshift = stbi__high_bit(mb) - 7;
                            bcount = stbi__bitcount(mb);
                            ashift = stbi__high_bit(ma) - 7;
                            acount = stbi__bitcount(ma);
                        }
                        for(j = 0; j < (int)s.img_y; ++j)
                        {
                            if(easy != 0)
                            {
                                for(i = 0; i < (int)s.img_x; ++i)
                                {
                                    byte a = 0;
                                    _out_[z + 2] = stbi__get8(s);
                                    _out_[z + 1] = stbi__get8(s);
                                    _out_[z + 0] = stbi__get8(s);
                                    z += 3;
                                    a = (byte)((easy == 2) ? stbi__get8(s) : 255);
                                    all_a |= a;
                                    if(target == 4)
                                    {
                                        _out_[z++] = a;
                                    }
                                }
                            }
                            else
                            {
                                var bpp = info.bpp;
                                for(i = 0; i < (int)s.img_x; ++i)
                                {
                                    var v = (bpp == 16) ? (uint)stbi__get16le(s) : stbi__get32le(s);
                                    uint a = 0;
                                    _out_[z++] = (byte)(stbi__shiftsigned(v & mr, rshift, rcount) & 255);
                                    _out_[z++] = (byte)(stbi__shiftsigned(v & mg, gshift, gcount) & 255);
                                    _out_[z++] = (byte)(stbi__shiftsigned(v & mb, bshift, bcount) & 255);
                                    a = (uint)((ma != 0) ? stbi__shiftsigned(v & ma, ashift, acount) : 255);
                                    all_a |= a;
                                    if(target == 4)
                                    {
                                        _out_[z++] = (byte)(a & 255);
                                    }
                                }
                            }
                            stbi__skip(s, pad);
                        }
                    }
                    if((target == 4) && (all_a == 0))
                    {
                        for(i = (int)(4 * s.img_x * s.img_y - 1); i >= 0; i -= 4)
                        {
                            _out_[i] = 255;
                        }
                    }
                    if(flip_vertically != 0)
                    {
                        byte t = 0;
                        for(j = 0; j < (int)s.img_y >> 1; ++j)
                        {
                            var p1 = _out_ + j * s.img_x * target;
                            var p2 = _out_ + (s.img_y - 1 - j) * s.img_x * target;
                            for(i = 0; i < (int)s.img_x * target; ++i)
                            {
                                t = p1[i];
                                p1[i] = p2[i];
                                p2[i] = t;
                            }
                        }
                    }
                    if((req_comp != 0) && (req_comp != target))
                    {
                        _out_ = stbi__convert_format(_out_, target, req_comp, s.img_x, s.img_y);
                        if(_out_ == null)
                        {
                            return _out_;
                        }
                    }
                    *x = (int)s.img_x;
                    *y = (int)s.img_y;
                    if(comp != null)
                    {
                        *comp = s.img_n;
                    }
                    return _out_;
                }

                public static int stbi__bmp_info(stbi__context s, int* x, int* y, int* comp)
                {
                    void* p;
                    var info = new stbi__bmp_data();
                    info.all_a = 255;
                    p = stbi__bmp_parse_header(s, &info);
                    stbi__rewind(s);
                    if(p == null)
                    {
                        return 0;
                    }
                    if(x != null)
                    {
                        *x = (int)s.img_x;
                    }
                    if(y != null)
                    {
                        *y = (int)s.img_y;
                    }
                    if(comp != null)
                    {
                        *comp = (info.ma != 0) ? 4 : 3;
                    }
                    return 1;
                }

                [StructLayout(LayoutKind.Sequential)]
                public struct stbi__bmp_data
                {

                    public int bpp;

                    public int offset;

                    public int hsz;

                    public uint mr;

                    public uint mg;

                    public uint mb;

                    public uint ma;

                    public uint all_a;

                }

            }

        }

    }

}
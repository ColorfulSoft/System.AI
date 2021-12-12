//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2021. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System.Runtime.InteropServices;

namespace System
{

    /// <summary>
    /// Helper class for Quarter conversions and some low level operations.
    /// This class is internally used in the Quarter class.
    /// </summary>
    /// <remarks>
    /// References:
    ///     - https://en.wikipedia.org/wiki/Minifloat
    /// </remarks>
    [ComVisible(false)]
    internal static class QuarterHelper
    {

        public static unsafe float QuarterToSingle(Quarter quarter)
        {
            var v = quarter.value;
            byte E = (byte)((v & 0x78) >> 3);
            byte F = (byte)(v & 0x07);
            float res = 0f;
            switch(E)
            {
                case 0x00:
                {
                    res = 0.125f * F;
                    break;
                }
                case 0x0f:
                {
                    *(uint*)&res = (uint)((F != 0) ? 0x7fffffff : 0x7f800000);
                    break;
                }
                default:
                {
                    *(uint*)&res = (((uint)E + 126) << 23) + ((uint)F << 20);
                    break;
                }
            }
            if((v & 0x80) != 0)
            {
                *(uint*)&res |= 0x80000000;
            }
            return res;
        }

        public static unsafe Quarter SingleToQuarter(float single)
        {
            int E;
            uint F;
            byte Res;
            uint src = *(uint*)&single;
            E = (int)((src >> 23) & 0x000000ff);
            F = src & 0x007fffff;
            switch(E)
            {
                case 0x00:
                {
                    Res = 0x00;
                    break;
                }
                case 0xff:
                {
                    Res = (byte)((F != 0) ? 0x7f : 0x78);
                    break;
                }
                default:
                {
                    E -= 126;
                    if(E < -3)
                    {
                        Res = 0;
                    }
                    else
                    {
                        if(E >= -3 && E < 1)
                        {
                            if(single < 0)
                            {
                                single = -single;
                            }
                            Res = (byte)((single + 0.0625f) * 8);
                        }
                        else
                        {
                            if(E > 15)
                            {
                                Res = 0x78;
                            }
                            else
                            {
                                Res = (byte)((E << 3) + (F >> 20));
                                if((F & 0x80000) != 0)
                                {
                                    Res++;
                                }
                                if(Res > 0x78)
                                {
                                    Res = 0x78;
                                }
                            }
                        }
                    }
                    break;
                }
            }
            if((src & 0x80000000) != 0)
            {
                Res |= 0x80;
            }
            return Quarter.ToQuarter(Res);
        }

        public static Quarter Negate(Quarter quarter)
        {
            return Quarter.ToQuarter((byte)(quarter.value ^ 0x80));
        }

        public static Quarter Abs(Quarter quarter)
        {
            return Quarter.ToQuarter((byte)(quarter.value & 0x7f));
        }

        public static bool IsNaN(Quarter quarter)
        {
            return ((quarter.value & 0x7f) > 0x78);
        }

        public static bool IsInfinity(Quarter quarter)
        {
            return ((quarter.value & 0x7f) == 0x78);
        }

        public static bool IsPositiveInfinity(Quarter quarter)
        {
            return (quarter.value == 0x78);
        }

        public static bool IsNegativeInfinity(Quarter quarter)
        {
            return (quarter.value == 0xf8);
        }

    }

}
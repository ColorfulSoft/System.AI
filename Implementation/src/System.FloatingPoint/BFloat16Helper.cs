//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2021. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System.Runtime.InteropServices;

namespace System
{

    /// <summary>
    /// Helper class for BFloat16 conversions and some low level operations.
    /// This class is internally used in the BFloat16 class.
    /// </summary>
    /// <remarks>
    /// References:
    ///     - https://en.wikipedia.org/wiki/Bfloat16_floating-point_format
    /// </remarks>
    [ComVisible(false)]
    internal static class BFloat16Helper
    {

        public static unsafe float BFloat16ToSingle(BFloat16 bfloat16)
        {
            uint v = (uint)(bfloat16.value << 16);
            return *(float*)&v;
        }

        public static unsafe BFloat16 SingleToBFloat16(float single)
        {
            uint v = *(uint*)&single;
            return BFloat16.ToBFloat16((ushort)(v >> 16));
        }

        public static BFloat16 Negate(BFloat16 bfloat16)
        {
            return BFloat16.ToBFloat16((byte)(bfloat16.value ^ 0x8000));
        }

        public static BFloat16 Abs(BFloat16 bfloat16)
        {
            return BFloat16.ToBFloat16((byte)(bfloat16.value & 0x7fff));
        }

        public static bool IsNaN(BFloat16 bfloat16)
        {
            return ((bfloat16.value & 0x7fff) > 0x7c00);
        }

        public static bool IsInfinity(BFloat16 bfloat16)
        {
            return ((bfloat16.value & 0x7fff) == 0x7c00);
        }

        public static bool IsPositiveInfinity(BFloat16 bfloat16)
        {
            return (bfloat16.value == 0x7c00);
        }

        public static bool IsNegativeInfinity(BFloat16 bfloat16)
        {
            return (bfloat16.value == 0xfc00);
        }

    }

}
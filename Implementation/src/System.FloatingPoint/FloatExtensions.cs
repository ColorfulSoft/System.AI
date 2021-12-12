//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2021. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System;
using System.IO;

namespace System
{
    /// <summary>
    /// Description of FloatExtensions.
    /// </summary>
    public static class FloatExtensions
    {
        public static Half ReadHalf(this BinaryReader br)
        {
            return Half.ToHalf(br.ReadUInt16());
        }
        public static void WriteHalf(this BinaryWriter bw, Half value)
        {
            bw.Write(value.value);
        }
        public static Quarter ReadQuarter(this BinaryReader br)
        {
            return Quarter.ToQuarter(br.ReadByte());
        }
        public static void WriteQuarter(this BinaryWriter bw, Quarter value)
        {
            bw.Write(value.value);
        }
    }
}

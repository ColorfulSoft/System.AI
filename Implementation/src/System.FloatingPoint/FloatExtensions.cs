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

        /// <summary>
        /// Reads a System.Quarter type value from the current stream and shifts the position in the stream by 2 bytes.
        /// </summary>
        /// <param name="br">BinaryReader object</param>
        /// <returns>The value read from the stream</returns>
        public static Half ReadHalf(this BinaryReader br)
        {
            return Half.ToHalf(br.ReadUInt16());
        }

        /// <summary>
        /// Writes a value of type System.Half with a length of 2 bytes to the current stream.
        /// </summary>
        /// <param name="bw">BinaryWriter object</param>
        /// <param name="value">The value being written to the stream</param>
        public static void WriteHalf(this BinaryWriter bw, Half value)
        {
            bw.Write(value.value);
        }

        /// <summary>
        /// Reads a System.Quarter type value from the current stream and shifts the position in the stream by 1 byte.
        /// </summary>
        /// <param name="br">BinaryReader object</param>
        /// <returns>The value read from the stream</returns>
        public static Quarter ReadQuarter(this BinaryReader br)
        {
            return Quarter.ToQuarter(br.ReadByte());
        }

        /// <summary>
        /// Writes a value of type System.Quarter with a length of 1 byte to the current stream.
        /// </summary>
        /// <param name="bw">BinaryWriter object</param>
        /// <param name="value">The value being written to the stream</param>
        public static void WriteQuarter(this BinaryWriter bw, Quarter value)
        {
            bw.Write(value.value);
        }

    }

}
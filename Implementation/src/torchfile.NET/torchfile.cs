//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

// This code is based on python-torchfile. See https://github.com/bshillingford/python-torchfile for
// more details.

using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace System.IO
{

    /// <summary>
    /// Mostly direct port of the Lua and C serialization implementation to
    /// dotnet, depending only on `Array`, and `Half`.
    /// Supported types:
    /// <para>
    /// * `nil` to dotnet `null`
    /// </para>
    /// <para>
    /// * numbers to dotnet floats, or by default a heuristic changes them to ints or
    ///   longs if they are integral
    /// </para>
    /// <para>
    /// * booleans
    /// </para>
    /// <para>
    /// * strings: read as normal dotnet strings, like
    ///   lua strings which don't support unicode, and that can contain null chars
    /// </para>
    /// <para>
    /// * tables converted to a Dictionary&lt;object, object&gt;; if they are list-like (i.e. have
    ///   numeric keys from 1 through n) they become a object[] by default
    /// </para>
    /// <para>
    /// * Torch classes: supports Tensors and Storages, and most classes such as
    ///   modules. Trivially extensible much like the Torch serialization code.
    ///   Trivial torch classes like most `nn.Module` subclasses become
    ///   `TorchObject`s.
    /// </para>
    /// <para>
    /// * functions: loaded into the `LuaFunction` object,
    ///   which simply wraps the raw serialized data, i.e. upvalues and code.
    /// </para>
    /// These are mostly useless, but exist so you can deserialize anything.
    /// Currently, the implementation assumes the system-dependent binary Torch
    /// format, but minor refactoring can give support for the ascii format as well.
    /// </summary>
    public static partial class torchfile
    {

        #region type codes

        private const int TYPE_NIL = 0;

        private const int TYPE_NUMBER = 1;

        private const int TYPE_STRING = 2;

        private const int TYPE_TABLE = 3;

        private const int TYPE_TORCH = 4;

        private const int TYPE_BOOLEAN = 5;

        private const int TYPE_FUNCTION = 6;

        private const int TYPE_RECUR_FUNCTION = 8;

        private const int LEGACY_TYPE_RECUR_FUNCTION = 7;

        #endregion

        #region load

        /// <summary>
        /// Loads the given t7 file using default settings; kwargs are forwarded to `T7Reader`.
        /// </summary>
        /// <param name="stream">Readable stream with T7 file.</param>
        /// <returns>Loaded object.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object load(Stream stream,
                                  bool use_list_heuristic = true,
                                  bool use_int_heuristic = true,
                                  bool utf8_decode_strings = false,
                                  object force_deserialize_classes = null,
                                  bool force_8bytes_long = true)
        {
            object obj;
            using(var f = new BinaryReader(stream))
            {
                var reader = new T7Reader(f,
                                          use_list_heuristic,
                                          use_int_heuristic,
                                          utf8_decode_strings,
                                          force_deserialize_classes,
                                          force_8bytes_long);
                obj = reader.read_obj();
            }
            return obj;
        }

        /// <summary>
        /// Loads the given t7 file using default settings; kwargs are forwarded to `T7Reader`.
        /// </summary>
        /// <param name="filename">T7 file name.</param>
        /// <returns>Loaded object.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static object load(string filename,
                                  bool use_list_heuristic = true,
                                  bool use_int_heuristic = true,
                                  bool utf8_decode_strings = false,
                                  object force_deserialize_classes = null,
                                  bool force_8bytes_long = true)
        {
            object obj;
            using(var f = File.OpenRead(filename))
            {
                obj = load(f,
                           use_list_heuristic,
                           use_int_heuristic,
                           utf8_decode_strings,
                           force_deserialize_classes,
                           force_8bytes_long);
            }
            return obj;
        }

        #endregion

    }

}
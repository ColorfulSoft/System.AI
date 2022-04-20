//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;

namespace System.AI
{

    public static partial class torch
    {

        /// <summary>
        /// Defines the device on which tensors are stored and calculations are performed.
        /// </summary>
        public sealed class Device
        {

            /// <summary>
            /// Computing backend.
            /// </summary>
            public enum Backend : byte
            {

                /// <summary>
                /// OpenCL backend.
                /// </summary>
                opencl,

                /// <summary>
                /// Managed dotnet backend.
                /// </summary>
                dotnet

            }

            /// <summary>
            /// Type of computing device.
            /// </summary>
            public enum DeviceType : byte
            {

                /// <summary>
                /// CPU.
                /// </summary>
                cpu,

                /// <summary>
                /// GPU.
                /// </summary>
                gpu,

                /// <summary>
                /// Dotnet runtime (JIT).
                /// </summary>
                jit

            }

            /// <summary>
            /// Computing backend.
            /// </summary>
            public Backend backend;

            /// <summary>
            /// Type of computing device.
            /// </summary>
            public DeviceType device_type;

            /// <summary>
            /// Device number.
            /// </summary>
            public int index;

            internal IBackend __backend;

            /// <summary>
            /// Initializes the Device object pointing to the specified device.
            /// </summary>
            /// <param name="device">Device name.</param>
            public Device(string device = "jit")
            {
                device = device.ToLower();
                if(device.StartsWith("dotnet"))
                {
                    if(device == "dotnet:jit")
                    {
                        this.backend = Backend.dotnet;
                        this.device_type = DeviceType.jit;
                        this.index = 0;
                        this.__backend = JITBackend.instance;
                        return;
                    }
                    throw new ArgumentException(string.Format("Unknown device \"{0}\".", device));
                }
                if(device.StartsWith("jit"))
                {
                    this.backend = Backend.dotnet;
                    this.device_type = DeviceType.jit;
                    this.index = 0;
                    this.__backend = JITBackend.instance;
                    if(device.Length != 3)
                    {
                        throw new ArgumentException(string.Format("Unknown device \"{0}\".", device));
                    }
                    return;
                }
                throw new NotSupportedException("Only dotnet:jit backend is available.");
            }

            /// <summary>
            /// Determines whether both objects of the Device class point to the same device.
            /// </summary>
            /// <param name="device1">First device.</param>
            /// <param name="device2">Second device.</param>
            /// <returns>Boolean value.</returns>
            public static bool operator ==(Device device1, Device device2)
            {
                return (device1.backend == device2.backend) &&
                       (device1.device_type == device2.device_type) &&
                       (device1.index == device2.index);
            }

            /// <summary>
            /// Determines whether both objects of the Device class point to different devices.
            /// </summary>
            /// <param name="device1">First device.</param>
            /// <param name="device2">Second device.</param>
            /// <returns>Boolean value.</returns>
            public static bool operator !=(Device device1, Device device2)
            {
                return (device1.backend != device2.backend) &&
                       (device1.device_type != device2.device_type) &&
                       (device1.index != device2.index);
            }

        }

    }

}
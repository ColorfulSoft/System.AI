//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.Collections.Generic;

namespace System.AI
{

    public static partial class torch
    {

        /// <summary>
        /// A multidimensional matrix containing values of the float8 type.
        /// </summary>
        public sealed class QuarterTensor : Tensor
        {

            /// <summary>
            /// Initializes a float8 tensor of the specified size on the device device.
            /// </summary>
            /// <param name="shape">Tensor measurements. If null, the tensor is 0-dimensional.</param>
            /// <param name="device">Device.</param>
            /// <param name="requires_grad">Specifies whether the tensor should contain a gradient.</param>
            public QuarterTensor(IList<int> shape = null,
                                 Device device = null,
                                 bool requires_grad = false) : base(shape,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 1-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 2-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 3-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 4-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 5-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 6-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 7-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 8-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 9-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 10-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 11-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 12-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 13-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 14-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 15-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 16-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 17-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 18-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 19-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 20-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 21-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 22-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 23-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 24-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 25-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 26-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 27-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 28-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="dim28">Twenty-eighth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 int dim28,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    dim28,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 29-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="dim28">Twenty-eighth dimension.</param>
            /// <param name="dim29">Twenty-ninth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 int dim28,
                                 int dim29,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    dim28,
                                                                    dim29,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 30-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="dim28">Twenty-eighth dimension.</param>
            /// <param name="dim29">Twenty-ninth dimension.</param>
            /// <param name="dim30">Thirtieth dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 int dim28,
                                 int dim29,
                                 int dim30,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    dim28,
                                                                    dim29,
                                                                    dim30,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 31-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="dim28">Twenty-eighth dimension.</param>
            /// <param name="dim29">Twenty-ninth dimension.</param>
            /// <param name="dim30">Thirtieth dimension.</param>
            /// <param name="dim31">Thirty-first dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 int dim28,
                                 int dim29,
                                 int dim30,
                                 int dim31,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    dim28,
                                                                    dim29,
                                                                    dim30,
                                                                    dim31,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 32-dimensional tensor of a float8 data type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dim9">Ninth dimension.</param>
            /// <param name="dim10">Tenth dimension.</param>
            /// <param name="dim11">Eleventh dimension.</param>
            /// <param name="dim12">Twelfth dimension.</param>
            /// <param name="dim13">Thirteenth dimension.</param>
            /// <param name="dim14">Fourteenth dimension.</param>
            /// <param name="dim15">Fifteenth dimension.</param>
            /// <param name="dim16">Sixteenth dimension.</param>
            /// <param name="dim17">Seventeenth dimension.</param>
            /// <param name="dim18">Eighteenth dimension.</param>
            /// <param name="dim19">Nineteenth dimension.</param>
            /// <param name="dim20">Twentieth dimension.</param>
            /// <param name="dim21">Twenty-first dimension.</param>
            /// <param name="dim22">Twenty-second dimension.</param>
            /// <param name="dim23">Twenty-third dimension.</param>
            /// <param name="dim24">Twenty-fourth dimension.</param>
            /// <param name="dim25">Twenty-fifth dimension.</param>
            /// <param name="dim26">Twenty-sixth dimension.</param>
            /// <param name="dim27">Twenty-seventh dimension.</param>
            /// <param name="dim28">Twenty-eighth dimension.</param>
            /// <param name="dim29">Twenty-ninth dimension.</param>
            /// <param name="dim30">Thirtieth dimension.</param>
            /// <param name="dim31">Thirty-first dimension.</param>
            /// <param name="dim32">Thirty-second dimension.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            public QuarterTensor(int dim1,
                                 int dim2,
                                 int dim3,
                                 int dim4,
                                 int dim5,
                                 int dim6,
                                 int dim7,
                                 int dim8,
                                 int dim9,
                                 int dim10,
                                 int dim11,
                                 int dim12,
                                 int dim13,
                                 int dim14,
                                 int dim15,
                                 int dim16,
                                 int dim17,
                                 int dim18,
                                 int dim19,
                                 int dim20,
                                 int dim21,
                                 int dim22,
                                 int dim23,
                                 int dim24,
                                 int dim25,
                                 int dim26,
                                 int dim27,
                                 int dim28,
                                 int dim29,
                                 int dim30,
                                 int dim31,
                                 int dim32,
                                 Device device = null,
                                 bool requires_grad = false) : base(dim1,
                                                                    dim2,
                                                                    dim3,
                                                                    dim4,
                                                                    dim5,
                                                                    dim6,
                                                                    dim7,
                                                                    dim8,
                                                                    dim9,
                                                                    dim10,
                                                                    dim11,
                                                                    dim12,
                                                                    dim13,
                                                                    dim14,
                                                                    dim15,
                                                                    dim16,
                                                                    dim17,
                                                                    dim18,
                                                                    dim19,
                                                                    dim20,
                                                                    dim21,
                                                                    dim22,
                                                                    dim23,
                                                                    dim24,
                                                                    dim25,
                                                                    dim26,
                                                                    dim27,
                                                                    dim28,
                                                                    dim29,
                                                                    dim30,
                                                                    dim31,
                                                                    dim32,
                                                                    torch.float8,
                                                                    device,
                                                                    requires_grad)
            {
            }

        }

    }

}
//****************************************************************************************************
// (C) ColorfulSoft corp., 2019-2022. All Rights reserved.
// This code is available under Apache-2.0 license
//****************************************************************************************************

using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// A torch.Tensor is a multi-dimensional matrix
        /// containing elements of a single data type.
        /// </summary>
        public class Tensor : IDisposable
        {

            #region Properties

            /// <summary>
            /// Tensor data storage.
            /// </summary>
            public Storage storage
            {

                get;

                internal set;

            }

            /// <summary>
            /// The size of the tensor.
            /// </summary>
            public Size shape
            {

                get;

                internal set;

            }

            /// <summary>
            /// The gradient of the tensor.
            /// </summary>
            public Tensor grad
            {

                get;

                set;

            }

            /// <summary>
            /// Indicates whether the tensor has a gradient.
            /// </summary>
            public bool requires_grad
            {

                get
                {
                    return this.grad != null;
                }

            }

            /// <summary>
            /// The tensor data type.
            /// </summary>
            public DType dtype
            {

                get;

                internal set;

            }

            /// <summary>
            /// The device on which this tensor is placed and
            /// on which all operations with it will be performed.
            /// </summary>
            public Device device
            {

                get;

                internal set;

            }

            /// <summary>
            /// Delegate of the back propagation function.
            /// </summary>
            internal delegate void backward_fn_delegate();

            /// <summary>
            /// The back propagation function.
            /// </summary>
            internal backward_fn_delegate backward_fn;

            /// <summary>
            /// The name of the backpropagation function.
            /// </summary>
            internal string grad_fn;

            /// <summary>
            /// Gets the number of tensor measurements.
            /// </summary>
            public int ndim
            {

                get
                {
                    return this.shape.Count;
                }

            }

            /// <summary>
            /// Gets the number of tensor elements.
            /// </summary>
            public int numel
            {

                get
                {
                    return this.storage.size;
                }

            }

            #endregion

            #region Constructors

            /// <summary>
            /// Initializes a tensor of the specified data type and size on the device device.
            /// </summary>
            /// <param name="shape">Tensor measurements. If null, the tensor is 0-dimensional.</param>
            /// <param name="dtype">Data type.</param>
            /// <param name="device">Device.</param>
            /// <param name="requires_grad">
            /// Specifies whether the tensor should contain a gradient.
            /// Only the floating-point tensor can have a gradient.
            /// </param>
            public Tensor(IList<int> shape = null,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false)
            {
                if((object)device == null)
                {
                    device = new Device("jit");
                }
                this.device = device;
                if(shape != null)
                {
                    var size = new int[shape.Count];
                    shape.CopyTo(size, 0);
                    this.shape = new Size(size);
                }
                else
                {
                    this.shape = new Size();
                }
                if(dtype == DType.@default)
                {
                    dtype = torch.default_dtype;
                }
                if(device == new Device("jit"))
                {
                    if((dtype == torch.float8) ||
                       (dtype == torch.float16) ||
                       (dtype == torch.bfloat16) ||
                       (dtype == torch.complex16) ||
                       (dtype == torch.complex32) ||
                       (dtype == torch.bcomplex32))
                    {
                        warnings.warn("The float8, float16, bfloat16, complex16, complex32 and bcomplex32 data types do not have hardware support on the CPU via jit. A software implementation is used. Do not use these types for bulk calculations.");
                    }
                    this.storage = new Storage(this.shape.numel, dtype);
                    if(requires_grad)
                    {
                        if((dtype != torch.float8) &&
                           (dtype != torch.float16) &&
                           (dtype != torch.bfloat16) &&
                           (dtype != torch.float32) &&
                           (dtype != torch.float64) &&
                           (dtype != torch.complex16) &&
                           (dtype != torch.complex32) &&
                           (dtype != torch.bcomplex32) &&
                           (dtype != torch.complex64) &&
                           (dtype != torch.complex128))
                        {
                            throw new NotSupportedException("Only floating point tensors may requires_grad.");
                        }
                        this.grad = torch.zeros(shape, dtype: dtype, device: device);
                    }
                }
                this.dtype = dtype;
            }

            /// <summary>
            /// Initializes a 1-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 2-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 3-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 4-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 5-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 6-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          int dim6,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 7-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          int dim6,
                          int dim7,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6,
                                                                       dim7},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 8-dimensional tensor of a dtype type.
            /// </summary>
            /// <param name="dim1">First dimension.</param>
            /// <param name="dim2">Second dimension.</param>
            /// <param name="dim3">Third dimension.</param>
            /// <param name="dim4">Fourth dimension.</param>
            /// <param name="dim5">Fifth dimension.</param>
            /// <param name="dim6">Sixth dimension.</param>
            /// <param name="dim7">Seventh dimension.</param>
            /// <param name="dim8">Eighth dimension.</param>
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          int dim6,
                          int dim7,
                          int dim8,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6,
                                                                       dim7,
                                                                       dim8},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 9-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          int dim6,
                          int dim7,
                          int dim8,
                          int dim9,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6,
                                                                       dim7,
                                                                       dim8,
                                                                       dim9},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 10-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
                          int dim2,
                          int dim3,
                          int dim4,
                          int dim5,
                          int dim6,
                          int dim7,
                          int dim8,
                          int dim9,
                          int dim10,
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6,
                                                                       dim7,
                                                                       dim8,
                                                                       dim9,
                                                                       dim10},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 11-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
                                                                       dim2,
                                                                       dim3,
                                                                       dim4,
                                                                       dim5,
                                                                       dim6,
                                                                       dim7,
                                                                       dim8,
                                                                       dim9,
                                                                       dim10,
                                                                       dim11},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 12-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim12},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 13-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim13},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 14-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim14},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 15-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim15},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 16-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim16},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 17-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim17},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 18-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim18},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 19-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim19},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 20-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim20},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 21-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim21},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 22-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim22},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 23-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim23},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 24-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim24},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 25-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim25},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 26-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim26},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 27-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim27},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 28-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim28},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 29-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim29},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 30-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim30},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 31-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim31},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            /// <summary>
            /// Initializes a 32-dimensional tensor of a dtype type.
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
            /// <param name="dtype">The tensor data type.</param>
            /// <param name="device">The device on which the tensor will be placed.</param>
            /// <param name="requires_grad">Specifies whether to create a gradient for the tensor.</param>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public Tensor(int dim1,
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
                          DType dtype = DType.@default,
                          Device device = null,
                          bool requires_grad = false) : this(new int[]{dim1,
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
                                                                       dim32},
                                                             dtype,
                                                             device,
                                                             requires_grad)
            {
            }

            #endregion

            #region Methods

            /// <summary>
            /// Computes the gradient of current tensor w.r.t. graph leaves.
            /// The graph is differentiated using the chain rule.
            /// If the tensor is non-scalar (i.e. its data has more than one element) and requires gradient,
            /// the function additionally requires specifying gradient.
            /// It should be a tensor of matching type and location, that contains the gradient of the differentiated function w.r.t. self.
            /// This function accumulates gradients in the leaves - you might need to zero them before calling it.
            /// </summary>
            /// <param name="gradient">Gradient.</param>
            public void backward(Tensor gradient = null)
            {
                if(this.shape.Count == 0)
                {
                    if(!this.requires_grad)
                    {
                        throw new ArgumentException("Element 0 of the tensor does not require grad.");
                    }
                    if((object)gradient == null)
                    {
                        this.grad = torch.tensor(1, this.dtype);
                        if(this.backward_fn != null)
                        {
                            this.backward_fn();
                        }
                    }
                    else
                    {
                        this.grad = gradient;
                        if(this.backward_fn != null)
                        {
                            this.backward_fn();
                        }
                    }
                }
                else
                {
                    if((object)gradient == null)
                    {
                        throw new ArgumentException("Grad can be implicitly created only for scalar outputs.");
                    }
                    else
                    {
                        this.grad = gradient;
                        if(this.backward_fn != null)
                        {
                            this.backward_fn();
                        }
                    }
                }
            }

            #endregion

            #region Destructor

            /// <summary>
            /// Releases the resources occupied by the current Tensor class object.
            /// </summary>
            void IDisposable.Dispose()
            {
            }

            #endregion

            #region operators

            #region implicit operator Tensor(Quarter[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Quarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(Half[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(Half[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(BFloat16[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16 v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(BFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(float[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(float[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(double[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(double[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(CQuarter[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CQuarter[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(CHalf[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CHalf[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(CBFloat16[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16 v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CBFloat16[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(CFloat[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CFloat[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(CDouble[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(CDouble[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(sbyte[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(sbyte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(byte[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(byte[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(short[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(short[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(ushort[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ushort[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(int[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(int[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(uint[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(uint[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(long[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(long[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(ulong[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(ulong[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            #region implicit operator Tensor(bool[*] v)

            /// <summary>
            /// Implicitly converts a 0-dimensional array (scalar) of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 1-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 2-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 3-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 4-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 5-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 6-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 7-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 8-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 9-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 10-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 11-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 12-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 13-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 14-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 15-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 16-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 17-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 18-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 19-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 20-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 21-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 22-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 23-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 24-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 25-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 26-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 27-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 28-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 29-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 30-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 31-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            /// <summary>
            /// Implicitly converts a 32-dimensional array of standard .NET type to tensor.
            /// </summary>
            /// <param name="v">Value.</param>
            /// <returns>torch.Tensor object.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Tensor(bool[,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,,] v)
            {
                return torch.tensor(v);
            }

            #endregion

            /// <summary>
            /// Provides indexing with slice support.
            /// </summary>
            public Tensor this[params object[] locs]
            {

                get
                {
                    var begin = (int*)Marshal.AllocHGlobal(this.shape.Count * sizeof(int)).ToPointer();
                    var size = new int[this.shape.Count];
                    var squeeze = new bool[this.shape.Count];
                    for(int i = 0; i < this.shape.Count; ++i)
                    {
                        begin[i] = 0;
                        size[i] = this.shape[i];
                    }
                    if(locs.Length > size.Length)
                    {
                        Marshal.FreeHGlobal((IntPtr)begin);
                        throw new ArgumentException("The number of indexes must not exceed the rank of the tensor.");
                    }
                    for(int i = 0; i < locs.Length; ++i)
                    {
                        if(locs[i] is string)
                        {
                            var v = locs[i] as string;
                            var start = 0;
                            var end = size[i];
                            if(v[0] == ':')
                            {
                                if(v.Length > 1)
                                {
                                    if(!int.TryParse(v.Substring(1), out end))
                                    {
                                        Marshal.FreeHGlobal((IntPtr)begin);
                                        throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                    }
                                    if(end < 0)
                                    {
                                        end = size[i] + end;
                                    }
                                }
                            }
                            else
                            {
                                if(v.IndexOf(':') == -1)
                                {
                                    if(!int.TryParse(v, out start))
                                    {
                                        Marshal.FreeHGlobal((IntPtr)begin);
                                        throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                    }
                                    if(start < 0)
                                    {
                                        start = size[i] + start;
                                    }
                                    squeeze[i] = true;
                                    end = start + 1;
                                }
                                else
                                {
                                    if(!int.TryParse(v.Substring(0, v.IndexOf(':')), out start))
                                    {
                                        Marshal.FreeHGlobal((IntPtr)begin);
                                        throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                    }
                                    if(start < 0)
                                    {
                                        start = size[i] + start;
                                    }
                                    if(v.IndexOf(':') < (v.Length - 1))
                                    {
                                        if(!int.TryParse(v.Substring(v.IndexOf(':') + 1), out end))
                                        {
                                            Marshal.FreeHGlobal((IntPtr)begin);
                                            throw new ArgumentException("Bad string range format. Should be ':<end>', '<start>:<end>', ':' or '<index>'.");
                                        }
                                        if(end < 0)
                                        {
                                            end = size[i] + end;
                                        }
                                    }
                                }
                            }
                            if(start >= end)
                            {
                                Marshal.FreeHGlobal((IntPtr)begin);
                                throw new ArgumentException("The initial index of the slice must not exceed the final index.");
                            }
                            if(v.IndexOf(':') == -1)
                            {
                                if(start >= size[i])
                                {
                                    Marshal.FreeHGlobal((IntPtr)begin);
                                    throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of dimension {1}.", start, i));
                                }
                            }
                            if((start >= size[i]) || (end > size[i]))
                            {
                                Marshal.FreeHGlobal((IntPtr)begin);
                                throw new IndexOutOfRangeException(string.Format("Slice [{0}:{1}] is out of range of dimension {2}.", start, end, i));
                            }
                            begin[i] = start;
                            size[i] = end - start;
                        }
                        else
                        {
                            if(locs[i] is int)
                            {
                                begin[i] = (int)locs[i];
                                if(begin[i] < 0)
                                {
                                    begin[i] = size[i] + begin[i];
                                }
                                if(begin[i] >= size[i])
                                {
                                    Marshal.FreeHGlobal((IntPtr)begin);
                                    throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of dimension {1}.", begin[i], i));
                                }
                                size[i] = 1;
                                squeeze[i] = true;
                            }
                            else
                            {
                                if(locs[i] is uint)
                                {
                                    begin[i] = (int)(uint)locs[i];
                                    if(begin[i] < 0)
                                    {
                                        begin[i] = size[i] + begin[i];
                                    }
                                    if(begin[i] >= size[i])
                                    {
                                        Marshal.FreeHGlobal((IntPtr)begin);
                                        throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of dimension {1}.", begin[i], i));
                                    }
                                    size[i] = 1;
                                    squeeze[i] = true;
                                }
                                else
                                {
                                    if(locs[i] is long)
                                    {
                                        begin[i] = (int)(long)locs[i];
                                        if(begin[i] < 0)
                                        {
                                            begin[i] = size[i] + begin[i];
                                        }
                                        if(begin[i] >= size[i])
                                        {
                                            Marshal.FreeHGlobal((IntPtr)begin);
                                            throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of dimension {1}.", begin[i], i));
                                        }
                                        size[i] = 1;
                                        squeeze[i] = true;
                                    }
                                    else
                                    {
                                        if(locs[i] is ulong)
                                        {
                                            begin[i] = (int)(ulong)locs[i];
                                            if(begin[i] < 0)
                                            {
                                                begin[i] = size[i] + begin[i];
                                            }
                                            if(begin[i] >= size[i])
                                            {
                                                Marshal.FreeHGlobal((IntPtr)begin);
                                                throw new IndexOutOfRangeException(string.Format("Index {0} is out of range of dimension {1}.", begin[i], i));
                                            }
                                            size[i] = 1;
                                            squeeze[i] = true;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var y_size = new List<int>();
                    for(int i = 0; i < this.shape.Count; ++i)
                    {
                        if(!squeeze[i])
                        {
                            y_size.Add(size[i]);
                        }
                    }
                    var y = new Tensor(y_size, this.dtype, this.device, this.requires_grad);
                    fixed(int* psize = size)
                    {
                        this.device.__backend.slice_get(this.storage, this.shape.__data_ptr, begin, y.storage, psize, this.shape.Count);
                    }
                    if(y.requires_grad)
                    {
                        y.backward_fn = () =>
                        {
                            fixed(int* psize = size)
                            {
                                this.device.__backend.slice_get_backward(this.grad.storage, this.shape.__data_ptr, begin, y.grad.storage, psize, this.shape.Count);
                            }
                            Marshal.FreeHGlobal((IntPtr)begin);
                            if(this.backward_fn != null)
                            {
                                this.backward_fn();
                            }
                        };
                        y.grad_fn = "SliceBackward";
                    }
                    else
                    {
                        Marshal.FreeHGlobal((IntPtr)begin);
                    }
                    return y;
                }

            }

            #endregion

            #region Internal utils

            /// <summary>
            /// Represents a multidimensional index as a one-dimensional one.
            /// </summary>
            /// <param name="indexes">Indexes.</param>
            /// <returns>One-dimensional index.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            internal int loc_to_index(int* indexes)
            {
                if(this.shape.Count == 0)
                {
                    return 0;
                }
                else
                {
                    if(this.shape.Count == 1)
                    {
                        return indexes[0];
                    }
                }
                var ilen = this.shape.Count;
                var index = 0;
                var size = this.shape.__data_ptr;
                for(int i = 0; i < (ilen - 1); ++i)
                {
                    index += indexes[i];
                    index *= size[i + 1];
                }
                index += indexes[ilen - 1];
                return index;
            }

            #endregion

            #region ToString

            /// <summary>
            /// Converts tensor data into a string representation by recursively traversing tensor dimensions.
            /// </summary>
            /// <param name="base">String representation.</param>
            /// <param name="dim">Current measurement.</param>
            /// <param name="indices">Current indexes.</param>
            /// <param name="data">Tensor data.</param>
            /// <param name="dtype">Data type.</param>
            /// <param name="format">A format string used to convert tensor values to a string representation.</param>
            private void recursive_unrolling(ref string @base, int dim, int* indices, void* data, DType dtype, string format)
            {
                switch(dtype)
                {
                    case torch.float8:
                    {
                        var pdata = (Quarter*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.float16:
                    {
                        var pdata = (Half*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.bfloat16:
                    {
                        var pdata = (BFloat16*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.float32:
                    {
                        var pdata = (float*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.float64:
                    {
                        var pdata = (double*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.complex16:
                    {
                        var pdata = (CQuarter*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.complex32:
                    {
                        var pdata = (CHalf*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.complex64:
                    {
                        var pdata = (CFloat*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.complex128:
                    {
                        var pdata = (CDouble*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.int8:
                    {
                        var pdata = (sbyte*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.uint8:
                    {
                        var pdata = (byte*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.int16:
                    {
                        var pdata = (short*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.uint16:
                    {
                        var pdata = (ushort*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.int32:
                    {
                        var pdata = (int*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.uint32:
                    {
                        var pdata = (uint*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.int64:
                    {
                        var pdata = (long*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.uint64:
                    {
                        var pdata = (ulong*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                    case torch.@bool:
                    {
                        var pdata = (bool*)data;
                        if(dim > 0)
                        {
                            if(indices[dim - 1] > 0)
                            {
                                @base += "       ";
                                for(int i = 0; i < dim; ++i)
                                {
                                    @base += " ";
                                }
                            }
                        }
                        @base += "[";
                        if((dim + 1) == this.shape.Count)
                        {
                            for(int i = 0; i < this.shape[dim]; ++i)
                            {
                                indices[dim] = i;
                                @base += string.Format(format, pdata[this.loc_to_index(indices)]) + (((i + 1) == this.shape[dim]) ? "" : ", ");
                            }
                        }
                        else
                        {
                            for(int i = 0; i < this.shape[dim]; i++)
                            {
                                indices[dim] = i;
                                recursive_unrolling(ref @base, dim + 1, indices, data, dtype, format);
                            }
                        }
                        @base += "]";
                        if(dim > 0)
                        {
                            if((indices[dim - 1] + 1) != this.shape[dim - 1])
                            {
                                @base += ",";
                                var n = this.shape.Count - dim;
                                for(int i = 0; i < n; i++)
                                {
                                    @base += (char)10;
                                }
                            }
                        }
                        break;
                    }
                }
            }

            /// <summary>
            /// Returns a format string for a Quarter array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(Quarter* x, int length)
            {
                var max = Quarter.MinValue;
                var min = Quarter.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a Half array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(Half* x, int length)
            {
                var max = Half.MinValue;
                var min = Half.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a BFloat16 array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(BFloat16* x, int length)
            {
                var max = BFloat16.MinValue;
                var min = BFloat16.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a float array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(float* x, int length)
            {
                var max = float.MinValue;
                var min = float.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a double array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(double* x, int length)
            {
                var max = double.MinValue;
                var min = double.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a CQuarter array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(CQuarter* x, int length)
            {
                var max = Quarter.MinValue;
                var min = Quarter.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i].Real;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                    v = x[i].Imaginary;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a CHalf array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(CHalf* x, int length)
            {
                var max = Half.MinValue;
                var min = Half.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i].Real;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                    v = x[i].Imaginary;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a CBFloat16 array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(CBFloat16* x, int length)
            {
                var max = BFloat16.MinValue;
                var min = BFloat16.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i].Real;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                    v = x[i].Imaginary;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a CFloat array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(CFloat* x, int length)
            {
                var max = float.MinValue;
                var min = float.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i].Real;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                    v = x[i].Imaginary;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a CDouble array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(CDouble* x, int length)
            {
                var max = double.MinValue;
                var min = double.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i].Real;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                    v = x[i].Imaginary;
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "7:0.####}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a byte array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(byte* x, int length)
            {
                return "{0,3}";
            }

            /// <summary>
            /// Returns a format string for a sbyte array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(sbyte* x, int length)
            {
                return "{0,4}";
            }

            /// <summary>
            /// Returns a format string for a short array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(short* x, int length)
            {
                var max = short.MinValue;
                var min = short.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for an ushort array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(ushort* x, int length)
            {
                var max = ushort.MinValue;
                var min = ushort.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if(max >= 10000)
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a int array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(int* x, int length)
            {
                var max = int.MinValue;
                var min = int.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for an uint array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(uint* x, int length)
            {
                var max = uint.MinValue;
                var min = uint.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if(max >= 10000)
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a long array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(long* x, int length)
            {
                var max = long.MinValue;
                var min = long.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if((max >= 10000) || (min <= -10000))
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for an ulong array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(ulong* x, int length)
            {
                var max = ulong.MinValue;
                var min = ulong.MaxValue;
                for(int i = 0; i < length; ++i)
                {
                    var v = x[i];
                    if(v > max)
                    {
                        max = v;
                    }
                    if(v < min)
                    {
                        min = v;
                    }
                }
                var format = "{0,";
                if(max >= 10000)
                {
                    format += "10:e2}";
                }
                else
                {
                    format += "5}";
                }
                return format;
            }

            /// <summary>
            /// Returns a format string for a boolean array.
            /// </summary>
            /// <param name="x">Pointer to array.</param>
            /// <param name="length">The length of the array.</param>
            /// <returns>Format string.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            private static string __ArrayController(bool* x, int length)
            {
                return "{0,5}";
            }

            /// <summary>
            /// Converts the current Tensor class object to a readable string representation.
            /// </summary>
            /// <returns>String representation.</returns>
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public override string ToString()
            {
                var data = this.storage.data_ptr;
                if(this.shape.Count == 0)
                {
                    switch(this.dtype)
                    {
                        case torch.float8:
                        {
                            return "tensor(" + (*(Quarter*)data).ToString() + ", dtype = torch.float8" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.float16:
                        {
                            return "tensor(" + (*(Half*)data).ToString() + ", dtype = torch.float16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.bfloat16:
                        {
                            return "tensor(" + (*(BFloat16*)data).ToString() + ", dtype = torch.bfloat16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.float32:
                        {
                            return "tensor(" + (*(float*)data).ToString() + ", dtype = torch.float32" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.float64:
                        {
                            return "tensor(" + (*(double*)data).ToString() + ", dtype = torch.float64" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.complex16:
                        {
                            return "tensor(" + (*(CQuarter*)data).ToString() + ", dtype = torch.complex16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.complex32:
                        {
                            return "tensor(" + (*(CHalf*)data).ToString() + ", dtype = torch.complex32" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.cbfloat16:
                        {
                            return "tensor(" + (*(CBFloat16*)data).ToString() + ", dtype = torch.bcomplex32" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.complex64:
                        {
                            return "tensor(" + (*(CFloat*)data).ToString() + ", dtype = torch.complex64" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.complex128:
                        {
                            return "tensor(" + (*(CDouble*)data).ToString() + ", dtype = torch.complex128" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                        }
                        case torch.int8:
                        {
                            return "tensor(" + (*(sbyte*)data).ToString() + ", dtype = torch.int8)";
                        }
                        case torch.uint8:
                        {
                            return "tensor(" + (*(byte*)data).ToString() + ", dtype = torch.uint8)";
                        }
                        case torch.int16:
                        {
                            return "tensor(" + (*(short*)data).ToString() + ", dtype = torch.int16)";
                        }
                        case torch.uint16:
                        {
                            return "tensor(" + (*(ushort*)data).ToString() + ", dtype = torch.int16)";
                        }
                        case torch.int32:
                        {
                            return "tensor(" + (*(int*)data).ToString() + ", dtype = torch.int32)";
                        }
                        case torch.uint32:
                        {
                            return "tensor(" + (*(uint*)data).ToString() + ", dtype = torch.int32)";
                        }
                        case torch.int64:
                        {
                            return "tensor(" + (*(long*)data).ToString() + ", dtype = torch.int64)";
                        }
                        case torch.uint64:
                        {
                            return "tensor(" + (*(ulong*)data).ToString() + ", dtype = torch.int64)";
                        }
                        case torch.@bool:
                        {
                            return "tensor(" + (*(bool*)data).ToString() + ", dtype = torch.bool)";
                        }
                    }
                }
                var indices = (int*)Marshal.AllocHGlobal(this.shape.Count * sizeof(int)).ToPointer();
                for(int i = 0; i < this.shape.Count; ++i)
                {
                    indices[i] = 0;
                }
                switch(this.dtype)
                {
                    case torch.float8:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((Quarter*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.float8" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.float16:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((Half*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.float16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.bfloat16:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((BFloat16*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.bfloat16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.float32:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((float*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.float32" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.float64:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((double*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.float64" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.complex16:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((CQuarter*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.complex16" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.complex32:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((CHalf*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.complex32" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.complex64:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((CFloat*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.complex64" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.complex128:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((CDouble*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.complex128" + (this.requires_grad ? ", requires_grad = true" : "") + ((this.grad_fn != null) ? (", grad_fn = " + this.grad_fn) : "") + ")";
                    }
                    case torch.int8:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((sbyte*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.int8)";
                    }
                    case torch.uint8:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((byte*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.uint8)";
                    }
                    case torch.int16:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((short*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.int16)";
                    }
                    case torch.uint16:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((ushort*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.uint16)";
                    }
                    case torch.int32:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((int*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.int32)";
                    }
                    case torch.uint32:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((uint*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.uint32)";
                    }
                    case torch.int64:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((long*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.int64)";
                    }
                    case torch.uint64:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((ulong*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.uint64)";
                    }
                    case torch.@bool:
                    {
                        var @base = "tensor(";
                        this.recursive_unrolling(ref @base, 0, indices, data, dtype, __ArrayController((bool*)data, this.storage.size));
                        Marshal.FreeHGlobal((IntPtr)indices);
                        return @base + ", dtype = torch.bool)";
                    }
                }
                Marshal.FreeHGlobal((IntPtr)indices);
                return "tensor()";
            }

            #endregion

        }

    }

}
//***************************************************************************************************
//* (C) ColorfulSoft corp., 2019-2022. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************
using System;

namespace System.AI
{

    public static unsafe partial class torch
    {

        /// <summary>
        /// Interface for any torch.NET backend.
        /// </summary>
        internal interface IBackend
        {

            #region void convert(<Type>* source, Storage destination)

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(Quarter* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(Half* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(BFloat16* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(float* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(double* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(CQuarter* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(CHalf* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(CBFloat16* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(CFloat* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(CDouble* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(sbyte* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(byte* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(short* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(ushort* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(int* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(uint* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(long* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(ulong* source, Storage destination);

            /// <summary>
            /// Copies the data by the source pointer to the destination storage with converting the
            /// source data type to the data type of the target storage.
            /// </summary>
            /// <param name="source">A pointer to the source data.</param>
            /// <param name="destination">Target storage.</param>
            void convert(bool* source, Storage destination);

            #endregion

            #region void <initialization>(Storage destination)

            /// <summary>
            /// Fills the destination storage with default values for its data type.
            /// For numeric types, the default value is 0, for boolean - false.
            /// </summary>
            /// <param name="destination">The storage being cleaned up.</param>
            void zeros(Storage destination);

            #endregion

            #region void <operation>(Storage source, Storage destination)

            /// <summary>
            /// Calculates the absolute value for each storage item.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            void abs(Storage source, Storage destination);

            /// <summary>
            /// Calculates the sine value for each source storage element.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            void sin(Storage source, Storage destination);

            /// <summary>
            /// Calculates the cosine value for each source storage element.
            /// </summary>
            /// <param name="source">Storage with source data.</param>
            /// <param name="destination">The storage to which the result of the operation will be recorded.</param>
            void cos(Storage source, Storage destination);

            #endregion

            #region void <operation>_backward([optional] Storage source, Storage source_grad, [optional] Storage destination, Storage destination_grad)

            /// <summary>
            /// Performs the error back propagation through the operation of extracting the absolute value.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination">Storage of the result values.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            void abs_backward(Storage source, Storage source_grad, Storage destination, Storage destination_grad);

            /// <summary>
            /// Performs the error back propagation through the operation of calculating the sine.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            void sin_backward(Storage source, Storage source_grad, Storage destination_grad);

            /// <summary>
            /// Performs the error back propagation through the operation of calculating the cosine.
            /// </summary>
            /// <param name="source">Storage of the original values.</param>
            /// <param name="source_grad">Storage of input data gradients, where the calculated error will be accumulated.</param>
            /// <param name="destination_grad">Storage with gradients for the result.</param>
            void cos_backward(Storage source, Storage source_grad, Storage destination_grad);

            #endregion

            #region Slicing ops

            void slice_get(Storage source, int* source_shape, int* begin_slice, Storage destination, int* destination_shape, int ndim);

            void slice_get_backward(Storage source_grad, int* source_shape, int* begin_slice, Storage destination_grad, int* destination_shape, int ndim);

            #endregion

        }

    }

}

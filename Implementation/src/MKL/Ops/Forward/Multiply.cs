//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 20.01.2021

using System;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace System
{

    namespace AI
    {

        internal static partial class MKL
        {

            #region Multiply

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(Half[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(float[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(double[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, sbyte[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (sbyte)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, byte[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (byte)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, short[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (short)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(byte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, sbyte[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (sbyte)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, sbyte[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (sbyte)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, short[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (short)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(sbyte[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, short[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (short)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, short[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (short)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, short[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = (short)(aval * bval);
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(short[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, int[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(int[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, sbyte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, byte[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, short[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, int[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static void Multiply(long[] a, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, long[] b, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, long[] y, int[] y_shape, int[] y_strides)
            {
                for(int i = 0; i < y.Length; ++i)
                {
                    var resi = i;
                    int aIndex = 0;
                    int aShapeDim = 0;
                    int bIndex = 0;
                    int bShapeDim = 0;
                    for(int j = 0; j < y_shape.Length; j++)
                    {
                        int current = 0;
                        if(j == (y_shape.Length - 1))
                        {
                            current = resi;
                        }
                        else
                        {
                            if(y_shape.Length == 1)
                            {
                                current = resi;
                            }
                            else
                            {
                                current = (int)Math.Floor(resi / (float)y_strides[j]);
                                resi -= current * y_strides[j];
                            }
                        }
                        int locIndex = current;
                        if(j >= (y_shape.Length - a_shape.Length))
                        {
                            int temp = locIndex;
                            if(a_broadcast_dims[aShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(a.Length == 1)
                            {
                                aIndex = 0;
                            }
                            else
                            {
                                if(a_strides.Length == 0)
                                {
                                    aIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        aIndex += a_strides[aShapeDim] * temp;
                                        aShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            aIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                        if(j >= (y_shape.Length - b_shape.Length))
                        {
                            int temp = locIndex;
                            if(b_broadcast_dims[bShapeDim] > 0)
                            {
                                temp = 0;
                            }
                            if(b.Length == 1)
                            {
                                bIndex = 0;
                            }
                            else
                            {
                                if(b_strides.Length == 0)
                                {
                                    bIndex = temp;
                                }
                                else
                                {
                                    if(j < (y_shape.Length - 1))
                                    {
                                        bIndex += b_strides[bShapeDim] * temp;
                                        bShapeDim++;
                                    }
                                    else
                                    {
                                        if(j == (y_shape.Length - 1))
                                        {
                                            bIndex += temp;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    var aval = a[aIndex];
                    var bval = b[bIndex];
                    y[i] = aval * bval;
                }
            }

            #endregion

        }

    }

}
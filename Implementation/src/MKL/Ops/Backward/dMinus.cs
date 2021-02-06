//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

//-> Latest commit: Brykin Gleb, 18.01.2021

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

            #region Minus

            public static void dMinus(Half[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, Half[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            public static void dMinus(Half[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += (Half)dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += (Half)dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            public static void dMinus(Half[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += (Half)dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += (Half)dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            public static void dMinus(float[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= (Half)dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= (Half)dy[i];
                        }
                    }
                }
            }

            public static void dMinus(float[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, float[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            public static void dMinus(float[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += (float)dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += (float)dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            public static void dMinus(double[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, Half[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= (Half)dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= (Half)dy[i];
                        }
                    }
                }
            }

            public static void dMinus(double[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, float[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= (float)dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= (float)dy[i];
                        }
                    }
                }
            }

            public static void dMinus(double[] da, int[] a_shape, int[] a_strides, int[] a_broadcast_dims, double[] db, int[] b_shape, int[] b_strides, int[] b_broadcast_dims, double[] dy, int[] y_shape, int[] y_strides)
            {
                var numel_a = 1;
                for(int i = 0; i < a_shape.Length; i++)
                {
                    numel_a *= a_shape[i];
                }
                var numel_b = 1;
                for(int i = 0; i < b_shape.Length; i++)
                {
                    numel_b *= b_shape[i];
                }
                if(da != null)
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(db.Length == 1)
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
                            da[aIndex] += dy[i];
                            db[bIndex] -= dy[i];
                        }
                    }
                    else
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(da.Length == 1)
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
                                    if(numel_b == 1)
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
                            da[aIndex] += dy[i];
                        }
                    }
                }
                else
                {
                    if(db != null)
                    {
                        for(int i = 0; i < dy.Length; ++i)
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
                                    if(numel_a == 1)
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
                                    if(db.Length == 1)
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
                            db[bIndex] -= dy[i];
                        }
                    }
                }
            }

            #endregion

        }

    }

}
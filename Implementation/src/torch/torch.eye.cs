//***************************************************************************************************
//* (C) ColorfulSoft corp., 2020. All rights reserved.
//* The code is available under the Apache-2.0 license. Read the License for details.
//***************************************************************************************************

using System;
using System.IO;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public static Tensor eye(int n, int m = -1, DType dtype = torch.float32, bool requires_grad = false)
            {
                if(m == -1)
                {
                    m = n;
                }
                var y = new Tensor(n, m, dtype, requires_grad);
                switch(dtype)
                {
                    case torch.float16:
                    {
                        MKL.Eye(y.__half, n, m);
                        return y;
                    }
                    case torch.float32:
                    {
                        MKL.Eye(y.__float, n, m);
                        return y;
                    }
                    case torch.float64:
                    {
                        MKL.Eye(y.__double, n, m);
                        return y;
                    }
                    case torch.int8:
                    {
                        MKL.Eye(y.__int8, n, m);
                        return y;
                    }
                    case torch.uint8:
                    {
                        MKL.Eye(y.__uint8, n, m);
                        return y;
                    }
                    case torch.int16:
                    {
                        MKL.Eye(y.__int16, n, m);
                        return y;
                    }
                    case torch.int32:
                    {
                        MKL.Eye(y.__int32, n, m);
                        return y;
                    }
                    case torch.int64:
                    {
                        MKL.Eye(y.__int64, n, m);
                        return y;
                    }
                    case torch.@bool:
                    {
                        MKL.Eye(y.__bool, n, m);
                        return y;
                    }
                }
                return y;
            }

        }

    }

}
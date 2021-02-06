using System;
using System.Collections.Generic;

namespace System
{

    namespace AI
    {

        public static partial class torch
        {

            public sealed class SerializableObject
            {

                internal Tensor __as_tensor;

                internal Dictionary<string, Tensor> __as_state_dict;

                private SerializableObject(Dictionary<string, Tensor> state_dict)
                {
                    this.__as_state_dict = state_dict;
                }

                private SerializableObject(Tensor data)
                {
                    this.__as_tensor = data;
                }

                public static implicit operator SerializableObject(Dictionary<string, Tensor> state_dict)
                {
                    return new SerializableObject(state_dict);
                }

                public static implicit operator SerializableObject(Tensor data)
                {
                    return new SerializableObject(data);
                }

                public static implicit operator Tensor(SerializableObject obj)
                {
                    if((object)obj.__as_tensor == null)
                    {
                        throw new ArgumentException("torch.SerializableObjectException: Not a tensor object.");
                    }
                    return obj.__as_tensor;
                }

                public static implicit operator Dictionary<string, Tensor>(SerializableObject obj)
                {
                    if(obj.__as_state_dict == null)
                    {
                        throw new ArgumentException("torch.SerializableObjectException: Not a state dict.");
                    }
                    return obj.__as_state_dict;
                }

                public override string ToString()
                {
                    return (this.__as_state_dict == null) ? this.__as_tensor.ToString() : this.__as_state_dict.ToString();
                }

            }

        }

    }

}
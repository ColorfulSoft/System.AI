# Data types of Torch.NET

## Missing PyTorch types

| Type | The reasons for the absence |
| ------------- | ------------- |
| torch.half(torch.float16) | The lack of hardware support on the CPU, on the GPU is used very rarely. The software implementation is very slow. |
| torch.double(torch.float64) | Not used in machine learning due to redundancy. |
| torch.int8 | Not used in machine learning. |
| torch.int16 | Not used in machine learning. |
| torch.int32 | Not used in machine learning. |
| torch.bool | The logical type is usually imitated via uint8, so a separate type is not required.|

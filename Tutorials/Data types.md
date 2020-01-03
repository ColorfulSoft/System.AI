# Data types of Torch.NET

## Missing PyTorch types

| Type | The reasons for the absence |
| ------------- | ------------- |
| torch.half(torch.float16) | The lack of hardware support on the CPU, on the GPU is used very rarely. The software implementation is very slow. |
| `torch.double(torch.float64)` | Not used in machine learning due to redundancy. |
| `torch.int8` | Not used in machine learning. |
| `torch.int16` | Not used in machine learning. |
| `torch.int32` | Not used in machine learning. |
| `torch.bool` | The logical type is usually imitated via uint8, so a separate type is not required.|

Torch.NET - this is a framework with a strict type system that does not allow you to make mistakes.

## The types available in Torch.NET

| Type | Usage |
|------|-------|
| `torch.uint8` | Logical operations. |
| `torch.long` | The index operations. |
| `torch.float(torch.float32)` | Data processing, neural network parameters. |

## Usage of data types

Data types in Torch.NET - this is a label for tensor initialization methods that allows you to select a specific type of storage within the tensor. The data type is a constant of the `torch.dtype` enum. You can manually set the `dtype` type as shown in the example.

C#:

```C#
var a = torch.zeros(2, 2, dtype: torch.uint8);
```
## Default data type

As in PyTorch, Torch.NET has a default data type that will be used when creating template tensors (via random number generators, sequences, ones, or zeros). It is initially installed as a `torch.float`, however, can be changed via calling the `torch.set_default_tensor_type()` method.

C#:

```C#
torch.set_default_tensor_type(torch.uint8);
```

The default data type can be obtained by accessing the `torch.default_dtype` property.

C#:

```C#
Console.WriteLine(torch.default_dtype);
```

## Limitations of data types

In Torch.NET there is a strict differentiation of the scope of different types of data. This entails restrictions on the use of certain operations for a particular data type. For example, we can't call a two-dimensional convolution for an integer data type tensor, but we can do it for a floating point data type tensor.

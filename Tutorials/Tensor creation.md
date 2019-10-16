# Tensor creation
## From a given data
### From standard .NET number

The simplest way to create the torch.Tensor is explicit conversion from the standard .NET number.

C#:

```C#
Half h = 1;
Single f = 2;
Double d = 3;
Byte b = 4;
var half_tensor = (Tensor)h;
var float_tensor = (Tensor)f;
var double_tensor = (Tensor)d;
var byte_tensor = (Tensor)b;
```

PascalABC.NET:

```Pascal
var h: Half := 1;
var f: Single := 2;
var d: Double := 3;
var b: Byte := 4;
var half_tensor := Tensor(h);
var float_tensor := Tensor(f);
var double_tensor := Tensor(d);
var byte_tensor := Tensor(b);
```

In this case, our tensor will have the same data type, as input .NET number. Let's check this!

C#:

```C#
Console.WriteLine(half_tensor);
Console.WriteLine(float_tensor);
Console.WriteLine(double_tensor);
Console.WriteLine(byte_tensor);
```

PascalABC.NET:

```Pascal
Console.WriteLine(half_tensor);
Console.WriteLine(float_tensor);
Console.WriteLine(double_tensor);
Console.WriteLine(byte_tensor);
```

This code will write the following text:

```
Torch.Tensor(1, dtype=half)
Torch.Tensor(2, dtype=float)
Torch.Tensor(3, dtype=double)
Torch.Tensor(4, dtype=uint8)
```

Explicit conversion does not support the initialization-time type conversion, i.e. tensor's type always will be equal to input data type. Explicit conversion returns 0-dim tensors. If you convert Half, Single(float), Double(double) to tensor, the resulting tensor will have a gradient.

### From standard .NET array

Another initialization option is to create tensors from standard .NET arrays. The designers of the torch.Tensor supports one-dimensional and multidimensional arrays of all standard .NET numeric types. For example, let's create the tensor from a 1-dim Half array.

C#:

```C#
var half_array = new Half[]{(Half)1.5, (Half)2.3, 5, 3, (Half)(-1.2)};
var t = new Tensor(half_array);
Console.WriteLine(t);
```

PascalABC.NET:

```Pascal
var half_array := new Half[](Half(1.5), Half(2.3), 5, 3, Half(-1.2));
var t := new Tensor(half_array);
Console.WriteLine(t);
```

This code should return the following message:

```
UserWarning: Hardware support for type float16 is not available in the .NET Framework, so a software implementation is used. You should use float32 or float64 to speed up your application.
Torch.Tensor([1.5, 2.298828, 5, 3, -1.199219], dtype=float16)
```
For now, Microsoft .NET Framework does not support hardware work with Half data type on the CPU, so when you try to create a tensor of type Half, a warning will be displayed. This warning is displayed once per program session.

If you want to create a tensor with a data type other than the input, you must use the dtype parameter.

C#:

```C#
var float_array = new float[]{1.5f, 2.3f, 5, 3, -1.2f};
var single = new Tensor(float_array);
var int32 = new Tensor(float_array, dtype: DType.int32);// or var int32 = new Tensor(float_array, DType.int32);
var half = new Tensor(float_array, dtype: DType.float16);// or var half = new Tensor(float_array, DType.float16);
Console.WriteLine(single);
Console.WriteLine(int32);
Console.WriteLine(half);
```

PascalABC.NET:

```Pascal
var float_array := new Single[](1.5, 2.3, 5, 3, -1.2);
var single := new Tensor(float_array);
var int32 := new Tensor(float_array, DType.int32);
var half := new Tensor(float_array, DType.float16);
Console.WriteLine(single);
Console.WriteLine(int32);
Console.WriteLine(half);
```

This code writes the following:

```
Torch.Tensor([1.5, 2.3, 5, 3, -1.2], dtype=float32)
Torch.Tensor([1, 2, 5, 3, -1], dtype=int32)
Torch.Tensor([1.5, 2.298828, 5, 3, -1.199219], dtype=float16)
```

Let's try to initialize the tensor from the multidimensional .NET array.

C#:

```C#
var fm = new float[3, 2];
fm[0, 0] = 1; fm[1, 0] = 2; fm[2, 0] = 3;
fm[0, 1] = 4; fm[1, 1] = 5; fm[2, 1] = 6;
var t = new Tensor(fm);
Console.WriteLine(t);
```

PascalABC.NET:

```Pascal
var fm := new Single[3, 2];
fm[0, 0] := 1; fm[1, 0] := 2; fm[2, 0] := 3;
fm[0, 1] := 4; fm[1, 1] := 5; fm[2, 1] := 6;
var t := new Tensor(fm);
Console.WriteLine(t);
```

If you run that code, you can see this:

```
Torch.Tensor([[1, 2, 3],
              [4, 5, 6]], dtype=float32)
```

Importantly, the input array should be in WHCB format.

### From shape

Sometimes it is necessary to create an empty tensor of certain sizes. To do this, you can use specialized designers.

If you want to create a 0-dim tensor, you should use constructor with two parameters (dtype and requires_grad) and dtype is mandatory.

C#:

```C#
var t = new Tensor(DType.float64);
Console.WriteLine(t);
```

PascalABC.NET:

```Pascal
var t := new Tensor(DType.float64);
Console.WriteLine(t);
```

The code will print this line:

```
Torch.Tensor(0, dtype=float64)
```

By default, the returned tensor have no gradients, but you can create diffirentiable tensor using the following code:

C#:

```C#
var t = new Tensor(DType.float64, true);
Console.WriteLine(t.requires_grad);
```

PascalABC.NET:

```Pascal
var t := new Tensor(DType.float64, True);
Console.WriteLine(t.requires_grad);
```

This code will print `True`, but if you will try to create bool or integer tensor with gradients, the following exception will be ocurred:

```
TorchException: Only Tensors of floating point dtype can require gradients.
```

Another way is used to create multidimensional tensors.

C#:

```C#
var t = new Tensor(2, 2, 3);
Console.WriteLine(t);
```

PascalABC.NET:

```Pascal
var t := new Tensor(2, 2, 3);
Console.WriteLine(t);
```

This code will print the following:

```
Torch.Tensor([[[0, 0],
               [0, 0]],

              [[0, 0],
               [0, 0]],

              [[0, 0],
               [0, 0]]], dtype=float32)
```

By default, all tensors will be initialized in float32 data type. You can change default data type using instruments in torch.Torch.
If you want to create the tensor of different type, you should pass destination DType to designer's parameter "dtype".

C#:

```C#
var t = new Tensor(2, 3, 4, dtype: DType.int8);
```

PascalABC.NET does not support positional arguments, so you should fill all the rest dimensions by 1 and fill "requires_grad" parameter(**only floating point tensors can require gradients!**)

PascalABC.NET:
```Pascal
var t := new Tensor(2, 2, 3, 1, 1, False, DType.int8);
```

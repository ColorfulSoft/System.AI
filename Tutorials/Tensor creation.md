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

Another initialization option is to create tensors from standard .NET arrays. The designers of the torch.Tensor supports one-dimensional and multidimensional arrays of all standard .NET numeric types.

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

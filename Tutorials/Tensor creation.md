# Tensor creation
## From a given data
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
Explicit conversion does not support the type conversion, i.e. tensor's type always will be equal to input data type. Explicit conversion returns 0-dim tensors. If you convert Half, Single(float), Double(double) to tensor, the resulting tensor will have a gradient.

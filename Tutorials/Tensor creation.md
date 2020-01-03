# Tensor creation
## Usings

Using System namespace for System.Console input/output.

```C#
using System;
```

Using System.AI namespace to access to Torch.NET framework.

```C#
using System.AI;
```

## PyTorch-style tensor creation
### Creation from a given data
#### From standard .NET number

The simplest way to create the torch.Tensor is simple conversion from the standard .NET number.

```C#
Single f = 2;
Byte b = 4;
var float_tensor = torch.tensor(f);
var byte_tensor = torch.tensor(b);
```

In this case, our tensor will have the same data type, as input .NET number. Let's check this!

```C#
Console.WriteLine(float_tensor);
Console.WriteLine(byte_tensor);
```

This code will write the following text:

```
tensor(2, dtype=float32)
tensor(4, dtype=uint8)
```

If you want to create a tensor with a data type other than the input, you must use the dtype parameter.

```C#
Single d = 3;
Byte b = 4;
var byte_tensor = torch.tensor(d, dtype: torch.uint8);
var single_tensor = torch.tensor(b, dtype: torch.float32);
```

It will write the following:

```
tensor(4, dtype=float32)
tensor(3, dtype=uint8)
```

By default, the returned tensor have no gradients, but you can create diffirentiable tensor using the following code:

```C#
float f = 1f;
var variable_t = torch.tensor(f, dtype: torch.float32, requires_grad: true);
Console.WriteLine(variable_t);
```

```
tensor(1, dtype=float32, requires_grad=true)
```

#### From standard .NET array

Another initialization option is to create tensors from standard .NET arrays. The designers of the `torch.Tensor` supports one-dimensional and multidimensional arrays of all standard .NET numeric types. For example, let's create the tensor from a 1-dim float array.

```C#
var float_array = new float[]{1.5f, 2.3f, 5, 3, -1.2f};
var t = torch.tensor(float_array);
Console.WriteLine(t);
```

This code should return the following message:

```
tensor([1.5, 2.298828, 5, 3, -1.199219], dtype=float32)
```

If you want to create a tensor with a data type other than the input, you must use the dtype parameter.

```C#
var float_array = new float[]{1.5f, 2.3f, 5, 3, -1.2f};
var single = torch.tensor(float_array);
var int64 = torch.tensor(float_array, dtype: torch.int64);
Console.WriteLine(single);
Console.WriteLine(int64);
```

This code writes the following:

```
tensor([1.5, 2.3, 5, 3, -1.2], dtype=float32)
tensor([1, 2, 5, 3, -1], dtype=long)
```

Let's try to initialize the tensor from the multidimensional .NET array.

```C#
var fm = new float[,]{{1, 2, 3},
                      {4, 5, 6}};
var t = torch.tensor(fm);
Console.WriteLine(t);
```

If you run that code, you can see this:

```
tensor([[1, 2, 3],
        [4, 5, 6]], dtype=float32)
```

### From shape
#### Create a tensor with zeros

Sometimes it is necessary to create an empty tensor of certain sizes. To do this, you can use specialized designers.
This code creates a 0-dimensional tensor with a default data type.

```C#
var t = torch.zeros();
Console.WriteLine(t);
```

The code will print this line:

```
tensor(0, dtype=float32)
```

You can specify the target data type `dtype` and `requires_grad`.

```C#
var t = torch.zeros(dtype.float32, true);
Console.WriteLine(t.requires_grad);
```

This code will print `True`, but if you will try to create integer tensor with gradients, the following exception will be ocurred:

```
TorchException: Only Tensors of floating point dtype can require gradients.
```

Another way is used to create multidimensional tensors of default data type.

```C#
var t = torch.zeros(new long[]{2, 2, 3});
Console.WriteLine(t);
```

This code will print the following:

```
tensor([[[0, 0, 0],
         [0, 0, 0]],

        [[0, 0, 0],
         [0, 0, 0]]], dtype=float32)
```

By default, all tensors will be initialized in `float32` data type. You can change default data type using instruments in torch.
If you want to create the tensor of different type, you should pass destination `DType` to designer's parameter `dtype`.

```C#
var t = torch.zeros(new long[]{2, 3, 4}, dtype: torch.uint8);
```

And the last way to create the tensor is using of instance of `torch.Size` structure.

```C#
var t = torch.zeros(new torch.Size(2, 2));
Console.WriteLine(t);
```

With this code, we create a 2x2 tensor.

```
tensor([[0, 0],
        [0, 0]], dtype=float32)
```

This designer supports `dtype` and `requires_grad` positional arguments.

#### Random initialization from shape

As in PyTorch, you can use random value initialization methods. At the moment, Torch.NET only supports the `torch.randn` and `torch.uniform`.

**torch.randn usage exapmle**

```C#
var t = torch.randn(2, 2, dtype: torch.@float, requires_grad: true);
Console.WriteLine(t);
```

Let's look at the written code. First, torch.randn takes the dimensions of the tensor. They can be passed as a sequence of numbers, an array, and a tuple. Next, there are the dtype and requires_grad parameters, which have default values equal to torch.default_dtype(Please note that this method can only work with floating point tensors) and false respectively. If you run the above code, the console will display something like the following:

```
tensor([[1,19845928947948, -1,44567358515229],
        [-1,44567358515229, 0,78331244965002]], dtype=float32, requires_grad=true)
```

**torch.uniform usage exapmle**

Overall, torch.uniform initializes the tensor with random values in the interval (min, max).

```C#
var t = torch.uniform(2, 2, min: -10, max: 10, dtype: torch.@float, requires_grad: true);
Console.WriteLine(t);
```

Let's look at the written code. First, torch.randn takes the dimensions of the tensor. They can be passed as a sequence of numbers, an array, and a tuple. In addition, torch.uniform requires you to specify min and max values of type double. Next, there are the dtype and requires_grad parameters, which have default values equal to torch.default_dtype(Please note that this method can only work with floating point tensors) and false respectively. If you run the above code, the console will display something like the following:

```
tensor([[4,06107173956049, 4,4880979575627],
        [-6,1454403755001, 4,23170401446135]], dtype=float32, requires_grad=true)
```


## .NET-style tensor creation

You can directly use `torch.Tensor` class constructors to initialize the tensor.

### Creation from a given data
#### From standard .NET number

The simplest way to create the torch.Tensor is explicit conversion from the standard .NET number.

```C#
Single f = 2;
Byte b = 4;
var float_tensor = (torch.Tensor)f;
var byte_tensor = (torch.Tensor)b;
```

In this case, our tensor will have the same data type, as input .NET number. Let's check this!

```C#
Console.WriteLine(float_tensor);
Console.WriteLine(byte_tensor);
```

This code will write the following text:

```
tensor(2, dtype=float32, requires_grad=true)
tensor(4, dtype=uint8)
```

Explicit conversion does not support the initialization-time type conversion, i.e. tensor's type always will be equal to input data type. Explicit conversion returns 0-dim tensors. If you convert Single(float) to tensor, the resulting tensor will have a gradient.

#### From standard .NET array

Another initialization option is to create tensors from standard .NET arrays. The designers of the torch.Tensor supports one-dimensional and multidimensional arrays of all standard .NET numeric types. For example, let's create the tensor from a 1-dim Half array.

```C#
var float_array = new float[]{1.5f, 2.3f, 5f, 3f, -1.2f};
var t = new torch.Tensor(float_array);
Console.WriteLine(t);
```

This code should return the following message:

```
tensor([1.5, 2.298828, 5, 3, -1.199219], dtype=float32)
```

If you want to create a tensor with a data type other than the input, you must use the `dtype` parameter.

```C#
var float_array = new float[]{1.5f, 2.3f, 5, 3, -1.2f};
var single = new Tensor(float_array);
var int64 = new Tensor(float_array, dtype: torch.@long);
Console.WriteLine(single);
Console.WriteLine(int64);
```

This code writes the following:

```
tensor([1.5, 2.3, 5, 3, -1.2], dtype=float32)
tensor([1, 2, 5, 3, -1], dtype=long)
```

Let's try to initialize the tensor from the multidimensional .NET array.

```C#
var fm = new float[,]{{1, 2, 3},
                      {4, 5, 6}};
var t = new torch.Tensor(fm);
Console.WriteLine(t);
```

If you run that code, you can see this:

```
Torch.Tensor([[1, 2, 3],
              [4, 5, 6]], dtype=float32)
```

#### From shape

Sometimes it is necessary to create an empty tensor of certain sizes. To do this, you can use specialized designers.

If you want to create a 0-dim tensor, you should use constructor with two parameters (`dtype` and `requires_grad`) and dtype is mandatory.

```C#
var t = new torch.Tensor(torch.float32);
Console.WriteLine(t);
```

The code will print this line:

```
tensor(0, dtype=float32)
```

By default, the returned tensor have no gradients, but you can create diffirentiable tensor using the following code:

```C#
var t = new torch.Tensor(torch.float32, true);
Console.WriteLine(t.requires_grad);
```

This code will print `True`, but if you will try to create integer tensor with gradients, the following exception will be ocurred:

```
TorchException: Only Tensors of floating point dtype can require gradients.
```

Another way is used to create multidimensional tensors.

```C#
var t = new torch.Tensor(2, 2, 3);
Console.WriteLine(t);
```

This code will print the following:

```
tensor([[[0, 0, 0],
         [0, 0, 0]],

        [[0, 0, 0],
         [0, 0, 0]]], dtype=float32)
```

By default, all tensors will be initialized in `float32` data type. You can change default data type using instruments in `torch`.
If you want to create the tensor of different type, you should pass destination `DType` to designer's parameter `dtype`.

```C#
var t = new torch.Tensor(2, 3, 4, dtype: torch.uint8);
```

And the last way to create the tensor is using of instance of `torch.Size` structure.

```C#
var t = new torch.Tensor(new torch.Size(2, 2));
Console.WriteLine(t);
```

With this code, we create a 2x2 tensor.

```
tensor([[0, 0],
        [0, 0]], dtype=float32)
```

This designer supports `dtype` and `requires_grad` positional arguments.

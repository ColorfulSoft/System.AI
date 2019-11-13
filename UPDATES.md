# Here are the latest news about Torch.NET

* [13.11.2019] Added support for all tensor operations(+, -, *, /).
* [12.11.2019] **Big update: Added + and * operators for tensors. Tensors are translated to BCHW format(as in PyTorch). Fixed a bug in nn.functional.max_pool2d. torch.tanh method added. Improved printing of tensors. Fixed minor bugs.**
* [10.11.2019] torch.Tensor.backward(Tensor gradient) have been implemented. torch.nn.functional.conv2d.forward have been optimized.
* [07.11.2019] Fixed minor bugs. Fixed a bug in the index property setter of the tensor.
* [05.11.2019] Added a base class of the optimizer. Added tensor.requires_grad_(bool requires_grad = true) method. Added methods nn.Module.train and nn.Module.eval.
* [04.11.2019] Functions torch.sin, torch.cos, torch.sinh, torch.cosh, torch.exp have been added.
* [04.11.2019] Added type aliases directly to torch. For example, torch.dtype.float32 can now be used via torch.float32, as in PyTorch.
* [04.11.2019] Added operations torch.acos, torch.asin, torch.atan.
* [04.11.2019] Write access has been added to the index property of the tensor. Added backward functions to the index property.
* [03.11.2019] Added index property of tensor(read-only for now).
* [02.11.2019] Conv2d layer implemented. MaxPool2d layer has been optimized.
* [02.11.2019] torch class has been significantly redesigned. Added initialization function for Tensor to torch class.
* [02.11.2019] Changed the structure of the library to better match the structure of PyTorch. The root namespace has been removed. Instead, there was a static torch class with nested static classes nn and nn.functional. And also sealed torch.Tensor class.
* [02.11.2019] Discontinued support PascalABC.NET due to incomplete language support for .NET Framework functionality.
* [18.10.2019] Added the ability to initialize a tensor from a standard multidimensional array of numeric or logical type.

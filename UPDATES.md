# Here are the latest news about Torch.NET

* [04.11.2019] Write access has been added to the index property of the tensor. Added backward functions to the index property.
* [03.11.2019] Added index property of tensor(read-only for now).
* [02.11.2019] Conv2d layer implemented. MaxPool2d layer has been optimized.
* [02.11.2019] torch class has been significantly redesigned. Added initialization function for Tensor to torch class.
* [02.11.2019] Changed the structure of the library to better match the structure of PyTorch. The root namespace has been removed. Instead, there was a static torch class with nested static classes nn and nn.functional. And also sealed torch.Tensor class.
* [02.11.2019] Discontinued support PascalABC.NET due to incomplete language support for .NET Framework functionality.
* [18.10.2019] Added the ability to initialize a tensor from a standard multidimensional array of numeric or logical type.

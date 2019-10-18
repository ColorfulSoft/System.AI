# Building a neural network
## Tensor, Parameter and Variable

**torch.Tensor** is a multidimensional matrix used to transfer data and gradients between layers and low-level mathematical operations between data.

**nn.Parameter** is a wrapper over the tensor, making it visible to the Module.state_dict and Module.parameters methods. The parameter must be a field of the child class of the Module class.

**autograd.Variable** is a wrapper over a tensor that allows the optimizer to modify a tensor that is not a (module) parameter. For now, you can pass pure tensor to optimizer, but this tensor should require gradient.

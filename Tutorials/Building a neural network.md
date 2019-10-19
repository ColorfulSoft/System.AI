# Building a neural network
## Tensor, Parameter and Variable

**torch.Tensor** is a multidimensional matrix used to transfer data and gradients between layers and low-level mathematical operations between data.

**nn.Parameter** is a wrapper over the tensor, making it visible to the Module.state_dict and Module.parameters methods. The parameter must be a field of the child class of the Module class.

**autograd.Variable** is a wrapper over a tensor that allows the optimizer to modify a tensor that is not a (module) parameter. For now, you can pass pure tensor to optimizer, but this tensor should require gradient.

## Module

torch.nn.Module is a container that allows you to combine several parameters, modules and calculation code to simplify the process of writing a program.

Your module should inherit torch.nn.Module.

The simplest module can be created using following code:

C#:

```C#
using torch;
using torch.nn;

namespace Example
{

    public class MyModule : Module
    {

        private ReLU relu; // Module

        private Parameter alpha; // Parameter

        public MyModule()
        {
            this.relu = new ReLU();
            this.alpha = new Parameter(1f, true);
        }

    }

}
```

PascalABC.NET:

```Pascal
{$Reference 'Release\torch.dll'}

uses System;
uses torch;
uses torch.nn;

type MyUnit = class(Module)

  private relu: ReLU; // Module

  private alpha: Parameter; // Parameter

  public constructor();
  begin
    self.relu := new torch.nn.ReLU();
    self.alpha := new Parameter(1.0);
  end;

end;

begin
  
end.
```

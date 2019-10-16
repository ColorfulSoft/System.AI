# Torch.NET
PyTorch-like framework for AI on Microsoft .NET Framework

# Getting started
## Compiling assembly
* Download and unzip this repository.
* Go to Implementation\ and run Compile.bat.
* All done! Now You can take torch.dll, torch.xml and torch.pdb from the implementation\Release folder and them to your project!

## Check out torch.dll
On C#:
```C#
using System;
using torch;

namespace FirtProgram
{

    public static class Program
    {

        public static void Main()
        {
            Console.WriteLine(Torch.library_info);
        }

    }

}
```

On PascalABC.NET:
```Pascal
{$Reference 'torch.dll'}
uses System;
uses torch;

begin
  Console.WriteLine(Torch.library_info);
end.
```
This code will write "Torch.NET ver. 0.1 -> build 24.09.2019" or another version you are using.

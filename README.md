# Torch.NET
PyTorch-like framework for AI on Microsoft .NET Framework

**Please note that Torch.NET does not copy the syntax and capabilities of PyTorch to the fullest.**

# Supported features
All features supported by Torch.NET at this moment are described in the Tutorials section. If something is not there, then this opportunity has not yet been implemented, but will appear soon. Information about updates can be seen in the Tutorials section or here: https://github.com/ColorfulSoft/Torch.NET/blob/master/UPDATES.md

**GPU calculations are implemented in an extension (separate library). This version includes only CPU Backend implemented in C#. This version is officially cross-platform.**

# Getting started
## System requirements
* Windows XP or later. Windows 7 is recommended. For now, not tested on different OS.
* Microsoft .NET Framework 4.0 and later. For now, not tested on Mono and different versions of MS .NET Framework.
* 128 MB of RAM
* 256 MB of free disk space.

## Compiling assembly
* Download and unzip this repository.
* Go to Implementation\ and run Compile.bat.
* All done! Now You can take torch.dll, torch.xml and torch.pdb from the implementation\Release folder and add them to your project!

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
            Console.ReadLine();
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
  Console.WriteLine(torch.Torch.library_info);
  Console.ReadLine()
end.
```
This code will write "Torch.NET ver. 0.1 -> build 24.09.2019" or another version you are using.

## Tutorials
* Tensor creation: https://github.com/ColorfulSoft/Torch.NET/blob/master/Tutorials/Tensor%20creation.md

More tutorials can be found here: https://github.com/ColorfulSoft/Torch.NET/blob/master/Tutorials

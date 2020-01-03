![Logo](https://github.com/ColorfulSoft/Torch.NET/blob/master/Torch.NET_logo.png)

# Torch.NET

PyTorch-like framework for AI on Microsoft .NET Framework

**Please note that Torch.NET does not copy the syntax and capabilities of PyTorch to the fullest.**

# Supported features
All features supported by Torch.NET at this moment are described in the Tutorials section. If something is not there, then this opportunity has not yet been implemented, but will appear soon. Information about updates can be seen in the Tutorials section or here: https://github.com/ColorfulSoft/Torch.NET/blob/master/UPDATES.md

# Getting started on Windows
## System requirements
* Windows XP or later. Windows 7 is recommended. For now, not tested on different OS.
* Microsoft .NET Framework 4.0 and later. For now, not tested on Mono and different versions of MS .NET Framework.
* 128 MB of RAM
* 256 MB of free disk space.

## Compiling assembly
* Download and unzip this repository.
* Go to Implementation\ and run Compile.bat.
* All done! Now You can take torch.dll and torch.xml from the Implementation\Release folder and add them to your project!

## Check out torch.dll
```C#
using System;
using System.AI;

namespace FirtProgram
{

    public static class Program
    {

        public static void Main()
        {
            Console.WriteLine(torch.library_info);
            Console.ReadLine();
        }

    }

}
```
This code will write "Torch.NET ver. 0.3 -> build 03.01.2020" or another version you are using.

## Tutorials
* Data types: https://github.com/ColorfulSoft/Torch.NET/blob/master/Tutorials/Data%20types.md
* Tensor creation: https://github.com/ColorfulSoft/Torch.NET/blob/master/Tutorials/Tensor%20creation.md

More tutorials can be found here: https://github.com/ColorfulSoft/Torch.NET/blob/master/Tutorials

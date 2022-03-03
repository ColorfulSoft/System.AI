![Logo](https://github.com/ColorfulSoft/System.AI/blob/master/Logo/System.AI_logo.png)

# What is System.AI

System.AI is a stack of machine learning and data analysis technologies for the .NET ecosystem.

# Supported platforms

System.AI is supported by any software and hardware platforms that support the Microsoft .NET Framework or its implementations, such as Microsoft .NET Core, Mono, or Xamarin. The core of the System.AI is written in pure C# and is exclusively managed code.

# Getting started

[![Colab](https://colab.research.google.com/assets/colab-badge.svg)](https://colab.research.google.com/github/ColorfulSoft/System.AI/blob/master/Docs/System.AI.ipynb)

Detailed instructions for launching on different platforms: https://github.com/ColorfulSoft/System.AI/blob/master/Docs/GettingStarted.md

# Libraries included in the System.AI and architecture of the project

|Library                 |Status      |Version |
|:----------------------:|:----------:|:------:|
|System.FloatingPoint    |**stable**  |1.1     |
|imageio.NET             |**stable**  |1.1     |

<details>
  <summary><b>Warning!</b></summary>
  
  Note that the libraries of System.AI basically repeats the interface and behavior of the corresponding analogues from the Python ecosystem, but they do not do it 100%. This is largely due to the difference in topologies .NET and Python. For example, the torch.jit module that exists in PyTorch probably won't be implemented in Torch.NET, since it will not make sense in the case of working in the ecosystem .NET (programs with Torch.NET by themselves are portable and there is no point in making them even more portable with torchscript).
  
</details>

**System.AI is a set of libraries, each of which can be used independently of the others as a component of your product. By default, System.AI is compiled into a set of dynamic libraries, however, it is also possible to compile into a single System.AI.dll library**

# The status of libraries in the System.AI

* **ready** - Development is complete. The library is ready to use. Expansion of the functionality is not planned(but not excluded).
* **stable** - Stable version, ready to use.
* **dev** - Development is underway, and the code will be added soon.
* **prev** - The code is posted for informational purposes and is currently not ready for use in production.

# Update history

* **[03.03.2022]** An updated version of imageio.NET is now available in System.AI 2.0
* **[13.12.2021]** Version 1.1 of the _System.FloatingPoint_ component has been released. The BFloat16 data type is implemented.
* **[12.12.2021]** The restructuring of the project has been launched.
* **[06.02.2021]** The code of ***Torch.NET*** and ***MKL*** is placed __for demonstration purposes__ in the form in which they are at this stage of development. Added the ***PyType.NET*** library.
* **[19.01.2021]** The new version of ***ImageIO.NET*** library is ready to use! _In the new version:_ data format has been changed to HWC, as in imageio for Python, performance of `imageio.imread` and `imageio.imwrite` has been improved.
* **[27.10.2020]** The new version of ***ImageIO.NET*** library is ready to use! Arrays of all standard numeric types are now supported for images. Also, ImageIO.NET now  supports reading and writing images from / to the stream.

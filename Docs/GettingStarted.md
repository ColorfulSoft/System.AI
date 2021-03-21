# Getting started with System.AI

## On Microsoft Windows

### Using Microsoft .NET Framework, w/o IDE

1) Download and unpack the System.AI repository.
2) Go to Implementation folder.
3) Run Compile.bat file.
4) All done! The Release folder with System.AI.dll and System.AI.xml were created.
5) Reference System.AI in your .NET project!

## On Android

### Using C# Shell

1) Install C# Shell from Play Market (C# Shell is an offline C# compiler and the Mono runtime for Android), Liminted free version is available.
1.1)  Official C# Shell release on PlayMarket: https://play.google.com/store/apps/details?id=com.radinc.csharpshell
2) Download and unpack the System.AI repository to your Android device.
3) Run C# Shell, click the "Open file/project" button on the menu tab.
4) In the file manager that opens, go to the unpacked repository.
5) Find and select System.AI.cspro file in the Implementation folder.
6) After selecting the file, click "Export assembly (exe)" in the menu tab.
7) In the window that opens, make sure that "Export assembly (.dll)" is selected and click "Export assembly".
8) Wait for the compilation to complete.
9) The bin folder with the System.AI.dll file will appear in the Implementation folder of the unpacked repository.
10) Reference the Mono binaries of System.AI in the C# project directly on your smartphone!

## On Google Colab

[![Colab](https://colab.research.google.com/assets/colab-badge.svg)](https://colab.research.google.com/github/ColorfulSoft/System.AI/blob/master/Docs/System.AI.ipynb)

Follow the instructions from ipynb to install mono on Google Colab, compile System.AI from source code and run AI projects directly on the server.

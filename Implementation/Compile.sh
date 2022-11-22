mkdir bin
mkdir bin/Release
csc @ConfigurationRel.rsp /out:bin/Release/System.FloatingPoint.dll /doc:bin/Release/System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Unix.rsp
csc @ConfigurationRel.rsp /out:bin/Release/warnings.dll /doc:bin/Release/warnings.xml @src/warnings.NET/warnings.NET.Unix.rsp
csc @ConfigurationRel.rsp /r:bin/Release/System.FloatingPoint.dll /r:bin/Release/warnings.dll /out:bin/Release/imageio.dll /doc:bin/Release/imageio.xml @src/imageio.NET/imageio.NET.Unix.rsp
csc @ConfigurationRel.rsp /r:bin/Release/System.FloatingPoint.dll /out:bin/Release/System.Complex.dll /doc:bin/Release/System.Complex.xml @src/System.Complex/System.Complex.Unix.rsp
csc @ConfigurationRel.rsp /out:bin/Release/PyType.dll /doc:bin/Release/PyType.xml @src/PyType.NET/PyType.NET.Unix.rsp
csc @ConfigurationRel.rsp /r:bin/Release/System.FloatingPoint.dll /r:bin/Release/warnings.dll /out:bin/Release/torchfile.dll /doc:bin/Release/torchfile.xml @src/torchfile.NET/torchfile.NET.Unix.rsp
csc @ConfigurationRel.rsp /out:bin/Release/micrograd.dll /doc:bin/Release/micrograd.xml @src/micrograd.NET/micrograd.NET.Unix.rsp
csc @ConfigurationRel.rsp /out:bin/Release/DotnetExtensions.dll /doc:bin/Release/DotnetExtensionsd.xml @src/DotnetExtensions/DotnetExtensions.Unix.rsp
mkdir bin/Debug
csc @ConfigurationDeb.rsp /out:bin/Debug/System.FloatingPoint.dll /doc:bin/Debug/System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Unix.rsp
csc @ConfigurationDeb.rsp /out:bin/Debug/warnings.dll /doc:bin/Debug/warnings.xml @src/warnings.NET/warnings.NET.Unix.rsp
csc @ConfigurationDeb.rsp /r:bin/Debug/System.FloatingPoint.dll /r:bin/Debug/warnings.dll /out:bin/Debug/imageio.dll /doc:bin/Debug/imageio.xml @src/imageio.NET/imageio.NET.Unix.rsp
csc @ConfigurationDeb.rsp /r:bin/Debug/System.FloatingPoint.dll /out:bin/Debug/System.Complex.dll /doc:bin/Debug/System.Complex.xml @src/System.Complex/System.Complex.Unix.rsp
csc @ConfigurationDeb.rsp /out:bin/Debug/PyType.dll /doc:bin/Debug/PyType.xml @src/PyType.NET/PyType.NET.Unix.rsp
csc @ConfigurationDeb.rsp /r:bin/Debug/System.FloatingPoint.dll /r:bin/Debug/warnings.dll /out:bin/Debug/torchfile.dll /doc:bin/Debug/torchfile.xml @src/torchfile.NET/torchfile.NET.Unix.rsp
csc @ConfigurationDeb.rsp /out:bin/Debug/micrograd.dll /doc:bin/Debug/micrograd.xml @src/micrograd.NET/micrograd.NET.Unix.rsp
csc @ConfigurationDeb.rsp /out:bin/Debug/DotnetExtensions.dll /doc:bin/Debug/DotnetExtensions.xml @src/DotnetExtensions/DotnetExtensions.Unix.rsp
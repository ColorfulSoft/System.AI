mkdir bin
mkdir bin/Release
csc @ConfigurationRel.rsp /out:bin/Release/System.AI.dll /doc:bin/Release/System.AI.xml @src/System.FloatingPoint/System.FloatingPoint.Unix.rsp @src/imageio.NET/imageio.NET.Unix.rsp @src/warnings.NET/warnings.NET.Unix.rsp @src/System.Complex/System.Complex.Unix.rsp @src/PyType.NET/PyType.NET.Unix.rsp @src/torchfile.NET/torchfile.NET.Unix.rsp
mkdir bin/Debug
csc @ConfigurationDeb.rsp /out:bin/Debug/System.AI.dll /doc:bin/Debug/System.AI.xml @src/System.FloatingPoint/System.FloatingPoint.Unix.rsp @src/imageio.NET/imageio.NET.Unix.rsp @src/warnings.NET/warnings.NET.Unix.rsp @src/System.Complex/System.Complex.Unix.rsp @src/PyType.NET/PyType.NET.Unix.rsp @src/torchfile.NET/torchfile.NET.Unix.rsp

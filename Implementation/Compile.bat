md bin
md bin\Release
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\System.FloatingPoint.dll /doc:bin\Release\System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\warnings.dll /doc:bin\Release\warnings.xml @src/warnings.NET/warnings.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /r:bin\Release\System.FloatingPoint.dll /r:bin\Release\warnings.dll /out:bin\Release\imageio.dll /doc:bin\Release\imageio.xml @src/imageio.NET/imageio.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /r:bin\Release\System.FloatingPoint.dll /out:bin\Release\System.Complex.dll /doc:bin\Release\System.Complex.xml @src/System.Complex/System.Complex.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\PyType.dll /doc:bin\Release\PyType.xml @src/PyType.NET/PyType.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /r:bin\Release\System.FloatingPoint.dll /r:bin\Release\warnings.dll /out:bin\Release\torchfile.dll /doc:bin\Release\torchfile.xml @src/torchfile.NET/torchfile.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\micrograd.dll /doc:bin\Release\micrograd.xml @src/micrograd.NET/micrograd.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\DotnetExtensions.dll /doc:bin\Release\DotnetExtensions.xml @src/DotnetExtensions/DotnetExtensions.Windows.rsp
md bin\Debug
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\System.FloatingPoint.dll /doc:bin\Debug\System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\warnings.dll /doc:bin\Debug\warnings.xml @src/warnings.NET/warnings.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /r:bin\Debug\System.FloatingPoint.dll /r:bin\Debug\warnings.dll /out:bin\Debug\imageio.dll /doc:bin\Debug\imageio.xml @src/imageio.NET/imageio.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /r:bin\Debug\System.FloatingPoint.dll /out:bin\Debug\System.Complex.dll /doc:bin\Debug\System.Complex.xml @src/System.Complex/System.Complex.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\PyType.dll /doc:bin\Debug\PyType.xml @src/PyType.NET/PyType.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /r:bin\Debug\System.FloatingPoint.dll /r:bin\Debug\warnings.dll /out:bin\Debug\torchfile.dll /doc:bin\Debug\torchfile.xml @src/torchfile.NET/torchfile.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Debug\micrograd.dll /doc:bin\Debug\micrograd.xml @src/micrograd.NET/micrograd.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Debug\DotnetExtensions.dll /doc:bin\Debug\DotnetExtensions.xml @src/DotnetExtensions/DotnetExtensions.Windows.rsp
cmd.exe

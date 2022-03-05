md bin
md bin\Release
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\System.FloatingPoint.dll /doc:bin\Release\System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\warnings.dll /doc:bin\Release\warnings.xml @src/warnings.NET/warnings.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /r:bin\Release\System.FloatingPoint.dll /r:bin\Release\warnings.dll /out:bin\Release\imageio.dll /doc:bin\Release\imageio.xml @src/imageio.NET/imageio.NET.Windows.rsp
md bin\Debug
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\System.FloatingPoint.dll /doc:bin\Debug\System.FloatingPoint.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\warnings.dll /doc:bin\Debug\warnings.xml @src/warnings.NET/warnings.NET.Windows.rsp
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /r:bin\Debug\System.FloatingPoint.dll /r:bin\Debug\warnings.dll /out:bin\Debug\imageio.dll /doc:bin\Debug\imageio.xml @src/imageio.NET/imageio.NET.Windows.rsp
cmd.exe

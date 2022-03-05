md bin
md bin\Release
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationRel.rsp /out:bin\Release\System.AI.dll /doc:bin\Release\System.AI.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp @src/imageio.NET/imageio.NET.Windows.rsp
md bin\Debug
C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe @ConfigurationDeb.rsp /out:bin\Debug\System.AI.dll /doc:bin\Debug\System.AI.xml @src/System.FloatingPoint/System.FloatingPoint.Windows.rsp @src/imageio.NET/imageio.NET.Windows.rsp
cmd.exe

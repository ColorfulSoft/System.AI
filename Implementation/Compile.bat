set "csc_path=C:\Windows\Microsoft.NET\Framework\v4.0.30319\csc.exe"

md "Release"
"%csc_path%" @"System.AI.rsp"

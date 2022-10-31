# Warnings.NET

The warnings module for the .NET ecosystem. An analogue of the standard Python warnings module.

## API reference

![namespace](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/namespace.png) `System`

* ![staticclass](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/staticclass.png) `warnings`

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `warnings()` **static** _Initializes the warnings module._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `simplefilter(string action, WarningCategory category) -> void` **static** _Sets a simple filter for an action with warnings of a given category._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `warn(object message, WarningCategory category = WarningCategory.UserWarning, int stacklevel = 1) -> void` **static** _Issue a warning, or maybe ignore it or raise an exception. The category argument, if given, must be a warning category class; it defaults to UserWarning. Alternatively, message can be a Warning instance, in which case category will be ignored and message.GetType() will be used. In this case, the message text will be message.ToString(). This function raises an exception if the particular warning issued is changed into an error by the warnings filter._

* * ![enum](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enum.png) `WarningCategory : byte` _Warning categories._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `Warning` _This is the base class of all warning category classes. It is a subclass of Exception._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `UserWarning` _The default category for warn()._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `DeprecationWarning` _Base category for warnings about deprecated features when those warnings are intended for other .NET developers._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `SyntaxWarning` _Base category for warnings about dubious syntactic features._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `RuntimeWarning` _Base category for warnings about dubious runtime features._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `FutureWarning` _Base category for warnings about deprecated features when those warnings are intended for end users of applications that are written in .NET language._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `PendingDeprecationWarning` _Base category for warnings about features that will be deprecated in the future._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `ImportWarning` _Base category for warnings triggered during the process of importing a module._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `UnicodeWarning` _Base category for warnings related to Unicode._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `BytesWarning` _Base category for warnings related to bytes and bytearray._

* * *  ![enumvalue](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/enumvalue.png) `ResourceWarning` _Base category for warnings related to resource usage._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `Warning : Exception`

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Warning(params object[] args) -> Warning` _Initializes the warning object with the specified arguments (data about the problem)._

* * *  ![property](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/property.png) `args -> object[]` **readonly** _Parameters passed when creating the warning instance._

* * *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetHashCode() -> int` **override** _Returns the hash code of the current warning object._

* * *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString() -> string` **override** _Returns a string representation of the current warning object._

* * *  ![virtualmethod](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/virtualmethod.png) `category() -> WarningCategory` **virtual** _Returns the warning category._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `BytesWarning : Warning` _Base category for warnings related to bytes and bytearray._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BytesWarning(params object[] args) -> BytesWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `DeprecationWarning : Warning` _Base category for warnings about deprecated features when those warnings are intended for other .NET developers._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `DeprecationWarning(params object[] args) -> DeprecationWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `FutureWarning : Warning` _Base category for warnings about deprecated features when those warnings are intended for end users of applications that are written in .NET language._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `FutureWarning(params object[] args) -> FutureWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `ImportWarning : Warning` _Base category for warnings triggered during the process of importing a module (ignored by default)._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `ImportWarning(params object[] args) -> ImportWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `PendingDeprecationWarning : Warning` _Base category for warnings about features that will be deprecated in the future (ignored by default)._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `PendingDeprecationWarning(params object[] args) -> PendingDeprecationWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `ResourceWarning : Warning` _Base category for warnings related to resource usage (ignored by default)._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `ResourceWarning(params object[] args) -> ResourceWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `RuntimeWarning : Warning` _Base category for warnings about dubious runtime features._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `RuntimeWarning(params object[] args) -> RuntimeWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `SyntaxWarning : Warning` _Base category for warnings about dubious syntactic features._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `SyntaxWarning(params object[] args) -> SyntaxWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `UnicodeWarning : Warning` _Base category for warnings related to Unicode._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `UnicodeWarning(params object[] args) -> UnicodeWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `UserWarning : Warning` _The default category for warn()._

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `UserWarning(params object[] args) -> UserWarning` _Initializes the warning object with the specified arguments (data about the problem)._

## Code samples

```C#
//reference warnings.dll
using System;

namespace WarningsTest
{

    public static class Program
    {

        public static float Divide(float a, float b)
        {
            if(b == 0)
            {
                warnings.warn("Division by zero.");
            }
            return a / b;
        }

        public static void Main()
        {
            Console.WriteLine(Divide(1f, 0f));
            Console.ReadKey(true);
        }

    }

}
```

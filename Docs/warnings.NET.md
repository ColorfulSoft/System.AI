# Warnings.NET

The warnings module for the .NET ecosystem. An analogue of the standard Python warnings module.

## API reference

![namespace](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/namespace.png) `System`

* ![staticclass](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/staticclass.png) `warnings`

* *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `warnings()` **static** _Initializes the warnings module._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `simplefilter(string action, WarningCategory category) -> void` **static** _Sets a simple filter for an action with warnings of a given category._

* *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) ![static](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/overlaystatic.png) `warn(object message, WarningCategory category = WarningCategory.UserWarning, int stacklevel = 1) -> void` **static** _Issue a warning, or maybe ignore it or raise an exception. The category argument, if given, must be a warning category class; it defaults to UserWarning. Alternatively, message can be a Warning instance, in which case category will be ignored and message.GetType() will be used. In this case, the message text will be message.ToString(). This function raises an exception if the particular warning issued is changed into an error by the warnings filter._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `Warning : Exception`

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `Warning(params object[] args) -> Warning` _Initializes the warning object with the specified arguments (data about the problem)._

* * *  ![property](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/property.png) `args -> object[]` **readonly** _Parameters passed when creating the warning instance._

* * *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `GetHashCode() -> int` **override** _Returns the hash code of the current warning object._

* * *  ![method](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/method.png) `ToString() -> string` **override** _Returns a string representation of the current warning object._

* * *  ![virtualmethod](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/virtualmethod.png) `category() -> WarningCategory` **virtual** _Returns the warning category._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `BytesWarning : Warning`

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `BytesWarning(params object[] args) -> BytesWarning` _Initializes the warning object with the specified arguments (data about the problem)._

* * ![class](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/class.png) `DeprecationWarning : Warning`

* * *  ![constructor](https://github.com/ColorfulSoft/System.AI/raw/v2.0/Docs/Icons/constructor.png) `DeprecationWarning(params object[] args) -> DeprecationWarning` _Initializes the warning object with the specified arguments (data about the problem)._

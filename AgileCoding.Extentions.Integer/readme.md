AgileCoding.Extensions.Integer
==============================

Overview
--------

AgileCoding.Extensions.Integer is a .NET library that provides several useful extension methods related to integers. This package simplifies certain tasks related to integer conversion and validation.

Installation
------------

This library is distributed via NuGet. To install it, use the NuGet package manager console:

bashCopy code

`Install-Package AgileCoding.Extensions.Integer -Version 1.0.0`

Features
--------

This library introduces the following extension methods:

1.  ToInt: Converts a string to an integer. If the string cannot be converted, it returns 0.
2.  ToInt with Exception: Converts a string to an integer and throws a specific exception if the string cannot be converted.
3.  ThrowsIfTrue: Throws a specific exception if the given condition is true.

Usage
-----

Here's an example of how to use these features in your code:

```csharp
using AgileCoding.Extentions.Integers;
using System;

// Convert a string to an integer
int number1 = "123".ToInt();

// Convert a string to an integer and throw an exception if conversion fails
try
{
    int number2 = "abc".ToInt<FormatException>("The input string was not in a correct format.");
}
catch (FormatException ex)
{
    // Handle or log the exception...
}

// Throw an exception if a condition is true
try
{
    int number3 = 10.ThrowsIfTrue<OverflowException>(number3 > int.MaxValue, "The number exceeds the maximum integer value.");
}
catch (OverflowException ex)
{
    // Handle or log the exception...
}
```

Documentation
-------------

For more detailed information about the usage of this library, please refer to the [official documentation](https://github.com/ToolMaker/AgileCoding.Extentions.Integer/wiki).

License
-------

This project is licensed under the terms of the MIT license. For more information, see the [LICENSE](https://github.com/ToolMaker/AgileCoding.Extentions.Integer/blob/main/LICENSE) file.

Contributing
------------

Contributions are welcome! Please see our [contributing guidelines](https://github.com/ToolMaker/AgileCoding.Extentions.Integer/blob/main/CONTRIBUTING.md) for more details.
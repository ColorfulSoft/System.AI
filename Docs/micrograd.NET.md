# Micrograd.NET
A tiny scalar-valued autograd engine and a neural net library on top of it with Torch.NET-like API. Dotnet port of Andrej Karpathy's `micrograd` Python library (https://github.com/karpathy/micrograd).

## Attention

**`^` operator used as power in micrograd.NET is NOT power (but bitwise logical) operator in C# (there is no operator for pow in C#), so `^` has lower priority than `-`, `+`, `*` and `/`. Take it in braces.**

## Code samples

Andrej Karpathy's micrograd example in C# using micrograd.NET

```C#
using System;
using System.AI;

public static class Program
{
    public static void Main(string[] args)
    {
        var a = new micrograd.engine.Value(-4);
        var b = new micrograd.engine.Value(2);
        var c = a + b;
        var d = a * b + (b ^ 3); // ^ operator is NOT power (but bitwise logical) operator in C# (there is no operator for pow in C#), so ^ has lower priority than -, +, * and /. Take it in braces.
        c += c + 1;
        c += 1 + c + (-a);
        d += d * 2 + (b + a).relu();
        d += 3 * d + (b - a).relu();
        var e = c - d;
        var f = e ^ 2;
        var g = f / 2;
        g += 10 / f;
        Console.WriteLine(g.data); // prints 24.7041, the outcome of this forward pass
        g.backward();
        Console.WriteLine(a.grad); // prints 138.8338, i.e. the numerical value of dg/da
        Console.WriteLine(b.grad); // prints 645.5773, i.e. the numerical value of dg/db
        Console.Write("Press any key to continue . . . ");
        Console.ReadKey(true);
    }
}
```

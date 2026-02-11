// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using System;

//11.02.2026 Multidimensional Arrays and Foreach Loop
int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        Console.WriteLine(numbers[i, j]);
    }
}

//foreach (int i in numbers)
//{
//    Console.WriteLine(i);
//}

//Logger log1 = Logger.GetLogger();
//Logger log2 = Logger.GetLogger();

//log1.Log("Hello");
//log2.Log("Madhan");

//Console.WriteLine(log1==log2);

//Console.WriteLine(MathHelper.Add(2, 3));

//Console.WriteLine("Hello, World!");
//Console.WriteLine($"AppName (const): {ConstantsDemo.AppName}");
//Console.WriteLine($"MaxRetries (const): {ConstantsDemo.MaxRetries}");
//Console.WriteLine($"Pi (const): {ConstantsDemo.Pi}");
//Console.WriteLine($"DefaultStatus (const enum): {ConstantsDemo.DefaultStatus}");
//Console.WriteLine($"BuildDate (static readonly, runtime): {ConstantsDemo.BuildDate}");
//Console.WriteLine($"Version (static readonly): {ConstantsDemo.Version}");

// Local const inside a method/top-level scope
//const int LocalTimeout = 30;
//Console.WriteLine($"LocalTimeout (const): {LocalTimeout}");

// Examples of what you cannot do with const (uncommenting will cause compiler errors):
// ConstantsDemo.BuildDate = DateTime.UtcNow;           // error: cannot assign to readonly field
// ConstantsDemo.AppName = "NewName";                  // error: const is compile-time constant and immutable
// public const DateTime SomeDate = DateTime.Now;      // error: DateTime is not allowed as const

// Notes (short):
// - Allowed types for `const`: built-in numeric types (sbyte..ulong, float, double, decimal), char, bool, string, and enum types.
// - `const` is implicitly `static` and must be initialized with a compile-time constant expression.
// - For values determined at runtime (DateTime.Now, results of method calls, objects), use `static readonly` or `readonly` instance fields.
// - Versioning: `const` values are inlined at compile time into callers. Changing a const in a library requires recompilation of dependent assemblies to pick up the new value;

public static class ConstantsDemo
{
    // Compile-time constants (must be known at compile time).
    public const int MaxRetries = 5;
    public const double Pi = 3.14159;
    public const string AppName = "ConsoleApp1";
    public const bool IsEnabled = true;
    public const char Separator = ',';

    // Enums are allowed as const values.
    public enum Status { Ok = 0, Error = 1 }
    public const Status DefaultStatus = Status.Ok;

    // Use static readonly for runtime values (not compile-time constants).
    // These can be assigned from method calls, DateTime.Now, etc.
    public static readonly DateTime BuildDate = DateTime.Now;
    public static readonly string Version = GetVersion();

    private static string GetVersion()
        => System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "0.0.0";
}


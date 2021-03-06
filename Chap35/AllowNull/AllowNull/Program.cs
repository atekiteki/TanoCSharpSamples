﻿#nullable enable
using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    private static string s = string.Empty;
    [AllowNull]
    public static string MyProperty
    {
        get { return s; }
        set { s = value ?? string.Empty; }
    }

    public static void ShowStringLength(string? s)
    {
        Console.WriteLine((s ?? "").Length);
    }
    static void Main()
    {
        MyProperty = null;
        ShowStringLength(MyProperty);
    }
}

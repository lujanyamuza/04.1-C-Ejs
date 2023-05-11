﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        Console.Write("\nEnter a string: ");
        string str = Reverse(Console.ReadLine());
        Console.WriteLine("\nReversed string -> {0}\n", str);
    }

    static string Reverse(string str)
    {
        string tmp = string.Empty;

        for (int i = 0; i < str.Length; i++)
            tmp = str[i] + tmp;

        return tmp;
    }
}
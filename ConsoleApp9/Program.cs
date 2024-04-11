using ConsoleApp9;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

class Program
{
    
    static void Main(string[] args)
    {
        TotalShadowLength total = new TotalShadowLength();
        total.start();
        Console.WriteLine("Введите выражение");
        string expression = Console.ReadLine();
        Console.WriteLine("Исходное выражение: " + expression);
        Console.WriteLine(task2.ConvertToReversePolishNotation(expression));
    }
}
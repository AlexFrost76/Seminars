﻿// Задача 1: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

using System;
class Task1
{
    public static void Main()
    {
        Console.Write("Введите значение M:");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите значение N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        PrintAllNaturalNumbers(m,n);
    }
    public static void PrintAllNaturalNumbers(int m, int n)
    {
        if (m > n)
            return;
       
        Console.Write($"{m} ");
        PrintAllNaturalNumbers(m + 1, n);

    }
}
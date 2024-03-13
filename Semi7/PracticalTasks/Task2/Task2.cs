//  Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//  Даны два неотрицательных числа m и n.
//  m = 2, n = 3 -> A(m,n) = 29
using System;
class Task2
{
    public static void Main()
    {
        Console.Write("Введите число M: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите число N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        PrintAkkerman(m, n);
    }
    public static void PrintAkkerman(int m, int n)
    {
        Console.WriteLine(AkkermanFunc(n, m));
    }
    // функция Аккермана
    public static int AkkermanFunc(int n, int m)
    {
        if (n == 0)
        {
            return m + 1;
        }
        else if (m == 0)
        {
            return AkkermanFunc(n - 1, 1);
        }
        return AkkermanFunc(n - 1, AkkermanFunc(n, m - 1));
    }
}

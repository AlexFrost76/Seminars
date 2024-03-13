// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

using System;

public static class Program
{
    public static void ReverseArr(int[] arr, int n)
    {
        if (n > 0)
        {
            Console.Write(arr[n] + " ");
            ReverseArr(arr, n - 1);
        }
        else Console.WriteLine(arr[0]);
    }
    public static void Main()
    {
        int[] arr = { 1, 2, 5, 0, 10, 34 };
        ReverseArr(arr, arr.Length - 1);
    }
}

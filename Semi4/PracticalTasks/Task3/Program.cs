// Напишите программу, которая перевернёт одномерный массив 
// (первый элемент станет последним, второй – предпоследним и т.д.)
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 }; // Source array
        int temp;
        // Output of the original array
        Console.Write("Original array: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        // Array reversal
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            // Swap elements
            temp = numbers[i];
            numbers[i] = numbers[numbers.Length - 1 - i];
            numbers[numbers.Length - 1 - i] = temp;
        }
        // Вывод измененного массива
        Console.Write("\nInverted array: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
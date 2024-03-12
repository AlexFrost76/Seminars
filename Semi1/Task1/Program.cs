﻿/*Напишите программу, которая на вход
принимает два целых числа и проверяет,
является ли первое число квадратом второго*/

Console.Write("input first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// if (number1 == number2 * number2)
// {
//     Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("No");
// }

if (number1 == Math.Pow(number2,2))
{
     Console.WriteLine("Square of the number {1} is equal to  {0} ", number1, number2);
}
else
{
    Console.WriteLine($"Square of the number {number2} is not equal to  {number1} ");
}
// Console.WriteLine("Square of the number " + number2 + " equal to " + number1);
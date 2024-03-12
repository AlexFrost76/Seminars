﻿// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.

Console.Write("Input your three digit number: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a <= 999 && a >= 100)
{
    int b = a / 100;
    int c = a % 10;
    int sum = b + c;
    Console.WriteLine(sum);
    Console.WriteLine(a / 10 % 10);
}
else
{
    Console.WriteLine("Your number is not three digit");
}
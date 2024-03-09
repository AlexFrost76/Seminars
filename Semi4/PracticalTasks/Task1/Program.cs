//Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.

using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter the numbe or 'q' for exit: ");
            string? input =  Console.ReadLine();
       
            if (input == "q")
            {
                break;
            }
            int number;
            if (int.TryParse(input, out number))
            {
                int sum = 0;
                while (number > 0) // Calculating the sum of the digits of a number
                {
                    sum += number % 10; // Adding the las digit to the sum
                    number /= 10; // Removing the last digit from a nmber
                }
                if (sum % 2 == 0) // Checking if the sum of digits is even
                {
                    Console.WriteLine("[STOP]");
                    break;
                }
            }
            else // If input is not a number and not 'q' repeat the request
            {
                Console.WriteLine("Incorrect input. Please enter an integer of 'q'.");
            }
        }
    }

}
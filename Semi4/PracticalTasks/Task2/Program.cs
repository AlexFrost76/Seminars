// Задача 2: Задайте массив заполненный случайными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

class Program
{
    static void Main()
    {
        {
            int[] numbers = new int[10]; // Array for storring random numbers
            Random random = new Random(); // Random numbers generator
            int evenCount = 0; // Random numbers counter
            // Filling an array with rsandom three-digit numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(100, 1000); // Random number from 100 to 999
                Console.Write(numbers[i] + " "); // Output generated number
                
                // Parity check and counter increment
                if (numbers[i] % 2 == 0)
                {
                    evenCount++;
                }
            }
            // Output the number of even numbers in an array
            Console.WriteLine($"\nNumber of even numbers in the array: {evenCount}");
        }
    }
}
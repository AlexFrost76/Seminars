using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        if(a % 7 == 0 && a% 23 == 0)
        {
            Console.WriteLine("YES");
        }
        else 
        {
            Console.WriteLine("NO");
        }
    }

}
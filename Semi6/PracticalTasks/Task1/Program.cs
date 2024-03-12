//Задача 1: Задайте двумерный массив символов (тип char [,]). 
//Создать строку из символов этого массива.
using System;
class Program
{
    static void Main()
    {
        char[,] CharArray = new char[,]{{'H','e','l','l','o'},{'W','o','r','l','d'}};
        //Console.WriteLine($"CharArray rows {CharArray.GetLength(0)}");
        //Console.WriteLine($"CharArray cols {CharArray.GetLength(1)}");
        
         string str = "";
         for (int a = 0; a < CharArray.GetLength(0); a++ )
         {
             for (int b = 0; b < CharArray.GetLength(1); b++)
             {
                str = str + CharArray[a,b].ToString();
             }
         }
         Console.WriteLine(str);
    }
}
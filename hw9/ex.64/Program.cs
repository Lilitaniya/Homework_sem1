/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

class Program
{
    static void Main()
    {
        int N = 5; 

        Console.Write("Натуральные числа от " + N + " до 1 с помощью рекурсии: ");
        PrintNaturalNumbers(N);

        Console.Write("."); 

        Console.ReadKey();
    }

    static void PrintNaturalNumbers(int N)
    {
        if (N < 1)
        {
            return;
        }

        if (N == 1)
        {
            Console.Write(N); 
        }
        else
        {
            Console.Write(N + ", "); 
        }

        PrintNaturalNumbers(N - 1);
    }
}
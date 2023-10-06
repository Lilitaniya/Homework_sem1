/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

class Program
{
    static void Main()
    {

        int M = 1;
        int N = 15;

        int sum = SumOfNaturalNumbers(M, N);

        Console.WriteLine($"Сумма натуральных элементов в промежутке от {M} до {N} = {sum}");
    }

    static int SumOfNaturalNumbers(int M, int N)
    {
        if (M == N)
        {
            return M;
        }
        else
        {
            return M + SumOfNaturalNumbers(M + 1, N);
        }
    }
}
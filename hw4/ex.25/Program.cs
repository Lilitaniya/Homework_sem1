/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 */
Console.Write("Введите число A: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine());

int result = 1; 

    if (B >= 0)
    {
        for (int i = 1; i <= B; i++)
        {
            result *= A;
        }

        Console.WriteLine($"{A}^{B} = {result}");
    }
    else
    {
        Console.WriteLine("B должно быть натуральным числом или нулем.");
    }

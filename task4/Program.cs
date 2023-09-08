/* Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
{
            Console.WriteLine($"Четные числа от 1 до {num}:");
            
            for (int i = 2; i <= num; i += 2)
            {
                Console.Write(i);

                if (i < num - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
        }
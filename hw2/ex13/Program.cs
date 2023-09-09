/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        if (number >= 100)
        {
            int digitCount = 0;
            int thirdDigit = 0;

            while (number > 0 && digitCount < 3)
            {
                digitCount++;
                if (digitCount == 3)
                {
                    thirdDigit = number % 10;
                }
                number /= 10;
            }

            if (digitCount == 3)
            {
                Console.WriteLine($"Третья цифра в введенном числе - это {thirdDigit}");
            }
            else
            {
                Console.WriteLine($"В введенном числе нет третьей цифры, так как оно меньше трехзначного.");
            }
        }
        else
        {
            Console.WriteLine($"В введенном числе  нет третьей цифры, так как оно меньше трехзначного.");
        }
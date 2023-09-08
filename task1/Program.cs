/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
Следующая задача в task2*/
Console.WriteLine("Введите первое число:");
        if (int.TryParse(Console.ReadLine(), out int firstNumber))
        {
            Console.WriteLine("Введите второе число:");
            if (int.TryParse(Console.ReadLine(), out int secondNumber))
            {
                if (firstNumber > secondNumber)
                {
                    Console.WriteLine($"{firstNumber} больше {secondNumber}.");
                }
                else if (firstNumber < secondNumber)
                {
                    Console.WriteLine($"{secondNumber} больше {firstNumber}.");
                }
                else
                {
                    Console.WriteLine("Оба числа равны.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода второго числа.");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода первого числа.");
        }
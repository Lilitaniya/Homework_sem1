/* Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

int arraySize = 4; // Количество чисел в массиве
Random random = new Random();
int[] numbers = new int[arraySize];

// Заполнение массива случайными трёхзначными числами
    for (int i = 0; i < arraySize; i++)
    {
        numbers[i] = random.Next(100, 1000); // генерация чисел от 100 до 999
    }

    int evenCount = 0;
    foreach (int number in numbers)
    {
        if (number % 2 == 0)
        {
            evenCount++;
        }
    }
Console.WriteLine("Случайный массив:");
    foreach (int number in numbers)
    {
        Console.Write(number + " ");
    }
Console.WriteLine("\nКоличество чётных чисел в массиве: " + evenCount);
/* Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

int arraySize = 4; 
Random random = new Random();
int[] numbers = new int[arraySize];
    for (int i = 0; i < arraySize; i++)
    {
        numbers[i] = random.Next(1, 100); // генерация числа от 1 до 99
    }

    // сумма элементов на нечётных позициях
    int sum = 0;
    for (int i = 1; i < arraySize; i += 2)
    {
        sum += numbers[i];
    }
Console.WriteLine("Сам массив:");
    foreach (int number in numbers)
    {
         Console.Write(number + " ");
    }
Console.WriteLine("\nСумма элементов на нечётных позициях: " + sum);
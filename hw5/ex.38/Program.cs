/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

double min = numbers[0];
double max = numbers[0];
    foreach (double number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
double diff = max - min;
Console.WriteLine("Массив вещественных чисел: 3.22, 4.2, 1.15, 77.15, 65.2");
Console.WriteLine("Разница между максимальным и минимальным числом: " + diff);
/* Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
 */
 int[,] array = {
            {1, 2, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
            {5, 2, 6, 7}
        };
int minRow = FindRowWithMinSum(array);
if (array.Length != 0)
{
    Console.WriteLine($"Строка с наименьшей суммой элементов: {minRow + 1}");
}
else
{
    Console.WriteLine("Массив пустой.");
}

static int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int rowSum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minSum)
        {
            minSum = rowSum;
            minRow = i;
        }
    }

    return minRow;
}
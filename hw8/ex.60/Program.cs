/* Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
int[,,] threeDimensionalArray = GenerateUniqueTwoDigitArray(2, 2, 2);

        PrintThreeDimensionalArray(threeDimensionalArray);

static void PrintThreeDimensionalArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                int value = array[i, j, k];
                Console.Write($"{value}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

static int[,,] GenerateUniqueTwoDigitArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    int minValue = 10;
    int maxValue = 99;
    Random random = new Random();

    int[] usedValues = new int[x * y * z];
    int index = 0;

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                int uniqueValue = GenerateUniqueValue(minValue, maxValue, usedValues, random);
                array[i, j, k] = uniqueValue;
                usedValues[index] = uniqueValue;
                index++;
            }
        }
    }

    return array;
}

static int GenerateUniqueValue(int minValue, int maxValue, int[] usedValues, Random random)
{
    int uniqueValue;
    do
    {
        uniqueValue = random.Next(minValue, maxValue + 1);
    } while (ArrayContainsValue(usedValues, uniqueValue));
    return uniqueValue;
}

static bool ArrayContainsValue(int[] array, int value)
{
    foreach (int element in array)
    {
        if (element == value)
        {
            return true;
        }
    }
    return false;
}
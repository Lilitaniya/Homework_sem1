/* Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

int[,] array = {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
    };
     Sort2DArrayDescending(array);

Console.WriteLine("Отсортированный по убыванию массив:");
Print2DArray(array);
static void Sort2DArrayDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            int key = array[i, j];
            int k = j - 1;
            while (k >= 0 && array[i, k] < key)
            {
                array[i, k + 1] = array[i, k];
                k = k - 1;
            }
            array[i, k + 1] = key;
        }
    }
}
    static void Print2DArray(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

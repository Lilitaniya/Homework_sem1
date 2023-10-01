/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
 */
class Program
{
    static int[,] FillSpiralMatrix(int n)
    {
        int[,] matrix = new int[n, n];
        int num = 1;
        int left = 0, right = n - 1, top = 0, bottom = n - 1;

        while (num <= n * n)
        {
            for (int i = left; i <= right; i++)
            {
                matrix[top, i] = num;
                num++;
            }
            top++;

            for (int i = top; i <= bottom; i++)
            {
                matrix[i, right] = num;
                num++;
            }
            right--;

            for (int i = right; i >= left; i--)
            {
                matrix[bottom, i] = num;
                num++;
            }
            bottom--;

            for (int i = bottom; i >= top; i--)
            {
                matrix[i, left] = num;
                num++;
            }
            left++;
        }

        return matrix;
    }

    static void PrintMatrix(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write($"{matrix[i, j]:D2} ");
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int n = 4;
        int[,] matrix = FillSpiralMatrix(n);
        PrintMatrix(matrix);
    }
}
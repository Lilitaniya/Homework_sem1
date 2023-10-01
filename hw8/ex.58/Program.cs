/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

 int[,] matrix1 = {
    {2, 4},
    {3, 2}
 };
  int[,] matrix2 = {
    {3, 4},
    {3, 3}
 };
int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

    Console.WriteLine("Результат умножения матриц:");
    PrintMatrix(resultMatrix);

static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int cols1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int cols2 = matrix2.GetLength(1);

    ValidateMatrixMultiplication(rows1, cols1, rows2, cols2);

    int[,] resultMatrix = new int[rows1, cols2];

    for (int i = 0; i < rows1; i++)
    {
         for (int j = 0; j < cols2; j++)
        {
            resultMatrix[i, j] = CalculateElement(matrix1, matrix2, i, j);
        }
    }

    return resultMatrix;
}

static int CalculateElement(int[,] matrix1, int[,] matrix2, int row, int col)
{
    int sum = 0;
    for (int k = 0; k < matrix1.GetLength(1); k++)
    {
        sum += matrix1[row, k] * matrix2[k, col];
    }
    return sum;
}

static void ValidateMatrixMultiplication(int rows1, int cols1, int rows2, int cols2)
{
    if (cols1 != rows2)
    {
        throw new InvalidOperationException("Столбцы первой матрицы должны быть равны строкам второй матрицы по количеству элементов.");
    }
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

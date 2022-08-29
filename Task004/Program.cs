// Сумма элементов главной диагонали матрицы.

int[,] CreateMatrix(int rowCount, int columnCount, int min, int max)
{
    int[,] matrix = new int[rowCount, columnCount];
    for (int i = 0; i < rowCount; i++)
    {
        for (int j = 0; j < columnCount; j++)
        {
            matrix[i, j] = new Random().Next(min, max+1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int FindDiagonalSum(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == j) sum += matrix[i,j];
        }
    }
    return sum;
}

int[,] matrix = CreateMatrix(5, 7, 0, 99);
PrintMatrix(matrix);
int sum = FindDiagonalSum(matrix);
Console.WriteLine($"Сумма элементов главной диагонали матрицы равна {sum}");



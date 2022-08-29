// 49. Задать двумерный массив. Заменить нечетные элементы их квадратами. Вывести.

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

void SquareEvenElements(int[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0)
                matrix[i, j] = matrix[i, j] * matrix[i, j];
        }
    }
}

int[,] matrix = CreateMatrix(5, 5, 0, 99);
PrintMatrix(matrix);
Console.WriteLine();
SquareEvenElements(matrix);
PrintMatrix(matrix);

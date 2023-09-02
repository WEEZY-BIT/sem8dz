// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Задаем две матрицы
int[,] matrix1 = new int[,]
{
            { 1, 2 },
            { 3, 4 }
};

int[,] matrix2 = new int[,]
{
            { 5, 6, },
            { 7, 8, }
            
};

// Умножаем матрицы
int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

// Выводим результат
Console.WriteLine("Результат умножения матриц:");
PrintMatrix(resultMatrix);

Console.ReadLine();
    

    static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
{
    int rows1 = matrix1.GetLength(0);
    int columns1 = matrix1.GetLength(1);
    int rows2 = matrix2.GetLength(0);
    int columns2 = matrix2.GetLength(1);

    if (columns1 != rows2)
    {
        throw new Exception("Невозможно умножить матрицы. Количество столбцов первой не равно количеству строк второй матрицы.");
    }

    int[,] resultMatrix = new int[rows1, columns2];

    for (int i = 0; i < rows1; i++)
    {
        for (int j = 0; j < columns2; j++)
        {
            int sum = 0;
            for (int k = 0; k < columns1; k++)
            {
                sum += matrix1[i, k] * matrix2[k, j];
            }
            resultMatrix[i, j] = sum;
        }
    }

    return resultMatrix;
}

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
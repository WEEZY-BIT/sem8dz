// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

int[,] array = new int[4, 4];
FillSpiralArray(array);
PrintArray(array);
    

    static void FillSpiralArray(int[,] array)
{
    int n = array.GetLength(0);
    int value = 1;
    int rowStart = 0;
    int rowEnd = n - 1;
    int colStart = 0;
    int colEnd = n - 1;

    while (rowStart <= rowEnd && colStart <= colEnd)
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            array[rowStart, i] = value++;
        }
        rowStart++;

        for (int i = rowStart; i <= rowEnd; i++)
        {
            array[i, colEnd] = value++;
        }
        colEnd--;

        if (rowStart <= rowEnd)
        {
            for (int i = colEnd; i >= colStart; i--)
            {
                array[rowEnd, i] = value++;
            }
            rowEnd--;
        }

        if (colStart <= colEnd)
        {
            for (int i = rowEnd; i >= rowStart; i--)
            {
                array[i, colStart] = value++;
            }
            colStart++;
        }
    }
}

static void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}\t", array[i, j]);
        }
        Console.WriteLine();
    }
}
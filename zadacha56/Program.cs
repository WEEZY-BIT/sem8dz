// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = new int[,]
        {
            { 5, 9, 2, 3 },
            { 1, 4, 7, 2 },
            { 8, 4, 2, 4 },
            { 5, 2, 6, 7 }
        };

Console.WriteLine("Исходный массив:");
PrintArray(array);

int minSumRowIndex = FindRowWithMinSum(array);


Console.WriteLine("Строка с наименьшей суммой элементов: " + (minSumRowIndex + 1));

Console.ReadLine();


static int FindRowWithMinSum(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int minSum = int.MaxValue;
    int minSumRowIndex = -1;
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minSumRowIndex = i;
        }
    }
    return minSumRowIndex;
}

static void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
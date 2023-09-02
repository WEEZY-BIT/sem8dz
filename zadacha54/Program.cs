// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.



// Создаем двумерный массив
int[,] array = new int[,]
{
    { 5, 2, 9 },
    { 1, 8, 4 },
    { 3, 7, 6 }
};


// Выводим исходный массив
Console.WriteLine("Исходный массив:");
PrintArray(array);


// Сортируем каждую строку по убыванию
SortRowsDescending(array);

// Выводим отсортированный массив
Console.WriteLine("Отсортированный массив:");
PrintArray(array);


    static void SortRowsDescending(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        // Создаем временный одномерный массив для сортировки
        int[] tempArray = new int[columns];

        // Копируем элементы текущей строки во временный массив
        for (int j = 0; j < columns; j++)
        {
            tempArray[j] = array[i, j];
        }

        // Сортируем временный массив по убыванию
        Array.Sort(tempArray);
        Array.Reverse(tempArray);

        // Копируем отсортированные элементы обратно в исходный массив
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = tempArray[j];
        }
    }
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
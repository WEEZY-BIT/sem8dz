//  Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2

int[,,] array = CreateArray();

PrintArray(array);


    static int[,,] CreateArray()
{
    int[,,] array = new int[2, 2, 2];
    int number = 10;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                array[i, j, k] = number;
                number++;
            }
        }
    }

    return array;
}

static void PrintArray(int[,,] array)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                Console.WriteLine("array[{0}, {1}, {2}] = {3}", i, j, k, array[i, j, k]);
            }
        }
    }  
}
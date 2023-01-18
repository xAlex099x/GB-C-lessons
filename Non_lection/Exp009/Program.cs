int[,] CreateFillArray()
{
    Console.WriteLine("Введите количество строк и столбцов в таблице (ввод числа через enter): ");
    int[,] arr = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
    Console.WriteLine();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Random.Shared.Next(100);
            Console.Write($"|{arr[i, j],2} | ");
        }
        Console.WriteLine();
    }
    return arr;
}

void PrintArray(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"|{collection[i, j],2} | ");
        }
        Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                int temp = array[i, k];
                if(array[i, k + 1] > array[i, k])
                {
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }
        }
    }
}

int[,] arr = CreateFillArray();

Console.WriteLine("Изначальный массив: ");
PrintArray(arr);
Console.WriteLine("Отсортированный массив: ");
SortArray(arr);
PrintArray(arr);
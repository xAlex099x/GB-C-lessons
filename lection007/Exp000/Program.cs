void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round(Random.Shared.NextDouble() * 10 - 3, 2);
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine("\n");
    }
}



Console.WriteLine("Введите количество строк в массиве: ");
int column = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

double[,] startArray = new double[column, rows];

FillArray(startArray);

PrintArray(startArray);

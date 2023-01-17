void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Random.Shared.Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}; ");
        }
        Console.WriteLine("");
    }
}

int? FindElement(int[,] array, int col, int row)
{
    if (array.GetLength(0) >= col & array.GetLength(1) >= row)
    {
        return array[col, row];
    }
    else
    {
        return null;
    }
}


int[,] arr = new int[3, 5];
FillArray(arr);

Console.WriteLine("Введите номер строки элемента: ");
int findColumn = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента: ");
int findRows = Convert.ToInt32(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.Blue;

int? result = FindElement(arr, findColumn - 1, findRows - 1);
if(result == null)
{
    Console.WriteLine("\nТакого числа нету.");
}
else
{
    Console.WriteLine("\nЗначение элемента: " + result);
}

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine("\nМассив: ");
PrintArray(arr);

Console.ResetColor();


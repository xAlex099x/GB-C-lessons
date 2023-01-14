string[] UserInput()
{
    Console.WriteLine("Введите числа через запятую: ");
    string strInput = Console.ReadLine();
    strInput = strInput.Replace(" ", "");
    string[] input = strInput.Split(",");
    return input;
}
int[] StrArrayToInt(string[] strArray)
{
    int[] intArray = new int[strArray.Length];

    for (int i = 0; i < strArray.Length; i++)
    {
        intArray[i] = int.Parse(strArray[i]);
    }

    return intArray;
}
int numberGreaterZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}
void PrintArray(int[] intArray)
{
    for (int i = 0; i < intArray.Length; i++)
    {
        Console.Write($"{intArray[i]};");
    }
}

while (true)
{
    string[] strArrInput = UserInput();

    int[] intArray = StrArrayToInt(strArrInput);

    int count = numberGreaterZero(intArray);

    Console.ForegroundColor = ConsoleColor.Blue;
    PrintArray(intArray);
    Console.WriteLine("\nЧисел больше нуля: " + count);
    Console.ResetColor();
    
    break;
}
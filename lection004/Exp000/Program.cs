
int[] newRndBinary(int size = 10)
{
    Random rnd = new Random();
    int[] array = new int[size];

    for (int i = 0; i <= array.Length - 1; i++)
    {
        array[i] = rnd.Next(0, 2);
    }

    array[0] = 1;
    return array;
}

int binaryToDecimal(int[] binaryArray)
{
    int result = 0;
    int temp = binaryArray.Length - 1;
    for (int i = 0; i <= binaryArray.Length - 1; i++, temp--)
    {
        if (binaryArray[i] != 0 && binaryArray[i] != 1)
        {
            return -1;
        }
        result += binaryArray[i] * (int)Math.Pow(2, temp);
    }
    return result;
}

void printBinary(int[] array, int result)
{
    Console.Write("Массив: ");
    for (int i = 0; i <= array.Length - 1; i++)
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine($" -> Результат: {result}");
}


int[] testArray = newRndBinary(7);
int number = binaryToDecimal(testArray);

printBinary(testArray, number);


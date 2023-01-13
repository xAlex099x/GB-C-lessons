List<int> FillList(int size = 10)
{

    List<int> list = new List<int>(size);
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        list.Add(rnd.Next(0, 20));
    }

    return list;
}

List<int> ProductPairsNumbers(List<int> list)
{
    List<int> tempList = new List<int>(list.Count / 2);

    for (int i = 0; i < list.Count / 2; i++)
    {
        tempList.Add(list[i] * list[list.Count - 1 - i]);
    }

    return tempList;
}

void PrintList(List<int> List)
{
    for (int i = 0; i < List.Count; i++)
    {
        Console.Write($"{List[i]};");
    }
}

void programsStart(){
while (true)
{
    Console.WriteLine("\nРазмер массива должен быть чётным.");
    Console.WriteLine("Укажите размер изначального массива: ");

    string? strInput = Console.ReadLine();
    bool parsResult = int.TryParse(strInput, out int input);

    if (parsResult == true)
    {
        if (input % 2 != 0 || input < 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("На ввод допустимы только чётные числа, больше 1.");
            Console.ResetColor();
            continue;
        }

        Console.ForegroundColor = ConsoleColor.Blue;

        List<int> startList = FillList(input);
        Console.Write("\nИзначальный массив -> ");
        PrintList(startList);

        Console.Write("\nМассив произведений пар чисел -> ");
        List<int> newList = ProductPairsNumbers(startList);
        PrintList(newList);
        Console.ResetColor();
        break;
    }

    else
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("На ввод допустимы только чётные числа, больше 1.");
        Console.ResetColor();
        continue;
    }
}
}

programsStart();
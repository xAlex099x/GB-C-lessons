while (true)
{
    Console.ForegroundColor = ConsoleColor.Blue;

    Console.WriteLine("Введите b1: ");
    bool res = int.TryParse(Console.ReadLine(), out int b1);
    if (res == false)
    {
        Console.WriteLine("Недопустимый ввод.");
        break;
    }

    Console.WriteLine("Введите k1: ");
    bool res2 = int.TryParse(Console.ReadLine(), out int k1);
    if (res2 == false)
    {
        Console.WriteLine("Недопустимый ввод.");
        break;
    }

    Console.WriteLine("Введите b2: ");
    bool res3 = int.TryParse(Console.ReadLine(), out int b2);
    if (res3 == false)
    {
        Console.WriteLine("Недопустимый ввод.");
        break;
    }

    Console.WriteLine("Введите k2: ");
    bool res4 = int.TryParse(Console.ReadLine(), out int k2);
    if (res4 == false)
    {
        Console.WriteLine("Недопустимый ввод.");
        break;
    }

    Console.WriteLine($"x = {(double)(b2 - b1) / (k1 - k2)}");
    Console.WriteLine($"y = {(double)((b2 + k1) - (b1 + k2)) / (k2 - k1)}");
    
    Console.ResetColor();
    break;
}
void dayInfo (int day)
{
    if (day % 7 > 0 & day % 7 <= 5)
    {
        Console.WriteLine("Будний день");
    }
    else
    {
        Console.WriteLine("Выходной");
    }
}

int day = System.Convert.ToInt32(Console.ReadLine());
dayInfo(day);

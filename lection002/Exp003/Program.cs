void itsHoliday(int number)
{
    if(number == 6 && number == 7)
    {
        Console.WriteLine("Это выходной");
    }
    else
    {
        Console.WriteLine("Это будний день");
    }
}

int number = 3;

itsHoliday(number);
void isPal(int number)
{
    if (number < 10000 || number > 100000)
    {
        Console.WriteLine("Число должно быть больше 9999 и меньше 100000.");
    }
    else if (number / 10000 == number % 100 % 10
        && number / 1000 % 10 == number % 100 / 10)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}

Console.WriteLine("Введите пятизначное число для проверки на палиндром: ");
int number = System.Convert.ToInt32(Console.ReadLine());

isPal(number);


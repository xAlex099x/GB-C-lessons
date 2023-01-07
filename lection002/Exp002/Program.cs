void thirdDigit (int number)
{
    string s = number.ToString();
    if (s.Length < 3)
    {
        Console.WriteLine("Третьей цифры нету");
    }

    else
    {
        Console.WriteLine(s[2]);
    }
}

int number = 1834912;
thirdDigit(number);

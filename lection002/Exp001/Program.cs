void secondDigit (int number)
{
    string s = number.ToString();
    if(s.Length >= 3)
    {
        Console.WriteLine(s[1]);
    }
    else
    {
        Console.WriteLine("Число не должно быть короче 3х символов");
    }
    
}

int number = 193124;
secondDigit(number);
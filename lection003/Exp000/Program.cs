bool isPal(int number)
{

    bool isPalindrome = false;
    if (number < 10000 || number > 100000)
    {
        Console.WriteLine("Число должно быть больше 9999 и меньше 100000.");
        return isPalindrome;
    }
    if (number / 10000 == number % 100 % 10
        && number / 1000 % 10 == number % 100 / 10)
    {
        isPalindrome = true;
    }
    return isPalindrome;
}

int n = System.Convert.ToInt32(Console.ReadLine());

Console.WriteLine(isPal(n));


int digitSum(int number)
{
    int absNumber = Math.Abs(number);
    string tempStr = System.Convert.ToString(absNumber);
    int res = 0;

    for (int i = 0; i <= tempStr.Length - 1; i++)
    {
        res += (int)Char.GetNumericValue(tempStr[i]);
    }
    return res;
}

Random rnd = new Random();
int number = rnd.Next(100,100000);
Console.WriteLine($"Число: {number}");
Console.WriteLine($"Сумма: {digitSum(number)}");

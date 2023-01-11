int digitSum(int number)
{
    int absNumber = Math.Abs(number);
    string tempStr = System.Convert.ToString(absNumber);
    int result = 0;

    for (int i = 0; i <= tempStr.Length - 1; i++)
    {
        result += (int)Char.GetNumericValue(tempStr[i]);
    }
    return result;
}

Random rnd = new Random();
int number = rnd.Next(0,100000);
Console.WriteLine($"Число: {number}");
Console.WriteLine($"Сумма: {digitSum(number)}");

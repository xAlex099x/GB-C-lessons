int digitCount(int number)
{
    int absNumber = Math.Abs(number);
    int tempNumber = absNumber;
    int count = 0;

    while (tempNumber > 0)
    {
        tempNumber = (int)(tempNumber / 10);
        count++;
    }

    return count;
}

Random rnd = new Random();
int number = rnd.Next(10, 1000);

int result = digitCount(number);
Console.WriteLine(number);
Console.WriteLine(result);



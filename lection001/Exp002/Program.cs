int a = 10;
int b = 20;
int c = 1;


Console.WriteLine("Числа: " + a + ", " + b + ", " + c);

if (a > b)
{
    if(a > c)
    {
        Console.WriteLine(a);
    }
    else
    {
        Console.WriteLine(c);
    }
}
else
{
    if(b > c)
    {
        Console.WriteLine(b);
    }
    else
    {
        Console.WriteLine(c);
    }
}
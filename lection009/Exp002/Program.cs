int UserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
double AkkermanFunction(double m, double n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AkkermanFunction(m - 1, 1);
    else return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

var m = UserInput();
var n = UserInput();
Console.WriteLine($"A({m},{n}) = {AkkermanFunction(m, n)}");
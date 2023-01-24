int UserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sum(int number1, int number2)
{
    if (number2 == number1 - 1) return 0;
    else return number2 + Sum(number1, number2 - 1);
}

int start = UserInput();
int end = UserInput();
Console.WriteLine($"Сумма чисел от {start} до {end} равна {Sum(start, end)} ");
int UserInput()
{
    Console.Write("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
void NaturalNumber(int value)
{
    if (value >= 1)
    {
        Console.Write($"{value}; ");
        NaturalNumber(value -1);
    }

}

int number = UserInput();
NaturalNumber(number);
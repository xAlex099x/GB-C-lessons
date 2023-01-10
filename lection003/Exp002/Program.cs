void squareTable(int border)
{
    int index = 1;
    while (index <= border)
    {
        Console.WriteLine("" + index + " в кубе = " + Math.Pow(index, 3));
        index++;
    }
}

Console.WriteLine("Введите границу для таблицы кубов: ");
int n = System.Convert.ToInt32(Console.ReadLine());

squareTable(n);

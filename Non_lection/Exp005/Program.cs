Random rnd = new Random();
int number = rnd.Next(10, 99);
string str = number.ToString();

if (int.Parse(str.Substring(0, 1)) > int.Parse(str.Substring(1, 1)))
{
    Console.WriteLine("Число " + number + ": первая цифра больше");
}
else
{
    Console.WriteLine("Число " + number + ": вторая цифра больше");
}

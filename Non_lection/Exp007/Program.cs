Random rnd = new Random();
int number = rnd.Next(1,100);

if(number % 7 == 0)
{
    Console.WriteLine("Число " + number + " кратно 7");
}
else
{
    Console.WriteLine("Число " + number + " не кратно 7");
}

if(number % 23 == 0)
{
    Console.WriteLine("Число " + number + " кратно 23");
}
else
{
    Console.WriteLine("Число " + number + " не кратно 23");
}

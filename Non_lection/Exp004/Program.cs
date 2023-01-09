int number = 967;
string str = number.ToString();

if(str.Length > 2)
{
Console.WriteLine(number % 10 ); // Способ через остаток от деления
Console.WriteLine(str[2]); // Через конвертацию в строку и обращению к символу
Console.WriteLine(str.Substring(2,1)); //Через подстроку
}
Random rnd = new Random(); int number = rnd.Next(100, 999);
string str = number.ToString();


int newInt = int.Parse(str.Substring(0, 1) + str.Substring(2, 1)); // способ через подстроку
string newStr = str[0] + str[2].ToString(); //способ через обращение к символу

Console.WriteLine("Изначальное число: " + str);
Console.WriteLine("Новое число через подстроку: " + newInt);
Console.WriteLine("Новое число через символ: " + newStr);
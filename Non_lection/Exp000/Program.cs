//1 вариант
int digit = 3;
int pow = 5;


int index = 1;
int sum = digit;
while(index < pow)
{
    sum = sum * digit;
    index++;
}



//2 вариант, через встроенный функционал.
Console.WriteLine("_____________");
Console.WriteLine(Math. Pow(digit, pow));
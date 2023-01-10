void dist3dPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    Console.WriteLine(Math.Round(result, 2));
}

Console.WriteLine("Введите x,y,z первой точки через запятую: ");
string point1 = Console.ReadLine();
string[] subs1 = point1.Split(",");
double x1 = System.Convert.ToDouble(subs1[0]);
double y1 = System.Convert.ToDouble(subs1[1]);
double z1 = System.Convert.ToDouble(subs1[2]);

Console.WriteLine("Введите x,y,z второй точки через запятую: ");
string point2 = Console.ReadLine();
string[] subs2 = point2.Split(",");
double x2 = System.Convert.ToDouble(subs2[0]);
double y2 = System.Convert.ToDouble(subs2[1]);
double z2 = System.Convert.ToDouble(subs2[2]);

dist3dPoint(x1, y1, z1, x2, y2, z2);


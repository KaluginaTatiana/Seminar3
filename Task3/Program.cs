// Принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве
Console.WriteLine("Введите координаты точки А");
Console.Write("х = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координаты точки В");
Console.Write("х = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y = ");
double y2 = Convert.ToDouble(Console.ReadLine());
double dist = Distance(x1, y1, x2, y2);
Console.WriteLine("Расстояние между точками А и В равно " + dist + ".");

double Distance(double xa, double ya, double xb, double yb)
{
    double distanceX = Math.Abs( xa - xb);
    double distanceY = Math.Abs( ya - yb);
    double distance = Math.Round(Math.Sqrt(Math.Pow(distanceX, 2) + Math.Pow(distanceY, 2)), 2);
    return distance;
}
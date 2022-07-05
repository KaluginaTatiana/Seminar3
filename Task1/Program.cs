// Задача - на вход подается точка с координатами (х, у), причем х, у не равны нулю.
// Определить в какой координатной четверти лежит точка
Console.WriteLine("Введите координату х");
double x = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату y");
double y = Convert.ToDouble(Console.ReadLine());
FindCoordinateQuarter(x, y);


void FindCoordinateQuarter(double abscissa, double ordinate)
{
    if (abscissa == 0 || ordinate == 0)
        Console.WriteLine("Точка лежит на координатной прямой.");
    else if (abscissa > 0 && ordinate > 0)
        Console.WriteLine("Точка находится в первой четверти.");
    else if (abscissa > 0 && ordinate < 0)
        Console.WriteLine("Точка находится во второй четверти.");
    else if (abscissa < 0 && ordinate > 0)
        Console.WriteLine("Точка находится в четвертой четверти.");
    else
        Console.WriteLine("Точка находится в третьей четверти.");
}
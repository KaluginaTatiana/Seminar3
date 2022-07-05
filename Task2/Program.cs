// По заданному номеру координатной четверти показать диапазон возможных координат
// точек в этой четверти
Console.WriteLine("Введите номер координатной четверти");
double num = Convert.ToDouble(Console.ReadLine());
CoordinatesOfThePointByQuarterNumber(num);

void CoordinatesOfThePointByQuarterNumber(double x)
{
    if ( x != 1 && x != 2 && x != 3 && x != 4) 
    Console.WriteLine("Ошибка. Номера координатных четвертей: 1, 2, 3 или 4.");
    else if (x == 1)
    Console.WriteLine("Диапазон возможных координат: x > 0, y > 0");
    else if (x == 2)
    Console.WriteLine("Диапазон возможных координат: x > 0, y < 0");
    else if (x == 3)
    Console.WriteLine("Диапазон возможных координат: x < 0, y < 0");
    else if (x == 4)
    Console.WriteLine("Диапазон возможных координат: x < 0, y > 0");
}
// Принимает на вход число N  и на выход выдает таблицу квадратов от 1 до N
// 3 -> 1, 4, 9
// 5 -> 1, 4, 9, 16, 25
Console.WriteLine("Введите целое положительное число, не равное нулю.");
double n = Convert.ToDouble(Console.ReadLine());
if ( n < 1 || n % 1 != 0 )
Console.WriteLine("Ошибка. Введите целое положительное число, не равное нулю.");
else 
SqrNumbers(n);


void SqrNumbers(double number)
{
    int count = 1;
    double sqr = 1;
    while (count <= number)
    {
        Console.Write(Math.Pow(sqr, 2) + " ");
        count++;
        sqr++;
    }
    Console.WriteLine(" ");
}
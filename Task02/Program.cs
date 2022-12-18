//Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.WriteLine("Введите k1");
string K1 = Console.ReadLine()??"";
int k1 = Convert.ToInt32(K1);
Console.WriteLine("Введите k2");
string K2 = Console.ReadLine()??"";
int k2 = Convert.ToInt32(K2);
Console.WriteLine("Введите b1");
string B1 = Console.ReadLine()??"";
int b1 = Convert.ToInt32(B1);
Console.WriteLine("Введите b2");
string B2 = Console.ReadLine()??"";
int b2 = Convert.ToInt32(B2);
double x;
double y;

if (k2 == k1)
{
    Console.WriteLine($"Прямые не пересекаются или полностью совпадают");
    return;
}
else
{
    x = (b1-b2)/(k2-k1);
    y = (k2*b1-k1*b2)/(k2-k1);
    Console.WriteLine($"Точка пересечения имеее координаты -({x};{y})");
}
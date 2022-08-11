// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void GetCoord(double b1, double k1, double b2, double k2)
{
    if ((k1 == k2) && (b1 == b2))
        Console.WriteLine("Прямые сщвпадают");
    else if (k1 == k2)
        Console.WriteLine("Прямые параллельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * (b2 - b1) / (k1 - k2) + b1;
        Console.WriteLine($"[{x}, {y}]");
    }
}

Console.WriteLine("Введите 4 числа через пробел");
string[] array = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
double b1 = double.Parse(array[0]);
double k1 = double.Parse(array[1]);
double b2 = double.Parse(array[2]);
double k2 = double.Parse(array[3]);

GetCoord(b1, k1, b2, k2);

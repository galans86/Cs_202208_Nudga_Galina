// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Укажите значения для поиска точки пересечения прямых");
Console.Write("b1 = ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("b2 = ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
int k2 = Convert.ToInt32(Console.ReadLine());


if (k1 == k2 && b1 == b2)
    Console.WriteLine("Прямые совпадают");
else if (k1 == k2)
    Console.WriteLine("Пересечений нет");
else
{
    double[] coord = Coordinates(b1, k1, b2, k2);
    Console.WriteLine($"Пересечение двух прямых в точке с координатами [{coord[0]};{coord[1]}]");
}

double[] Coordinates(int b1, int k1, int b2, int k2)
{
    double[] coord = new double[2];
    if (b1 == b2) return coord;
    coord[0] = Math.Round((double)(b2 - b1) / (k1 - k2), 1);
    coord[1] = Math.Round((double)k1 * coord[0] + b1, 1);
    return coord;
}
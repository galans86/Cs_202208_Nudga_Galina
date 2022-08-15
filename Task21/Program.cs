// Задача 21. Напишите программу, которая принимает на вход 
// координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Destination(int xc1,int yc1, int zc1, int xc2, int yc2, int zc2)
{
    return Math.Sqrt( Math.Pow(xc2-xc1,2) + Math.Pow(yc2-yc1,2) + Math.Pow(zc2-zc1,2));
}

Console.WriteLine("Введите координаты точки А:");
Console.Write("x = ");
int xc1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yc1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int zc1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты точки B:");
Console.Write("x = ");
int xc2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y = ");
int yc2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z = ");
int zc2 = Convert.ToInt32(Console.ReadLine());

double Dest = Math.Round( Destination(xc1,yc1,zc1,xc2,yc2,zc2), 2 );
Console.WriteLine($"Расстояние между точками А({xc1},{yc1},{zc1}) и B({xc2},{yc2},{zc2}) = {Dest}");
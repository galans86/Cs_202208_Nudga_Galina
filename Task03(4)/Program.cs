// Напишите программу, которая принимает на вход
// три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите последовательно три целых числа a,b,c");
Console.Write("a = ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("b = ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("c = ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (b > max) { max = b; };
if (c > max) { max = c; };

Console.WriteLine($"Максимальное число = {max}");

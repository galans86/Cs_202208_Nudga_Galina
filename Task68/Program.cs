// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 3 n = 2 -> A(m,n) = 29

Console.Write("Введите неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
    Console.WriteLine("Ошибка ввода!");
else
    Console.WriteLine($"A({m},{n}) = {Akkerman(m, n)}");

long Akkerman(long m, long n)
{
    if (m == 0)
        return n + 1;
    else if (n == 0 && m > 0)
        return Akkerman(m - 1, 1);
    else
        return (Akkerman(m - 1, Akkerman(m, n - 1)));
}

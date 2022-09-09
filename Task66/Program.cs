// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0 || m > n)
    Console.WriteLine("Ошибка ввода!");
else
    Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {SumNaturals(m, n)}");

int SumNaturals(int m, int n)
{
    if (m == n)
        return  m;
    else if (m > n)
        return 0;
    else
        return SumNaturals(++m, --n) + m + n;
}
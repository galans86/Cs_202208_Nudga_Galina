// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree( int number, int degree)
{
    int result = 1;
    for( int i = 0; i < degree; i++)
        result *= number;

    return result;
}

Console.WriteLine("Введите число А: ");
int ac = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень B: ");
int bc = Convert.ToInt32(Console.ReadLine());

if (bc < 0) 
    Console.WriteLine("Ошибка ввода");
else
{
    int result = Degree(ac,bc);
    Console.WriteLine($"А в степени В равно {result}");
}
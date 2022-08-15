// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число N для построения таблицы кубов: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number < 1 ) 
    Console.WriteLine("Ошибка ввода");
else
{
    int count = 1;
    while(count <= number)
    {
        Console.WriteLine($"{count} | {Math.Pow(count,3)}");
        count++;    
    }
}
    
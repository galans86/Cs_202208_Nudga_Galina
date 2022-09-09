// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Введите натуральное число N: ");
int number = Convert.ToInt32(Console.ReadLine());
PrintAllNaturals(number);

void PrintAllNaturals( int num )
{
    if(num == 1)
    {
        Console.WriteLine(num);
        return;
    }
    else
    {
      Console.Write($"{num}, " );
      PrintAllNaturals( num > 0? --num: ++num );
    }
}

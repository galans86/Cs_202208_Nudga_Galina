// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int DigitSum(int number)
{
   int result = 0;
   while(number > 10)
   {
     result += number % 10;
     number /= 10; 
   }     
    return result += number;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0) 
    Console.WriteLine("Ошибка ввода");
else
{ 
    int result = DigitSum( number );
    Console.WriteLine($"Сумма цифр числа {number} равна {result}");
}
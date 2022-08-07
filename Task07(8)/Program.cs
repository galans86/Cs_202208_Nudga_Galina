//Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите целое число N для поиска всеx четных чисел от 1 до N: ");

int number = Convert.ToInt32(Console.ReadLine());
if (number < 2)
{ 
    Console.Write("Нет");
} else
{
 int number_step = 2;   
 while( number_step <= number)
  { 
   Console.Write($"{number_step} ");
   number_step = number_step + 2;
  }; 
};
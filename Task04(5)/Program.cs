// Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

Console.Write("Введите целое число N для поиска всеx целых чисел от -N до N: ");

int number = Convert.ToInt32(Console.ReadLine());
int number_step = 0 - number;

while( number_step < number)
{ 
 Console.Write($"{number_step}, ");
 number_step++;
}; 
 Console.Write($"{number_step}");
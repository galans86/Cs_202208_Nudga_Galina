 //Напишите программу, которая принимает на вход трёхзначное 
 // число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите целое трехзначное число ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0){ number = 0 - number; };
if (number >= 100 & number <= 999)
{
   string s_numb = Convert.ToString(number);
   string last = s_numb.Substring(2);
   Console.WriteLine($"Последняя цифра введенного числа = {last}");
}  else
{
  Console.WriteLine("Ошибка ввода");
};
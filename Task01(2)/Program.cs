// 
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine()); 

if (number1 == number2)
{  
Console.WriteLine($"Число {number2} равно числу {number1}"); 
} 
else if (number1 > number2)
 {
  Console.WriteLine($"Число {number1} больше числа {number2}"); 
 }
 else
 {
  Console.WriteLine($"Число {number2} больше числа {number1}"); 
 };


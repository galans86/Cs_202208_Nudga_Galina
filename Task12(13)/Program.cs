// Задача 13: Напишите программу, которая выводит
// третью цифру заданного числа или сообщает, что третьей цифры нет. Решить без использования строк.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int ThirdDigit(int number)
{ 
  int numb = number;  
  numb = numb < 0 ? numb * -1 : numb;
  if (numb < 100) return -1;
  else
  {
    while (numb >= 1000)
    {
        numb = numb / 10;
    }
    return numb % 10;
  }
}

Console.Write("Введите целое число  ");
int number = Convert.ToInt32(Console.ReadLine());
int result = ThirdDigit(number);

if (result>=0)
    Console.WriteLine($"Третья цифра числа {number} => {result}");
else
    Console.WriteLine("Третьей цифры нет");

  

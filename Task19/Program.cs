// Задача 19. Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int Length(int number)
{
    int numb = number;
    int len = 0;
    while(numb > 0)
    {
      numb = numb / 10;
      len++;
    }
    return len;
}

bool Palindrome( int number)
{
  int len = 5;  
//для переменной длины вызывать Length(number); 
//и дополнить проверкой if (len < 2) return true;

  int numb = number;
  int divider = 0;
  int FirstDigit = 0;
  int SecondDigit = 0;
  
  while(len >= 2)
  {
    divider = Convert.ToInt32(Math.Pow( 10, len - 1));
    FirstDigit = numb / divider;
    SecondDigit = numb % 10;
    if ( FirstDigit != SecondDigit ) return false;

    numb = numb % divider;
    numb = numb / 10;
    len = len - 2;
  }
  return true;
}

Console.WriteLine("Введите пятизначное исло, чтобы проверить является оно палиндромом: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Length(number) != 5) 
    Console.WriteLine("Ошибка ввода");
else 
    Console.WriteLine(Palindrome(number)? "Да" : "Нет");

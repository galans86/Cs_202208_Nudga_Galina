// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool Weekend(int number)
{
    return number <= 7 && number > 0 && ( number % 6 == 0 || number % 7 == 0 ); 
}

Console.Write("Введите цифру для проверки, является ли этот день выходным: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7 || number < 1)
    Console.WriteLine("Ошибка ввода");
else
    Console.WriteLine(Weekend(number)? "Да" : "Нет");


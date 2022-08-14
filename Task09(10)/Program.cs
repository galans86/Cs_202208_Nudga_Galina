// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondDigit(int numb)
{
    return ( numb / 10 ) % 10;
}

int number = new Random().Next(1, 1000);
Console.WriteLine($"Вторая цифра числа {number} => {SecondDigit(number)}");
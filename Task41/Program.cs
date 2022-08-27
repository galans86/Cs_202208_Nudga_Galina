// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Какое количество чисел желаете ввести?");
int m = Convert.ToInt32(Console.ReadLine());
if (m > 0)
{
    int[] array = InputArray(m);
    int result = CalcGreaterThenZero(array);
    Console.WriteLine($"Количество чисел больше 0 равно {result}");
}
else
    Console.WriteLine("Ошибка ввода");


int[] InputArray(int m)
{
    Console.WriteLine("Введите целые числа через пробел");
    string line = Console.ReadLine();
    string[] arrstr = line.Split(' ');

    int[] array = new int[m];
    for (int i = 0; i < m; i++)
        array[i] = Convert.ToInt32(arrstr[i]);
    return array;
}


int CalcGreaterThenZero(int[] array)
{
    int result = 0;
    for (int i = 0; i < m; i++)
        result += array[i] > 0 ? 1 : 0;
    return result;
}


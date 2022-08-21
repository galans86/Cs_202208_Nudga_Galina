// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for( int i=0; i < array.Length; i++)
        array[i] = rnd.Next(min, max+1);
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
     for( int i =0; i < array.Length - 1; i++)
         Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}] ");
}

int SumOddPos(int[] array)
{
    int sum = 0;
    for( int i=0; i < array.Length; i++)  
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}
int[] array = CreateArrRndInt(4,0,99);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве = {SumOddPos(array)}");

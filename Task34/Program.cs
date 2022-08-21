// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateArrRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for( int i =0; i < array.Length; i++)
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

int CountEvenNumber(int[] array)
{
    int count = 0;
    for(int i = 0;i<array.Length; i++)
    {   
     if(array[i] % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateArrRndInt(8,100,999);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {CountEvenNumber(array)}");

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateRndDouble(int size, int max)
{
    double[] array = new double[size];
    Random randObj = new Random();
    double number = 0;
    for(int i=0; i<size; i++)
    {
      number = randObj.NextDouble()*max;
      array[i] = Math.Floor(number);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
     for( int i =0; i < array.Length - 1; i++)
         Console.Write($"{array[i]}, ");
    Console.Write($"{array[array.Length - 1]}] ");
}


double[] array = CreateRndDouble(4,0,10);
PrintArray(array);
Console.WriteLine();
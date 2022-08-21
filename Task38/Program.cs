// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateRndDouble(int size, int before, int after)
{
    double[] array = new double[size];
    Random randObj = new Random();

    for(int i=0; i<size; i++)
    {
      array[i] = Math.Round( randObj.NextDouble() * Math.Pow( 10, before ), after );
    }
    return array;
}

double SubMaxMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double result = 0;
    for (int i=0; i<array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }
    result = Math.Round(max - min, 2);
    return result;
}

void PrintArray(double[] array)
{
    Console.Write("[");
     for( int i =0; i < array.Length - 1; i++)
         Console.Write($"{array[i]}  ");
    Console.Write($"{array[array.Length - 1]}] ");
}


double[] array = CreateRndDouble(4,2,1);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Разницу между максимальным и минимальным элементами массива равна { SubMaxMin(array)}");

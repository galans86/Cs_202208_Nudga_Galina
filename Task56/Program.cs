// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

int[,] CreateMatrixRndInt(int row, int col, int min, int max)
{
    var rnd = new Random();
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("]");
    }
}

int FindMinSumRow(int[,] matrix)
{
    int[] sumArray = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumArray[i] += matrix[i, j]; //массив сумм
        }
    }

    int min = sumArray[0];
    int row = 0;
    //Console.WriteLine(sumArray[0]); //для проверки
    for (int i = 1; i < sumArray.GetLength(0); i++)
    {
        //Console.WriteLine(sumArray[i]); //для проверки
        if (sumArray[i] < min)
        {
            row = i;
            min = sumArray[i];
        }
    }
    return row + 1;
}
Console.WriteLine("Исходный массив:");
int[,] matrix = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(matrix);
int row = FindMinSumRow(matrix);
Console.WriteLine($"Строка с наименьшей суммой элементов  -> {row}");

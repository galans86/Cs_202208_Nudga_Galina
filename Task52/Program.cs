// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[,] AverangeInColomn(int[,] matrix)
{
    double[,] avgMatrix = new double[1, matrix.GetLength(1)];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
        }
        avgMatrix[0, j] = Math.Round(((double)sum / matrix.GetLength(0)), 1);
    }
    return avgMatrix;
}

void PrintAvgMatrix(double[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1) - 1; j++)
    {
        Console.Write($"{matrix[0, j]};  ");
    }
    Console.WriteLine($"{matrix[0, matrix.GetLength(1) - 1]}.");
}

Console.WriteLine("Задан массив:");
int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
double[,] avgMatrix = AverangeInColomn(matrix);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintAvgMatrix(avgMatrix);
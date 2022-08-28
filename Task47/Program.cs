// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrixRndDouble(int row, int col, int intp, int decp)
{
    var rnd = new Random();
    double[,] matrix = new double[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * Math.Pow(10, intp), decp);
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("]");
    }
}
Console.WriteLine("Укажите размерность массива:");
Console.Write("rows = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("colomns = ");
int col = Convert.ToInt32(Console.ReadLine());

double[,] matrix = CreateMatrixRndDouble(row, col, 1, 1);
PrintMatrix(matrix);

// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


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

void SortMatrixRows(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 1; j < matrix.GetLength(1); j++)
        {
            int k = j;
            while (matrix[i, k] > matrix[i, k - 1]) 
            {
                int temp = matrix[i, k - 1];
                matrix[i, k - 1] = matrix[i, k];
                matrix[i, k] = temp;
                k--;
                if (k == 0) break;
            }
        }
    }
}

Console.WriteLine("Исходный массив:");
int[,] matrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine("Сортированный массив:");
SortMatrixRows(matrix);
PrintMatrix(matrix);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrixInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    int number = 1;
    int rows = matrix.GetLength(0);
    int cols = matrix.GetLength(1);
    int irow = 0;
    int jcol = 0;
    int frow = 0;
    int fcol = 0;

    while (number <= matrix.Length)
    {
        for (int j = fcol; j < cols; j++)
        {
            matrix[irow, j] = number++;
            jcol = j;
        }
        frow++;
        for (int i = frow; i < rows; i++)
        {
            matrix[i, jcol] = number++;
            irow = i;
        }

        cols--;
        for (int j = cols - 1; j >= fcol; j--)
        {
            matrix[irow, j] = number++;
            jcol = j;
        }
        fcol++;
        
        rows--;
        for (int i = rows - 1; i >= frow; i--)
        {
            matrix[i, jcol] = number++;
            irow = i;
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

Console.WriteLine("Спиральный массив:");
int[,] matrix = CreateSpiralMatrixInt(4, 4, 1, 10);
PrintMatrix(matrix);
// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


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

int[,] MultiplyMatrix(int[,] matrixFirst, int[,] matrixSecond)
{
    int[,] resultMatrix = new int[matrixFirst.GetLength(0), matrixSecond.GetLength(1)]; //строки х столбцы

    for (int row = 0; row < matrixFirst.GetLength(0); row++)
    {
        for (int col = 0; col < matrixSecond.GetLength(1); col++)
        {
            for (int i = 0; i < matrixSecond.GetLongLength(0); i++)
            {
                resultMatrix[row, col] += matrixFirst[row, i] * matrixSecond[i, col];
            }
        }
    }
    return resultMatrix;
}


Console.WriteLine("Матрица 1:");
int[,] matrixFirst = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrixFirst);
Console.WriteLine("Матрица 2:");
int[,] matrixSecond = CreateMatrixRndInt(2, 2, 1, 10);
PrintMatrix(matrixSecond);
if (matrixFirst.GetLength(1) != matrixSecond.GetLength(0))
{
    Console.WriteLine("Ошибка! Количество столбцов в первой матрице должно равняться количеству строк второй матрицы");
}
else
{
    int[,] matrixMultiply = MultiplyMatrix(matrixFirst, matrixSecond);
    Console.WriteLine("Результирующая матрица:");
    PrintMatrix(matrixMultiply);
}
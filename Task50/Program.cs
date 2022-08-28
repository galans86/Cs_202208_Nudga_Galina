// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int row, int col)
{
    var rnd = new Random();
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1,10);
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


int[,] matrix = CreateMatrixRndInt(3, 4);
PrintMatrix(matrix);
Console.WriteLine("Укажите позицию элемента в массиве:");
Console.Write("row = ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("colomn = ");
int col = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(row - 1 < matrix.GetLength(0) && col - 1 < matrix.GetLength(1) && row > 0 && col > 0 ?
                  $"Элемент равен {matrix[row-1,col-1]}":
                  "Такого элемента в массиве нет");
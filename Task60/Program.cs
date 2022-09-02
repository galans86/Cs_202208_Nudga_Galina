// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] CreateDeepArray(int row, int col, int deep)
{
    int[,,] deepArray = new int[row, col, deep];
    int number = 10;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < deep; k++)
            {
                deepArray[i, j, k] = number;
                number++;
                if (number >= 100) number = 10;
            }
        }
    }
    return deepArray;
}


void PrintDeepArray(int[,,] deepArray)
{
    for (int k = 0; k < deepArray.GetLength(2); k++)
    {
        for (int i = 0; i < deepArray.GetLength(0); i++)
        {
            for (int j = 0; j < deepArray.GetLength(1); j++)
            {
                Console.Write($"{deepArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
int[,,] deepArray = CreateDeepArray(2, 2, 2);
PrintDeepArray(deepArray);
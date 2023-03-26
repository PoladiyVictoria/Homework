// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrx = new int[rows, columns];
    Random R = new Random();
    for (int i = 0; i < matrx.GetLength(0); i++)
    {
        for (int j = 0; j < matrx.GetLength(1); j++)
        {
            matrx[i, j] = R.Next(0, 10);
        }
    }
    return matrx;
}
void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j], 4} ");
        }
        Console.WriteLine("|");
    }
}
void SortMatrixRowsFromMaxToMin(int[,] matr)
{
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int m = 0; m < matr.GetLength(1); m++)
        {
            int max = m;
            for (int j = m; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] > matr[i, max])
                {
                    max = j;
                }
                j++;
            }
            if (matr[i, m] != matr[i, max])
            {
                int buffer = matr[i, m];
                matr[i, m] = matr[i, max];
                matr[i, max] = buffer;
            }
        }
        
    }
}

Console.Write("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(row, column);
PrintMatrix(matrix);
Console.WriteLine();
SortMatrixRowsFromMaxToMin(matrix);
PrintMatrix(matrix);
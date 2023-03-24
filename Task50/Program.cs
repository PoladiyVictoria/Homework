// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

void FillMatrix(int[,] mtrx)
{
    Random rand = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
      for (int j = 0; j < mtrx.GetLength(1); j++)
      {
        mtrx[i, j] = rand.Next(0, 25);
      }  
    }
}

void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"|{mtrx[i, j],2}|");
        }
        Console.WriteLine();
    }
}

bool CheckElement(int i, int j, int[,] mtrx)
{
    return i < mtrx.GetLength(0) && j < mtrx.GetLength(1);
}

Console.Write("Введите количетсво строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетсво столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента строки:");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс элемента столбца:");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
FillMatrix(Matrix);
PrintMatrix(Matrix);
Console.WriteLine(CheckElement(rows, columns, Matrix) ? 
$"Значение заданного элемента равно: {Matrix[rows, columns]}" : "Данного элемента нет в массиве ");

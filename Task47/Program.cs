// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillMatrix(double[,] mtrx)
{
    Random rand = new Random();
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
      for (int j = 0; j < mtrx.GetLength(1); j++)
      {
        mtrx[i, j] = rand.NextDouble();
        double buffer = rand.Next(0, 33);
        mtrx[i, j] = Math.Round(mtrx[i, j] * buffer, 1);
      }  
    }
}

void PrintMatrix(double[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"|{mtrx[i, j],5}|");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количетсво строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетсво столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
double [,] Matrix = new double[m, n];
FillMatrix(Matrix);
PrintMatrix(Matrix);
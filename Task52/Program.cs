// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] Average(int[,] mtrx)
{
    double[] result = new double[mtrx.GetLength(1)];
    double sum = 0;
    int index = 0;
    for (int j = 0; j < mtrx.GetLength(1); j++)
    {
        for (int i = 0; i < mtrx.GetLength(0); i++)
        {
            sum = sum + mtrx[i, j];
        }
        double average = Math.Round(sum / (mtrx.GetLength(0)), 2);
        result[index] = average;
        index++;
    }
    return result;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.WriteLine($"{arr[arr.Length - 1]}]");
}

Console.Write("Введите количетсво строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количетсво столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] Matrix = new int[m, n];
FillMatrix(Matrix);
PrintMatrix(Matrix);
double[] averageColums = Average(Matrix);
PrintArray(averageColums);
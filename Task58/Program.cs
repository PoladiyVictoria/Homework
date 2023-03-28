// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
            Console.Write($"{matr[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}
int[,] MatrixProduct(int[,] mtrx1, int[,] mtrx2)
{
    int[,] result = new int[mtrx1.GetLength(0), mtrx2.GetLength(1)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int m = 0; m < mtrx1.GetLength(1); m++)
            {
                sum = sum + (mtrx1[i, m] * mtrx2[m, j]);
            }
            result[i, j] = sum;
        }
    }
    return result;
}
int InputNumber(string text)
{
    Console.Write($"Введите число {text}: ");
    string noconvert = Console.ReadLine();
    int numb = Convert.ToInt32(noconvert);
    return numb;
}

int row1 = InputNumber("строк 1 матрицы");
int column1 = InputNumber("столбцов 1 матрицы");
int row2 = InputNumber("строк 2 матрицы");
int column2 = InputNumber("столбцов 2 матрицы");
int[,] matrix1 = CreateMatrixRndInt(row1, column1);
int[,] matrix2 = CreateMatrixRndInt(row2, column2);
PrintMatrix(matrix1);
Console.WriteLine("x");
PrintMatrix(matrix2);
if (column1 == row2)
{
    Console.WriteLine("Результат произведения матриц");
    int[,] matrixProduct = MatrixProduct(matrix1, matrix2);
    PrintMatrix(matrixProduct);
}
else Console.WriteLine("Вычислить произведение матриц невозможно");

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
    Console.WriteLine("");
}

int[] SumRows(int[,] mtrx)

{
    int[] result = new int[mtrx.GetLength(0)];
    int index = 0;
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            sum = sum + mtrx[i, j];
        }
        result[index] = sum;
        index++;
    }
    return result;
}

int MinNumber(int[] array)
{
    int minIndex = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
    }    
    return minIndex;
}

void PrintArray(int[] arr)
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
int[,] Matrix =  CreateMatrixRndInt(m, n);
PrintMatrix(Matrix);
int[] sumRows = SumRows (Matrix);
PrintArray(sumRows);
int minNumber = MinNumber(sumRows);
Console.WriteLine($"Номер строки с наименьшей суммой элементов равна: {minNumber + 1}");


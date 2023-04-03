// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrixSpirally(int[,] mtrx)
{
    int sizei = mtrx.GetLength(0);
    int sizej = mtrx.GetLength(1);
    int num = 1;
    int i = 0; int j = 0;
    while (sizej > 0)
    {
        for (int m = 0; m < sizej; m++)
        {
            mtrx[i, j] = num;
            num++;
            j++;
        } 
        i++; j--;
        for (int m = 0; m < sizei - 1; m++)
        {
            mtrx[i, j] = num;
            num++;
            i++;
        }
        i--; j--;
        for (int m = 0; m < sizej -1; m++)
        {
            mtrx[i, j] = num;
            num++;
            j--;
        }
        i--; j++;
        for (int m = 0; m < sizei - 2; m++)
        {
            mtrx[i, j] = num;
            num++;
            i--;
        }
        i++; j++;
        sizej = sizej - 2;
        sizei = sizei - 2;
        if (sizei == 0 && sizej > 0)
        {
            sizej--;
        }
        if (sizej == 0 && sizei > 0)
        {
            sizei--;
        }
    }

}
void PrintMatrix(int[,] mtrx)
{
    for (int i = 0; i < mtrx.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < mtrx.GetLength(1); j++)
        {
            Console.Write($"{mtrx[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[rows, columns];
FillMatrixSpirally(matrix);
PrintMatrix(matrix);



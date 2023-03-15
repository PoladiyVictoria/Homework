// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void FillArray(double[] arr, int arrSize)
{
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = rand.NextDouble();
        double a = rand.Next(1, 50);
        arr[i] = Math.Round(arr[i] * a, 1);
    }
}

void PrintArray(double[] arr, int arrSize)
{
    Console.Write("[");
    for (int i = 0; i < arrSize - 1; i++)
    {
        Console.Write($"{arr[i]}; ");
    }
    Console.WriteLine($"{arr[arrSize - 1]}]");
}

double MaxNumber(double[] arr, int arrSize)
{
    double resultMax = arr[0];
    for (int i = 0; i < arrSize; i++)
    {
        if(arr[i] > resultMax)
        {
            resultMax = arr[i];
        }
    }
    return resultMax;
}

double MinNumber(double[] arr, int arrSize)
{
    double resultMin = arr[0];
    for (int i = 0; i < arrSize; i++)
    {
        if(arr[i] < resultMin)
        {
            resultMin = arr[i];
        }
    }
    return resultMin;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] array = new double[size];
FillArray(array, size);
PrintArray(array, size);
double max = MaxNumber(array, size);
double min = MinNumber(array, size);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива, равна: {Math.Round(max - min, 1)}");
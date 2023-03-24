// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int arraySize = 8;
int[] array = new int [arraySize];

FillArray(array, arraySize);
PrintArray(array, arraySize);

void FillArray(int[] arr, int arrSize)
{
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
}

void PrintArray(int[] arr, int arrSize)
{
    for (int i = 0; i < arrSize; i++)
    {
        Console.WriteLine($"[{i}]={arr[i]} ");
    }
}


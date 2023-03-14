// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] arr, int arrSize)
{
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
}

void PrintArray(int[] arr, int arrSize)
{
    Console.Write("[");
    for (int i = 0; i < arrSize - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[arrSize - 1]}]");
}

int Amount(int[] arr, int arrSize)
{
    int result = 0;
    for (int i = 0; i < arrSize; i++)
    {
        if(arr[i] % 2 == 0)
        {
            result = result + 1;
        }
    }
    return result;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, size);
PrintArray(array, size);
int amount = Amount(array, size);
Console.WriteLine($"Количество чётных чисел в массиве равно: {amount}");
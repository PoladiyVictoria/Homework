// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void FillArray(int[] arr, int arrSize)
{
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        arr[i] = rand.Next(0, 90);
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

int SumNumber(int[] arr, int arrSize)
{
    int sum = 0;
    for (int i = 1; i < arrSize; i = i +2)
    {
        sum = sum + arr[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
FillArray(array, size);
PrintArray(array, size);
int sum = SumNumber(array, size);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна: {sum}");

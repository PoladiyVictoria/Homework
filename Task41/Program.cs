// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

void FillArray(int[] arr, int arrSize)
{
    Console.Write($"Введите число под индексом ");
    for (int i = 0; i < arrSize; i++)
    {
        Console.Write($"{i}: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
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
int PositiveNumbers(int[] arr, int arrSize)
{
    int result = 0;
    for (int i = 0; i < arrSize; i++)
    {
       if(arr[i] > 0) 
       {
        result++;
       }
    }
    return result;
}

Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size]; 
FillArray(array, size);
PrintArray(array, size);
int amount = PositiveNumbers(array, size);
Console.WriteLine($"Количетсво чисел больше 0 равно: {amount}");


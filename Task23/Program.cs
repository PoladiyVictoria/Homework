// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите натуральное число N: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n > 0)
{
    Cube(n);
}
else Console.WriteLine("Введите положительное число!");

void Cube (int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i} -> {i*i*i}");
    }
}

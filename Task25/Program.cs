// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Degree(int num1, int num2)
{
    int i = 1;
    int result = 1;
    while (i <= num2)
    {
        result = num1 * result;
        i++;
    }
    return result;
}

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b > 0)
{
    int degree = Degree(a, b);
    Console.WriteLine($"Число А в степени В равно {degree} ");
}
else Console.WriteLine("Введите положительное число B!");


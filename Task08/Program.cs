//  Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите целое число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int current_numb = 1;
Console.WriteLine("Четные числа до числа N: ");
while (current_numb <= numberN)
{
    if (current_numb % 2 == 0)
    {
        Console.WriteLine(current_numb);
    }
    current_numb = current_numb + 1;
}
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumDigit(int num)
{
    int sum = 0;
    while (num > 0)
    {
        int lastDigit = num % 10;
        sum = sum + lastDigit;
        num = num / 10;
    }
    return sum;
}

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0)
{
    int sumDigit = SumDigit(number);
    Console.WriteLine($"Сумма цифр числа {number} = {sumDigit}");
}
else
{
    number = number * (-1);
    int sumDigit = SumDigit(number);
    Console.WriteLine($"Сумма цифр числа -{number} = {sumDigit}");
}


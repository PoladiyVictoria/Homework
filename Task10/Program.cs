// Напишите программу, которая принимает на вход трехзначное число 
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
 
if (number > 99 && number < 1000) 
{
    int secondNumber = SecondNumber(number);
    Console.WriteLine($"Вторая цифра введенного числа {secondNumber} ");
}
else 
{
    Console.WriteLine("Введено не трёхзначное число!");
}
int SecondNumber(int num)
{
    int digit = num / 10;
    int result = digit % 10;
    return result;
}
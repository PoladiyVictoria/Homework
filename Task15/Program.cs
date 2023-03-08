// Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите целое число: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day > 0 && day < 8)
{
    Console.WriteLine(Weekend(day) ? $"Цифра {day} является выходным" 
    : $"Цифра {day} не является выходным");
}
else 
{
    Console.WriteLine($"Цифра {day} не является днем недели");
}

bool Weekend(int num)
{
    return num == 6 || num == 7;
}

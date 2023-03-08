// Напишите программу, которая выводит третью цифру заданного числа
//  или сообщает, что третьей цифры нет.
//  645 -> 5
//  78 -> третьей цифры нет
//  32679 -> 6

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99) 
{
    int thirdNumber = ThirdNumber(number);
    Console.WriteLine($"Третья цифра введенного числа {thirdNumber} ");
}
else 
{
    Console.WriteLine("Третьей цифры нет");
}

int ThirdNumber(int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int result = num % 10;
    return result;
}

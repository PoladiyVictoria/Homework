// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 9999 && number < 100000)
{
    int firstTwoNumber = number / 1000;
    int lastTwoNumber = number % 100;
    int lastDidit = lastTwoNumber % 10;
    int firstDigit = lastTwoNumber / 10;
    int lastCheckNumber = lastDidit * 10 + firstDigit;

    Console.WriteLine(CheckPolindrome(firstTwoNumber, lastCheckNumber) ? "Число является полиндромом"
    : "Число не является полиндромом");
}
else 
{
    Console.WriteLine("Введено не пятизначное число! Введите пятизначное.");
}

bool CheckPolindrome(int num1, int num2)
{
    return (num1 == num2);
}

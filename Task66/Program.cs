// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int sumNumber(int numM, int numN)
{
     if (numM > numN) 
     {
        if ((numM + 1) == numN) return numM;
        else return numN + sumNumber(numM, numN + 1);
     }
     else 
     {
        if (numM == numN) return numN;
        else return numM + sumNumber(numM+1, numN);
     }
}

Console.Write("Введите число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine($"Сумма чисел от {numberM} до {numberN} равна {sumNumber(numberM, numberN)}");


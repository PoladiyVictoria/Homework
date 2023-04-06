// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Ackermann(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    else if (numN == 0) return Ackermann(numM - 1, 1);
    else return Ackermann(numM - 1, Ackermann(numM, numN - 1));
}


Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

int ackermann = Ackermann(m, n);
Console.WriteLine($"A({m}, {n}) = {ackermann}");

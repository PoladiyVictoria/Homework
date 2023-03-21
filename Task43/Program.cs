// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double InputNumber(string text)
{
    Console.WriteLine($"Введите значение {text}");
    string digit = Console.ReadLine();
    double result = Convert.ToDouble(digit);
    return result;
}

double FindX(double numB1, double numK1, double numB2, double numK2)
{
    return (numB2 - numB1) / (numK1 - numK2);
}

double FindY(double numB, double numK, double numX)
{
    return (numK*numX) + numB;
}

double b1 = InputNumber("b1");
double k1 = InputNumber("k1");
double b2 = InputNumber("b2");
double k2 = InputNumber("k2");
double x = Math.Round(FindX(b1, k1, b2, k2), 2);
double y = Math.Round(FindY(b1, k1, x), 2);
Console.WriteLine($"Точка пересечения прямых -> ({x} ; {y})");
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int Coordinate(string text)
{
    Console.WriteLine($"Введите значение координаты {text}");
    string digit = Console.ReadLine();
    int result = Convert.ToInt32(digit);
    return result;
}

int Square (int coord1, int coord2)
{
    int result = (coord2 - coord1)*(coord2 - coord1);
    return result;
}

int x1 = Coordinate("x1");
int x2 = Coordinate("x2");
int y1 = Coordinate("y1");
int y2 = Coordinate("y2");
int z1 = Coordinate("z1");
int z2 = Coordinate("z2");

double Leng = Math.Sqrt(Square(x1, x2) + Square(y1, y2) + Square(z1, z2));
Console.WriteLine($"Растояние между точкой А и В равно = {Math.Round(Leng, 2, MidpointRounding.ToZero)}");
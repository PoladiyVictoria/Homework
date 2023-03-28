// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)

int[,,] CreateBoxRndInt(int numX, int numY, int numZ)
{
    int[,,] Box = new int[numX, numY, numZ];
    Random R = new Random();
    for (int i = 0; i < Box.GetLength(0); i++)
    {
        for (int j = 0; j < Box.GetLength(1); j++)
        {
            for (int m = 0; m < Box.GetLength(2); m++)
            {
               Box[i, j, m] = R.Next(10, 100); 
            }
        }
    }
    return Box;
}
void PrintBox(int[,,] Box)
{
    for (int i = 0; i < Box.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < Box.GetLength(1); j++)
        {
            for (int m = 0; m < Box.GetLength(2); m++)
            {
                Console.Write($"{Box[i, j, m],4}({i},{j},{m})");
            }
        }
        Console.WriteLine("|");
    }
}
Console.Write("Введите количество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите толщину: ");
int z = Convert.ToInt32(Console.ReadLine());

int[,,] box = CreateBoxRndInt(x, y, z);
PrintBox(box);

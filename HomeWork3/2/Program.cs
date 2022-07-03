// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double Distance(int x1, int x2, int y1, int y2, int z1, int z2)
{
    double dis = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
    return dis;
}



Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1: ");
int n11 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int n12 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int n13 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2: ");
int n21 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int n22 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int n23 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Distance(n11, n21, n12, n22, n13, n23));
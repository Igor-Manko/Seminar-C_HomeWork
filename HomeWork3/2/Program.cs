// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

double points(int a, int b)
{
    double p = Math.Pow((b - a), 2);
    return p;
}

double distance(int a1, int b1, int c1, int a2, int b2, int c2)
{
    //double dis = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2) + Math.Pow((c2 - c1), 2));
    double dis = Math.Sqrt(points(a1, a2) + points(b1, b2) + points(c1, c2));
    return dis;
}

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1: ");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
int Z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2: ");
int X2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
int Y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
int Z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(distance(X1, Y1, Z1, X2, Y2, Z2));
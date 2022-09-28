/*
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53

*/

double distance ()
{
Console.WriteLine("Введите координаты X точки A: ");
int A_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки A: ");
int A_y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки A: ");
int A_z = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты X точки B: ");
int B_x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Y точки B: ");
int B_y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты Z точки B: ");
int B_z = Convert.ToInt32(Console.ReadLine());
    
    double result = Math.Sqrt(Math.Pow(A_x - B_x, 2) + Math.Pow(A_y - B_y, 2) + Math.Pow(A_z - B_z, 2));
    return result;
}

double result = distance ();
Console.WriteLine(result);

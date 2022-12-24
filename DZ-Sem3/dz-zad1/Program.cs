// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53.


using static System.Console;

WriteLine("Введите ax: ");
int ax = int.Parse(ReadLine()!);
WriteLine("Введите ay: ");
int ay = int.Parse(ReadLine()!);
WriteLine("Введите az: ");
int az = int.Parse(ReadLine()!);
WriteLine("Введите bx: ");
int bx = int.Parse(ReadLine()!);
WriteLine("Введите by: ");
int by = int.Parse(ReadLine()!);
WriteLine("Введите bz: ");
int bz = int.Parse(ReadLine()!);

double x = bx - ax;
double y = by - ay;
double z = az - bz;

double line = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2)+ Math.Pow(z,2));

WriteLine($"{line:f2}");

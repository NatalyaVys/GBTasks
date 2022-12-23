// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

using static System.Console;

WriteLine("Введите ax: ");
//bool isParse=int.TryParse(ReadLine(),out int ax);
int ax = int.Parse(ReadLine()!);
WriteLine("Введите ay: ");
//bool isParse=int.TryParse(ReadLine(),out int ay);
int ay = int.Parse(ReadLine()!);
WriteLine("Введите bx: ");
//bool isParse=int.TryParse(ReadLine(),out int bx);
int bx = int.Parse(ReadLine()!);
WriteLine("Введите by: ");
//bool isParse=int.TryParse(ReadLine(),out int by);
int by = int.Parse(ReadLine()!);

//int line = 0;
double x = bx - ax;
double y = by - ay;

double line = Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));

WriteLine($"{line:f2}");
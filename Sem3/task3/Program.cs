// Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

using static System.Console;
Clear();

WriteLine("Введите х ");
int x = Convert.ToInt32(ReadLine());
WriteLine("Введите y ");
int y = Convert.ToInt32(ReadLine());

if (x != 0 && y != 0)
{
    if (x > 0 && y > 0)
    {
        WriteLine("Точка находится в первой четверти");
    }
    else if (x < 0 && y > 0)
    {
        WriteLine("Точка находится во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        WriteLine("Точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        WriteLine("Точка находится в четвертой четверти");
    }
else
{
    WriteLine("Точка попадает на ось координат");
}
}
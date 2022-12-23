//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка

using static System.Console;
Clear();

Write("Введите номер четверти: ");
int i = int.Parse(ReadLine()!);

switch(i)
{
    case 1:
        {
            WriteLine("x>0 y>0");
            break;
        }
    case 2:
        {
            WriteLine("x<0 y>0");
            break;
        }
    case 3:
        {
            WriteLine("x<0 y<0");
            break;
        }
    case 4:
        {
            WriteLine("x>0 y<0");
            break;
        } 
    default:
        {
            WriteLine("Ошибка");
            break;
        }           
}

// if(i < 1 || i > 4)
// {
//    WriteLine("Ошибка");
//    return;
//}
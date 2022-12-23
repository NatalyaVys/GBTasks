// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

using static System.Console;
Clear();

WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);
if (day > 5 && day < 8)
{
    WriteLine("Выходной день");
}
else if (day < 6)
{
    WriteLine("Будний день");
}
if (day > 7) 
{
    WriteLine("Ошибка");
}
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5, 782 -> 8, 918 -> 1


using static System.Console;

Write("Введи число: ");
int Num = int.Parse(ReadLine()!);
int a = Num / 10;
int b = a % 10;

WriteLine("Заданное число: " + Num);
WriteLine("Вторая цифра числа: " + b);
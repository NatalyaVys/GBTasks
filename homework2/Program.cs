﻿//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

using static System.Console;

Write("введите число: ");
int Num = int.Parse(ReadLine()!);

if (Num % 2 == 0)
{
    WriteLine("да, число четное ");
}
else
{
    WriteLine("нет, число нечетное ");
}
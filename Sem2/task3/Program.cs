﻿// Задача 12:** Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 416, 4  -> кратно
using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);
int c = a%b;

if (a%b == 0)
{
    WriteLine("Кратно");
}
else
{
    WriteLine("Некратно");
    WriteLine(c);
}
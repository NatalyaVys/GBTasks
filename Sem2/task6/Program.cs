﻿// **Задача 16:**Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a == b*b)
{
   WriteLine($"Число {a} явялется квардратом числа {b}"); 
}
else if (b == a*a)
{
   WriteLine($"Число {b} явялется квардратом числа {a}");
}
else
{
    WriteLine("Ни одно число не явялется квдратом другого");
}
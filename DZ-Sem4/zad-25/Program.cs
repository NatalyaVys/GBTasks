// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа
// (A и B) и возводит число A в натуральную степень B с использованием цикла.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

using static System.Console;

WriteLine("введите число A");
int A = int.Parse(ReadLine()!);
WriteLine("введите число b");
int b = int.Parse(ReadLine()!);
int stepen = A;

for (int i = 1; i < b; i++)
{
stepen = stepen * A;
}
WriteLine("A в степени b равно: " + stepen);
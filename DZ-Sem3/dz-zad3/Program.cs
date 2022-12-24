// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, 
 // является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да.

using static System.Console;
Clear();

WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int a = number / 10000;
int b = (number / 1000) % 10;
int c = (number / 10) % 10;
int d = number % 10;

if (a == d && b == c)
{
    WriteLine("Число " + number + " является палиндромом");
}
else
{
    WriteLine("Число " + number + " не является палиндромом");
}
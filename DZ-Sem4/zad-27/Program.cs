//Задача 27: Напишите программу, реализующую метод, 
//который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

using static System.Console;

Write("введите число ");
int i = int.Parse(ReadLine()!);
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = sum + num;
}
WriteLine("сумма всех цифр в числе равна: " + sum);
// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46, 782 -> 72, 918 -> 98

using static System.Console;
int number = new Random().Next(100, 1000);
WriteLine(number);

int a1 = number/100;
int a2 = number/10;
int a3 = number%10;
int a4 = a1 * 10 + a3;

WriteLine(a4);
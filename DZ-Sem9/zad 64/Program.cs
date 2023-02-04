//*Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();

WriteLine("Введите натуральное число больше 1:");
int number = int.Parse(ReadLine()!);


void NumberCounter (int number)
{
    if (number < 0) Write($"{number} не натуральное число");
    if (number == 0) return;
    Write("{0,4}", number);
    NumberCounter (number - 1);
}
NumberCounter(number);
WriteLine();
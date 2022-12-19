// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

using static System.Console;
Clear();

Write("введите первое число: ");
int num_1 = int.Parse(ReadLine()!);

Write("введите второе число: ");
int num_2 = int.Parse(ReadLine()!);

Write("введите третье число: ");
int num_3 = int.Parse(ReadLine()!);

int max = num_1;

if (num_2 > max)
{
    max = num_2;
}
if ( num_3 > max)
{
    max = num_3;
}
WriteLine("max число: {0} ", max);
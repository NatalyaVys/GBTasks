// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

using static System.Console;
Clear();

Write("введите число: ");
int num = int.Parse(ReadLine()!);

int Count = 1;

while (Count <= num)
{
    if (Count % 2 == 0)
    {
        Write("{0} ", Count);
    }
    Count ++;
}

WriteLine("");
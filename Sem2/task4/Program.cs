// доп задача. задача вводится два числа, и показывает либо больше, либо меньше, либо равно

using static System.Console;

WriteLine("Введите первое число: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if (a>b)
{
    WriteLine(">");
}
else if (a<b)
{
    WriteLine("<");
}
else
{
    WriteLine("=");
}


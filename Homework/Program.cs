// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
using static System.Console;

 //int a = 5; b = 7 -> max = 7 ;
 //int a = 2; b = 10 -> max = 10 ;
 //int a = -9; b = -3 -> max = -3 ;

Write("Введите первое число: ");
int a = int.Parse(ReadLine()!);
Write("Введите второе число: ");
int b = int.Parse(ReadLine()!);

if ( a > b )
{
    WriteLine("Max = {0} (первое число)", a );
}
else 
if ( a < b )
{
    WriteLine("Max = {0} (второе число)", b );
}
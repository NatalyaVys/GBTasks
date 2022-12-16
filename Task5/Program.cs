using static System.Console;

Write("Введите число ");
int n = int.Parse(ReadLine()!);
if (n >= 100 && n <= 999) WriteLine(n%10);
else WriteLine("ВВедено не трехзначное число");
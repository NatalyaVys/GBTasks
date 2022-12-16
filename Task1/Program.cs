using static System.Console;

WriteLine("введите число:   ");

int a = int.Parse(ReadLine()!);
//int b = Convert.ToInt32(ReadLine());
WriteLine($"квадрат числа {a} равен {a*a}");

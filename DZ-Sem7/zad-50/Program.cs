//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого числа в массиве нет
// 1;1-> 9

using static System.Console;
Clear();

Write("Введите строку, m: ");
int num1 = Convert.ToInt32(Console.ReadLine()) - 1;
Write("Введите столбец, n: ");
int num2 = Convert.ToInt32(Console.ReadLine()) - 1;
int m = 7; 
int n = 5; 
Random random = new Random();
int[,] arr = new int[m, n];
WriteLine("Исходный массив m*n: ");
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
{
    arr[i, j] = random.Next(10, 99);
Write("{0} ", arr[i, j]);
}
WriteLine();
}
    if (num1 < 0 | num1 > arr.GetLength(0) - 1 | num2 < 0 | num2 > arr.GetLength(1) - 1)
{
WriteLine("Элемента не существует.  ");
}
    else
{
    WriteLine("Значение элемента массива = {0}", arr[num1, num2]);
}
 
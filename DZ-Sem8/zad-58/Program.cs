// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//  Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;
Clear();

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] array2 = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(array);
PrintArray2(array);
WriteLine();

FillArrayRandom(array2);
PrintArray2(array2);
WriteLine();

if (array.GetLength(0) != array2.GetLength(1))               // если матрица не квадрат
{
    WriteLine("Нельзя перемножить");
   return;
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array2.GetLength(1); j++)
    {
        resultArray[i, j] = 0;
        for (int k = 0; k < array.GetLength(1); k++)
        {
            resultArray[i, j] += array[i, k] * array2[k, j];
        }
    }
}

PrintArray2(resultArray);

int ReadInt(string message)                     // функция ввода
{
    Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArrayRandom(int[,] array)                  // заполнения массива рандомными числами от 1 до 9
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 9);
        }
    }
}


void PrintArray2(int[,] array)                          // вывод двумерного массива в терминал 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }
}


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;
 Clear();
 
WriteLine("введите количество строк:");
int linesVol = Convert.ToInt32(Console.ReadLine());
WriteLine("введите количество столбцов:");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];

FillArrayRandomNumbers(numbers);

WriteLine("введеный массив:");
PrintArray(numbers);
            
    for (int a = 0; a < numbers.GetLength(0); a++)
{
    for (int b = 0; b < numbers.GetLength(1) - 1; b++)
    {
    for (int c = 0; c < numbers.GetLength(1) - 1; c++)
      {
    if (numbers[a, c] < numbers[a, c + 1]) 
    {
         int temp = 0;
        temp = numbers[a, c];
        numbers[a, c] = numbers[a, c + 1];
        numbers[a, c + 1] = temp;
       }
      }
    }
}

WriteLine("массив с упорядоченными значениями:");
PrintArray(numbers);
            
void FillArrayRandomNumbers(int[,] array)
 {
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
             array[a, b] = new Random().Next(0, 10);
            }
        }
    }

void PrintArray(int[,] array)
    {
    for (int a = 0; a < array.GetLength(0); a++)
     {
        Write("[ ");
        for (int b = 0; b < array.GetLength(1); b++)
        {
        Write(array[a, b] + " ");
        }
    Write("]");
    WriteLine("");
    }
 }
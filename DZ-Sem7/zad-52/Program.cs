// Задача 52. Напишите программу реализующую методы, формирования двумерного массива 
//и массива средних арифметических значений каждого столбца.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;
Clear();

Write("Введите количество строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Write("Введите количество столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
       
int[,] numbers = new int[n, m];
FillArrayRandomNumbers(numbers);
            
            
for (int j = 0; j < numbers.GetLength(1); j++)
    {
    double SrAr = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
     SrAr = (SrAr + numbers[i, j]);
    }
    SrAr = SrAr / n;
       Write($"{SrAr + "; "}"); 
    }
    WriteLine("");
     PrintArray(numbers);
            

void FillArrayRandomNumbers(int[,] array)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = new Random().Next(0, 10);
        }
        }
    }
    
void PrintArray(int[,] array)
    {
            
    for (int i = 0; i < array.GetLength(0); i++)
        {
        Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Write(array[i, j] + " ");
        }
        Write("]");
        WriteLine("");
       }
    }

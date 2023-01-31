//  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//  Массив размером 2 x 2 x 2
//  66(0,0,0) 25(0,1,0)
//  34(1,0,0) 41(1,1,0)
//  27(0,0,1) 90(0,1,1)
//  26(1,0,1) 55(1,1,1)
// взрыв мозга))))

using static System.Console;
Clear();

int[,,] array3D = new int[2, 2, 2];
FillArray(array3D);
PrintIndex(array3D);


void PrintIndex(int[,,] arr)                        // Функция вывода индекса элементов 3D массива
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            WriteLine();
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Write($"{array3D[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

void FillArray(int[,,] arr)                             // Функция заполнения 3D массива не повторяющимеся числами
{
    int count = 10;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[k, i, j] += count;
                count += 3;    
            }
        }
    }
}
WriteLine();
// Задача 34: Напишите программу реализующую методы формирования массива, 
// заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


using static System.Console;
Clear();

WriteLine("Введите длину массива:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);

PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

int count = 0;
for (int x = 0; x < numbers.Length; x++)
{
if (numbers[x] % 2 == 0)
count++;
}
WriteLine($"в данном массиве, {count} четных. ");


void PrintArray(int[] numbers)
{
    Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Write(numbers[i] + " ");
    }
    Write("]");
    WriteLine();
}

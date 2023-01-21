//Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами 
//           и вычисления разницы между максимальным и минимальным элементов массива.
// [3,3 / 7,1/ 22,5/ 2,2/ 78,2] -> 76


using static System.Console;
Clear();

Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] number = new double[size];
FillArrayRandomNumbers(number);
PrintArray(number);

double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        {
            max = number[a];
        }
    if (number[a] < min)
        {
            min = number[a];
        }
}
WriteLine($"Максимальное = {max}, Минимальное = {min}");
WriteLine($"Разность между Max и Min = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        {
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
        }
}
void PrintArray(double[] number)
{
    Write("[ ");
    for(int i = 0; i < number.Length; i++)
        {
        Write(number[i] + " ");
        }
    Write("]");
    WriteLine();
}
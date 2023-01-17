//Задача 29: Напишите программу, реализующую метод, который формирует массив случайных
//целых чисел из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19,6, 1, 33 -> [1, 2, 5, 7, 19,6, 1, 33 ]

using static System.Console;

int lenArr = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArr];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Write(randomArray[i] + " ");
}


// Функция ввода
int ReadInt(string message)      // 
{
    WriteLine(message );
    return Convert.ToInt32(Console.ReadLine());
}
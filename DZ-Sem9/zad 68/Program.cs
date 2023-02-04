// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29//


using static System.Console;
Clear();

Write("Введите начальное число M: ");
int numberM = int.Parse(ReadLine()!);

Write("Введите начальное число N: ");
int numberN = int.Parse(ReadLine()!);

//Метод вычисления функции Аккермана:
int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
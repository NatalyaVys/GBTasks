//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8  12-> 2  85 -> 8

using static System.Console;
int number = new Random().Next(10,100);

WriteLine(number);
int a1=number/10;    //целочисленное деление
int a2=number%10;    //вернет нам младший разряд
//int max=a1>a2?a1:a2;          // тернарный оператор?значение истины,:иначе
//WriteLine(max);

WriteLine(a1>a2?a1:a2);
//if (a1>a2)
//{
//WriteLine(a1);
//}
//else 
//{
 //   WriteLine("a2");
//}
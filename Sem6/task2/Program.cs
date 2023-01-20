//задача 40. программа на вход принимает на вход три числа 
//и проверяет, может ли существовать треугольник со сторонами такой длины.

using static System.Console;

//треугольник abc

int a = askNumber("введите сторону a: ");
int b = askNumber("введите сторону b: ");
int c = askNumber("введите сторону c: ");

WriteLine(IsTriangle(a,b,c) ? $"Треугольник со сторонами {a}, {b}, {c} существует." : $"Треугольник со сторонами {a}, {b}, {c} не существует.");

bool IsTriangle(int inA, int inB, int inC)
{
    if (a+b> c && a+c >b && b+c>a)  return true;
    return false;
}


int askNumber(string inPrompt)
{
    int resultNum = 0;
    string userInput = "";
    while(!int.TryParse(userInput, out resultNum))
    {
        Console.Write(inPrompt);
        userInput= Console.ReadLine()!;
    }
    return resultNum;
}

// Задача 42. Программа будет преобразовывать десятичное число в двоичное.
// 1. 45-> 101101, 2. 3-> 11, 3. 2-> 10.

using static System.Console;

int num = askNumber("Ввведите число для преревода в двоичную систему: ");

WriteLine(decimalToBinary(num));

string decimalToBinary(int inNum)
{
string result = string.Empty;

int rem;        // остаток- rem
while (inNum >0)
{
    
    rem = inNum % 2;
    inNum /= 2;
    result = rem.ToString() + result;
}
return result;
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
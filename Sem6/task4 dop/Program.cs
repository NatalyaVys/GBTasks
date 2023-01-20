// 6 знаков билетик, сумма первых трех равна сумме вторых трех.

using static System.Console;

//WriteLine("введите номер билета:  ");
//string ticket = ReadLine();

int ticket = askNumber("ведите номер билета: ");
WriteLine(IsLuckyTicket(ticket) ? $"билетик {ticket} счастливый./n" : $"билетик {ticket} не счастливый./n");

bool IsLuckyTicket(int inNum)

{
int a = inNum / 100000;
int b = (inNum / 10000) % 10;
int c = (inNum / 1000) % 10;
int d = (inNum % 1000) / 100;
int e = (inNum % 1000) / 10 % 10;
int f = (inNum % 1000) % 10;
  
//для проверки вычеслений
//WriteLine ($"{a} {b} {c} {d} {e} {f}");
return (a + b + c== d + e + f);
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
// N Число фибоначи(ряд) без рекурсии

using static System.Console;
Clear();

WriteLine($"ряд фибоначи = [{string.Join(",", fibonachi(20))}]");
//{string.Join(",", array)

int[] fibonachi(int N)
{
    int[] result = new int[N];
    result[0] = 0;
    result[1] = 1;
    for(int i = 2; i < N; i ++)
    {
        result[i] = result[i-1] + result[i-2];
    }
return result;
}

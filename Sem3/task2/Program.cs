//По номеру дня недели вывести его название

using static System.Console;
Clear();

WriteLine("Введите номер дня недели: ");
int day = Convert.ToInt32(ReadLine());

switch(day)
{
    case 1:
        {
            WriteLine("Понедельник");
            break;
        }
    case 2:
        {
            WriteLine("Вторник");
            break;
        }
    case 3:
        {
            WriteLine("Среда");
            break;
        }
    case 4:
        {
            WriteLine("Четверг");
            break;
        }
    case 5:
        {
            WriteLine("Пятница");
            break;
        }
    case 6:
        {
            WriteLine("Суббота");
            break;
        }
    case 7:
        {
            WriteLine("Воскресенье");
            break;
        }
    default:
        {
            WriteLine("Это не день недели");
            break;
        }
}
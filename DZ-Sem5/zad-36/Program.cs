// Задача 36: Напишите программу реализующую методы формирования массива, 
//заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


using static System.Console;
Clear();


Write($"Введи длину массива: ");
int ElementNumbers = Convert.ToInt32(Console.ReadLine()); 
int randomNumber =  RandomNumbers(ElementNumbers, 1, 10);
WriteLine($"  Сумма элементов, стоящих на нечётных позициях: {randomNumber}");
 
int RandomNumbers(int ElementNumbers, int min, int max)

  {
  int[] randomNumber = new int[ElementNumbers];
  int sumElements = 0;
  Write("[");
  
    for (int i = 0; i < randomNumber.Length; i++ )
    {
      randomNumber[i] = new Random().Next(min, max);
    
      Write(randomNumber[i] + " ");
      
      if (i % 2 != 1)
      {
        sumElements = sumElements + randomNumber[i];
      }
    }
   Write("]");   
  return sumElements;

   }
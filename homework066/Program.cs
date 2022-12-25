/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string message)
{
   int result = 0;
   while (true)
   {
      Console.WriteLine(message);
      if (int.TryParse(Console.ReadLine(), out result))
      {
         break;
      }
      else
      {
         Console.WriteLine("Ввели не число");
      }
   }
   return result;
}

int Summ(int m, int n)
{
   int summ = 0;
   if (m <= n)
   {
      summ = m + Summ(m + 1, n);
   }
   return summ;
}

int m = GetNumber("Введите число m");
int n = GetNumber("Введите число n");
Console.WriteLine($"{Summ(m, n)}");

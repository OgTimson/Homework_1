/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

Console.WriteLine("Введите число N:");
string NStr = Console.ReadLine();
int N = Math.Abs(Convert.ToInt32(NStr)); // чтобы взять числа по модулю

Console.WriteLine("Все четные числа от 1 до вашего N числа:");

for (int i = 1; i <= N; i++)
{
  if (i % 2 == 0)
  {
    Console.Write($"{i}, ");
  }
}
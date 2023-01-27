/*
Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

Console.WriteLine("Введите целое число:");
string numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
int remains = number % 2;

if (remains == 0)
{
    Console.WriteLine($"Да, число {number} - четное!");
}
else
{
    Console.WriteLine($"Нет, число {number} - нечетное!");
}
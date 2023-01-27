/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

Console.WriteLine("Введите первое число:");
string number1Str = Console.ReadLine();
double number1 = Convert.ToDouble(number1Str);

Console.WriteLine("Введите второе число:");
string number2Str = Console.ReadLine();
double number2 = Convert.ToDouble(number2Str); // Чтобы можно было использовать числа с запятой

if (number1 > number2)
{
    Console.WriteLine($"max = {number1}");
}
else
{
    Console.WriteLine($"max = {number2}");
}
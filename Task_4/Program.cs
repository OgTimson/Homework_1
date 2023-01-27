/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

Console.WriteLine("Введите первое число:");
string number1Str = Console.ReadLine();
double number1 = Convert.ToDouble(number1Str); // Чтобы можно было использовать числа с запятой

Console.WriteLine("Введите второе число:");
string number2Str = Console.ReadLine();
double number2 = Convert.ToDouble(number2Str); // Чтобы можно было использовать числа с запятой

Console.WriteLine("Введите третье число:");
string number3Str = Console.ReadLine();
double number3 = Convert.ToDouble(number3Str); // Чтобы можно было использовать числа с запятой

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"max = {number1}");
}
else if (number2 > number3)
{
    Console.WriteLine($"max = {number2}");
}
else
{
    Console.WriteLine($"max = {number3}");
}
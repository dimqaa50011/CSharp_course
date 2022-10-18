// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

System.Console.Write("Введите первое чило: ");
int num1 = Int32.Parse(System.Console.ReadLine());

System.Console.Write("Введите первое чило: ");
int num2 = Int32.Parse(System.Console.ReadLine());

System.Console.Write("Введите первое чило: ");
int num3 = Int32.Parse(System.Console.ReadLine());

int max = num1;

if (num2 > max) max = num2;
if (num3 > max) max = num3;

System.Console.WriteLine($"{num1}, {num2}, {num3} -> {max}");
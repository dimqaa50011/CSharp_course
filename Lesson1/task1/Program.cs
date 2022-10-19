//  Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int num1 = Int32.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Int32.Parse(Console.ReadLine());

int max = num1;
if (num2 > max)
{
    max = num2;
}

Console.WriteLine($"num1={num1}; num2={num2} -> max={max}");
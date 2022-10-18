// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

System.Console.Write("Введите целое число: ");
int digit = Int32.Parse(System.Console.ReadLine());

string answer;

if (digit % 2 == 0)
{
    answer = "Четное";
}
else
{
    answer = "Нечетное";
}

System.Console.WriteLine(answer);
// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите целое число: ");

int userAnswer = Int32.Parse(System.Console.ReadLine());
int counter = 2;

string result = "";

while (counter < userAnswer)
{
    result += $"{counter}, ";
    counter+=2;
}


System.Console.WriteLine(result);

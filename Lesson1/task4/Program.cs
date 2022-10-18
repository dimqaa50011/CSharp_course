// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

System.Console.Write("Введите целое число: ");

int userAnswer = Int32.Parse(System.Console.ReadLine());
int counter = 0;

string result = "";

while (counter < userAnswer)
{
    counter++;
    if (counter % 2 == 0)
    {
        result += $"{counter},";
    }
    else
    {
        continue;
    }

    
}

System.Console.WriteLine(result);

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Не использовать строки для

int Prompt(string msg)
{
    System.Console.WriteLine(msg);
    int answer = Int32.Parse(System.Console.ReadLine());
    return answer;
}

bool ValidDigit(int number)
{
    if (number < 100 || number >= 1000)
    {
        System.Console.WriteLine($"Введенное число не являеся трехзначиным. number={number}");
        return false;
    }
    return true;
}

void OnStartup()
{
    int num = Prompt("Введите трехзначное целое число: ");
    if (ValidDigit(num))
    {
        System.Console.WriteLine((num % 100) / 10);
    }
}

OnStartup();
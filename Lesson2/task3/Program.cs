// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Не использовать строки для расчета.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int num = Int32.Parse(System.Console.ReadLine());
    return num;
}

bool Validator(int num)
{
    if (num < 100)
    {
        return false;
    }
    return true;
}

int GetThirdDigit(int num)
{
    int tmp = num;
    while (true)
    {
        if (tmp >= 100 && tmp < 1000)
        {
            int result = tmp % 10;
            return result;
        }

        tmp /= 10;
    }

}


void OnStartup()
{
    int num = Prompt("Введите цисло: ");
    if (Validator(num))
    {
        int result = GetThirdDigit(num);
        System.Console.WriteLine($"{num} -> {result}");
    }
    else {
        System.Console.WriteLine($"{num} -> третьей цифры нет");
    }

}

OnStartup();
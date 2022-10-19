//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

int Prompt(string msg)
{
    System.Console.Write(msg);
    int num = Int32.Parse(System.Console.ReadLine());
    return num;
}

bool GetDayOfTheWeek(int digit)
{
    int[] daysOfTheWeek = { 1, 2, 3, 4, 5 };
    foreach (int element in daysOfTheWeek)
    {
        if (element == digit)
        {
            return true;
        }
    }
    return false;
}

void Main()
{
    int digit = Prompt("Введите цифру: ");

    string dayOff = "Нет";

    if (digit == 6 || digit == 7)
    {
        dayOff = "Да";
    }
    else if (!GetDayOfTheWeek(digit))
    {
        dayOff = "Такого дня недели не сущеcтвует";
    }

    System.Console.WriteLine($"{digit} -> {dayOff}");
}

Main();
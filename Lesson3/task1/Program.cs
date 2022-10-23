// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Без использования строк

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

bool ValidateNumber(int num)
{
    if (num >= 10000 && num < 100000)
    {
        return true;
    }
    return false;
}

int GetDigit(int num, int rate)
{
    int result = Convert.ToInt32(num % Math.Pow(10, rate + 1)) / Convert.ToInt32(Math.Pow(10, rate));
    return result; 
}

bool GetPalindrome(int num)
{
    int[] tmpArr = new int[5];
    int count = 0; 

    while (count < 5)
    {
        tmpArr[count] = GetDigit(num, count); 
        count++;
    }


    if (Enumerable.SequenceEqual(tmpArr, tmpArr.Reverse()))
    {
        return true;
    }
    return false;
}

void Starter()
{
    int num = Prompt("Введите пятизначное число: ");
    if (ValidateNumber(num))
    {
        string answer = "Нет";
        if (GetPalindrome(num))
        {
            answer = "Да";
        }

        System.Console.WriteLine($"{num} -> {answer}");
    }
    else
    {
        System.Console.WriteLine($"Число не пятизначное num={num}");
    }
}

Starter();
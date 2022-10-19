// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Не использовать строки для расчета.


void OnStartup()
{
    int num = new Random().Next(100, 1000);
    int firstDigit = num / 100;
    int lastDigit = num % 10; 

    System.Console.WriteLine($"{num} -> {firstDigit}{lastDigit}"); 
}

OnStartup();
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

string GetCubeTable(int num)
{
    double[] cubes = new double[num];
    for (int i = 0; i < num; i++)
    {
        cubes[i] = Math.Pow(i + 1, 3);
    }

    return string.Join(", ", cubes);
}

void Starter()
{
    int number = Prompt("Введите число: ");
    string cubes = GetCubeTable(number);
    System.Console.WriteLine($"{number} -> {cubes}");
}

Starter();
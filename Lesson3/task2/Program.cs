// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84 

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Prompt(string msg)
{
    System.Console.Write(msg);
    return int.Parse(Console.ReadLine());
}

double GetDistance(Dictionary<char, int[]> coords)
{
    int[] difference = new int[3];
    double result = 0;

    for (int i = 0; i < difference.Length; i++)
    {
        difference[i] = coords['A'][i] - coords['B'][i]; 
    } 

    for (int i = 0; i < difference.Length; i++)
    {
        result += Math.Pow(difference[i], 2);
    }

    return Math.Round(Math.Sqrt(result), 2);
}

Dictionary<char, int[]> GetPoints()
{
    char[] pointsNames = new char[2] {'A', 'B'};
    char[] coordNames = new char[3] {'x', 'y', 'z'};

    var data = new Dictionary<char, int[]>();
    for (int i = 0; i < pointsNames.Length; i++)
    {
        int[] tmpArrData = new int[3];
        for (int j = 0; j < coordNames.Length; j++)
        {
            int coord = Prompt($"Введите координату {coordNames[j]} для точки {pointsNames[i]}: ");
            tmpArrData[j] = coord;
        }

        data.Add(pointsNames[i], tmpArrData);
    }

    return data;
}

void PrintResult(Dictionary<char, int[]> data, double result)
{
    string answer = "";

    foreach (var item in data)
    {
        answer += $"{item.Key} ({String.Join(", ", item.Value)}) ";
    }
    answer += $"-> {result}";

    System.Console.WriteLine(answer);
}

void Starter()
{
    var data = GetPoints();
    double result = GetDistance(data);
    PrintResult(data, result);
}

Starter();
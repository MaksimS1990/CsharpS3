// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4.

Console.Clear();
Console.WriteLine();

Console.Write("Введите число:   ");
string writeN = Console.ReadLine()!;
int N = Convert.ToInt32(writeN);

int[] GetSqrtTable(int N)
{
    int[] SqrtArray = new int[N];
    
    for (int i = 0; i < N; i++)
    {
        SqrtArray[i] = (i + 1) * (i + 1);
    }

    return SqrtArray;
}

void PrintTable(int[] Array)
{
    int number = 1;
    for (int i = 0; i < Array.Length; i++)
    {
        Console.WriteLine($"{number} ^ 2 = {Array[i]}");
        number++;
    }
}

int[] SqrtTable = GetSqrtTable(N);
PrintTable(SqrtTable);

Console.WriteLine("Введите координаты точки А (х,y)");
int xa = int.Parse(Console.ReadLine()!);
int ya = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координаты точки B (х,y)");
int xb = int.Parse(Console.ReadLine()!);
int yb = int.Parse(Console.ReadLine()!);

double Length(int xa, int ya, int xb, int yb)
{
    double result = 0;
    result =  Math.Sqrt(Math.Pow((xa - xb), 2) + Math.Pow((ya - yb), 2));
    return result;
}

Console.WriteLine("Длина отрезка " + Length(xa, ya, xb, yb));


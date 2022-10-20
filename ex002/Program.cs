// Задача 21: Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве.
//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double distance (int[] dotsA, int[] dotsB)
{
    return Math.Sqrt(Math.Pow(dotsA[0]-dotsB[0], 2)+Math.Pow(dotsA[1]-dotsB[1], 2));
}

int[] dotsA = new int[2];
int[] dotsB = new int[2];

Console.WriteLine("Enter the X(A):");
dotsA[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(A):");
dotsA[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the X(B):");
dotsB[0] = int.Parse(Console.ReadLine()!);

Console.WriteLine("Enter the Y(B):");
dotsB[1] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(distance(dotsA, dotsB),3));

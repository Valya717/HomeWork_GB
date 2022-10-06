/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.Clear();
double [] coord1 = new double [3];
int i = 0;
Console.Write("Первая точка имеет координаты (X,Y,Z): ");
while (i<coord1.Length )
{
    coord1[i] = new  Random().Next(-50,51);
    Console.Write(coord1[i] + " ");
    i++;
}
double [] coord2 = new double [3];
i = 0;
Console.Write("\nВторая точка имеет координаты (X,Y,Z): ");
while (i<coord2.Length )
{
    coord2[i] = new  Random().Next(-50,51);
    Console.Write(coord2[i] + " ");
    i++;
}
Console.WriteLine();


i = 0;
double sum =0;
while (i<coord1.Length)
{
    double x = Math.Abs (coord1[i] - coord2[i]);
    sum = sum + x*x;
    i++;
}
double result = Math.Sqrt (sum);
Console.WriteLine ("Расстояние между первой и второй точкой: " + result);
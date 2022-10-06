Console.Clear();
int [] coord1 = new int [2];
int i = 0;
Console.Write("Первая точка имеет координаты (X,Y): ");
while (i<coord1.Length )
{
    coord1[i] = new Random().Next(-50,51);
    Console.Write(coord1[i] + " ");
    i++;
}
int [] coord2 = new int [2];
i = 0;
Console.Write("\nВторая точка имеет координаты (X,Y): ");
while (i<coord2.Length )
{
    coord2[i] = new Random().Next(-50,51);
    Console.Write(coord2[i] + " ");
    i++;
}
Console.WriteLine();

i = 0;
int sum =0;
while (i<coord1.Length)
{
    int x = Math.Abs (coord1[i] - coord2[i]);
    sum = sum + x*x;
    i++;
}
double result = Math.Sqrt (sum);
Console.WriteLine ("Расстояние между первой и второй точкой: " + result);
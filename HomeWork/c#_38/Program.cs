// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] CreateArray (int x)
{
     return new double [x];
}

void FillArrayRandomFromBefore(double[] array, int x, int y)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble(x, y);
    }
}

void PrintArray(double [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write(array[i] + ", ");
    }
  
}
double [] array = CreateArray (10);
FillArrayRandomFromBefore (array, -15, 100);
PrintArray (array);

int  i = 0;
int length = array.Length;
double maxNum = array[i];
double minNum = array[i];

while (i<length)
{
    if (array [i]> maxNum)
    {
        maxNum = array [i];
    }
    else if (array[i]< minNum)
    {
        minNum = array [i];
    }
    i ++;
}
Console.WriteLine();
Console.WriteLine($"Максимальное цисло равно: {maxNum}.");
Console.WriteLine($"Минимальное цисло равно: {minNum}.");
Console.WriteLine($"Разница чисел равна: {maxNum -minNum }");
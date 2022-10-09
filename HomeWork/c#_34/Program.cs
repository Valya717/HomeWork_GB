// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Clear();

void FillArrayRandomFromBefore (int [] array, int x, int y)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(x,y);
    }
}

void PrintArray (int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write (array[i] + ", ") ;
    }
}

int [] array = new int [20];
FillArrayRandomFromBefore(array, 100, 1000);
PrintArray(array);
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
    {
       count ++; 
    }
}
Console.WriteLine( $"Колличество четных чисел равно: {count}.");
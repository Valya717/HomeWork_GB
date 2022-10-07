// Задача 30: Напишите программу, которая выводит массив из воьми элеметов , заполненный 0 и 1 в случайном порядке

Console.Clear();

int [] array = new int [8];
int i = 0;
while (i<array.Length)
{
    array[i] = new Random().Next(0,2);
    Console.Write(array[i] +" ");
    i++;
}
Console.WriteLine();
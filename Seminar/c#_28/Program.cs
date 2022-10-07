// Задача 28: Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N
// 4->24;
// 5->120;

Console.Clear();

Console.WriteLine("Введите число: ");
int N = Convert.ToInt32 (Console.ReadLine());
int i = 1;
int result = 1;
while (N>=i)
{
    result = result * i;
    i++;
}
Console.WriteLine($"Произведение чисел от 1 до {N} равно: {result} ");
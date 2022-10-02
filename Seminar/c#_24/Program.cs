// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36
Console.Clear();
int n = new Random().Next(1,11);
int sum = 0;
int index = 1;
while (index<=n)
{
    sum = sum + index;
    index++;
}

Console.WriteLine ($"Сумма от 1 до {n} равна: {sum}");
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Clear();

int n = new Random().Next(1,6);
int n1 = new  Random().Next(1,6);
Console.Write ($"Цисло {n} в степени {n1} равно:");
int mult = 1;
int i = 0;
while (i<n1)
{
    mult = mult * n;
    i++;
}
Console.Write (mult);
Console.WriteLine ();


// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int num3;
num3 = Convert.ToInt32(Console.ReadLine());

int max;
max = num;

if(max > num2)
{max = max;}
else max = num2;

if(max > num3)
{max = max;}
else max = num3;

Console.Write("Большее число: ");
Console.WriteLine(max);

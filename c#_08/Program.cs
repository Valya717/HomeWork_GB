// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число больше 1: ");
int num;
num = Convert.ToInt32(Console.ReadLine());
int res = 2;

while (num >= res)
    {
    Console.Write(res + ", ");
    res+=2;
    }

Console.Write(" - четные числа от 1 до " );
Console.WriteLine(num);



// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите число: ");
int num;
num = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int num2;
num2 = Convert.ToInt32(Console.ReadLine());

if (num > num2)
    {
        Console.Write("Большее число: ");
    Console.WriteLine(num);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num2);
    }

else
    {
   Console.Write("Большее число: ");
    Console.WriteLine(num2);
    Console.Write("Меньшее число: ");
    Console.WriteLine(num);
    }

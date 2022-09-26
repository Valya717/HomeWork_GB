/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36*/
int n = new Random().Next (1,100); //[1...100)
Console.WriteLine (n);
int x = 1;
int sum = 0;
while (x<=n)
{sum = sum + n;
x++;
}
Console.WriteLine (sum);

    
    
    

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32 (Console.ReadLine());
int i = 1;
Console.Write($"Квадрат чисел от 1 до {n} : ");
while (i<=n)
{
    Console.Write(i*i + " ");
    i++;
}

 Console.WriteLine();
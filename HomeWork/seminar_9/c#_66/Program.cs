// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NumbersSum(int m, int n)
{
    int sum =0;
    if (m < n) return sum += m + NumbersSum (m+1, n);
    if (m == n) return sum +=  m;
    if (n < m) return sum += m + NumbersSum ( m-1, n);
    else return sum;
}
Console.WriteLine("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int sum = NumbersSum ( m, n);
Console.WriteLine ($"Сумма чисел между {m} И {n} включительно равна: {sum}");
// Задача 64: Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int a, int n)
{
    if (a < n)
    {
       return NumbersRec (a+1, n) + $"{a} " ;
    }
     if (a == n)
    {
       return $"{a} " ;
    }
    else if (n < a)
    {
       return  NumbersRec (a-1, n) +  $"{a} " ;
    }
    else return String.Empty;
}
Console.WriteLine (NumbersRec (1, n));
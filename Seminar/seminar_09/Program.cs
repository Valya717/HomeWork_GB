
// string Inversion (string x)
// {
//     if (x.Length<0) return x [x.Length-1];
//     return Inversion + x[ x.Length-1]-1;
// }
// string x = "Hello";
// Inversion(x);

// Задайте число N. Напишите программу, которая выдает все натуральные числа от 1 до N.
Console.WriteLine("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
string NumbersRec(int a, int n)
{
    if (a < n)
    {
       return $"{a} " + NumbersRec (a+1, n) ;
    }
     if (a == n)
    {
       return $"{a}" ;
    }
    else if (n < a)
    {
       return  NumbersRec (a-1, n) + $" {a}" ;
    }
    else return String.Empty;
}
Console.WriteLine (NumbersRec (1, n));
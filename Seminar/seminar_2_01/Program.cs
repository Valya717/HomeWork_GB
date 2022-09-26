// Напишите программу, которая выводит случайное число из отрезка [10, 99] и
 // показывает наибольшую цифру числа. 
 //78 -> 8 
 // 12-> 2 
 // 85 -> 8

 
 int n = new Random().Next (10,100); //[10...99)
 Console.WriteLine (n);
 int x = n/10;
 int r = n - x*10;
 if (x > r)
Console.WriteLine (x);
 else Console.WriteLine (r);

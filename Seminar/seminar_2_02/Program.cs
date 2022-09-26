// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
 int n = new Random().Next (100,1000); //[100...999)
 Console.WriteLine (n);
 int n1 = n/100;
 int n2 = n % 100;
 int n3 = n2 %10;
 Console.Write (n1);
 Console.WriteLine (n3);
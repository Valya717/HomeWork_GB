/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

int n = new Random().Next(10000,100000);
Console.Write (n);
int a = n%10;
int b =(n%100-a)/10; 
int c= n/10000;
int d = n/1000 - c *10; 
if (a==c &  b==d)
{
    Console.WriteLine (" - является полиндромом");
}
else 
{
    Console.WriteLine (" - не полиндромом");
}


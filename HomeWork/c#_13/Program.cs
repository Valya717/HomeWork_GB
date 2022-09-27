/*Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6*/
/*int n = new Random().Next (1,100000); //[1...100000)
Console.WriteLine (n);*/
Console.Write("Введите число: ");
int n;
n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
    {
    Console.WriteLine ("Третьей цифры нет");
    }
else 
while (n>=1000)
    {
    n /= 10;
    }
 Console.WriteLine ($"Третья цифра {n%10}");
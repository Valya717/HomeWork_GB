
Console.Clear();
int number = new Random().Next(1,5);
Console.WriteLine(number + "- четверть");

if (number == 1 )
{
    Console.WriteLine("Координаты могут быть: x от 0 до 100, y от 0 до 100");
} 
if (number == 2 )
{
    Console.WriteLine("Координаты могут быть: x от -100 до 0, y от 1 до 100");
} 
if (number == 3 )
{
    Console.WriteLine("Координаты могут быть: x от -100 до 0, y от -100 до 0");
} 
if (number == 4 )
{
    Console.WriteLine("Координаты могут быть: x от 0 до 100, y от -100 до 0");
} 

Console.Clear();
int [] array = new int [2];
int i = 0;
while (i<array.Length )
{
    array[i] = new Random().Next(-10,11);
    Console.WriteLine(array[i]);
    i++;
}
if (array[0]>0 &array[1] >0 )
{
    Console.WriteLine("1 четверть");
}

if (array[0]<0 &array[1]>0)
{
    Console.WriteLine("2 четверть");
}
if (array[0]<0 &array[1]<0)
{
    Console.WriteLine("3 четверть");
}
if (array[0]>0 &array[1]<0)
{
    Console.WriteLine("4 четверть");
}
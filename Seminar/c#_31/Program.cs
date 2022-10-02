Console.Clear();
int count = 10;
int [] array = new int [count];
int find = new Random().Next(1,21);
int index = 0;
Console.Write ($"Искомое число:  \n{find}");
Console.WriteLine ("\nИз массива чисел:");
while (index<count)
{
    array[index] = new Random().Next(1,101);
    Console.Write(+ array[index]+ " ");
    index++;
}
index = 0;
bool element = false;
while (index<count)
{
    if (array[index]==find)
    {
    element = true; 
    }
    index++;
}

if (element)
{
    Console.WriteLine ("\nИскомое число имеется в массиве");
}
else 
{
    Console.WriteLine ("\nИскомое число отсутствует в массиве");
}

// Найти точки пересечения двух прямых на координатной оси.
Console.Clear();

int [] array = new int [4];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next (-50,51); 
    Console.WriteLine ($"Точка  х{i+1} равна: {array[i]}");
}
// array[0] = 0;
// array[1] = 1;
// array[2] = 0;
// array[3] = -5;
// Console.WriteLine ($"Точка  х1 равна: {array[0]}");
// Console.WriteLine ($"Точка  х2 равна: {array[1]}");
// Console.WriteLine ($"Точка  х3 равна: {array[2]}");
// Console.WriteLine ($"Точка  х4 равна: {array[3]}");
if (array[0]>array[1])
{
    int help = array[0];
    array[0]= array[1];
    array [1] = help;
}
if (array[2]>array[3])
{
    int help = array[2];
    array[2]= array[3];
    array [3] = help;
}


if (array[2]< array[0])
{
    if (array[3]<array[0])
    {
        Console.WriteLine ("Отрезки не пересекаются");
    }    
     else  if (array[3]==array[0])
    {
        Console.WriteLine ($"Отрезки пересекаются в точке {array[0]} ");
    }
    else  if (array[3]<array[1])
    {
        Console.WriteLine ($"Отрезки пересекаются от точки {array[0]} до {array[3]} ");
    }
    else Console.WriteLine ($"Отрезки пересекаются от точки {array[0]} до {array[1]} ");
}
else if (array[2]< array[1])
{
    if (array[3]<array[1])
    {
        Console.WriteLine ($"Отрезки пересекаются от точки {array[2]} до {array[3]} ");
    }    
    else Console.WriteLine ($"Отрезки пересекаются от точки {array[2]} до {array[1]} ");
}
else if (array[2] == array[1])
{
   Console.WriteLine($"Отрезки пересекаются в точке {array[1]} ");
}
else Console.WriteLine ("Отрезки не пересекаются");

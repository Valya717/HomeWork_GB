// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

void FillArrayRandomFromBefore (int [] array, int x, int y)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(x,y);
    }
}

void PrintArray (int [] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write (array[i] + ", ") ;
    }
}

int [] array = new int [7];
FillArrayRandomFromBefore(array, -100, 101);
PrintArray(array);
int result = 0;
for (int i = 1; i <array.Length; i+=2)
{
    result += array[i];
}
Console.WriteLine ($"Сумма элементов на нечетных позциях (по индексу как в примере) равна: {result}. ");
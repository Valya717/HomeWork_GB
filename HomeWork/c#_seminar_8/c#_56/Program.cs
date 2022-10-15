// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Console.Clear();
void FillMatrixRandomFromBefore(int[,] matrix, int x, int y)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(x, y);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if ((matrix[i, j] > 9 & matrix[i, j] < 100) | (matrix[i, j] < 0 & matrix[i, j] > -10))
                Console.Write($"  {matrix[i, j]}|");
            else if ((matrix[i, j] >= 0 & matrix[i, j] < 10))
                Console.Write($"   {matrix[i, j]}|");
            else if ((matrix[i, j] < -9 & matrix[i, j] > -100))
                Console.Write($" {matrix[i, j]}|");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите колличество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[x, y];
FillMatrixRandomFromBefore(matrix, 0, 10);
PrintMatrix(matrix);
int sumMinString = 0;
for (int i = 0; i < y; i++)
{
    sumMinString += matrix[0, i];
}
int sum = 0;
int numberMinString = 1;
for (int i = 1; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    if (sum < sumMinString)
    {
    sumMinString = sum;
    numberMinString = i+1;
    }
    sum =0;
}
Console.WriteLine($" Наименьшая сумма элементов равна {sumMinString} в строке {numberMinString}");
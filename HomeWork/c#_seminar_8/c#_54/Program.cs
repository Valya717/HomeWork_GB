// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
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

void SortedFromMaxBeforeMinElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sortedSize = 0;
        while (sortedSize < matrix.GetLength(1))
        {
            int help = 0;
            int min = matrix[i, 0];
            for (int j = 0; j < matrix.GetLength(1)-1; j++)
            {
                if (matrix[i, j + 1] > min)
                {
                    help = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = help;
                }
                else min = matrix[i, j + 1];
            }
            sortedSize ++;
        }
    }
}

Console.Write("Введите колличество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[x, y];
FillMatrixRandomFromBefore(matrix, 0, 10);
PrintMatrix(matrix);
SortedFromMaxBeforeMinElement(matrix);
Console.WriteLine("Массив с элементами по убыванию:");
PrintMatrix(matrix);
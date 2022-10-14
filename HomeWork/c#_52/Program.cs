// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
Console.Clear();

void FillMatrixRandomFromBefore (int [,] matrix, int x, int y)
{
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           matrix[i,j] = new Random().Next(x,y);
        }
    }
}

void PrintMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
    Console.WriteLine();
    }
}

void AVG (int [,] matrix)
{
    
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        double del = matrix.GetLength(0);
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        Console.WriteLine($"Среднее арифметичесоe стобца {i+1} равно: {sum / del}.");
    }
}
Console.Write("Введите колличесвто строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличесвто столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int [,] matrix = new int [x,y];
FillMatrixRandomFromBefore(matrix, -10, 11);
PrintMatrix(matrix);
AVG (matrix);
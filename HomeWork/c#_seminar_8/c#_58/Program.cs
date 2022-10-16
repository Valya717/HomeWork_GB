// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
                Console.Write($"  {matrix[i, j]}|"); //-9,-8..-1,10,11..99
            else if ((matrix[i, j] >= 0 & matrix[i, j] < 10))
                Console.Write($"   {matrix[i, j]}|");//0..9
            else if ((matrix[i, j] < -9 & matrix[i, j] > -100) | (matrix[i, j] > 99 & matrix[i, j] < 1000))
                Console.Write($" {matrix[i, j]}|");//-99,-98..-10, 100..999
        }
        Console.WriteLine();
    }
}

int x = new Random().Next(3, 5);
int y = new Random().Next(3, 5);
int z = new Random().Next(3, 5);
// int x = 4;
// int y = 4;
// int z = 3;

Console.WriteLine($"Матрица А: колличество строк {x}, колличество столбов {y}.");
Console.WriteLine($"Матрица B: колличество строк {y}, колличество столбов {z}.");
Console.WriteLine();
int[,] matrixA = new int[x, y];
int[,] matrixB = new int[y, z];
int[,] matrixC = new int[x, z];
FillMatrixRandomFromBefore(matrixA, 0, 10);
Console.WriteLine("Матрица А:");
PrintMatrix(matrixA);
Console.WriteLine("Матрица B:");
FillMatrixRandomFromBefore(matrixB, 0, 10);
PrintMatrix(matrixB);
for (int i = 0; i < matrixC.GetLength(0); i++)
{
    for (int j = 0; j < matrixC.GetLength(1); j++)
    {
        int sum = 0;
        if (z > x)
        {
            {
                for (int l = 0; l < matrixC.GetLength(0); l++)
                {
                    sum += matrixA[i, l] * matrixB[l, j];
                }
                matrixC[i, j] = sum;
            }
        }
        else
        {
            for (int l = 0; l < matrixC.GetLength(1); l++)
            {
                sum += matrixA[i, l] * matrixB[l, j];
            }
            matrixC[i, j] = sum;
        }
    }
}
Console.WriteLine("Матрица C (A*B):");
PrintMatrix(matrixC);
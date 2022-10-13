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
            Console.Write($"{matrix[i,j]}  ");
        }
    Console.WriteLine();
    }
}

int stringMatrix = new Random().Next(2,5);
int columnMatrix = new Random().Next(2,5);
int [,] matrix = new int [stringMatrix, columnMatrix];
FillMatrixRandomFromBefore (matrix, 0 , 10);
PrintMatrix(matrix);
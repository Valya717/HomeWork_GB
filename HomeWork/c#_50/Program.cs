// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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

int stringMatrix = new Random().Next(2,6);
int columnMatrix = new Random().Next(2,6);
int [,] matrix = new int [stringMatrix, columnMatrix];
FillMatrixRandomFromBefore (matrix, 0 , 51);
PrintMatrix(matrix);
Console.WriteLine($"Введите искомое число: ");
int x = Convert.ToInt32(Console.ReadLine());
bool element = false;
int col = 0;
int str = 0;
for (int i = 0; i < matrix.GetLength(0) ; i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           if (matrix[i,j] == x)
            {
                element = true;
                col = j+1;
                str = i+1;
                break;
            }           
        }
    }
if (element==true)
{
    Console.WriteLine ($"Искомое число имеется в строке {str}, столбце {col}.");
}
else 
{
    Console.WriteLine ("\nИскомое число отсутствует в массиве");
}
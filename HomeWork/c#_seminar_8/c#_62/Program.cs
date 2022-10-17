// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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
int y= 4;//строки
int x =4;//столбцы
int[,] snail = new int[x, y];
int startNum = 1;//заполняем от 1
int finishNun =x*y;//заканчиваем заполнять
int count = 0;// колличество кругов
int i=0;
while (startNum<=finishNun)
{
for (int j = count; j < x-count; j++)
{
    snail[i, j] = startNum;
    startNum++;
    if (j == x-(count+1)) i = j;
}
for (int l = count+1; l < y-count; l++)
{
    snail[l, i] = startNum;
    startNum++;
}
for (int k = i-1; k >= count; k--)
{
    snail[i, k] = startNum;
    startNum++;
}
for (int m = i-1; m > count; m--)
{
    snail[m, count] = startNum;
    startNum++;
}
count ++;
i = count;
}

PrintMatrix(snail);
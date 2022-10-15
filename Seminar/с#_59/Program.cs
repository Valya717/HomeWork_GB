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

void PrintArray(int[] array)

{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        Console.Write(array[index] + " ");
        index++;
    }
}

// SearchCountMinNum здесь найдем сколько элементов минимальных. Работает.
int SearchCountMinNum(int[,] matrix)
{
    int minNum = matrix[0, 0];
    int minNumHelp = matrix[0, 0];
    int countMinNum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] <= minNum)
            {
                minNum = matrix[i, j];
                if (minNumHelp > minNum)
                {
                    countMinNum = 0;
                    minNumHelp = minNum;
                }
                if (minNumHelp == minNum) countMinNum++;
            }

        }
    }
    return countMinNum;
}
// SearchMinNumbersIndex найдем  индексы минимальных элементов и запишем в два массива
// массив индексов строк и массиве индексов стобов. Работает.
void SearchMinNumbersIndex(int[,] matrix, int[] StringIndexMinElement, int [] ColumnIndexMinElement, int countMinNum)
{
    int minNum = matrix[0, 0];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < minNum) minNum = matrix[i, j];
        }
    }
    for (int l = 0; l < countMinNum; l++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == minNum)
                {
                    StringIndexMinElement[l] = i;
                    ColumnIndexMinElement[l] = j;
                    l++;
                }
            }
        }
    }
}
// DeleteStringColumnAndPrint Удалим и распечатаем все строки и столбцы. НЕ РАБОТАЕТ
// void DeleteStringColumnAndPrint(int[,] matrix, int[] StringIndexMinElement, int[] ColumnIndexMinElement, int countMinNum)

// {
  
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             if (i == StringIndexMinElement[help])
//             while (help < countMinNum)
//             {
                
//             }
//             if (i != StringIndexMinElement[help])
//         }
    
   
// }

Console.Write("Введите колличество строк: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите колличество столбцов: ");
int y = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[x, y];
FillMatrixRandomFromBefore(matrix, 0, 10);
PrintMatrix(matrix);
int countMinNum = SearchCountMinNum(matrix);
Console.WriteLine($"Минимальных чисел: {countMinNum} ");
int[] StringIndexMinElement = new int[countMinNum];
int [] ColumnIndexMinElement = new int[countMinNum];
SearchMinNumbersIndex(matrix, StringIndexMinElement, ColumnIndexMinElement, countMinNum);
Console.WriteLine("Позиции минимальных чисел");
PrintArray(StringIndexMinElement); 
Console.WriteLine();
PrintArray(ColumnIndexMinElement);
// Console.WriteLine();
// DeleteStringColumnAndPrint(matrix, StringColumnIndexMinElement, countMinNum);
int [,] newMatrix = new int [x-countMinNum,y-countMinNum];
Console.WriteLine();
PrintMatrix(newMatrix);

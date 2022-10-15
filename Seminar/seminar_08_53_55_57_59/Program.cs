// Задайте двумерный массив, программа, которая поменяет местами первую и последнюю строку.
Console.Clear();
// Методы FillMatrixRandomFromBefore и PrintMatrix используются в каждой задаче, прописаны один раз
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
// Console.Write ("Введите колличество строк: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int [x,y];
// FillMatrixRandomFromBefore (matrix, -99, 100);
// Console.WriteLine("Я заполнила случайными числами. Смотри что получилось: ");
// PrintMatrix (matrix);

// int strUp = 0;
// int strDown = matrix.GetLength(0)-1;
// int help = 0;
// for (int i = 0; i < matrix.GetLength(1); i++)
// {
//     help = matrix[strUp,i];
//     matrix[strUp,i]= matrix[strDown,i];
//     matrix[strDown,i] = help;
// }
// Console.WriteLine();
// Console.WriteLine("Хочешь поменяю первую и последнюю строчку местами?Тогда нажми 1. Если не хочешь нажми 2.");
// int q = Convert.ToInt32(Console.ReadLine());
// if(q == 1) PrintMatrix(matrix);
// else Console.WriteLine("Ну хочешь??? А я так старалась!");
// // 

// // 55. программа которая меняет строки на стобцы или невозсожно сообщает

// void FillMatrixRandomFromBefore (int [,] matrix, int x, int y)
// {
//     for (int i = 0; i < matrix.GetLength(0) ; i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//            matrix[i,j] = new Random().Next(x,y);
//         }
//     }
// }

// void PrintMatrix (int [,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0) ; i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if ((matrix[i,j] >9 & matrix[i,j]  <100) | (matrix[i,j] < 0 & matrix[i,j] > -10)) 
//             Console.Write($"  {matrix[i,j]}|");
//             else if ((matrix[i,j] >= 0 & matrix[i,j]  <10 )) 
//             Console.Write($"   {matrix[i,j]}|");
//             else if ((matrix[i,j] < -9  & matrix[i,j]  > -100 )) 
//             Console.Write($" {matrix[i,j]}|");
//         }
//     Console.WriteLine();
//     }
// }

// Console.Write ("Введите колличество строк: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите такое же колличество столбцов: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int [x,y];
// if(x != y ) Console.WriteLine("Так не получиться. Надо столько же!");
// else 
// {FillMatrixRandomFromBefore(matrix, -9,10);
// PrintMatrix(matrix);
// Console.WriteLine();
// int help=0;


//   for (int i = 0; i < matrix.GetLength(0); i++)
// {
//     for (int j = i+1; j <  matrix.GetLength(1); j++)
//     {
//         help = matrix[i,j];
//         matrix[i,j]= matrix[j,i];
//         matrix[j,i] = help;
//     }

// }


// PrintMatrix(matrix);
// }
// 57. найти скольео раз всречается цифра в массиве

// void SearchNumbers (int [,] matrix)
// {
//     for (int num = 0; num < 10; num++)
//     {
//         int count =0;
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             for (int j = 0; j < matrix.GetLength(1); j++)
//             {
//                 if ( matrix[i,j] == num  ) count ++;
//             }
//         }
//         if (count != 0) Console.WriteLine ($"Число {num} встречается в массиве {count} раз.");
//     }
// }
// Console.Write ("Введите колличество строк: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите колличество столбцов: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int [,] matrix = new int [x,y];
// FillMatrixRandomFromBefore (matrix, 0, 10);
// PrintMatrix (matrix);
// SearchNumbers(matrix);

// 59. Удалить строку и стобец на пересечении нахождения наименьшего элемента в массиве
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
// SearchMinNumbersIndex найдем поочередно индексы минимальных элементов (стр 1 эл, столб 1эл, стр 2эл, столб 2 эл...)
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
// DeleteStringColumnAndPrint Удалим и распечатаем все строки и столбцы
void DeleteStringColumnAndPrint(int[,] matrix, int[] StringIndexMinElement, int[] ColumnIndexMinElement, int countMinNum)

{
    
   
}

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

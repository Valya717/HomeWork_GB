// Задача 31.
// Задайте массив из 12 элементов, заполненный случайными числами в промежутке от -9 до 9. 
// Найдите сумму отрицательных и положительных чисел.

Console.Clear();
// void FillArrayRandomFromBefore (int [] array, int x, int y)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(x,y);
//     }
// }

// void PrintArray (int [] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write (array[i] + ", ") ;
//     }
// }

// int [] array = new int [12];

// FillArrayRandomFromBefore  (array, -99, 100);
// Console.Write("Даны числа:");
// PrintArray(array);
// Console.WriteLine();
// int index = 0;
// int sumPos = 0;
// int sumNeg = 0;
//     while (index < array.Length)
//     {
//         if (array[index] <0)
//         {
//             sumNeg += array[index];
//             index++;
//         }
//         else 
//         {
//             sumPos += array[index];
//             index++;
//         }
//     }
// Console.WriteLine( $"Сумма отрицательных чисел составит: {sumNeg}.");
// Console.WriteLine( $"Сумма положительных чисел составит: {sumPos}.");

// Задача 32.
// Напишите программу замены чисел массива: положительные на отрицательные и наоборот
// void FillArrayRandomFromBefore (int [] array, int x, int y)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(x,y);
//     }
// }

// void PrintArray (int [] array)
        // {
        //     int length = array.Length;
        //     for (int i = 0; i < length; i++)
        //     {
        //         Console.Write (array[i] + ", ") ;
        //     }
        // }

// int[] array = new int [8];
// FillArrayRandomFromBefore (array, -50, 51);
// PrintArray(array);
// Console.WriteLine();

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = - array[i];
// }

// PrintArray(array);
// Console.WriteLine();

// Задача 33. Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// void FillArrayRandomFromBefore(int[] array, int x, int y)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(x, y);
//     }
// }

// void PrintArray(int[] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         Console.Write(array[i] + ", ");
//     }
// }

// void SearchNum(int[] array, int x)
// {
//     Console.Write($"Цифра {x} есть в нем? Ответ: ");
//     int length = array.Length;
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i] == x)
//         {
//             count++;
//             break;
//         }
//     } 
//     if (count>0)
//     {
//         Console.WriteLine ("Yes");
//     }
//     else Console.WriteLine ("No");
// } 
// int [] array = new int [10];
// FillArrayRandomFromBefore(array, -10, 10);
// Console.Write("Дан массив:");
// PrintArray(array);
// Console.WriteLine();
// SearchNum(array,5);


    

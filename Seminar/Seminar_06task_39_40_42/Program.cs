// 39.Программа которая перевернет одномерный массив

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
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write (array[i] + ", ") ;
//     }
//     Console.WriteLine (array[length-1]);
//  }

// Console.WriteLine ("Введите колличество эллементов в массиве: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int [] array = new int [n];
// FillArrayRandomFromBefore (array, 0, 101);
// Console.WriteLine ("Массив: ");
// PrintArray (array);

// int i = 0;
// int help = 0;
// int length = array.Length;
// int j = 1;
// while (i < length/2)
// {
//     help = array [i];
//     array[i] = array[length-j];
//     array[length-j] = help;
//     i++;
//     j++;
   
// }
// Console.WriteLine ("Перевернутый массив: ");
// PrintArray (array);

// 40. Принимает три числа и проверяет может быть треугольник со сторонами такой длины.

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
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write (array[i] + ", ") ;
//     }
//     Console.WriteLine (array[length-1]);
//  }
// int [] array = new int [3];
// FillArrayRandomFromBefore (array, 0, 101);
// Console.Write ("Длины равны: ");
// PrintArray (array);
// int sum01 = array[0]+array[1];
// int sum12 = array[1]+array[2];
// int sum02 = array[0]+array[2];
// if (sum01 > array[2] && sum12 > array[0] && sum02 > array[1]) 
// {
//     Console.Write("Можно начертить треугольник.");
// }
// else Console.Write("Треугольник не получится.");

// 42. Программа, которая будет преобразовывать десятичное число в двоичное

// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32 (Console.ReadLine());
// int count = 0;
// int a = n;
// while (a>0)
// {
//     a = a/2;
//     count ++;
// }
// int [] array = new int [count];
// int length = array.Length;
// while (n>0)
// {
//     array[length-1] = n%2;
//     n =n/2;
//     length--;
// }
// void PrintArray (int [] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write (array[i] ) ;
//     }
//     Console.WriteLine (array[length-1]);
//  }
//  PrintArray (array);

// 44. Не используя рекурсию, вывести первые N чисел Фибоначчи. Первые два числа 0 и 1.

// Console.WriteLine("Введите число:");
// int F = Convert.ToInt32 (Console.ReadLine());
// void PrintArray (int [] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write (array[i] + " ") ;
//     }
//     Console.WriteLine (array[length-1]);
// }
// int [] array = new int [F];
// array [0] = 0;
// array [1] = 1;
// int i = 2;
// while (i < F)
// {
//     array [i]= array [i-2] + array [i-1];
//     i++;
// }

// Console.Write($"Первые {F} чисел Фибоначи:");
// PrintArray (array);

// 45. Программа, копия заданного массива (поэлементное копирование)
// Console.WriteLine ("Введите колличество элементов массива: ");
// int F = Convert.ToInt32 (Console.ReadLine());
// void PrintArray (int [] array)
// {
//     int length = array.Length;
//     for (int i = 0; i < length-1; i++)
//     {
//         Console.Write (array[i] + " ") ;
//     }
//     Console.WriteLine (array[length-1]);
// }
// int [] array = new int [F];
// void FillArrayRandomFromBefore (int [] array, int x, int y)
// {
//     int length = array.Length;
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = new Random().Next(x,y);
//     }
// }

// FillArrayRandomFromBefore (array, -100, 101);
// Console.WriteLine ("Выведен массив элементов: ");
// PrintArray(array);
// int length = array.Length;
// int [] arrayCopy = new int [F];
// for (int i = 0; i < length; i++)
// {
//     arrayCopy[i] = array[i];
// }
// Console.WriteLine ("Выведена копия массива элементов: ");
// PrintArray(arrayCopy);
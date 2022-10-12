// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
Console.WriteLine ("Сколько чисел будете вводить? ");
int F = Convert.ToInt32 (Console.ReadLine());
int [] array = new int [F];
Console.WriteLine ("Введите числа: ");
int i = 0;
while (i<F)
{
    array[i] = Convert.ToInt32 (Console.ReadLine());
    i++;
}
int count =0;
for (int j = 0; j < F; j++)
{
    if (array[j] % 2==0) count ++;
}
if (count == 0) Console.WriteLine ($"Четных чисел нет.");
else Console.WriteLine ($"Четных чисел {count} ");

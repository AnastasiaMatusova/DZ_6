// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.WriteLine("Задайте количество вводимых чисел:");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = new int[m];

int[] arrayM(int m)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите чило {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
int[] newArray = arrayM(m);
int result(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
result(newArray);
Console.WriteLine($"{string.Join(", ", array)} → {result(newArray)}");


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите значение b1:");
double b1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите значение k1:");
double k1 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите значение b2:");
double b2 = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine("Введите значение k2:");
double k2 = Convert.ToUInt32(Console.ReadLine());
if (k1 == k2 && b1 == b2) Console.WriteLine($"\n Прямые совпадают");
else
{
    if (k1 == k2 && b1 != b2) Console.WriteLine($"\n Прямые паралельны");
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = x * k1 + b1;
        Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} → ({x}; {y})");
    }
}
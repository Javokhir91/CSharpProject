﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
Console.Clear();

double[] array = { 3, 7, 22, 2, 78 };

double count = 0;
double max = 0;
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    
    if (array[i] < min) min = array[i];
}
count = max - min;
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(min);
Console.WriteLine(max);
Console.WriteLine("Разница между max и min = " + count);
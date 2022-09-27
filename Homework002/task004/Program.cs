// Задача 228: Напишите программу, которая принимает на вход семь чисел, 
// и находит их среднее арифметическое

// 1 2 3 4 5 6 7-> 4
// 10 20 30 40 50 60 70 -> 40

// Первый вариант 

int[] array = {1, 2, 3, 4, 5, 6, 7};
int length = array.Length;
int index = 0;
int sum = 0;
while (index < length)
{
    sum = array[index] + sum;
    index++;
}
int average = sum / length;
Console.WriteLine($"среднее арифметическое число = {average}");

// Второй и лучший Вариант

// Console.WriteLine("Введите планируемое количество чисел:");

// int count = int.Parse(Console.ReadLine());
// int sum = 0;
// for (int i = 1; i <= count; i++)
// {
// Console.WriteLine($"Введите {i}-ое число:");
// int number = int.Parse(Console.ReadLine());
// sum = sum + number;
// }
// int average = sum / count;
// Console.WriteLine(average);

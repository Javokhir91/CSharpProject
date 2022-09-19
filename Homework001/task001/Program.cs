Console.Write("Введите первое число :  ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число :  ");
int num_2 = Convert.ToInt32(Console.ReadLine());

if (num_1 > num_2)  {
    Console.WriteLine("Максимальное число :  " + num_1);
    Console.WriteLine("Минимально число :  "  + num_2);
}
else    {
    Console.WriteLine("Максимальное число :  " + num_2);
    Console.WriteLine("Минимально число :  "  + num_1);
}
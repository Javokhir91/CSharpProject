Console.WriteLine("Введите число : ");
int N = Convert.ToInt32(Console.ReadLine());
int start_N = 1;

while (start_N < N) {
    if (start_N % 2 == 0)
        Console.WriteLine(start_N);
        start_N++; 
}

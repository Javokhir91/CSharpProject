// Фунции 
// Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}
// Method1();

// Вид2 
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}
// Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    for (int i = 0; i < count; i++) // метод for
    {
        Console.WriteLine(msg);
    }
}
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++; //еще этот метод называют инкрементом 
//     }
// }
// Method21(msg: "Текст сообщения", count: 4);
//Вид3
// если метод что то вощвращает то в начале метода пропишем тип метода 
// (string или int и тд)
int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
// Console.WriteLine(year);

// Вид4
string Method4(int count, string text)
{
    // int = 0;
    string result = String.Empty; // Empty означает что пустая строка
    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
string res = Method4(10, "\nasd");
// System.Console.WriteLine(res);

// Цикл в цикле : таблица умножение 
for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($" {i} x {j} = {i * j} ");
    }
    Console.WriteLine();
}

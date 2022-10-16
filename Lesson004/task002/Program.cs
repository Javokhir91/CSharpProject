/*Задача №23
напишите программу, которая принимает на вход число (N) и 
выдает таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear(); // для очистки консол

int ReadData(string line) //  читаю данные от пользователя
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}

void PrintData(string text, string value) // вывожу данные
{
    Console.WriteLine(text + value);
}

string LineNum(int numN, int p) // нахожу длину и возведение 
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i, p);
    }
    return outLine;
}

int numN = ReadData("Введите число N: ");

string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 3);

PrintData("", lineTop);
PrintData("", lineDown);
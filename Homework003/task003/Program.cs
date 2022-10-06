#region Задача №23
/*Задача №23
напишите программу, которая принимает на вход число (N) и 
выдает таблицу кубов чисел от 1 до N.
Например:
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
#endregion

Console.Clear(); // для очистки консол

#region ReadData // читаю данные от пользователя
int ReadData(string line) //  читаю данные от пользователя
{
    Console.WriteLine(line);
    int number = int.Parse(Console.ReadLine() ?? "");
    return number;
}
#endregion

#region PrintData // вывожу данные
void PrintData(string text, string value) // вывожу данные
{
    Console.WriteLine(text + value);
}
#endregion

#region LineNum // нахожу длину и возведение
string LineNum(int numN, int p) // нахожу длину и возведение 
{
    string outLine = "1";
    for (int i = 2; i <= numN; i++)
    {
        outLine = outLine + " " + Math.Pow(i, p);
    }
    return outLine;
}
#endregion

int numN = ReadData("Введите число N: ");

string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 3);

PrintData("", lineTop);
PrintData("", lineDown);
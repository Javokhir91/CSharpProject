#region 
/*Задача №19
Напишите метод, который принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
#endregion

Console.Clear(); // для очистки консол

#region ReadData //  читаю данные от пользователя
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

#region PaliTest // проверяю число на палиндром..
string PaliTest(int number) // проверяю число на палиндром..
{
    int pal = 0;
    int num = number;
    while (number > 0)
    {
        pal = pal * 10 + number % 10; number = number / 10;
    }
    return num == pal ? "Палиндром" : "Не палиндром";
}
#endregion

int user = ReadData("Введите число: ");
PrintData("Число: ", PaliTest(user));
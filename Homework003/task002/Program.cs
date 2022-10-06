#region Задача №21
/* Задача №21
Напишите метод, который принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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

#region FindLenth //ищу рассторянию
double FindLenth(int x1, int y1, int z1, int x2, int y2, int z2) //ищу рассторянию 
{
    return Math.Sqrt
  (
        Math.Pow(x1 - x2, 2) +
        Math.Pow(y1 - y2, 2) +
        Math.Pow(z1 - z2, 2)
  );

}
#endregion

int x1 = ReadData("Введите координату х первой точки: ");
int y1 = ReadData("Введите координату х второй точки: ");
int z1 = ReadData("Введите координату z второй точки: ");
int x2 = ReadData("Введите координату y первой точки: ");
int y2 = ReadData("Введите координату y второй точки: ");
int z2 = ReadData("Введите координату z второй точки: ");

double result = FindLenth(x1, y1, z1, x2, y2, z2);
result = Math.Round(result, 2);
PrintData("Расстояние между точками: ", result.ToString());
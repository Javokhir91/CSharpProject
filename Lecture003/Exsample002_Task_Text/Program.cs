/* ==== Работа с текстом
Дан текст. В тексте нужно все пробели заменить черточками, 
маленькие буквы "к" заменить большими "К",
а большие "С" заменить маленькими "с".

Ясна ли задача? */

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";  //Лев Толстой : Война и мир(1868)

//string s = "qwerty"
//            0123     - индексы 
// индекс s[3] // буждет "r" 
string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '|');
Console.WriteLine(newText); // код не работает - лекция №3, 25минута
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);

/* 1. Найти позицию минимального элемента в неотсортированной части массива
   2. Произвести обмен этого значения со значением первой неотсортированной позиции
   3. Повторять пока есть не отсортированные элементы */
int [] arr = {1,5,4,3,2,6,7,1,1}; //создаем массив из неотсортированных элементов 

void PrintArray(int [] array) // создаем метод что бы распетать массив с элементами 
{
    int count = array.Length; 

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
// PrintArray(arr);

void SelectionSort(int [] array) // создаем метов Сортировки элементов в массиве / 1 1 1 2 3 4 5 6 7
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length ; j++)  // этот блок только ищет максимальный элемент 
        {
            if (array[j] > array[minPosition])
            {
                minPosition = j;
            }
        }
        int tempoArray = array[i]; // сдесь присходит обмен вместами 
        array[i] = array[minPosition];
        array[minPosition] = tempoArray;
    }
}

// SelectionSort(arr);
// PrintArray(arr);
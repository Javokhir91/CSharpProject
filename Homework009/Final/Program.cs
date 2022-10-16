// Вариант первый 
char[] collection = ("Зада4ча: Напи3сать програм23му, котор4ая").ToCharArray();
var result = string.Empty;
foreach(var item in collection)
{
if(!char.IsDigit(item))
result+= item;
}
Console.WriteLine(result);

// Вариант втрой 

// char [] collection = ("Зада4ча: Напи3сать програм23му, котор4ая").ToCharArray(); 
// int count = 0;
// foreach (char item in collection)
// { 
//   if(!char.IsDigit(item))
//   {
//   count++;
//   }
// }
// //Этот код определит нецифры
// char[] newArr = new char[count];
// //Массив длиной определенной ранее
// count =0;
// foreach (char item in collection) 
// { 
//  if(!char.IsDigit(item))
//     {
//     newArr[count]=item;
//     count++;    
//     }
// }
// System.Console.WriteLine(newArr);

 
// Console.WriteLine("Введи: ");

// string strings = "Зада4ча: Напи3сать програм23му, котор4ая из сформ324ированного";
// string newString = "";
// for (int i = 0; i < strings.Length; i++)
// {
//     if (!char.IsNumber(strings[i])) 
//     {
//         newString += strings[i];
//     }
// }
// System.Console.WriteLine(newString);

// string [] collection = {"Зада4ча: Напи3сать програм23му, котор4ая"};

// foreach (var item in collection) 
// {
//     for (int i = 0; i < collection.Length; i++)
//     {
//         if (!char.IsDigit(collection[i]))
//         {
//             System.Console.WriteLine(collection[i]);
//         }
//     }
//     System.Console.WriteLine(item);
// }
// System.Console.WriteLine();



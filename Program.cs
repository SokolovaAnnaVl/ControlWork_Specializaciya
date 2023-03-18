// Задача: Написать программу, которая из имеющегося массива строк
//  формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры: [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”] 
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”] 
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

// string[] GetArray = new string[] {"Hello", "2", "world", "2235" };
string[] GetArray = new string[] {“1234”, “1567”, “- 2”, “computer science” };
// string[] GetArray = new string[] {“Russia”, “Denmark”, “Kazan”};
string[] NewArray = new string[GetArray.Length];

void GetArrayThreeSymbols(string[] GetArray, string[] NewArray)
{
    int count = 0;
    for (int i = 0; i < GetArray.Length; i++)
    {
    if(GetArray[i].Length <= 3)
        {
        NewArray[count] = GetArray[i];
        count++;
        }
    }
}
void PrintArray(string[] GetArray2)
{
    for (int i = 0; i < GetArray2.Length; i++)
    {
        Console.Write($"{GetArray2[i]} ");
    }
    Console.WriteLine();
}


GetArrayThreeSymbols(GetArray, NewArray);
Console.WriteLine();
PrintArray(NewArray);
Console.WriteLine();

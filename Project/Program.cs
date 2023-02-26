// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ['1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] ->

string InsertString(string text) //метод ввода строки пользователем
{
    Console.WriteLine(text);
    string result = Console.ReadLine();
    return result;
}

string[] StringToArrayOfStrings(string userArray) //перевод строки в массив строк
{
    string str = userArray;
    string[] arrOfStrings = str.Split(",");
    return arrOfStrings;
}

void PrintArrOfStrings(string[] array) // вывод массива строк в консоль
{
    Console.Write("["); 
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", "); 
        else Console.Write(array[i]); 
    }
    Console.Write("]");
}
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
    string[] arrOfStrings = str.Split("");
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

int ThreeSymbStrings(string[] array) //подсчет сколько элементов имеет <= 3 символов
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) 
        count++;
    }
    return count;
}
string[] ThreeSimbolsArr(string[] arr) //создание массива из элементов меньше трех
{
    string text = "null";
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i].Length <= 3) 
        arr[i] = arr[i];
        else arr[i] = text;
    }
    return arr;
}

string[] ResultArray(int size, string[] array) //создание нового массива с длиной = count 
{
    string[] newArr = new string[size];
    string text = "null";
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == text)
        {
            i ++;
        }
        else newArr[i] = array[i];
    }
    return newArr;
}

string userString = InsertString("Введите массив через пробел: "); //ввод массива пользователем
Console.WriteLine();

string[] arrOfStrings = StringToArrayOfStrings(userString);//перевод строки в массив строк
PrintArrOfStrings(arrOfStrings);
Console.WriteLine();

int sizeResultArr = ThreeSymbStrings(arrOfStrings); // сколько элементов c символами <= 3
string[] resultArray = ThreeSimbolsArr(arrOfStrings); 
PrintArrOfStrings(resultArray);
string[] newArray = ResultArray(sizeResultArr, resultArray);
PrintArrOfStrings(newArray);
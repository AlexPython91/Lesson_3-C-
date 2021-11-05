using System;

// Вид 5. Метод for

string Method4(int count, string text)  // тип строка, возвращаемый аргумент int
{
    //int i = 0;
    string result = String.Empty;   // пустая строка
    for(int i = 0; i < count; i++)     // Счетчик вместо while
    {
        result = result + text;   // сохр. в результат 
    }
    return result;
} 

string res = Method4(10, " z ");   // назначаем переменную res
Console.WriteLine(res);   // вызов метода с возвращением аргумента
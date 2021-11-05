using System;

// Вид 4. Что то принимают и что то возвраящают. Самые используемые
string Method4(int count, string text)  // тип строка, возвращаемый аргумент int
{
    int i = 0;
    string result = String.Empty;   // пустая строка

    while(i < count)
    {
        result = result + text;   // сохр. в результат 
        i++;
    }
    return result;
} 

string res = Method4(10, " z ");   // назначаем переменную res
Console.WriteLine(res);   // вызов метода с возвращением аргумента
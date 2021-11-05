using System;

// Вид 1. Ничего не возвращают и не принимают аргументы

// Метод, который не принимает аргументов и ничего не возвращаяет

void Method1()  // тип данных / имя метода / () не принимает аргументы
{
    Console.WriteLine("Что нибудь написать");
}

Method1();  // Вызов метода: имя / ()


// Вид 2. Ничего не взвращаяют но принимают какие то аргументы

void Method2(string msg)    // тип данных / имя метода / () принятые аргументы
{ 
    Console.WriteLine(msg);
}

Method2(msg: "Текст сообщения");

// Именованные аргументы:

void Method21(string msg, int count)    // тип данных / имя метода / () принятые аргументы
{ 
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method21("Текст сообщения", 4); 

// Явно указываем именование аргументов

void Method22(string msg, int count)    // тип данных / имя метода / () принятые аргументы
{ 
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}

Method22(count: 4, msg: "Новый текст"); 


// Вид 3. Что то возвращают но ничего не принимают

int Method3()
{
    return DateTime.Now.Year;  // в методе обязательно использовать return
}
int year = Method3();   // используем идентификатьр переменной и присваиваем значение через =
Console.WriteLine(year);    // используем значение, которое вернул метод


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

string res = Method4(10, "qwerty");   // назначаем переменную res
Console.WriteLine(res);   // вызов метода с возвращением аргумента
using System;

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
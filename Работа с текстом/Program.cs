using System;

// Работа с текстом
//Дан текст. В тексте нужно все пробелы заментить черточками, 
//маленькие буквы "к" заменить большими "К"
//а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбась, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде, "
            + "вы бы взяли приступом согласие прусского короляю "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// Пояснение: если есть строка то есть вспомогательный функционал

//string s = "qwerty";

// обращение к отдельному сиволу строки s[3] - буква r

string Replace(string text, char oldValue, char newValue) // метод замены символов старого на новы 
{
    string result = String.Empty;  // инициализация пустой строки

    int length = text.Length;     // обращение к количеству символов в строке
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";   // сравниваем текущий символ с заменяемым и кладем новое значение
        else result = result + $"{text[i]}";                         // если нет совпадений то добавляем текщий сивмол, кот. был
    }
    
    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);
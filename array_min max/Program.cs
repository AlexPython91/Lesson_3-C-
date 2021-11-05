using System;

// 1. Найти позицию минимального элемента в неотсортированной части массива
// 2. Произвести обмен этого значения со значением первой не сорт. позиции
// 3. Повторять пока есть неотсортироованные элементы

int[] array = {1, 5, 4, 3, 2, 6, 7, 1, 1};  // создали массив


void PrintArray(int[] array)   // метод печати массива
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");   // вывод в строку
    }
    Console.WriteLine();
}


void SelectionSort(int[] array)   // метод заполнения массива
{
    for(int i = 0; i < array.Length - 1; i++)       
    {
        int minPosition = i;   // определяем мин. позицию массива, запоминаем поз. рабочего эл. с ней будут действия

        for(int j = i + 1; j < array.Length; j++)   //начинаем с первой поз. кот. еще не отсортирована и до последнего элемента
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int tempporary = array[i];
        array[i] = array[minPosition];   // обмен двух значений
        array[minPosition] = tempporary;
    }
}

PrintArray(array);
SelectionSort(array);

PrintArray(array);


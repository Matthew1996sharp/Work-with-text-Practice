/* Задание 5. Напишите программу со статическим методом, определяющим позиции,
* на которых в тексте находится определённый символ. Аргументы - текст и символ.
* Результатом метод возвращается целочисленный массив, значения элементов 
* которого - это индексы позиций, на которых символ (второй аргумент) находится
* в тексте (первый аргумент). Если символ в тексте не встречается, 
* то метод результатом возвращает массив из одного элемента, 
* значение которого равно -1 */
using System;
class TextTaskFive
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.WriteLine("Введите символ для поиска");
        char symbol = Convert.ToChar(Console.ReadLine());
        Console.Write("Массив совпадений символа в тексте: ");
        int[] search = Searching(text, symbol);
        foreach (int item in search)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
    static int[] Searching(string text, char symbol)
    {
        List<int>ListOfIndex = new List<int>(); //список индексов
        if (!text.Contains(symbol)) //проверка текста на содержание символа
            ListOfIndex.Add(-1); //добавление элемента -1 в список
        else
        {
            int index = text.IndexOf(symbol, 0); //первое совпадение
            while (index < -1)
            {
                ListOfIndex.Add(index); //заносим индекс совпадения в список
                index = text.IndexOf(symbol, index + 1);
            }
        }
        return ListOfIndex.ToArray(); //отображение списка как массив
    }
}
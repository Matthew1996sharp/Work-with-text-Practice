/* Задание 6. Напишите программу со статическим методом, аргументом которому
 * передаётся текст, а результатом возвращается символьный массив,
 * состоящий из букв (без учёта пробелов и знаков препинания),
 * из которых состоит текст. Если буква несколько раз встречается в тексте,
 * в массиве она представлена одним элементом.
 * Буквы в массиве-результате должны быть отсортированы в алфавитном порядке */
using System;
class TextTaskSix
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.Write("Массив букв из текста в алфавитном порядке: ");
        char[] letters = SymbolArray(text);
        for (int i = 0; i < letters.Length - 1; i++)
        {
            Console.Write(letters[i] + " ");
        }
        Console.WriteLine(letters[letters.Length - 1]);
    }
    static char[] SymbolArray(string text)
    {
        text = text.ToUpper(); //перевод символов строки в верхний регистр
        string line = ""; //локальная текстовая переменная
        foreach (char item in text)
        {
            //если символ - буква и не встречался ранее в строке результата
            if ((item >= 'А') && (item <= 'Я') 
                && (!line.Contains(item))) line += item;
        }
        char[] letters = line.ToCharArray(); //преобразование строки в массив
        Array.Sort(letters); //сортировка массива по возрастанию
        return letters;
    }
}
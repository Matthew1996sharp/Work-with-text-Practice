/* Задание 1. Напишите программу, в которой есть статический метод. 
* Аргументом методу передаётся текстовое значение.
* Результатом метод возвращает текст, в котором, 
* по сравнению с текстом-аргументом, между символами вставлены пробелы */
using System;
class TextTaskOne
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.WriteLine("Текст с пробелами между символами");
        Console.WriteLine(Splitting(text));
    }
    static string Splitting(string text)
    {
        string line = ""; //локальная текстовая переменная
        for (int i = 0; i < text.Length; i++)
        {
            //посимвольный перенос текста из аргумента локальную
            //текстовую переменную с добавлением пробелов
            if (text[i] == ' ') line += text[i];
            else line += text[i] + " ";
        }
        line = line.TrimEnd(); //после последнего символа нет пробела
        return line;
    }
}
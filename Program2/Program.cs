/* Задание 2. Напишите программу, в которой есть статический метод,
* получающий аргументом и возвращающий результатом текстовое значение.
* Результат метода - текст со словами в обратном порядке.
* Словами считать блоки текста, разделённые пробелами */
using System;
class TextTaskTwo
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.WriteLine("Текст со словами в обратном порядке");
        Console.WriteLine(Reverse(text));
    }
    static string Reverse(string text)
    {
        string[] words = text.Split(); //разбивка текста пробелами
        string line = ""; //локальная текстовая переменная
        for (int i = words.Length - 1; i >= 0; i--)
        {
            line += words[i] + " "; //перенос блоков в обратном порядке
        }
        line = line.TrimEnd(); //после последнего блока нет пробела
        return line;
    }
}
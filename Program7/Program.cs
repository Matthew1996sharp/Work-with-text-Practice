/* Задание 7. Напишите программу со статическим методом, 
* который эмулирует работу метода Substring().
* Аргументами методу передаётся текст и два целочисленных аргумента.
* результатом метод возвращает текстовую строку,
* которая состоит из символов текста (первый аргумент),
* начиная с позиции с индексом, определяемым вторым аргументом.
* Третий аргумент статического метода определяет количество символов,
* которые включаются в подстроку */
using System;
class TextTaskSeven
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.Write("Введите индекс начала интервала: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите количество символов в подстроке: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Подстрока из {0} символов с {1} индекса: {2}",
            b, a, Substr(text, a, b));
    }
    static string Substr(string text, int a, int b)
    {
        string result = "";
        for (int i = a; i <= a + b - 1; i++)
        {
            result += text[i];
        }
        return result;
    }
}
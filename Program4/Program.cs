/* Задание 4. Напишите программу со статическим методом для сравнения строк.
 * Текстовые строки сравниваются следующим образом:
 * для каждого текстового значения определяется набор различных букв
 * (при этом количество вхождений буквы в текст значения не имеет).
 * Текстовые строки считаются равными, если содержат одинаковые наборы букв */
using System;
class TextTaskFour
{
    static void Main()
    {
        Console.WriteLine("Введите первый текст");
        string FirstText = Console.ReadLine();
        Console.WriteLine("Введите второй текст");
        string SecondText = Console.ReadLine();
        if (Comparison(FirstText, SecondText))
            Console.WriteLine("Тексты содержат одинаковые наборы букв");
        else Console.WriteLine("Тексты содержат разные наборы букв");
    }
    static bool Comparison(string FirstText, string SecondText)
    {
        string FirstString = "", SecondString = "";
        foreach (char item in FirstText)
            if ((item >= 'А') && (item <= 'Я')
                && !FirstString.Contains(item)) FirstString += item;
        foreach (char item in SecondText)
            if ((item >= 'А') && (item <= 'Я')
                && !SecondString.Contains(item)) SecondString += item;
        if (FirstString.Length != SecondString.Length) return false;
        foreach (char item in FirstString)
        {
            if (!SecondString.Contains(item)) return false;
        }
        return true;
    }
}
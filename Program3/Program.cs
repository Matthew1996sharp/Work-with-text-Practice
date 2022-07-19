/* Задание 3. Напишите программу со статическим методом для 
 * сравнения текстовых строк. Строки сравниваются посимвольно.
 * Правило сравнения символов такое: два символа считаются одинаковыми,
 * если их коды отличаются не больше, чем на единицу.
 * Текстовые строки совпадают, если у них совпадают символы */
using System;
class TextTaskThree
{
    static void Main()
    {
        Console.WriteLine("Введите первый текст");
        string FirstText = Console.ReadLine();
        Console.WriteLine("Введите второй текст");
        string SecondText = Console.ReadLine();
        if (Comparison(FirstText, SecondText))
            Console.WriteLine("Строки совпадают");
        else Console.WriteLine("Строки не совпадают");
    }
    static bool Comparison(string FirstText, string SecondText)
    {
        if (FirstText.Length != SecondText.Length) return false;
        for (int i = 0; i < FirstText.Length; i++)
        {
            if (Math.Abs(FirstText[i] - SecondText[i]) <= 1) return false;
        }
        return true;
    }
}
/* Задание 9. Напишите программу с классом, в котором есть текстовое поле 
* и символьное поле. Значение полям присваивается при создании объекта класса.
* В классе должен быть метод, возвращающий результатом массив строк.
* Такие строки получаются разбиением на подстроки значения текстового поля.
* Символ-индикатор определяется значением символьного поля.
* Переопределить в классе метод ToString() так, 
* чтобы он возвращал текст со значениями полей объекта и подстроки, 
* на которые разбивается текст из текстового поля */
using System;
class MyClass
{
    public string line;
    public char symbol;
    public MyClass(string l, char s)
    {
        line = l; symbol = s; //присвоение значений полям объекта
        Console.WriteLine("Создан новый объект");
    }
    public string[] Splitting()
    {
        return line.Split(symbol); //разбиение текста в текстовом поле объекта
    }
    public override string ToString()
    {
        string text = "Текстовое поле объекта: " + line +
            "\nСимвольное поле объекта: " + symbol +
            "\nМассив подстрок, разделённых символом " + symbol + ":\n";
        for (int i = 0; i < Splitting().Length; i++)
        {
            text += Splitting()[i] + "\n";
        }
        return text; //возврат текста со значениями полей и подстрок
    }
}
class TextTaskNine
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.WriteLine("Введите символ для разбивки");
        char symbol = Convert.ToChar(Console.ReadLine());
        MyClass obj = new MyClass(text, symbol);
        Console.WriteLine(obj.ToString());
    }
}
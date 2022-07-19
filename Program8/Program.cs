/* Задание 8. Напишите программу с классом, у которого есть текстовое поле.
* Значение текстовому полю присваивается при создании объекта класса.
* Также в классе должен быть метод, позволяющий вставить подстроку в текст 
* из текстового поля. Аргументами методу передаётся подстрока для вставки 
* в текст, а также индекс позиции, начиная с которой выполянется вставка.
* Переопределить в классе метод ToString() так, чтобы он возвращал текст */
using System;
class MyClass
{
    public string line;
    public MyClass(string l)
    {
        line = l; //присовение значения текстовому полю объекта
        Console.WriteLine("Создан новый объект класса MyClass");
    }
    public string Input(string str, int index)
    {
        return line.Insert(index, str); //вставка подстроки
    }
    public override string ToString()
    {
        return line; //переопределение метода ToString()
    }
}
class TextTaskEight
{
    static void Main()
    {
        Console.WriteLine("Введите текст");
        string text = Console.ReadLine();
        Console.WriteLine("Введите подстроку для вставки в текст");
        string str = Console.ReadLine();
        Console.Write("Введите индекс позиции подстроки: ");
        int index = Convert.ToInt32(Console.ReadLine());

        MyClass obj = new MyClass(text);
        string line = obj.Input(str, index);
        Console.WriteLine("Текстовое поле объекта: " + obj.ToString());
        Console.WriteLine("Текстовое поле объекта после вставки: " + line);
    }
}
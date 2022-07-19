/* Задание 10. Напишите программу с классом, у которого есть поле, являющееся 
* ссылкой на целочисленный массив. При создании объекта массив заполняется 
* случайными числами. Переопределите в классе метод ToString() так, 
* чтобы метод возвращал текстовую строку со значениями элементов массива. 
* Также строка должна содержать информацию о количестве элементов 
* массива и среднем значении для элементов массива */
using System;
class MyClass
{
    public int[] numbers;
    public MyClass(int number)
    {
        Random rand = new Random();
        numbers = new int[number];
        for (int i = 0; i < number; i++)
        {
            numbers[i] = rand.Next(20);
        }
        Console.WriteLine("Создан новый объект");
    }
    public override string ToString()
    {
        string text = "Значения элементов массива: ";
        for (int i = 0; i < numbers.Length - 1; i++)
        {
            text += numbers[i] + " ";
        }
        text += numbers[numbers.Length - 1] + "\n";
        text += "Количество элементов в массиве: " + numbers.Length;
        text += "\nСреднее значение элементов массива: " +
            (double)numbers.Sum() / numbers.Length;
        return text;
    }
}
class TextTaskTen
{
    static void Main()
    {
        Console.Write("Введите количество элементов массива: ");
        int number = Convert.ToInt32(Console.ReadLine());

        MyClass obj = new MyClass(number);
        Console.WriteLine(obj.ToString());
    }
}
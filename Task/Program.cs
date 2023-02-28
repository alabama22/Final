// Написать программу, которая 
// из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами
// Примеры:
// ["hello","2","world",":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer scince"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

// Console.WriteLine("задайте длину массива: ");
// int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Укажите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] str = new string[n];
for (int i = 0; i < n; i++)
{
    Console.Write("Введите элемент {0}:\r\n    ", i + 1);
    str[i] = Console.ReadLine();
}
Console.Write("[ ");
for (int i = 0; i < n; i++)
{
    Console.Write($"{str[i]} ");
}
Console.Write("] ");

string[] NewArray(string[] elem)
{
    string[] arr = new string[elem.Length];
    Console.Write("-> ");
    Console.Write("[ ");
    for (int i = 0; i < elem.Length; i++)
    {
        if (elem[i].Length <= 3)
        {
            Console.Write($"{elem[i]} ");
        }
    }
    Console.WriteLine("] ");
    return arr;
}

string[] newArr = NewArray(str);
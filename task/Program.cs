/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.*/


Console.Write("Введите колличество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] array = CreateArray(size);
string[] NewArray = new string[array.Length];  // Создаем новый массив


for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length < 4)
    {
        NewArray[i] = array[i];
    }
}

Console.WriteLine($"Новый массив состоит из :");
PrintArray(NewArray);

string[] CreateArray(int size) // Метод для создания строчного массива с клавиатуры
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i}-й элемент массива : ");
        array[i] = Console.ReadLine()!; //Заполняем его
    }
    Console.WriteLine();
    return array;
}

void PrintArray(string[] array)  // Метод для печати массива
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}
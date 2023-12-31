﻿// Задача алгоритмически не самая сложная, 
// однако для полноценного выполнения проверочной работы необходимо:

// Создать репозиторий на GitHub
// Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете её в отдельный метод)
// Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
// Написать программу, решающую поставленную задачу
// Использовать контроль версий в работе над этим небольшим проектом 
// (не должно быть так, что всё залито одним коммитом, как минимум этапы 2, 3, и 4 должны быть расположены в разных коммитах)

// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


using System.Diagnostics.Contracts;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks.Dataflow;

Console.WriteLine("Введите размер массива -> ");
int symbol = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите элементы массива ->");
string[] massive = MassiveIndastial(symbol);
Console.WriteLine(String.Join(", ", massive));
Console.WriteLine("Массив с елементами менее трёх символов -> " + String.Join(", ", MassiveEnumeration(massive)));


partial class Program
{
/// <summary>
/// Метод создания массива c элементами типа string, вводимыми пользователем
/// </summary>
/// <param name="s">Переменная задающая размер массива</param>
/// <returns>Возвращает Массив элементов</returns>
    public static string[] MassiveIndastial(int s)
{
    string[] array = new string[s];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("-> ");
        array[i] = Console.ReadLine()!;
    }
    return array;
}

/// <summary>
/// Метод проверки массива с использованием параллельных цыклов for и записью 
/// </summary>
/// <param name="array">Массив используемый в методе проверки</param>
/// <returns>Возвращает массив с элементами заданных параметров</returns>
public static string[] MassiveEnumeration(string[] array)
{

    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] arr = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arr[count] = array[i];
            count++;
        }
    }
    return arr;
}









}
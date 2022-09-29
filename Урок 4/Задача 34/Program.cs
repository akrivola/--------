/*
Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
int[] populateRandom(int length)
{
    int[] result = new int[length];
    for (int i=0; i < length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

string outArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i]);
        if (i != array.Length - 1) 
        {
            result += ", ";
        }
    }
    result += "]";
    return;
}

int evenNumber(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            result += array[i];
        }
    }
    return result;
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = populateRandom(arrayLength);
Console.WriteLine($"Количество четных чисел в массиве {outArray(array)} -> {evenNumber(array)}");

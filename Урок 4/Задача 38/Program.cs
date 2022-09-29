/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int[] populateRandom(int length)
{
    int[] result = new int[length];
    for (int i=0; i < length; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}

string outArray(int[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
        if (i != array.Length - 1) 
        {
            result += ", ";
        }
    }
    result += "]";
    return result;
}

int min(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            result += array[i];
        }
    }
    return result;
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] array = populateRandom(arrayLength);
Console.WriteLine($"Количество четных чисел в массиве {outArray(array)} -> {sumOddPlaces(array)}");
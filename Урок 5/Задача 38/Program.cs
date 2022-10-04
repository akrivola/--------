/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между
максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
double[] populateRandom(int length)
{
    double[] result = new double[length];
    for (int i=0; i < length; i++)
    {
        Random temp = new Random();
        result[i] = new (temp.NextDouble);// * Double.MaxValue * 2) - Double.MinValue;
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

int max(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}
int min(int[] array)
{
    int result = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < result)
        {
            result = array[i];
        }
    }
    return result;
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
double[] array = populateRandom(arrayLength);
Console.WriteLine($"{outArray(array)} -> {max(array) - min(array)}");
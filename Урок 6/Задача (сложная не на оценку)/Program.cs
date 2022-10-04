/*
*Задача(сложная не на оценку) *
Напишите программу, которая находит подмножество данного 
множества чисел такое, что сумма его элементов равна заданному числу
*/
int[] populateRandom(int length)
{
    int[] result = new int[length];
    for (int i=0; i < length; i++)
    {
        result[i] = new Random().Next(-9, 10);
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


// заполняем массив размером 1..10 числами в диапазоне -9..9
Random rnd = new Random();
int size = rnd.Next(1, 11);
int[] array = populateRandom(size);
Console.WriteLine($"{outArray(array)}");
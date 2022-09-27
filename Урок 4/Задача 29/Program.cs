/*
Задача 29: Напишите программу, в которой пользователь задает
длину массива, элементы которого задаются в диапазоне [1,99] 
и выводит на экран.

5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) 
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    return;
}

int[] populateRandom(int length)
{
    int[] result = new int[length];
    for (int i=0; i < length; i++)
    {
        result[i] = new Random().Next(1, 100);
    }
    return result;
}

Console.Write("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
PrintArray(populateRandom(arrayLength));

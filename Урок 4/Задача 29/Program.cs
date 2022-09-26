/*
Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1) Console.Write(", ");
    }
    Console.WriteLine("]");
    return;
}
int[] array1 = {1, 2, 5, 7, 19};
PrintArray(array1);
int[] array2 = {6, 1, 33};
PrintArray(array2);
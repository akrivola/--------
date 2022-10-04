/*
Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int countPositive(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result++;
        }
    }
    return result;
}

string outArray(int[] array)
{
    string result = "";
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
        if (i != array.Length - 1) 
        {
            result += ", ";
        }
    }
    return result;
}

int M;
Console.Write("Введите M:");
M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
for (int i = 0; i < M; i++)
{
    Console.Write($"Введите {i + 1} число из {M}:");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"{outArray(array)} -> {countPositive(array)}");

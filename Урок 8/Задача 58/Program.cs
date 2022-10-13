/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] multiplication(int[,] array1, int[,] array2)
{

    int[,] result = new int[array1.GetLength(0), array2.GetLength(1)];
    // проверка
    if (array1.GetLength(0) != array2.GetLength(1))
    {
        Console.WriteLine("Невозможно перемножить матрицы.");
        return result;
    }

    for (int i = 0; i < array1.GetLength(0); i++)
        for (int j = 0; j < array2.GetLength(0); j++)
            for (int k = 0; k < array2.GetLength(1); k++)
                result[i, k] += array1[i, j] * array2[j, k];
    return result;
}

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
int[,] array1 = 
{
    {2, 4},
    {3, 2},
};
int[,] array2 = 
{
    {3, 4},
    {3, 3}
};

printArray(multiplication(array1, array2));
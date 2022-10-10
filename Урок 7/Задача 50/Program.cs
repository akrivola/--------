/*
Задача 50. Напишите программу, которая на вход принимает 
позицию элемента в двумерном массиве, и возвращает значение 
этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
5 -> 9

индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/

void posInArray(int[,] array, int position)
{
    Console.Write($"{position} -> ");
    // сразу проверяем, если позиция > числа элементов
    if (array.GetLength(0) * array.GetLength(1) < position + 1)
    {
        Console.WriteLine("такого числа в массиве нет");
        return;
    }
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (count == position)
            {
                Console.WriteLine(array[i, j]);
                return;
            }
            count++;
        }
    }
}

int[,] array = 
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};
posInArray(array, 17);
posInArray(array, 5);
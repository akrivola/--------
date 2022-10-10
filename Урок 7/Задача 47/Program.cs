/*
Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

void outArray(double [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:#.#} ",array[i, j]);
        }
        Console.WriteLine();
    }
}

double [,] randomArray2D(int rows, int columns)
{
    double [,] array = new double [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array [i, j] = new Random().NextDouble() * 20 - 10;
        }
    }
    return array;
}

Console.Write("Введите число строк массива m = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива n = ");
int n = Convert.ToInt32(Console.ReadLine());
outArray(randomArray2D(m, n));
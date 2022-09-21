/*
Напишите программу, которая выводит случайное число 
из отрезка [10, 99] и показывает наибольшую цифру числа. 
78 -> 8 12-> 2 85 -> 8
*/

int getRandomNumberFromRange(int minBorder, int MaxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder,MaxBorder + 1);
    return result;
}

int randomNumber = getRandomNumberFromRange(10,99);
Console.WriteLine($"Случайное значение {randomNumber}");
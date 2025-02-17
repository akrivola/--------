﻿/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int sumNatural(int M, int N)
{
    int result = M;
    if(M == N)
    {
        return result;
    }    
    result += sumNatural(M + 1, N);
    return result;
}

Console.Write("M = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"M = {M}; N = {N} - > {sumNatural(M, N)}");
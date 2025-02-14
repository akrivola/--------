﻿/*
Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

double Range(int[] arg1, int[] arg2)
{
    return Math.Round(Math.Sqrt(Math.Pow((arg2[0] - arg1[0]), 2) + Math.Pow((arg2[1] - arg1[1]), 2) + Math.Pow((arg2[2] - arg1[2]),  2)), 2);
}

Console.WriteLine(Range(new int[] {3, 6, 8}, new int[] {2, 1, -7}));
Console.WriteLine(Range(new int[] {7, -5, 0}, new int[] {1, -1, 9}));
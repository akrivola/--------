﻿// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

string Even(int N)
{
    string result = "";
    int i = 1;
    while(i <= N)
    {
        if (i % 2 == 0)
        {
            if (result == "") 
                result += i;
            else
                result += ", " + i;
        }
        i++;
    }
    return result; 
}

Console.WriteLine(Even(5));
Console.WriteLine(Even(8));
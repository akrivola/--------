/*
Задача 10: Напишите программу, которая принимает
на вход трёхзначное число и на выходе показывает
вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/
char sMiddle(int intArg1)
{
    return intArg1.ToString()[1];
}
Console.WriteLine(sMiddle(456));
Console.WriteLine(sMiddle(782));
Console.WriteLine(sMiddle(918));
/*
Задача 15: Напишите программу, которая принимает на вход цифру,
обозначающую день недели, и проверяет, является ли этот день
выходным.

6 -> да
7 -> да
1 -> нет
*/
string sWeekend(int iArg1)
{
    if (iArg1 == 6 | iArg1 == 7)
    {
        return "да";
    }
    else
    {
        return "нет";
    }
}
Console.WriteLine(sWeekend(6));
Console.WriteLine(sWeekend(7));
Console.WriteLine(sWeekend(1));
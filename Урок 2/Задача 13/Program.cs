/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
char sThird(int intArg1)
{
    if (intArg1 < 100)
    {
        Console.Write("третьей цифры нет");
        return '\0';
    }
    return intArg1.ToString()[2];
}
Console.WriteLine(sThird(645));
Console.WriteLine(sThird(78));
Console.WriteLine(sThird(32679));
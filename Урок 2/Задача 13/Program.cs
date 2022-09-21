/*
Задача 13: Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

void ThirdDigit(int Arg)
{
    int result;
    int temp = Arg;
    int NumberOfDigits = 0;
    while(temp > 0)
    {
        temp = temp / 10;
        NumberOfDigits++;
    }
    if (NumberOfDigits < 3)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        result = Arg % (10 ^ (NumberOfDigits - 3));
        Console.WriteLine(result.ToString());
    }
    return;
}
ThirdDigit(645);
ThirdDigit(78);
ThirdDigit(32679);
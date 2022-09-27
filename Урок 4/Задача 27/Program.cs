/*
Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.

452 -> 11
82 -> 10
9012 -> 12
*/
int sum(int Arg)
{
    int result = 0;
    while(Arg > 0)
    {
        result = result + (Arg % 10);
        Arg = Arg / 10;
    }
    return result;
}
Console.WriteLine(sum(452));
Console.WriteLine(sum(82));
Console.WriteLine(sum(9012));
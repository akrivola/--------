/*
Задача 25: Напишите цикл, который принимает на вход два
числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/
int power(int arg1, int arg2)
{
    int result = arg1;
    for (int i = 2; i <= arg2; i++)
    {
        result = result * arg1;
    }
    return result;
}
Console.WriteLine(power(3, 5));
Console.WriteLine(power(2, 4));
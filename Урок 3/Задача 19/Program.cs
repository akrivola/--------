/*
Напишите программу, которая принимает на вход пятизначное число и проверяет, 
является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

string IfPalindrome(int Arg)
{
    string sArg = Arg.ToString();
    for (int i = 0; i < sArg.Length / 2; i++) // можно проверять только до половины, чтобы ускорить цикл, 
    {                                         // а середина всегда равна самой себе в нечетных кол-вах цифр 
        if (sArg[i] != sArg[sArg.Length - i - 1] )
        {
            return "нет";
        }
    }
    return "да";
}
Console.WriteLine(IfPalindrome(14212));
Console.WriteLine(IfPalindrome(12821));
Console.WriteLine(IfPalindrome(23432));
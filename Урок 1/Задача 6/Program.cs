// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без 
// остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

string Odd(int arg)
{
    if (arg % 2 == 0)
        return "Да"; 
    else 
        return "Нет";
}

Console.WriteLine(Odd(4));
Console.WriteLine(Odd(-3));
Console.WriteLine(Odd(7));
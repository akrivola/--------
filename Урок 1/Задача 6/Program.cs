// Задача 6: Напишите программу, которая на вход принимает число
// и выдаёт, является ли число чётным (делится ли оно на два без 
// остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

string Even(int arg)
{
    if (arg % 2 == 0)
        return "Да"; 
    else 
        return "Нет";
}

Console.WriteLine(Even(4));
Console.WriteLine(Even(-3));
Console.WriteLine(Even(7));
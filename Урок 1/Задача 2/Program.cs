// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
//
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3
// Console.Write("Введите число # 1: ");
// int a = Convert.ToInt32(Console.Read());
// Console.Write("Введите число # 2: ");
// int b = Convert.ToInt32(Console.Read());
// Console.WriteLine(a.ToString);
int a = 5;
int b = 7;
int min = 0;
int max = 0;
if (a > b)
{
    min = b;
    max = a;
}
else
{
    min = a;
    max = b; 
}
Console.WriteLine(max + " - большее число");
Console.WriteLine(min + " - меньшее число");
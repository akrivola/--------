/*
Напишите программу, которая принимает на вход число (N) и выдаёт
таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int [] Cubes (int Arg)
{
    int[] result = new int[Arg];
    for(int i=0; i < Arg; i++)
    {
        result[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return result;
}

Console.WriteLine(string.Join(", ", Cubes(3)));
Console.WriteLine(string.Join(", ", Cubes(5)));
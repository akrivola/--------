/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] populateArray3D ()
{
    int [,,] result = new int [2, 2, 2];
    int [] stack = new int [8];
    int newItem;

    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int k = 0; k < 2; k++)
            {
                do
                {
                    newItem = new Random().Next(10, 100);
                } while (isContained(newItem));
                stack[i * 4 + j * 2 + k] = newItem;
                result[i, j, k] = newItem;
            }
        }
    }
    return result;

    bool isContained(int newItem)
    {
        bool result = false;
        for (int i = 0; i < stack.Length; i++)
            if(newItem == stack[i])
                result = true;                        
        return result;
    }
}

void printArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

printArray(populateArray3D());
/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

void printArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0:0#} ", array[i, j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[,] populateArray(int dimX, int dimY)
{
    int count = 1;
    int[,] array = new int [dimX, dimY];
    
    // текущие координаты
    int currentX = -1; // начинаем как бы за краем
    int currentY = 0;

    // начальное направление
    int dirX = 1; 
    int dirY = 0;

    while(isNextStepFree())
    {
        currentX += dirX;
        currentY += dirY;
        array[currentY, currentX] = count++;
        if(!isNextStepFree())
            turnRight();
    }
    return array;

    void turnRight()
    {
        if(dirX == 1 && dirY == 0) // если было вправо, то вниз
        {
            dirX = 0;
            dirY = 1; 
            return;
        }
        if(dirX == 0 && dirY == 1) // если было вниз, то влево
        {
            dirX = -1; 
            dirY = 0;  
            return;
        }
        if(dirX == -1 && dirY == 0) // если было влево, то вверх
        {
            dirX = 0;
            dirY = -1; 
            return;
        }
        if(dirX == 0 && dirY == -1) // если было вверх, то вправо
        {
            dirX = 1; 
            dirY = 0; 
            return;
        }
    }

    bool isNextStepFree()
    {
        if (currentX + dirX >= array.GetLength(0)
            || currentY + dirY >= array.GetLength(1)
            || currentX + dirX < 0
            || currentY + dirY < 0)
            return false;
        return array[currentY + dirY, currentX + dirX] == 0;
    } 
}

printArray(populateArray(4, 4));
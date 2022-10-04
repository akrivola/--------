/*
*Задача(сложная не на оценку) *
Напишите программу, которая находит подмножество данного 
множества чисел такое, что сумма его элементов равна заданному числу
*/
int[] populateRandom(int length)
{
    int[] result = new int[length];
    for (int i=0; i < length; i++)
    {
        result[i] = new Random().Next(-9, 10);
    }
    return result;
}

string outArray(int[] array)
{
    string result;
    if (array == null)
    {
       result = "не найдено"; 
    }
    else
    {
        result = "[";
        for (int i = 0; i < array.Length; i++)
        {
            result += array[i];
            if (i != array.Length - 1) 
            {
                result += ", ";
            }
        }
        result += "]";
    }
    return result;
}

int sumArray(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    return result;    
}

// поиск хотя бы 1 подмножества, сумма цифр которого равна value
int[] findSubset(int[] array, int value)
{
    int n = array.Length; // n - размерность исходного множества
    if (sumArray(array) == value)
    {
        // нашли
        return array;
    }
    else
    {
        if (n == 1)
        {
            // не нашли, уменьшать массив некуда, уже 1 элемент
            return null;
        }
        else
        {
            //берем массив на 1 элемент меньше исходного, убирая по очереди все по одному
            for (int i = 0; i < n; i++)
            {
                int[] temp = new int[n - 1];
                int k = 0;
                for (int j = 0; j < n ; j++)
                {
                    if (j != i)
                    {
                        temp[k] = array[j];
                        k++;
                    }
                }
                // вызываем рекурсию, проверяя массив на 1 элемент меньше
                // и так, пока не найдем подмножество или не проверим все
                // массивы из 1 элемента
                int[] test = findSubset(temp, value);
                if (test != null)
                {
                    return test;
                }
            }
            return null;
        }     
    }
}
   
// тестируем 10 раз
for (int i = 0; i < 10; i++)
{
    // заполняем массив размером 1..10 числами в диапазоне -9..9
    int[] array = populateRandom(new Random().Next(1, 11));

    // задаем случайным образом в диапазоне -9..9 число, которому будет равна
    // сумма искомого подмножества
    int value = new Random().Next(-9, 10);

    Console.WriteLine($"в подмножестве {outArray(array)} ищем подмножество, сумма чисел в котором равна {value} -> {outArray(findSubset(array, value))}");
}
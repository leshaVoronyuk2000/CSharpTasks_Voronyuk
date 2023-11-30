/*Task 31
    Создайте массив из 12 элементов, заполненный случайными числами 
    в диапазоне от -9 до 9. Найдите сумму отрицательных и положительных элементов
    в массиве.

*/

int[] CreateArray()
{
    int[] array = new int[12];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int NegativeSum(int[] array)
{
    int negativeSum = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i]<0)
        {
            negativeSum = negativeSum + array[i];
        }
    }
    return negativeSum;
}

int PositiveSum(int[] array)
{
    int positiveSum = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i]>0)
        {
            positiveSum = positiveSum + array[i];
        }
    }
    return positiveSum;
}

void PrintArray(int[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        if(i<array.Length-1)
        Console.Write(array[i]+", ");
        else Console.Write(array[i]);
    }
    System.Console.WriteLine();
}

int[] randomArray = CreateArray();
int negativeSum = NegativeSum(randomArray);
int positiveSum = PositiveSum(randomArray);
PrintArray(randomArray);
System.Console.WriteLine($"Сумма отрицательных элементов в массиве равняется {negativeSum}");
System.Console.WriteLine($"Сумма положительных элементов в массиве равняется {positiveSum}");
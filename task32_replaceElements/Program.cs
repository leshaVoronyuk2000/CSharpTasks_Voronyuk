/*
    Task 32
    Создайте массив и замените в нем положительные элементы на отрицательные и наоборот.
*/ 
Console.WriteLine("Hello, World!");
int[] CreateArray()
{
    int[] array = new int[12];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(-9,10);
    }
    return array;
}

int[] ReplaceArray(int[] array)
{
    int[] changedArray = new int[array.Length];
    for(int i = 0;i < array.Length;i++)
    {
        changedArray[i] = -1*array[i];
    }
    return changedArray;
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

int[] currentArray = CreateArray();
int[] changedArray = ReplaceArray(currentArray);
PrintArray(currentArray);
PrintArray(changedArray);

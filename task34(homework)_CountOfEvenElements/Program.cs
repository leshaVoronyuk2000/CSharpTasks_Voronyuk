// Task 34. Задайте массив заполненный случайными положительными числами.
// Посчитайте количество чётных элементов.

Console.WriteLine("Hello, World!");

int[] CreateArray()
{
    int[] array = new int[8];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
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

void CountOfEvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i]%2 == 0) count++;
    }
    Console.WriteLine($"Количество чётных элементов {count}");
}

int[] randomArray = CreateArray();
PrintArray(randomArray);
CountOfEvenNumbers(randomArray);
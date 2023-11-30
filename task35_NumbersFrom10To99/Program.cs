// Task 35. Создайте массив из 123 случайных чисел. Найдите количество лементов лежащих 
// в промежутке от 10 до 99.

Console.WriteLine("Hello, World!");

int[] CreateArray()
{
    int[] array = new int[123];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(1,200);
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
        if((i+1)%10 == 0) System.Console.WriteLine(); 
    }
    System.Console.WriteLine();
}

void CountNumbersFrom10To99(int[] array)
{
    int count = 0;
    for(int i = 0;i < array.Length;i++)
    {
       if(array[i]>=10 && array[i]<=99)
       {
        count++;
       }
    }
    Console.WriteLine($"Количество элементов в промежутке от 10 до 99 равняется {count}");
}

int[] randomArray = CreateArray();
PrintArray(randomArray);
CountNumbersFrom10To99(randomArray);
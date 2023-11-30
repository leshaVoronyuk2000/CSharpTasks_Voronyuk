// Task 33. Напишите программу, которая найдёт заданный элемент в массиве.
Console.WriteLine("Hello, World!");

int[] CreateArray()
{
    int[] array = new int[8];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(1,11);
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

void SearchElement(int[] array, int number)
{
    bool isEqual = false;
    for(int i = 0;i < array.Length;i++)
    {
        if(array[i] == number)
        {
            isEqual = true;
            break;
        }
    }
    if(isEqual) 
    {
        Console.WriteLine($"Элемент {number} есть");
    } else Console.WriteLine($"Элемента {number} нет");
}

int[] randomArray = CreateArray();
PrintArray(randomArray);
SearchElement(randomArray,10);
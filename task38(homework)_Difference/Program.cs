// Task 38 Найдите разницу между минимальным и максимальным значением.
Console.WriteLine("Hello, World!");

double [] CreateArray()
{
    double [] array = new double[8];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = Math.Round(new Random().NextDouble()*(10.01-1)+1,2);
    }
    return array;
}

void PrintArray(double[] array)
{
    for(int i = 0;i < array.Length;i++)
    {
        if(i<array.Length-1)
        Console.Write(array[i]+", ");
        else Console.Write(array[i]);
    }
    System.Console.WriteLine();
}

double Difference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1;i < array.Length;i++)
    {
        if(array[i]<min) min = array[i];
    }
    for(int i = 1;i < array.Length;i++)
    {
        if(array[i]>max) max = array[i];
    }
    return max - min;
}

double[] randomArray = CreateArray();
PrintArray(randomArray);
Console.WriteLine($"Разница между максимальным и минимальным равняется {Difference(randomArray)}");
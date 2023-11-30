// Task 37. Найдите пары элементов.

int[] CreateArray()
{
    int[] array = new int[7];
    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(1,9);
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

int[] ProductPair(int[] array)
{
    if(array.Length%2==0)
    {
        int[] pairs = new int[array.Length/2];
        for(int i = 0;i < pairs.Length;i++)
        {
            pairs[i] = array[i]*array[array.Length-1-i];
        }
        return pairs;
    } 
    else
    {
        int[] pairs = new int[array.Length/2+1];
        for(int i = 0;i < pairs.Length;i++)
        {
            if(i == (pairs.Length-1))
            {
                pairs[i] = array[i];
                break;
            } 
            pairs[i] = array[i]*array[array.Length-1-i];
        }
        return pairs;
    } 
  
}

int[] randomArray = CreateArray();
PrintArray(randomArray);
System.Console.WriteLine();
PrintArray(ProductPair(randomArray));

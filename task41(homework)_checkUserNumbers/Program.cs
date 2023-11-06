// Task 41. Пользователь вводит M чисел. Сколько введёных чисел больше 0.
int[] FillArray(int size)
{
    int[] array = new int[size];
    for(int i = 0;i < size;i++)
    {
        Console.Write($"Введите число N{i+1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void PrintArray(int[] array)
{
    for(int j = 0;j < array.Length;j++)
    {
        Console.Write(array[j] + "\t");
    }
    System.Console.WriteLine();
}

int countOfPossitiveNumbers(int[] array)
{
    int size = array.Length;
    int count = 0;
     for(int k = 0;k < size;k++)
    {
        if(array[k] > 0)
        {
           count = count + 1;
        }
    }
    return count;
}

System.Console.Write("Введите количество чисел: ");
int userSize = Convert.ToInt32(Console.ReadLine());
int[] userNumbers = FillArray(userSize);
PrintArray(userNumbers);
System.Console.Write($"Количество чисел больше 0: {countOfPossitiveNumbers(userNumbers)}");
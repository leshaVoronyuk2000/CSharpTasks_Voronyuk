// task 29 Массив из 8 элементов.

void array8()
{
    int[] arr = new int[8];
    for(int i = 0;i<arr.Length;i++)
    {
        arr[i] = new Random().Next(0,21);
        Console.Write(arr[i] + " ");
    }
}
array8();

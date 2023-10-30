/*
  Task 30 
  Заполните восьмиразмерный массив нулями и единицами в случайном порядке;
*/ 
Console.Clear();
void randomArr()
{
    int[] array = new int[8];

    for(int i = 0;i < array.Length;i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write(array[i] + " ");
    }
}

randomArr();
Console.WriteLine();
randomArr();


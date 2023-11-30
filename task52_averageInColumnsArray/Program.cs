/*
    Task 52. Создайте целочисленный массив. Верните среднее значение элементов
    в каждом столбце.
*/

int[,] CreateMatrix(int rows = 2,int cols = 5)
{
    int[,] matrix = new int[rows,cols];
    for(int i = 0;i < rows;i++)
    {
       for(int j = 0;j < cols;j++)
       {
         matrix[i,j] = new Random().Next(1,10);
       }
    }
    return matrix;
}

double[] FindAverageInColumns(int[,] matrix)
{
    double[] averageInColumns = new double[matrix.GetLength(1)];
    for(int i = 0;i < matrix.GetLength(1);i++)
    {
        int avg = 0;
        for(int j = 0;j < matrix.GetLength(0);j++)
        {
            avg = avg + matrix[j,i];
        }
        avg = avg/matrix.GetLength(0);
        averageInColumns[i] = avg;
    }
    return averageInColumns;
}

void Print2DArray(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
    
}

void PrintArray(double[] array)
{
  for(int i = 0;i < array.Length;i++)
  {
    Console.Write("{0:0.00} ",array[i]);
  } 
}
int[,] random2DArray = CreateMatrix();
Print2DArray(random2DArray);
System.Console.WriteLine();
PrintArray(FindAverageInColumns(random2DArray));


// Task 54. Отсартировать строки в массиве по убыванию.

int[,] CreateMatrix(int rows = 5,int cols = 5)
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

int[,] SortDescending(int[,] matrix)
{
  
  for(int i = 0;i < matrix.GetLength(0);i++)
  {
    for(int j = 0;j < matrix.GetLength(1);j++)
    {
      for(int k = 0;k < j;k++)
      {
        if(matrix[i,k]<matrix[i,j])
        {
            int temp = matrix[i,k];
            matrix[i,k] = matrix[i,j];
            matrix[i,j] = temp;
        }
      }
    }
  }
  return matrix;
}

int[,] randomMatrix = CreateMatrix();
Print2DArray(randomMatrix);
System.Console.WriteLine();
Print2DArray(SortDescending(randomMatrix));

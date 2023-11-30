/*
    Task 53.
    Напишите программу, которая последнюю и первую строчку поменяет местами.
    Например:
    1 2 3     6 7 8
    3 4 5 --> 3 4 5 
    6 7 8     1 2 3
*/

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

int[,] SwapRows(int[,] matrix)
{
        int[,] result = new int[matrix.GetLength(0),matrix.GetLength(1)];
        for(int i = 0;i < result.GetLength(0);i++)
        {
            for(int j = 0;j < result.GetLength(1);j++)
            {
                result[i,j] = matrix[i,j];
            }
        }

        for(int j = 0;j < result.GetLength(0);j++)
        {
            int temp = result[0,j];
            result[0,j] = result[matrix.GetLength(0)-1,j];
            result[matrix.GetLength(0)-1,j] = temp;
        }
        return result;
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

int[,] myMatrix = CreateMatrix();
Print2DArray(myMatrix);
System.Console.WriteLine();
int[,] changedMatrix = SwapRows(myMatrix);
Print2DArray(changedMatrix);

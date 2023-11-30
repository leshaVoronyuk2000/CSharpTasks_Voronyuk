/*
    Поменяйте строки и столбцы местами.
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

int[,] SwapRowsAndCols(int[,] matrix)
{
    int[,] result = new int[matrix.GetLength(0),matrix.GetLength(1)];
    for(int i = 0;i < result.GetLength(0);i++)
    {
        for(int j = 0;j < result.GetLength(1);j++)
        {
            result[i,j] = matrix[j,i];
        }

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

void Check2DArray(int[,] array)
{
    if(array.GetLength(0) == array.GetLength(1))
    {
        Print2DArray(array);
        System.Console.WriteLine();
        Print2DArray(SwapRowsAndCols(array));
    }
    else
    {
        Print2DArray(array);
        System.Console.WriteLine("Строки и столбцы нельзя поменять");
    } 
}

int[,] userMatrix = CreateMatrix(4,3);
Check2DArray(userMatrix);
 

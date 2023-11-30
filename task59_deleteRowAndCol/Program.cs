// Task 59. Удалите строку и столбец, где находится минимальный элемент.

int[,] CreateMatrix(int rows = 5,int cols = 5)
{
    int[,] matrix = new int[rows,cols];
    for(int i = 0;i < rows;i++)
    {
       for(int j = 0;j < cols;j++)
       {
         matrix[i,j] = new Random().Next(1,7);
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

int FindMinRow(int[,] array)
{
    int minRow = 0;
    int minItem = array[0,0];
    for(int i = 0;i<array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            if(minItem > array[i,j])
            {
                minRow = i;
                minItem = array[i,j];
            }
        }
    }
    return minRow;
}

int FindMinCol(int[,] array)
{
    int minCol = 0;
    int minItem = array[0,0];
    for(int i = 0;i<array.GetLength(0);i++)
    {
        for(int j = 0;j<array.GetLength(1);j++)
        {
            if(minItem > array[i,j])
            {
                minCol = j;
                minItem = array[i,j];
            }
        }
    }
    return minCol;
}


int[,] DeleteRowAndCol(int[,] matrix)
{
    int[,] changedMatrix = new int[matrix.GetLength(0)-1,matrix.GetLength(1)-1];
    int minRow = FindMinRow(matrix);
    int minCol = FindMinCol(matrix);
    int rows = 0;
    int cols = 0;
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        if(i == minRow) continue;
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            if(j == minCol) continue;
            changedMatrix[rows,cols] = matrix[i,j];
            cols++;
        }
        cols = 0;
        rows++;
    }
    return changedMatrix; 
}

int[,] userArray = CreateMatrix(4,4);
Print2DArray(userArray);
int[,] changedUserArray = DeleteRowAndCol(userArray);
System.Console.WriteLine();
Print2DArray(changedUserArray);

// Task 57. Напишите частотный словарь элементов в двумерном массиве.



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

int CountOfElements(int[,] matrix,int item)
{
    int count = 0;
    for(int i = 0;i< matrix.GetLength(0);i++)
    {
        for(int j = 0;j< matrix.GetLength(1);j++)
        {
            if(matrix[i,j] == item)
            {
              count = count + 1;
            }
        }
    }
    return count;
} 

void CalculateUniqueElements(int[,] array)
{
    for(int i = 0;i < array.GetLength(0);i++)
    {
        for(int j = 0;j < array.GetLength(1);j++)
        {
            bool isUnique = true;
            int count = 0;
            int rows = 0;
            int cols = 0;
            if(i == 0 && j == 0)
            {
                count = CountOfElements(array,array[i,j]);
                System.Console.WriteLine($"Количество {array[i,j]} = {count}");
                continue;
            }
            while(rows<=i)
            {
                if(rows == i && cols == j) 
                {
                    break;
                }
                if(array[rows,cols]==array[i,j])
                {
                    isUnique = false;
                    break;
                }
                cols++;
                if(cols == array.GetLength(1))
                {
                    cols = 0;
                    rows++;
                }

            }
            if(isUnique)
            {
               count = CountOfElements(array,array[i,j]);
               System.Console.WriteLine($"Количество {array[i,j]} = {count}"); 
            }
        }
    }
}

int[,] user2DArray = CreateMatrix(4,4);
Print2DArray(user2DArray);
CalculateUniqueElements(user2DArray);
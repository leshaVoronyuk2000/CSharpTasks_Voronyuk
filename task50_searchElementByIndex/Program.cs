/*
    Task 50. Напишите программу, которая на вход принимает позиции элемента,
    в двумерном элементе и на выходе возвращает значение данного элемента.
*/ 

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

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

int[] FindNumberByPosition(int[,] matrix,int x,int y)
{  
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        if(x > matrix.GetLength(0) - 1 ||
           y > matrix.GetLength(1) - 1 ||
           x < 0 || y < 0)
        {
           break;
        }
       for(int j = 0;j < matrix.GetLength(1);j++)
       {
          if(i == x && j == y)
          {
            return new int[]{matrix[i,j],0};
          }
       }
    }
    return new int[0];
}

void CheckElement(int[] result,int x, int y)
{
    if(result.Length > 0)
    {
        Console.WriteLine($"Элемент с индесами {x} и {y} это {result[0]}");
    }
    else Console.WriteLine("Такого индекса нет");

}


int userX = Prompt("Введите номер строки от 0 до 4: ");
int userY = Prompt("Введите номер столбца от 0 до 4: ");
int[,] randomMatrix = CreateMatrix();
Print2DArray(randomMatrix);
CheckElement(FindNumberByPosition(randomMatrix,userX,userY),userX,userY);

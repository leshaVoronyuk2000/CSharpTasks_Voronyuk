/*
    Task 47 Создайте массив размера mxn, каждый элемент которого находится 
    по формуле matrix[i,j] = i + j.
*/ 

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Fill2DArray (int rows,int cols)
{
    int[,] table = new int[rows,cols];
    for(int i = 0;i < rows;i++)
    {
        for(int j = 0;j < cols;j++)
        {
            table[i,j] = i + j;
        }
    }
    return table;
}

void Print2DArray(int[,] matrix)
{
    for(int i = 0;i < matrix.GetLength(0);i++)
    {
        for(int j = 0;j < matrix.GetLength(1);j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int userRows = Prompt("Количество строк: ");
int userCols = Prompt("Количество столбцов: ");
int[,] user2DArray = Fill2DArray(userRows,userCols);
Print2DArray(user2DArray);
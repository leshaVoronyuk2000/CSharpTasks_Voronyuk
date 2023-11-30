// Task 46 Распечатайте двумерный массив, заполненный рандомнгыми числами.

int showMessage(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Fill2DArray (int start,int end,int rows,int cols)
{
    int[,] table = new int[rows,cols];
    for(int i = 0;i < rows;i++)
    {
        for(int j = 0;j < cols;j++)
        {
            table[i,j] = new Random().Next(start,end+1);
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
            Console.Write(matrix[i,j]+" ");
        }
        Console.WriteLine();
    }
    
}

int userRows = showMessage("Введите количество строк: ");
int userCols = showMessage("Введите количество столбцов: ");
int userMin = showMessage("Введите начало диапазона: ");
int userMax = showMessage("Введите конец диапазона: ");
int[,] user2DArray = Fill2DArray(userMin,userMax,userRows,userCols);
Print2DArray(user2DArray);

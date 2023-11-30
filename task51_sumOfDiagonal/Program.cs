//Task 51 Сумма элементов в массиве, находящихся на главной диагонали;

int Prompt(string msg)
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

int sumOfMainDiagonal(int[,] matrix)
{
    int sum = 0;
    for(int i = 0;i < matrix.GetLength(1);i++)
    { 
            sum = sum + matrix[i,i];
    }  
   
    return sum;
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

int userRows = Prompt("Введите количество строк: ");
int userCols = Prompt("Введите количество столбцов: ");
int userMin = Prompt("Введите начало диапазона: ");
int userMax = Prompt("Введите конец диапазона: ");
int[,] user2DArray = Fill2DArray(userMin,userMax,userRows,userCols);

Console.WriteLine("Массив: ");
Print2DArray(user2DArray);
Console.WriteLine("Сумма элементов на главной диагонали: " + sumOfMainDiagonal(user2DArray));
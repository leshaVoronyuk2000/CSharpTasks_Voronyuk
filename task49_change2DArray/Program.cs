/*
    Task 49. Замените в массиве элементы с чётными индексами на их квадрат.
 */

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

int[,] ModifyEvenIndex2DArray (int[,] table)
{
    int[,] result = new int[table.GetLength(0),table.GetLength(1)];
    for(int i = 0;i < result.GetLength(0);i++)
    {
        for(int j = 0;j < result.GetLength(1);j++)
        {
            if(i%2 == 0 && j%2 == 0)
               result[i,j] = (int) Math.Pow(table[i,j],2);
            else result[i,j] = table[i,j];
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

int userRows = Prompt("Введите количество строк: ");
int userCols = Prompt("Введите количество столбцов: ");
int userMin = Prompt("Введите начало диапазона: ");
int userMax = Prompt("Введите конец диапазона: ");
int[,] user2DArray = Fill2DArray(userMin,userMax,userRows,userCols);

Console.WriteLine("Начальный массив: ");
Print2DArray(user2DArray);
int[,] newUser2DArray = ModifyEvenIndex2DArray(user2DArray);
Console.WriteLine("Измененный массив: ");
Print2DArray(newUser2DArray);
System.Console.WriteLine();
Print2DArray(user2DArray);
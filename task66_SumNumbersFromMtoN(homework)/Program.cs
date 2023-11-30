/*
    Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
    M = 1; N = 15 -> 120
    M = 4; N = 8. -> 30
*/

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbers(int M,int N)
{
    if(M <= N) 
    {
        return M + SumNumbers(M+1,N);
    } else return 0;
}


int start = Prompt("Введите начало диапазона: ");
int end = Prompt("Введите конец диапазона: ");
int result = SumNumbers(start,end);
Console.WriteLine($"Сумма чисел между {start} и {end} --> {result}");
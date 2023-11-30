// Task 64.
// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int N)
{
    if(N > 0)
    {
        Console.Write(N + " ");
        PrintNumbers(N-1);
    } 
}
int userNum = Prompt("Введите ваше число: ");
PrintNumbers(userNum);
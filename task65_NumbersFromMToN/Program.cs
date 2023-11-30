// Task 65. Выведите числа в диапазоне от M до N.


int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int start,int end)
{
        Console.Write(start + " ");
        if(start < end) PrintNumbers(start+1,end);  
}

int userStart = Prompt("Введите начало диапазона: ");
int userEnd = Prompt("Введите конец диапазона: ");
PrintNumbers(userStart,userEnd);


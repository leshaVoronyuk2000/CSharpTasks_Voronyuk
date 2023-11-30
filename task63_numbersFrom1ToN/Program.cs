// Task 63. Напечатайте цифры от 1 до N.

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumbers(int number, int current = 1)
{   
    Console.Write(current + " ");
    if(current<number) PrintNumbers(number,current + 1);
}

int userNum = Prompt("Введите ваше число от 1 и т.д ");
PrintNumbers(userNum);
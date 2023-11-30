// Task 67. Наппишите программу, которая считает сумму цифр в числе;

int Prompt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int SumOfDigits(int number)
{
    if(number>0)
    {
       return number%10 + SumOfDigits(number/10);
    } else return 0;
    
}

int userNumber = Prompt("Введите ваше число: ");
int sum = SumOfDigits(userNumber);
Console.WriteLine($"Сумма цифр в числе {userNumber} равняется {sum}");